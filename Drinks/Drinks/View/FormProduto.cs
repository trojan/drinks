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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            LimparCampos();
        }

        // DAO
        DAO.DAO dao = new DAO.DAO();

        // MODEL
        Model.MarcaModel mrc_m = new Model.MarcaModel();
        Model.UnidadeMedidaModel und_m = new Model.UnidadeMedidaModel();
        Model.TamanhoModel tmh_m = new Model.TamanhoModel();
        Model.ProdutoModel prd_m = new Model.ProdutoModel();

        // CONTROLLER
        Controller.MarcaController mrc_c = new Controller.MarcaController();
        Controller.UnidadeMedidaController und_c = new Controller.UnidadeMedidaController();
        Controller.TamanhoController tmh_c = new Controller.TamanhoController();
        Controller.ProdutoController prd_c = new Controller.ProdutoController();

        #region [FUNÇÕES]
        public void ListaMarca()
        {
            DataTable dtMarca = new DataTable();

            dao.ListarDados(null, mrc_m, null, null, null).Fill(dtMarca);

            comboBoxMarca.DataSource = dtMarca;

            comboBoxMarca.ValueMember = "CODIGO";
            comboBoxMarca.DisplayMember = "DESCRICAO";
            comboBoxMarca.Refresh();
        }

        public void ListaUnidadeMedida()
        {
            DataTable dtUnidadeMedida = new DataTable();

            dao.ListarDados(null, null, und_m, null, null).Fill(dtUnidadeMedida);

            comboBoxUnidadeMedida.DataSource = dtUnidadeMedida;

            comboBoxUnidadeMedida.ValueMember = "CODIGO";
            comboBoxUnidadeMedida.DisplayMember = "DESCRICAO";
            comboBoxUnidadeMedida.Refresh();
        }

        public void ListaTamanho()
        {
            DataTable dtTamanho = new DataTable();

            dao.ListarDados(null, null, null, tmh_m, null).Fill(dtTamanho);

            comboBoxTamanho.DataSource = dtTamanho;

            comboBoxTamanho.ValueMember = "CODIGO";
            comboBoxTamanho.DisplayMember = "DESCRICAO";
            comboBoxTamanho.Refresh();
        }

        public void ListaProduto()
        {
            string busca_seletiva = null;
            DataTable dtProduto = new DataTable();
            dao.ListarDados(busca_seletiva, null, null, null, prd_m).Fill(dtProduto);

            dgvProdutos.DataSource = dtProduto;
            dgvProdutos.Columns["CODIGO"].Visible = false;
            dgvProdutos.Columns["MARCA"].Visible = true;
            dgvProdutos.Columns["PRODUTO"].Visible = true;
            dgvProdutos.Columns["UNIDADE_MEDIDA"].Visible = true;
            dgvProdutos.Columns["TAMANHO"].Visible = true;
            dgvProdutos.Columns["QUANTIDADE"].Visible = false;
            dgvProdutos.Columns["VALOR_UNITARIO"].Visible = true;
            dgvProdutos.Columns["VALOR_TOTAL_UNITARIO"].Visible = false;
        }

        public void LimparCampos()
        {
            textBoxID.Text = "";
            textBoxDescricao.Text = "";
            textBoxValorUnitario.Text = "";

            textBoxDescricao.Select();
            buttonExcluir.Enabled = false;
        }

        public void Sair()
        {
            if (textBoxID.Text != "" && textBoxID.Text != null ||
                textBoxDescricao.Text != null && textBoxDescricao.Text != "" ||
                textBoxValorUnitario.Text != null && textBoxValorUnitario.Text != "")
                MessageBox.Show("Necessário salvar antes de sair!", "Mensagem do Sistema");
            else
                this.Close();
        }



        #endregion

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // CARREGARA O CONTEUDO NO FORMULARIO

            ListaMarca();
            ListaUnidadeMedida();
            ListaTamanho();
            ListaProduto();
            // TIRAR LINHA EM BRANCO DO DATA_GRID_VIEW
            dgvProdutos.AllowUserToAddRows = false;
        }

        // --- BOTOES ---

        #region [NOVO]
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ListaMarca();
            ListaUnidadeMedida();
            ListaTamanho();
        }
        #endregion

        #region [SALVAR]
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text != "" && textBoxDescricao != null
            && textBoxValorUnitario.Text != "" && textBoxValorUnitario.Text != null)
            {
                labelDescricao.Text = "Descrição";
                labelDescricao.ForeColor = Color.Black;

                labelValor.Text = "Valor";
                labelValor.ForeColor = Color.Black;

                if (textBoxID.Text != "" && textBoxID.Text != null)
                    prd_c.AlteraProduto(Convert.ToInt16(textBoxID.Text), Convert.ToInt16(comboBoxMarca.SelectedValue),
                                            Convert.ToString(textBoxDescricao.Text),
                                            Convert.ToInt16(comboBoxUnidadeMedida.SelectedValue),
                                            Convert.ToInt16(comboBoxTamanho.SelectedValue),
                                            Convert.ToDecimal(textBoxValorUnitario.Text));
                else
                    prd_c.InsereProduto(Convert.ToInt16(comboBoxMarca.SelectedValue), Convert.ToString(textBoxDescricao.Text),
                                        Convert.ToInt16(comboBoxUnidadeMedida.SelectedValue),
                                        Convert.ToInt16(comboBoxTamanho.SelectedValue),
                                        Convert.ToDecimal(textBoxValorUnitario.Text));

                ListaProduto();
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


                if (textBoxValorUnitario.Text == "" || textBoxValorUnitario.Text == null)
                {
                    labelValor.Text = "*Valor";
                    labelValor.ForeColor = Color.Red;
                    textBoxValorUnitario.Select();
                }
                else
                {
                    labelValor.Text = "Valor";
                    labelValor.ForeColor = Color.Black;
                }
            }
        }
        #endregion

        #region [EXCLUIR]
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxID != null)
                if (MessageBox.Show("Tem certeza que deseja excluir ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    prd_c.ExcluiProduto(Convert.ToInt32(textBoxID.Text));

            LimparCampos();
            ListaProduto();
        }
        #endregion

        #region [SAIR]
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Sair();

        }
        #endregion


        // --- PEGARA O CONTEUDO DA LINHA SELECIONADA, E ATRIBUIRA AOS ITENS DO FORMULARIO --- 

        #region [SELECIONAR LINHA]
        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha_selecionada = dgvProdutos.CurrentRow.Index;

            if (linha_selecionada >= 0)
            {
                textBoxID.Text = dgvProdutos.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxMarca.Text = dgvProdutos.SelectedRows[0].Cells[1].Value.ToString();
                textBoxDescricao.Text = dgvProdutos.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxTamanho.Text = dgvProdutos.SelectedRows[0].Cells[3].Value.ToString();
                comboBoxUnidadeMedida.Text = dgvProdutos.SelectedRows[0].Cells[4].Value.ToString();
                textBoxValorUnitario.Text = dgvProdutos.SelectedRows[0].Cells[6].Value.ToString();
            }

            buttonExcluir.Enabled = true;
        }
        #endregion


        private void pictureBoxMarca_Click(object sender, EventArgs e)
        {
            FormMarca fmrc = new FormMarca();
            fmrc.ShowDialog();

            ListaMarca();
        }

        private void pictureBoxTamanho_Click(object sender, EventArgs e)
        {
            FormTamanho ftmh = new FormTamanho();
            ftmh.ShowDialog();

            ListaTamanho();
        }

        private void pictureBoxUnidadeMedida_Click(object sender, EventArgs e)
        {
            FormUnidadeMedida fund = new FormUnidadeMedida();
            fund.ShowDialog();

            ListaUnidadeMedida();
        }
    }
}
