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
                MessageBox.Show("Salvo com sucesso!");
            else
                MessageBox.Show("Erro ao salvar!");
        }

        public void AlteraProduto(int idProduto, int idMarca, string descricao, int idUnidadeMedida, int idTamanho, decimal valorUnitario)
        {
            prd.IdProduto = idProduto;
            prd.IdMarca = idMarca;
            prd.DescricaoProduto = descricao;
            prd.IdUnidadeMedida = idUnidadeMedida;
            prd.IdTamanho = idTamanho;
            prd.ValorUnitario = valorUnitario;

            if (dao.InserirDados(null, null, null, prd) == true)
                MessageBox.Show("Alterado com sucesso!");
            else
                MessageBox.Show("Erro ao alterar os dados!");
        }

    }
}
