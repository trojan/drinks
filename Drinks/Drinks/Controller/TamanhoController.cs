﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class TamanhoController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.TamanhoModel tmh = new Model.TamanhoModel();


        public void InsereTamanho(string descricao)
        {
            tmh.DescricaoTamanho = descricao;

            if (descricao != "" && descricao != null)
                if (dao.InserirDados(null, null, tmh, null) == true)
                    MessageBox.Show("Salvo com sucesso!");
                else
                    MessageBox.Show("Erro ao salvar!");
            else
                MessageBox.Show("Preencha os campos: \nDescrição!");
        }

        public void AlteraTamanho(int id, string descricao)
        {
            tmh.IdTamanho = id;
            tmh.DescricaoTamanho = descricao;

            if (descricao != "" && descricao != null)
                if (dao.AlterarDados(null, null, tmh, null) == true)
                    MessageBox.Show("Alterado com sucesso!");
                else
                    MessageBox.Show("Erro ao alterar os dados!");
            else
                MessageBox.Show("Preencha o campo: \nDescrição!");
        }

    }
}