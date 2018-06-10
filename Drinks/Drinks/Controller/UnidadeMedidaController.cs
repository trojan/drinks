using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class UnidadeMedidaController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.UnidadeMedidaModel und = new Model.UnidadeMedidaModel();


        public void InsereUnidadeMedida(string descricao)
        {
            und.DescricaoUnidadeMedida = descricao;

            if (dao.InserirDados(null, und, null, null) == true)
                MessageBox.Show("Salvo com sucesso!");
            else
                MessageBox.Show("Erro ao salvar!");
        }

        public void AlteraUnidadeMedida(int id, string descricao)
        {
            und.IdUnidadeMedida = id;
            und.DescricaoUnidadeMedida = descricao;

            if (dao.AlterarDados(null, und, null, null) == true)
                MessageBox.Show("Alterado com sucesso!");
            else
                MessageBox.Show("Erro ao alterar os dados!");
        }


        public void ExcluiUnidadeMedida(int id)
        {
            und.IdUnidadeMedida = id;


            if (dao.ExcluirDados(null, und, null, null) == true)
                MessageBox.Show("Excluido com Sucesso!");
            else
                MessageBox.Show("Erro ao excluir os dados!");

        }
    }
}
