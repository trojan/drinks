using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class UnidadeMedidaModel
    {
        private int idUnidadeMedida;
        private string descricaoUnidadeMedida;

        public int IdUnidadeMedida { get => idUnidadeMedida; set => idUnidadeMedida = value; }
        public string DescricaoUnidadeMedida { get => descricaoUnidadeMedida; set => descricaoUnidadeMedida = value; }
    }
}
