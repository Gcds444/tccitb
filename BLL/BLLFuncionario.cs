/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class BLLFuncionario
    {
        DAO.Funcionario funcionario;
        DAO.DAOFuncionario DAOFuncionario;

        public void Inserir
        (string Nome, string DataNasc, string RG, string CPF, string Email, string TResidencial, string TMovel, string CEP, string Senha, string Usuario)
        {
            

            funcionario = new DAO.Funcionario();
            funcionario.Nome = Nome;
            funcionario.DataNasc = DataNasc;
            funcionario.RG = RG;
            funcionario.CPF = CPF;
            funcionario.Email = Email;
            funcionario.TResidencial = TResidencial;
            funcionario.TMovel = TMovel;
            funcionario.CEP = CEP;
            funcionario.Senha = Senha;
            funcionario.Usuario = Usuario;
         
            DAOFuncionario = new DAO.DAOFuncionario();
            DAOFuncionario.Inserir(funcionario);
        }

        public DataTable SelecionarFuncionarioCPF(string CPF)
        {
            DAOFuncionario = new DAO.DAOFuncionario();
            return DAOFuncionario.buscarFuncionarioCPF(CPF);
        }

        public DataTable SelecionarFuncionarioCadastro(string Usuario, string Senha)
        {
            DAOFuncionario = new DAO.DAOFuncionario();
            return DAOFuncionario.buscarFuncionarioCadastro(Usuario,Senha);
        }
        public DataTable SelecionarFuncionarioInteiro()
        {
            DAOFuncionario = new DAO.DAOFuncionario();
            return DAOFuncionario.MostrarFuncionarioCPF();
        }

        public void AtualizarFuncionarioCPF(string Nome, string DataNasc, string RG, string CPF, string Email, string Residencial, 
                                        string Movel, string CEP, string Usuario, string Senha)
        {
            funcionario = new DAO.Funcionario();
            funcionario.Nome = Nome;
            funcionario.DataNasc = DataNasc;
            funcionario.RG = RG;
            funcionario.CPF = CPF;
            funcionario.Email = Email;
            funcionario.TResidencial = Residencial;
            funcionario.TMovel = Movel;
            funcionario.CEP = CEP;
            funcionario.Usuario = Usuario;
            funcionario.Senha = Senha;
            
            DAOFuncionario = new DAO.DAOFuncionario();
            DAOFuncionario.AtualizarFuncionarioDAO(funcionario);
        }

        public void ExcluirFuncionarioCPF(string CPF)
        {
            funcionario = new DAO.Funcionario();
            funcionario.CPF = CPF;

            DAOFuncionario = new DAO.DAOFuncionario();
            DAOFuncionario.ExcluirFuncionarioDAO(funcionario);
        }


        public DataTable SelecionarFuncionarioInativo()
        {
            DAOFuncionario = new DAO.DAOFuncionario();
            return DAOFuncionario.MostrarFuncionarioInativo();
        }
    }
}*/
