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
    public partial class FormConsultaProduto : Form
    {
        public FormConsultaProduto()
        {
            InitializeComponent();
        }

        // DAO
        DAO.DAO dao = new DAO.DAO();
        // MODEL
        Model.ProdutoModel prd_m = new Model.ProdutoModel();
        // CONTROLLER
        Controller.ProdutoController prd_c = new Controller.ProdutoController();

        string busca_seletiva = null;

        #region [FUNÇÃO]
        public void ListaProduto()
        {
            
            DataTable dtProduto = new DataTable();
            dao.ListarDados(busca_seletiva, null, null, null, prd_m).Fill(dtProduto);

            dgvProdutos.DataSource = dtProduto;
            dgvProdutos.Columns["CODIGO"].Visible = false;
            dgvProdutos.Columns["MARCA"].Visible = true;
            dgvProdutos.Columns["PRODUTO"].Visible = true;
            dgvProdutos.Columns["UNIDADE_MEDIDA"].Visible = true;
            dgvProdutos.Columns["TAMANHO"].Visible = true;
            dgvProdutos.Columns["QUANTIDADE"].Visible = true;
            dgvProdutos.Columns["VALOR_UNITARIO"].Visible = true;
            dgvProdutos.Columns["VALOR_TOTAL_UNITARIO"].Visible = true;
        }
        #endregion

        private void FormConsultaProduto_Load(object sender, EventArgs e)
        {
            ListaProduto();

            dgvProdutos.AllowUserToAddRows = false;
        }

        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
