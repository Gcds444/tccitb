using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class BLLFuncionarioSql
    {
        DAO.FuncionarioSql func;
        DAO.DAOFuncionarioSql DAOFuncionario;

        public void Inserir(string Nome, string DataNasc, string Sexo, string Genero, string RG, string CPF, string Email, string TResidencial, string TMovel, string CEP, string Logradouro, string Endereco, string Numero, string Complemento, string Bairro, string Cidade, string UF, string Cargo, string Salario, string Usuario, string Senha, string Situacao)
        {

            func = new DAO.FuncionarioSql();

            func.Nome = Nome;
            func.DataNasc = DataNasc;
            func.Sexo = Sexo;
            func.Genero = Genero;
            func.RG = RG;
            func.CPF = CPF;
            func.Email = Email;
            func.TResidencial = TResidencial;
            func.TMovel = TMovel;
            func.CEP = CEP;
            func.Logradouro = Logradouro;
            func.Endereco = Endereco;
            func.Numero = Numero;
            func.Complemento = Complemento;
            func.Bairro = Bairro;
            func.Cidade = Cidade;
            func.UF = UF;
            func.Cargo = Cargo;
            func.Salario = Salario;
            func.Senha = Senha;
            func.Usuario = Usuario;
            func.Situacao = Situacao;

            DAOFuncionario = new DAO.DAOFuncionarioSql();
            DAOFuncionario.inserirFuncionario(func);
        }

        public DataTable SelecionarFuncionarioCPF(string CPF)
        {
            DAOFuncionario = new DAO.DAOFuncionarioSql();
            return DAOFuncionario.buscarFuncionarioCPF(CPF);
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
        public void AtualizarFuncionarioCPF(string Nome, string DataNasc, string Sexo, string Genero, string RG, string CPF, string Email, string TResidencial, string TMovel, string CEP, string Logradouro, string Endereco, string Numero, string Complemento, string Bairro, string Cidade, string UF, string Cargo, string Salario, string Usuario, string Senha, string Situacao)
           { 
            func = new DAO.FuncionarioSql();

            func.Nome = Nome;
            func.DataNasc = DataNasc;
            func.Sexo = Sexo;
            func.Genero = Genero;
            func.RG = RG;
            func.CPF = CPF;
            func.Email = Email;
            func.TResidencial = TResidencial;
            func.TMovel = TMovel;
            func.CEP = CEP;
            func.Logradouro = Logradouro;
            func.Endereco = Endereco;
            func.Numero = Numero;
            func.Complemento = Complemento;
            func.Bairro = Bairro;
            func.Cidade = Cidade;
            func.UF = UF;
            func.Cargo = Cargo;
            func.Salario = Salario;
            func.Senha = Senha;
            func.Usuario = Usuario;
            func.Situacao = Situacao;

            DAOFuncionario = new DAO.DAOFuncionarioSql();
            DAOFuncionario.AtualizarFuncionarioDAO(func);
    }
        public void carragarCombo(ComboBox cbx)
        {
            DAOFuncionario cargoDAO = new DAO.DAOFuncionarioSql();
            OracleDataReader dr = cargoDAO.buscarCargos();
            while (dr.Read())
            {
                cbx.Items.Add(dr.GetString(1));
            }
        }
    
    }

}
