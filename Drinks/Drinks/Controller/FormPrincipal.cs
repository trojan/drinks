using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            DAO.DAO dao = new DAO.DAO();

            // Criara a pasta bd e o arquivo .sdf
            dao.CreateDB();

            // Criara as tabelas no bd caso nao tiver nenhuma
            if (dao.CheckTB() == 0)
                dao.CreateTB();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Sistema ?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region [COMPRAS]
        private void nOVACOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormCompra fcmp = new View.FormCompra();
            fcmp.ShowDialog();
        }
        #endregion

        #region [VENDAS]
        // CAIXA    
        private void cAIXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormCaixa fcx = new View.FormCaixa();
            fcx.ShowDialog();
        }
        #endregion

        #region [ESTOQUE]
        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormProduto fpdr = new View.FormProduto();
            fpdr.ShowDialog();
        }
        
        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormMarca fmrc = new View.FormMarca();
            fmrc.ShowDialog();
        }

        private void uNIDADEMEDIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormUnidadeMedida fund = new View.FormUnidadeMedida();
            fund.ShowDialog();
        }

        private void tAMANHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormTamanho ftmh = new View.FormTamanho();
            ftmh.ShowDialog();
        }

        private void cONSULTARPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.FormConsultaProduto fcprd = new View.FormConsultaProduto();
            fcprd.ShowDialog();
        }

        #endregion

        
    }
}
