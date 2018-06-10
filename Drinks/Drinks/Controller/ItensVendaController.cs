using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class ItensVendaController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.ItensVendaModel ivnd_m = new Model.ItensVendaModel();

        public void InsereItensVenda(int idItensVenda, int idProduto, int quantidadeUnitario, decimal valorUnitario)
        {
            ivnd_m.IdItensVenda = idItensVenda;
            ivnd_m.IdProduto = idProduto;
            ivnd_m.QuantidadeUnitario = quantidadeUnitario;
            ivnd_m.ValorUnitario = valorUnitario;

            if (dao.InserirItensVenda(ivnd_m) == false)
                MessageBox.Show("Erro ao retirar Produto!");
        }
    }
}
