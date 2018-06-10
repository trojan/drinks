using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.Controller
{
    class FornecedorController
    {
        DAO.DAO dao = new DAO.DAO();
        Model.FornecedorModel fnd = new Model.FornecedorModel();


        public void InsereFornecedor(long cnpj, string razaoSocial, int cep, string endereco, string numero, string bairro, string cidade, string uf, int dddTelefone, int telefone, int dddCelular, int celular, string nomeFantasia, long inscricaoEstadual, string email)
        {
            fnd.Cnpj = cnpj;
            fnd.RazaoSocial = razaoSocial;
            fnd.Cep = cep;
            fnd.Endereco = endereco;
            fnd.Numero = numero;
            fnd.Bairro = bairro;
            fnd.Cidade = cidade;
            fnd.Uf = uf;
            fnd.DDDTelefone = dddTelefone;
            fnd.Telefone = telefone;
            fnd.DDDCelular = dddCelular;
            fnd.Celular = celular;
            fnd.NomeFantasia = nomeFantasia;
            fnd.InscricaoEstadual = inscricaoEstadual;
            fnd.Email = email;
        }

        public void AlteraFornecedor(long cnpj, string razaoSocial, int cep, string endereco, string numero, string bairro, string cidade, string uf, int dddTelefone, int telefone, int dddCelular, int celular, string nomeFantasia, long inscricaoEstadual, string email)
        {

        }

        public void ExcluiFornecedor(long cnpj, string razaoSocial, int cep, string endereco, string numero, string bairro, string cidade, string uf, int dddTelefone, int telefone, int dddCelular, int celular, string nomeFantasia, long inscricaoEstadual, string email)
        {

        }

    }
}
