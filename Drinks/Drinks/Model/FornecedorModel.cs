using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Model
{
    class FornecedorModel
    {
        public long     Cnpj { get; set; }
        public string   RazaoSocial { get; set; }
        public int      Cep { get; set; }
        public string   Endereco { get; set; }
        public string   Numero { get; set; }
        public string   Bairro { get; set; }
        public string   Cidade { get; set; }
        public string   Uf { get; set; }
        public int      DDDTelefone { get; set; }
        public int      Telefone { get; set; }
        public int      DDDCelular { get; set; }
        public int      Celular { get; set; }   
        public string   NomeFantasia { get; set; }
        public long     InscricaoEstadual { get; set; }
        public string   Email { get; set; }
    }
}
