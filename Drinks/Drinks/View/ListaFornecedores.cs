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
    public partial class ListaFornecedores : Form
    {
        public ListaFornecedores()
        {
            InitializeComponent();
        }

        #region [DECLARAÇÕES]
        // DAO
        DAO.DAO dao = new DAO.DAO();

        // MODELO
        Model.FornecedorModel fnd_m = new Model.FornecedorModel();

        //CONTROLLER
        Controller.FornecedorController fnd_c = new Controller.FornecedorController();
        #endregion

        #region [FUNÇÕES]

        public void ListaFornecedor()
        {
            string busca_seletiva = null;
            DataTable dtFornecedor = new DataTable();
            dao.ListarFornecedor(busca_seletiva, fnd_m).Fill(dtFornecedor);

            dgvFornecedores.DataSource = dtFornecedor;
            dgvFornecedores.Columns["CNPJ"].Visible = true;
            dgvFornecedores.Columns["RAZAO_SOCIAL"].Visible = true;
            dgvFornecedores.Columns["CEP"].Visible = true;
            dgvFornecedores.Columns["ENDERECO"].Visible = true;
            dgvFornecedores.Columns["NUMERO"].Visible = true;
            dgvFornecedores.Columns["BAIRRO"].Visible = true;
            dgvFornecedores.Columns["CIDADE"].Visible = true;
            dgvFornecedores.Columns["UF"].Visible = true;
            dgvFornecedores.Columns["DDD_TELEFONE"].Visible = true;
            dgvFornecedores.Columns["TELEFONE"].Visible = true;
            dgvFornecedores.Columns["DDD_CELULAR"].Visible = true;
            dgvFornecedores.Columns["CELULAR"].Visible = true;
            dgvFornecedores.Columns["NOME_FANTASIA"].Visible = true;
            dgvFornecedores.Columns["INSCRICAO_ESTADUAL"].Visible = true;
            dgvFornecedores.Columns["EMAIL"].Visible = true;
        }


        #endregion


        private void ListaFornecedores_Load(object sender, EventArgs e)
        {
            ListaFornecedor();
            dgvFornecedores.AllowUserToAddRows = false;
        }
    }
}
