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
            textBoxDescricao.Select();
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


        public void ListaMarca()
        {
            DataTable dtMarca = new DataTable();

            dao.ListarDados(null, mrc_m, null, null, null).Fill(dtMarca);

            comboBoxMarca.DataSource = dtMarca;

            comboBoxMarca.ValueMember = "idMarca";
            comboBoxMarca.DisplayMember = "descricao";
            comboBoxMarca.Refresh();
        }

        public void ListaUnidadeMedida()
        {
            DataTable dtUnidadeMedida = new DataTable();

            dao.ListarDados(null, null, und_m, null, null).Fill(dtUnidadeMedida);

            comboBoxUnidadeMedida.DataSource = dtUnidadeMedida;

            comboBoxUnidadeMedida.ValueMember = "idUnidadeMedida";
            comboBoxUnidadeMedida.DisplayMember = "descricao";
            comboBoxUnidadeMedida.Refresh();
        }

        public void ListaTamanho()
        {
            DataTable dtTamanho = new DataTable();

            dao.ListarDados(null, null, null, tmh_m, null).Fill(dtTamanho);

            comboBoxTamanho.DataSource = dtTamanho;

            comboBoxTamanho.ValueMember = "idTamanho";
            comboBoxTamanho.DisplayMember = "descricao";
            comboBoxTamanho.Refresh();
        }

        public void ListaProduto()
        {

            string busca_seletiva = null;
            DataTable dtProduto = new DataTable();
            dao.ListarDados(busca_seletiva, null, null, null, prd_m).Fill(dtProduto);

            dgvProdutos.DataSource = dtProduto;

            dgvProdutos.Columns["MARCA"].Visible = true;
            dgvProdutos.Columns["PRODUTO"].Visible = true;
            dgvProdutos.Columns["UNIDADE_MEDIDA"].Visible = true;
            dgvProdutos.Columns["TAMANHO"].Visible = true;
            dgvProdutos.Columns["QUANTIDADE"].Visible = true;
            dgvProdutos.Columns["VALOR_UNITARIO"].Visible = true;
            dgvProdutos.Columns["VALOR_TOTAL_UNITARIO"].Visible = true;
            //dgvProdutos.Columns["VALOR_TOTAL"].Visible = true;
        }

        public void LimparCampos()
        {
            textBoxID.Text = "";
            textBoxDescricao.Text = "";
            textBoxValorUnitario.Text = "";

            textBoxDescricao.Select();
        }


        private void FormProduto_Load(object sender, EventArgs e)
        {
            ListaMarca();
            ListaUnidadeMedida();
            ListaTamanho();
            ListaProduto();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text != "" && textBoxDescricao != null
                && textBoxValorUnitario.Text != "" && textBoxValorUnitario.Text != null)
            {
                labelDescricao.Text = "Descricao";
                labelDescricao.ForeColor = Color.Black;

                labelValor.Text = "Valor";
                labelValor.ForeColor = Color.Black;

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
                    labelDescricao.Text = "*Descricao";
                    labelDescricao.ForeColor = Color.Red;
                    textBoxDescricao.Select();
                }
                else
                {
                    labelDescricao.Text = "Descricao";
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


        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text != null && textBoxDescricao.Text != "" || textBoxValorUnitario.Text != null && textBoxValorUnitario.Text != "")
                MessageBox.Show("Necessário salvar antes de sair!", "Mensagem do Sistema");
            else
                this.Close();
        }
    }
}
