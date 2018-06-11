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


        public void InsereFornecedor(long cnpj, string razaoSocial, string cep, string endereco, string numero, string bairro, string cidade, string uf, int dddTelefone, int telefone, int dddCelular, string celular, string nomeFantasia, long inscricaoEstadual, string email)
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


            if (dao.InserirFornecedor(fnd) == true)
                MessageBox.Show("Inserido com Sucesso!", "Mensagem do Sistema");
            else
                MessageBox.Show("Falha ao inserir!", "Mensagem do Sistema");

        }
        
        public void AlteraFornecedor(long cnpj, string razaoSocial, string cep, string endereco, string numero, string bairro, string cidade, string uf, int dddTelefone, int telefone, int dddCelular, string celular, string nomeFantasia, long inscricaoEstadual, string email)
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


            if (dao.AlterarFonecedor(fnd) == true)
                MessageBox.Show("Alterado com Sucesso!", "Mensagem do Sistema");
            else
                MessageBox.Show("Falha ao alterar!", "Mensagem do Sistema");
        }

        public void ExcluiFornecedor(long cnpj)
        {
            fnd.Cnpj = cnpj;


            if (dao.ExcluirFornecedor(fnd) == true)
                MessageBox.Show("Excluido com Sucesso!", "Mensagem do Sistema");
            else
                MessageBox.Show("Falha ao excluir!", "Mensagem do Sistema");
        }
    }
}
