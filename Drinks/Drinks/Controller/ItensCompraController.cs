using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class ItensCompraController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.ItensCompra icmp_m = new Model.ItensCompra();

        public void InsereItensCompra(int idItensCompra, int idProduto, int quantidadeUnitario, decimal valorUnitario)
        {
            icmp_m.IdItensCompra = idItensCompra;
            icmp_m.IdProduto = idProduto;
            icmp_m.QuantidadeUnitario = quantidadeUnitario;
            icmp_m.ValorUnitario = valorUnitario;

            if (dao.InserirItensCompra(icmp_m) == true)
                MessageBox.Show("Produto inserido");
            else
                MessageBox.Show("Erro ao inserir Produto!");
        }
    }
}
