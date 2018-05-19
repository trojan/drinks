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
    public partial class FormModulos : Form
    {
        public FormModulos()
        {
            InitializeComponent();
        }

        // [CRIARA OS ITENS DO MENU]
        private string[] itensMenu = {"USUARIOS", "PRODUTOS", "COMPRAS", "VENDAS", "FINANCEIRO"};

        private void FormModulos_Load(object sender, EventArgs e)
        {
            // [ATRIBUIRA OS ITENS AO MENU]
            foreach (string itens in itensMenu)
                listaModulos.Items.Add(itens);

            // [SELECIONARA O PRIMEIRO ITEM DO MENU]
            listaModulos.SelectedItem = itensMenu.FirstOrDefault();
        }

        private void FormModulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* 
                [SAIR DO SISTEMA] 

                Na tentativa de fechar o MENU MÓDULOS, será exibido uma  mensagem,
                perguntando se deseja sair do sistema.
            */

            if (MessageBox.Show("Deseja sair do Sistema ?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.Environment.Exit(0);
            else
                e.Cancel = true;
        }
    }
}
