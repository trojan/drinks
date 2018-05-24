using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class TamanhoModel
    {
        private int idTamanho;
        private string descricaoTamanho;

        public int IdTamanho { get => idTamanho; set => idTamanho = value; }
        public string DescricaoTamanho { get => descricaoTamanho; set => descricaoTamanho = value; }
    }
}
