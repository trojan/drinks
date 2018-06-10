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
    public partial class FormUnidadeMedida : Form
    {
        public FormUnidadeMedida()
        {
            InitializeComponent();
            LimparCampos();
        }

        // DAO
        DAO.DAO dao = new DAO.DAO();
        // MODEL
        Model.UnidadeMedidaModel und_m = new Model.UnidadeMedidaModel();
        // CONTROLLER
        Controller.UnidadeMedidaController und_c = new Controller.UnidadeMedidaController();

        #region [FUNÇÕES] 
        public void ListaUnidadeMedida()
        {
            string busca_seletiva = null;
            DataTable dtUnidadeMedida = new DataTable();
            dao.ListarDados(busca_seletiva, null, und_m, null, null).Fill(dtUnidadeMedida);

            dgvUnidadeMedida.DataSource = dtUnidadeMedida;
            dgvUnidadeMedida.Columns["CODIGO"].Visible = true;
            dgvUnidadeMedida.Columns["DESCRICAO"].Visible = true;
        }

        public void LimparCampos()
        {
            textBoxID.Text = "";
            textBoxDescricao.Text = "";

            textBoxDescricao.Select();
            buttonExcluir.Enabled = false;
        }

        #endregion

        private void FormUnidadeMedida_Load(object sender, EventArgs e)
        {
            ListaUnidadeMedida();
            // TIRAR LINHA EM BRANCO DO DATA_GRID_VIEW
            dgvUnidadeMedida.AllowUserToAddRows = false;
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
                    und_c.AlteraUnidadeMedida(Convert.ToInt16(textBoxID.Text), textBoxDescricao.Text);
                else
                    und_c.InsereUnidadeMedida(textBoxDescricao.Text);

                ListaUnidadeMedida();
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
                    und_c.ExcluiUnidadeMedida(Convert.ToInt16(textBoxID.Text));

            LimparCampos();
            ListaUnidadeMedida();
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
        private void dgvUnidadeMedida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha_selecionada = dgvUnidadeMedida.CurrentRow.Index;

            if (linha_selecionada >= 0)
            {
                textBoxID.Text = dgvUnidadeMedida.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDescricao.Text = dgvUnidadeMedida.SelectedRows[0].Cells[1].Value.ToString();
            }

            buttonExcluir.Enabled = true;
        }
        #endregion
    }
}
