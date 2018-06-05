using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class CompraModel
    {
        public int IdCompra { get; set; }
        public int IdItensCompra { get; set; }
        public int QuantidadeTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
