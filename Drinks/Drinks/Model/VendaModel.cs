using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class VendaModel
    {
        public int IdVenda { get; set; }
        public int IdItensVenda { get; set; }
        public int QuantidadeTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataVenda{ get; set; }
    }
}
