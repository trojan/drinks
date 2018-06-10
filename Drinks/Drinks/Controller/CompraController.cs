using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class CompraController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.CompraModel cmp_m = new Model.CompraModel();


        public void InsereCompra(int idItensCompras, int quantidadeTotal, decimal valorTotal)
        {
            cmp_m.IdItensCompra = idItensCompras;
            cmp_m.QuantidadeTotal = quantidadeTotal;
            cmp_m.ValorTotal = valorTotal;
            cmp_m.DataCompra = DateTime.Now.Date;

            if (dao.InserirCompra(cmp_m) == true)
                MessageBox.Show("Compra Finalizada!", "Mensagem do Sistema");
            else
                MessageBox.Show("Falha ao Finalizar Compra!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
