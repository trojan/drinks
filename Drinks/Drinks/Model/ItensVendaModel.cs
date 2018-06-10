using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class ItensVendaModel
    {
        public int IdItensVenda { get; set; }
        public int IdProduto { get; set; }
        public int QuantidadeUnitario { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
