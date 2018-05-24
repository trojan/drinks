using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class ProdutoModel
    {
        private int idProduto;
        private int idMarca;
        private string descricaoProduto;
        private int idUnidadeMedida;
        private int idTamanho;
        private int quantidade;
        private decimal valorUnitario;
        private decimal valorUnitarioTotal;
        private decimal valorTotal;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string DescricaoProduto { get => descricaoProduto; set => descricaoProduto = value; }
        public int IdUnidadeMedida { get => idUnidadeMedida; set => idUnidadeMedida = value; }
        public int IdTamanho { get => idTamanho; set => idTamanho = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public decimal ValorUnitarioTotal { get => valorUnitarioTotal; set => valorUnitarioTotal = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
