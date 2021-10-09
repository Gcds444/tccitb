using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLLClienteSql
    {
        DAO.ClienteSql cliente;
        DAO.DAOClienteSql DAOCliente;

        public void Inserir(string Nome, string Razao, string CNPJ, string Email, string Telefone, string CEP, string Logradouro, string Endereco, string Numero, string Complemento, string Bairro, string Cidade, string UF, string NomeRepresentante, string CPF, string TelefoneRepresentante, string EmailRepresentante, string Situacao)
        {

            cliente = new DAO.ClienteSql();

            cliente.Nome = Nome;
            cliente.Razao = Razao;
            cliente.CNPJ = CNPJ;
            cliente.Email = Email;
            cliente.Telefone = Telefone;
            cliente.CEP = CEP;
            cliente.Logradouro = Logradouro;
            cliente.Endereco = Endereco;
            cliente.Numero = Numero;
            cliente.Complemento = Complemento;
            cliente.Bairro = Bairro;
            cliente.Cidade = Cidade;
            cliente.UF = UF;
            cliente.NomeRepresentante = NomeRepresentante;
            cliente.CPF = CPF;
            cliente.TelefoneRepresentante = TelefoneRepresentante;
            cliente.EmailRepresentante = EmailRepresentante;
            cliente.Situacao = Situacao;
           
            DAOCliente = new DAO.DAOClienteSql();
            DAOCliente.InserirCliente(cliente);
        }
        public DataTable SelecionarClienteCPF(string CPF)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteCPF(CPF);
        }
        public DataTable ConsultarCliente()
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.MostrarCliente();
        }
        public void Atualizar(string Nome, string Razao, string CNPJ, string Email, string Telefone, string CEP, string Logradouro, string Endereco, string Numero, string Complemento, string Bairro, string Cidade, string UF, string NomeRepresentante, string CPF, string TelefoneRepresentante, string EmailRepresentante, string Situacao)
        {

            cliente = new DAO.ClienteSql();

            cliente.Nome = Nome;
            cliente.Razao = Razao;
            cliente.CNPJ = CNPJ;
            cliente.Email = Email;
            cliente.Telefone = Telefone;
            cliente.CEP = CEP;
            cliente.Logradouro = Logradouro;
            cliente.Endereco = Endereco;
            cliente.Numero = Numero;
            cliente.Complemento = Complemento;
            cliente.Bairro = Bairro;
            cliente.Cidade = Cidade;
            cliente.UF = UF;
            cliente.NomeRepresentante = NomeRepresentante;
            cliente.CPF = CPF;
            cliente.TelefoneRepresentante = TelefoneRepresentante;
            cliente.EmailRepresentante = EmailRepresentante;
            cliente.Situacao = Situacao;

            DAOCliente = new DAO.DAOClienteSql();
            DAOCliente.AtualizarCLienteDAO(cliente);
        }
    }
}
