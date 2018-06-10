using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class VendaController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.VendaModel vnd_m = new Model.VendaModel();

        public void InsereVenda(int idItensVendas, int quantidadeTotal, decimal valorTotal)
        {
            vnd_m.IdItensVenda = idItensVendas;
            vnd_m.QuantidadeTotal = quantidadeTotal;
            vnd_m.ValorTotal = valorTotal;
            vnd_m.DataVenda = DateTime.Now.Date;

            if (dao.InserirVenda(vnd_m) == true)
                MessageBox.Show("Venda Finalizada!", "Mensagem do Sistema");
            else
                MessageBox.Show("Falha ao Finalizar Venda!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

    }
}
