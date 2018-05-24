using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class MarcaController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.MarcaModel mrc = new Model.MarcaModel();


        public void InsereMarca(string descricao)
        {
            mrc.DescricaoMarca = descricao;

            if (descricao != "" && descricao != null)
                if (dao.InserirDados(mrc, null, null, null) == true)
                    MessageBox.Show("Salvo com sucesso!");
                else
                    MessageBox.Show("Erro ao salvar!");
            else
                MessageBox.Show("Preencha os campos: \nDescrição!");
        }

        public void AlteraMarca(int id, string descricao)
        {
            mrc.IdMarca = id;
            mrc.DescricaoMarca = descricao;

            if (descricao != "" && descricao != null)
                if (dao.AlterarDados(mrc, null, null, null) == true)
                    MessageBox.Show("Alterado com sucesso!");
                else
                    MessageBox.Show("Erro ao alterar os dados!");
            else
                MessageBox.Show("Preencha o campo: \nDescrição!");
        }

    }
}

