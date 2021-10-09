using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace BLL
{
    public class BLLClienteSql
    {
        DAO.ClienteSql cliente;
        DAO.DAOClienteSql DAOCliente;

        public void Inserir(string Nome, string Razao, string CNPJ, string Email, string Telefone, string CEP, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string UF, string NomeRepresentante, string CPF, string TelefoneRepresentante, string EmailRepresentante, string Senha)
        {

            cliente = new DAO.ClienteSql();

            cliente.Nome = Nome;
            cliente.Razao = Razao;
            cliente.CNPJ = CNPJ;
            cliente.Email = Email;
            cliente.Telefone = Telefone;
            cliente.CEP = CEP;
            cliente.Logradouro = Logradouro;
            cliente.Numero = Numero;
            cliente.Complemento = Complemento;
            cliente.Bairro = Bairro;
            cliente.Cidade = Cidade;
            cliente.UF = UF;
            cliente.NomeRepresentante = NomeRepresentante;
            cliente.CPF = CPF;
            cliente.TelefoneRepresentante = TelefoneRepresentante;
            cliente.EmailRepresentante = EmailRepresentante;
            cliente.Senha = Senha;

            DAOCliente = new DAO.DAOClienteSql();
            DAOCliente.InserirCliente(cliente);
        }
        public DataTable SelecionarClienteCNPJ(string CNPJ)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteCNPJ(CNPJ);
        }
        public DataTable SelecionarClienteCPF(string CPF)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteCPF(CPF);
        }
        public DataTable SelecionarClienteEmail(string Email)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteEmail(Email);
        }
        public DataTable SelecionarClienteEmailRepresentante(string Email)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteEmailRepresentante(Email);
        }
        public DataTable SelecionarClienteNome(string Nome)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteNome(Nome);
        }
        public DataTable SelecionarClienteRazao(string Razao)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteRazao(Razao);
        }
         public DataTable SelecionarClienteID(string id)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.buscarClienteID(id);
        }
        public DataTable ConsultarCliente()
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.MostrarCliente();
        }
        public void Atualizar(string ID,string Nome, string Razao, string CNPJ, string Email, string Telefone, string CEP, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string UF, string NomeRepresentante, string CPF, string TelefoneRepresentante, string EmailRepresentante, string senha)
        {

            cliente = new DAO.ClienteSql();
            cliente.Id = ID;
            cliente.Nome = Nome;
            cliente.Razao = Razao;
            cliente.CNPJ = CNPJ;
            cliente.Email = Email;
            cliente.Telefone = Telefone;
            cliente.CEP = CEP;
            cliente.Logradouro = Logradouro;
            cliente.Numero = Numero;
            cliente.Complemento = Complemento;
            cliente.Bairro = Bairro;
            cliente.Cidade = Cidade;
            cliente.UF = UF;
            cliente.NomeRepresentante = NomeRepresentante;
            cliente.CPF = CPF;
            cliente.TelefoneRepresentante = TelefoneRepresentante;
            cliente.EmailRepresentante = EmailRepresentante;
            cliente.Senha = senha;

            DAOCliente = new DAO.DAOClienteSql();
            DAOCliente.AtualizarCLienteDAO(cliente);
        }
        public void carregarComboCliente(ComboBox cbx)
        {
            DAOCliente = new DAO.DAOClienteSql();
            OracleDataReader dr = DAOCliente.buscarClienteCombo();
            while (dr.Read())
            {
                cbx.Items.Add(dr.GetString(1));
            }
        }
        public DataTable BuscarClienteNome(string Nome)
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.BuscarClienteNome(Nome);

        }
        public void Inativar(string ID)
        {                   
            DAOCliente = new DAO.DAOClienteSql();
            DAOCliente.Inativar(ID);
        }
        public void Ativar(string ID)
        {
            DAOCliente = new DAO.DAOClienteSql();
            DAOCliente.Ativar(ID);
        }
        public DataTable SelecionarClienteInativo()
        {
            DAOCliente = new DAO.DAOClienteSql();
            return DAOCliente.MostrarClienteInativo();
        }
    }
}
