using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks
{
    public partial class FormPainel : Form
    {
        public FormPainel()
        {
            InitializeComponent();
        }

        private void FormPainel_Load(object sender, EventArgs e)
        {
            FormModulos fm = new FormModulos();
            fm.ShowDialog();
        }
    }
}
