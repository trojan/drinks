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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
            LimparCampos();
        }

        // DAO
        DAO.DAO dao = new DAO.DAO();
        // MODEL
        Model.MarcaModel mrc_m = new Model.MarcaModel();
        // CONTROLLER
        Controller.MarcaController mrc_c = new Controller.MarcaController();

        #region [FUNÇÕES] 
        public void ListaMarca()
        {
            string busca_seletiva = null;
            DataTable dtMarca = new DataTable();
            dao.ListarDados(busca_seletiva, mrc_m, null, null, null).Fill(dtMarca);

            dgvMarca.DataSource = dtMarca;
            dgvMarca.Columns["CODIGO"].Visible = true;
            dgvMarca.Columns["DESCRICAO"].Visible = true;
        }

        public void LimparCampos()
        {
            textBoxID.Text = "";
            textBoxDescricao.Text = "";

            buttonExcluir.Enabled = false;
        }

        #endregion

        private void FormMarca_Load(object sender, EventArgs e)
        {
            ListaMarca();
            // TIRAR LINHA EM BRANCO DO DATA_GRID_VIEW
            dgvMarca.AllowUserToAddRows = false;
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
                    mrc_c.AlteraMarca(Convert.ToInt16(textBoxID.Text), textBoxDescricao.Text);
                else
                    mrc_c.InsereMarca(textBoxDescricao.Text);

                ListaMarca();
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
                    mrc_c.ExcluiMarca(Convert.ToInt16(textBoxID.Text));

            LimparCampos();
            ListaMarca();
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
        private void dgvMarca_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha_selecionada = dgvMarca.CurrentRow.Index;

            if (linha_selecionada >= 0)
            {
                textBoxID.Text = dgvMarca.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDescricao.Text = dgvMarca.SelectedRows[0].Cells[1].Value.ToString();
            }

            buttonExcluir.Enabled = true;
        }
        #endregion

    }
}

