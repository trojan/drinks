using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class ProdutoController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.ProdutoModel prd = new Model.ProdutoModel();


        public void InsereProduto(int idMarca, string descricao, int idUnidadeMedida, int idTamanho, decimal valorUnitario)
        {
            prd.IdMarca = idMarca;
            prd.DescricaoProduto = descricao;
            prd.IdUnidadeMedida = idUnidadeMedida;
            prd.IdTamanho = idTamanho;
            prd.ValorUnitario = valorUnitario;


            if (dao.InserirDados(null, null, null, prd) == true)
                MessageBox.Show("Salvo com sucesso!", "Mensagem do Sistema");
            else
                MessageBox.Show("Falha ao salvar!", "Mensagem do Sistema");
        }

        public void AlteraProduto(int idProduto, int idMarca, string descricao, int idUnidadeMedida, int idTamanho, decimal valorUnitario)
        {
            prd.IdProduto = idProduto;
            prd.IdMarca = idMarca;
            prd.DescricaoProduto = descricao;
            prd.IdUnidadeMedida = idUnidadeMedida;
            prd.IdTamanho = idTamanho;
            prd.ValorUnitario = valorUnitario;


            if (dao.AlterarDados(null, null, null, prd) == true)
                MessageBox.Show("Alterado com sucesso!");
            else
                MessageBox.Show("Erro ao alterar os dados!");
        }

        public void ExcluiProduto(int id)
        {
            prd.IdProduto = id;


            if (dao.ExcluirDados(null, null, null, prd) == false)
                MessageBox.Show("Não foi possível efetuar a exclusão!", "Mensagem do Sistema");
        }


        public void AlteraQuantidadeProduto(int id, int quantidade)
        {
            prd.IdProduto = id;
            prd.Quantidade = quantidade;


            if (dao.AlterarQuantidadeProduto(prd) == false)
                MessageBox.Show("Falha ao alterar a Quantidade!", "Mensagem do Sistema");
        }
    }
}
