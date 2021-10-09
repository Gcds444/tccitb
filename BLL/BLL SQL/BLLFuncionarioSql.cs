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
    public class BLLFuncionarioSql
    {
        DAO.FuncionarioSql func;
        DAO.DAOFuncionarioSql DAOFuncionario;



        public void Inserir(string Nome, string DataNasc, string Sexo, string CPF, string Email, string TResidencial, string TMovel, string CEP, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string UF, string Usuario, string Senha, string Funcao)
        {

            func = new DAO.FuncionarioSql();

            func.Nome = Nome;
            func.DataNasc = DataNasc;
            func.Sexo = Sexo;
            func.CPF = CPF;
            func.Email = Email;
            func.TResidencial = TResidencial;
            func.TMovel = TMovel;
            func.CEP = CEP;
            func.Logradouro = Logradouro;
            func.Numero = Numero;
            func.Complemento = Complemento;
            func.Bairro = Bairro;
            func.Cidade = Cidade;
            func.UF = UF;
            func.Senha = Senha;
            func.Usuario = Usuario;
            func.Funcao = Funcao;
            

            DAOFuncionario = new DAO.DAOFuncionarioSql();
            DAOFuncionario.inserirFuncionario(func);
        }

        public DataTable SelecionarFuncionarioCPF(string CPF)
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            return DAOFuncionario.buscarFuncionarioCPF(CPF);
            
        }
        public DataTable SelecionarIDlogin(string IDlogin)
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            return DAOFuncionario.buscarIDlogin(IDlogin);
        }
        public DataTable SelecionarIDFuncionario(string IDFuncionario)
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            return DAOFuncionario.BuscarID(IDFuncionario);
        }

        public DataTable SelecionarFuncionarioInteiro()
        {
           DAOFuncionario = new DAO.DAOFuncionarioSql();
           return DAOFuncionario.MostrarFuncionarioCPF();
        }

        public DataTable SelecionarFuncionarioCadastro(string Usuario, string Senha) 
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            return DAOFuncionario.buscarFuncionarioCadastro(Usuario, Senha);
       }
        public void AtualizarFuncionarioCPF(string ID, string Nome, string DataNasc, string Sexo, string CPF, string Email, string TResidencial, string TMovel, string CEP, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string UF, string Usuario, string Senha, string Funcao)
           { 
            func = new DAO.FuncionarioSql();

            func.ID = ID;
            func.Nome = Nome;
            func.DataNasc = DataNasc;
            func.Sexo = Sexo;
            func.CPF = CPF;
            func.Email = Email;
            func.TResidencial = TResidencial;
            func.TMovel = TMovel;
            func.CEP = CEP;
            func.Logradouro = Logradouro;
            func.Numero = Numero;
            func.Complemento = Complemento;
            func.Bairro = Bairro;
            func.Cidade = Cidade;
            func.UF = UF;
            func.Senha = Senha;
            func.Usuario = Usuario;
            func.Funcao = Funcao;
            
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            DAOFuncionario.AtualizarFuncionarioDAO(func);
    }
        public void carregarComboFuncionario(ComboBox cbx)
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            OracleDataReader dr = DAOFuncionario.buscarFuncionario();
            while (dr.Read())
            {
                cbx.Items.Add(dr.GetString(1));
            }
        }
            public DataTable BuscarFuncionarioNome(string Nome) 
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            return DAOFuncionario.BuscarFuncionarioNome(Nome);
        
        }
            public void Inativar(string ID) 
            {             

                DAOFuncionario = new DAO.DAOFuncionarioSql();
                DAOFuncionario.Inativar(ID);
            }
            public void Ativar(string ID)
            {

                DAOFuncionario = new DAO.DAOFuncionarioSql();
                DAOFuncionario.Ativar(ID);
            }
            public void InativarDireto()
            {
                func = new DAO.FuncionarioSql();
                

                DAOFuncionario = new DAO.DAOFuncionarioSql();
                DAOFuncionario.InativarDireto(func);
            }

     /*   public void InativarFunc(int id, int status)
        {
            funcionario = new Funcionario();
            funcionario.Id = id;
            login = new Login();
            login.id = id;
            if (status == 1)
            {
                funcionario.AtivoInativo = 0;
                login.status = 0;
            }
            else
            {
                funcionario.AtivoInativo = 1;
                login.status = 1;
            }


            DAOfuncionario = new DAOFuncionario();
            DAOfuncionario.AtivarDesativar(funcionario, login);
        
            */
            public DataTable SelecionarFuncionarioInativo()
            {
                DAOFuncionario = new DAO.DAOFuncionarioSql();
                return DAOFuncionario.MostrarFuncionarioInativo();
            }
        
    
    }

}
