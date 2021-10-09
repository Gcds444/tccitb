/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class BLLCliente
    {
        DAO.Cliente cliente;
        DAO.DAOCliente DAOCliente;
     

        public void Incluir(string Empresa, string Nome, string Email, string Tel, string CPF) 
        {
            cliente = new DAO.Cliente();
            cliente.Empresa = Empresa;
            cliente.Nome = Nome;
            cliente.Email = Email;
            cliente.Tel = Tel;
            cliente.CPF = CPF;


            DAOCliente = new DAO.DAOCliente();
            DAOCliente.Inserir(cliente);
        }

        public DataTable SelecionarClienteCPF(string CPF) 
        {           
            DAOCliente = new DAO.DAOCliente();
            return DAOCliente.buscarClienteCPF(CPF);
        }

        public DataTable SelecionarClienteCPFInteiro()
        {
            DAOCliente = new DAO.DAOCliente();
            return DAOCliente.MostrarClienteCPF();
        }

        public void AtualizarClienteCPF(string Empresa, string Nome, string Email, string Tel, string CPF)
        {
            cliente = new DAO.Cliente();
            cliente.Empresa = Empresa;
            cliente.Nome = Nome;
            cliente.Email = Email;
            cliente.Tel = Tel;
            cliente.CPF = CPF;


            DAOCliente = new DAO.DAOCliente();
            DAOCliente.AtualizarClienteDAO(cliente);
        }


        public void ExcluirClienteCPF(string CPF)
        {
            cliente = new DAO.Cliente();
            cliente.CPF = CPF;

            DAOCliente = new DAO.DAOCliente();
            DAOCliente.ExcluirClienteDAO(cliente);
        }

        public DataTable SelecionarClienteInativoCPF()
        {
            DAOCliente = new DAO.DAOCliente();
            return DAOCliente.MostrarClienteInativo();
        }
    }
}*/
                                                         