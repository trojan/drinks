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

            dao.CreateDB();

            if (dao.CheckTB() == 0)
                dao.CreateTB();
        }
        
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMinimize_Click(object sender, EventArgs e)
        {
            // minimizar o aplicativo
            // veja: https://msdn.microsoft.com/en-us/library/system.windows.forms.notifyicon.aspx
        }
    }
}
