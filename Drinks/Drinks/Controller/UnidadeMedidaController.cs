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

            if (descricao != "" && descricao != null)
                if (dao.InserirDados(null, und, null, null) == true)
                    MessageBox.Show("Salvo com sucesso!");
                else
                    MessageBox.Show("Erro ao salvar!");
            else
                MessageBox.Show("Preencha os campos: \nDescrição!");
        }

        public void AlteraUnidadeMedida(int id, string descricao)
        {
            und.IdUnidadeMedida = id;
            und.DescricaoUnidadeMedida = descricao;

            if (descricao != "" && descricao != null)
                if (dao.AlterarDados(null, und, null, null) == true)
                    MessageBox.Show("Alterado com sucesso!");
                else
                    MessageBox.Show("Erro ao alterar os dados!");
            else
                MessageBox.Show("Preencha o campo: \nDescrição!");
        }

    }
}
