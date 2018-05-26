using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class ProdutoModel
    {
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public string DescricaoProduto { get; set; }
        public int IdUnidadeMedida { get; set; }
        public int IdTamanho { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorUnitarioTotal { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
