using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions;
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

            textBoxCnpj.Select();
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
            //if (textBoxCnpj != null && textBoxCnpj.Text != "")
            //    fnd_c.AlteraFornecedor(long.Parse(textBoxCnpj.Text), textBoxRazaoSocial.Text, textBoxCEP.Text, textBoxEndereco.Text, textBoxNum.Text, textBoxBairro.Text, textBoxCidade.Text, textBoxUF.Text, Convert.ToInt32(textBoxDDDTelefone.Text), Convert.ToInt32(textBoxTelefone.Text), Convert.ToInt32(textBoxDDDCelular.Text), textBoxCelular.Text, textBoxNomeFantasia.Text, long.Parse(textBoxInscricaoEstadual.Text), textBoxEmail.Text);
            //else
                fnd_c.InsereFornecedor(long.Parse(textBoxCnpj.Text), textBoxRazaoSocial.Text, textBoxCEP.Text, textBoxEndereco.Text, textBoxNum.Text, textBoxBairro.Text, textBoxCidade.Text, textBoxUF.Text, Convert.ToInt32(textBoxDDDTelefone.Text), Convert.ToInt32(textBoxTelefone.Text), Convert.ToInt32(textBoxDDDCelular.Text), textBoxCelular.Text, textBoxNomeFantasia.Text, long.Parse(textBoxInscricaoEstadual.Text), textBoxEmail.Text);

            LimpaCampos();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxCnpj != null && textBoxCnpj.Text != "")
                if (MessageBox.Show("Tem certeza que deseja excluir ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    fnd_c.ExcluiFornecedor(long.Parse(textBoxCnpj.Text));

            LimpaCampos();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (textBoxCnpj != null && textBoxCnpj.Text != "")
                MessageBox.Show("Necessário salvar antes de sair!", "Mensagem do Sistema");
            else
                this.Close();

        }

        private void pictureBoxBuscaCnpj_Click(object sender, EventArgs e)
        {
            ListaFornecedores flfnd = new ListaFornecedores();
            flfnd.ShowDialog();
        }
    }
}