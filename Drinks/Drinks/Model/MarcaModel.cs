using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class MarcaModel
    {
        private int idMarca;
        private string descricaoMarca;

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string DescricaoMarca { get => descricaoMarca; set => descricaoMarca = value; }
    }
}
