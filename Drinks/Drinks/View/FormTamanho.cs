using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.View
{
    public partial class FormTamanho : Form
    {
        public FormTamanho()
        {
            InitializeComponent();
            LimparCampos();
        }

        // DAO
        DAO.DAO dao = new DAO.DAO();
        // MODEL
        Model.TamanhoModel tmh_m = new Model.TamanhoModel();
        // CONTROLLER
        Controller.TamanhoController tmh_c = new Controller.TamanhoController();

        #region [FUNÇÕES] 
        public void ListaTamanho()
        {
            string busca_seletiva = null;
            DataTable dtTamanho = new DataTable();
            dao.ListarDados(busca_seletiva, null, null, tmh_m, null).Fill(dtTamanho);

            dgvTamanho.DataSource = dtTamanho;
            dgvTamanho.Columns["CODIGO"].Visible = true;
            dgvTamanho.Columns["DESCRICAO"].Visible = true;
        }

        public void LimparCampos()
        {
            textBoxID.Text = "";
            textBoxDescricao.Text = "";

            buttonExcluir.Enabled = false;
        }

        #endregion

        private void FormTamanho_Load(object sender, EventArgs e)
        {
            ListaTamanho();
            // TIRAR LINHA EM BRANCO DO DATA_GRID_VIEW
            dgvTamanho.AllowUserToAddRows = false;
        }


        // --- BOTOES ---

        #region [NOVO]
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        #endregion

        #region [GRAVAR]
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text != "" && textBoxDescricao != null)
            {
                labelDescricao.Text = "Descrição";
                labelDescricao.ForeColor = Color.Black;

                if (textBoxID.Text != "" && textBoxID.Text != null)
                    tmh_c.AlteraTamanho(Convert.ToInt16(textBoxID.Text), textBoxDescricao.Text);
                else
                    tmh_c.InsereTamanho(textBoxDescricao.Text);

                ListaTamanho();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textBoxDescricao.Text == "" || textBoxDescricao.Text == null)
                {
                    labelDescricao.Text = "*Descrição";
                    labelDescricao.ForeColor = Color.Red;
                    textBoxDescricao.Select();
                }
                else
                {
                    labelDescricao.Text = "Descrição";
                    labelDescricao.ForeColor = Color.Black;
                }
            }
        }
        #endregion

        #region [EXCLUIR]
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxID != null)
                if (MessageBox.Show("Tem certeza que deseja excluir ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tmh_c.ExcluiTamanho(Convert.ToInt16(textBoxID.Text));

            LimparCampos();
            ListaTamanho();
        }
        #endregion

        #region [SAIR]
        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxID.Text != null || textBoxDescricao.Text != null && textBoxDescricao.Text != "")
                MessageBox.Show("Necessário salvar antes de sair!", "Mensagem do Sistema");
            else
                this.Close();
        }


        #endregion

        // --- PEGARA O CONTEUDO DA LINHA SELECIONADA, E ATRIBUIRA AOS ITENS DO FORMULARIO --- 

        #region [SELECIONAR LINHA]
        private void dgvTamanho_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha_selecionada = dgvTamanho.CurrentRow.Index;

            if (linha_selecionada >= 0)
            {
                textBoxID.Text = dgvTamanho.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDescricao.Text = dgvTamanho.SelectedRows[0].Cells[1].Value.ToString();
            }

            buttonExcluir.Enabled = true;
        }
        #endregion
    }
}
