using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;

namespace Drinks.View
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        DAO.DAO dao = new DAO.DAO();
        Controller.FornecedorController fnd_c = new Controller.FornecedorController();
        Model.FornecedorModel fnd_m = new Model.FornecedorModel();

        #region [FUNÇÕES]

        public void BuscaCEP()
        {
            var viaCepService = new ViaCepService();

            if (!string.IsNullOrWhiteSpace(textBoxCEP.Text))
                try
                {
                    var endereco = viaCepService.ObterEndereco(textBoxCEP.Text);
                    textBoxEndereco.Text = endereco.Logradouro;
                    textBoxBairro.Text = endereco.Bairro;
                    textBoxCidade.Text = endereco.Localidade;
                    textBoxUF.Text = endereco.UF;

                    textBoxNum.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("O CEP especificado não existe!");
                }
            else
                MessageBox.Show("Informe um CEP válido!");
        }

        public void LimpaCampos()
        {
            textBoxCnpj.Text = "";
            textBoxRazaoSocial.Text = "";
            textBoxCEP.Text = "";
            textBoxEndereco.Text = "";
            textBoxNum.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxUF.Text = "";
            textBoxDDDTelefone.Text = "";
            textBoxTelefone.Text = "";
            textBoxDDDCelular.Text = "";
            textBoxCelular.Text = "";
            textBoxNomeFantasia.Text = "";
            textBoxInscricaoEstadual.Text = "";
            textBoxEmail.Text = "";

            textBoxCnpj.Focus();
        }


        #endregion


        private void textBoxCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscaCEP();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}