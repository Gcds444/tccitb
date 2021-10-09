using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;


namespace DAO
{
    public class DAOFuncionarioSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string inserirFuncionario(FuncionarioSql funcionario)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();

                SQL = "INSERT INTO ADMUSER.FUNCIONARIO (ID_FUNCIONARIO,NOME_FUNCIONARIO,DT_NASC_FUNCIONARIO,SEXO_FUNCIONARIO,GENERO_FUNCIONARIO,RG_FUNCIONARIO,CPF_FUNCIONARIO,EMAIL_FUNCIONARIO,TEL_RES_FUNCIONARIO,TEL_MOV_FUNCIONARIO,CEP_FUNCIONARIO,LOGRADOURO_FUNCIONARIO,ENDERECO_FUNCIONARIO,NUMERO_FUNCIONARIO,COMPLEMENTO_FUNCIONARIO,BAIRRO_FUNCIONARIO,CIDADE_FUNCIONARIO,UF_FUNCIONARIO,CARGO_FUNCIONARIO,SALARIO_FUNCIONARIO,USUARIO,SENHA,SITUACAO_FUNCIONARIO)"
                        + "VALUES (ADMUSER.SQN_FUNCIONARIO.NEXTVAL,'" + funcionario.Nome + "','" + funcionario.DataNasc + "','" + funcionario.Sexo + "','" + funcionario.Genero + "','" + funcionario.RG + "','" + funcionario.CPF + "','" + funcionario.Email + "','" + funcionario.TResidencial + "','" + funcionario.TMovel + "','" + funcionario.CEP + "','" + funcionario.Logradouro + "','" + funcionario.Endereco + "','" + funcionario.Numero + "','" + funcionario.Complemento + "','" + funcionario.Bairro + "','" + funcionario.Cidade + "','" + funcionario.UF + "','" + funcionario.Cargo + "','" + funcionario.Salario + "','" + funcionario.Usuario + "','" + funcionario.Senha + "','" + funcionario.Situacao + "')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }

        public DataTable buscarFuncionarioCPF(string CPF)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.FUNCIONARIO WHERE CPF_FUNCIONARIO LIKE '%" + CPF + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MostrarFuncionarioCPF()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.FUNCIONARIO";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable buscarFuncionarioCadastro(string Usuario, string Senha)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "select * from ADMUSER.FUNCIONARIO where USUARIO LIKE '%" + Usuario + "%' and SENHA LIKE '%" + Senha + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable AtualizarFuncionarioDAO(FuncionarioSql funcionario)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.FUNCIONARIO SET NOME_FUNCIONARIO ='" + funcionario.Nome + "',DT_NASC_FUNCIONARIO ='" + funcionario.DataNasc + "',SEXO_FUNCIONARIO ='" + funcionario.Sexo + "',GENERO_FUNCIONARIO ='" + funcionario.Genero + "',RG_FUNCIONARIO ='" + funcionario.RG + "',CPF_FUNCIONARIO ='" + funcionario.CPF + "',EMAIL_FUNCIONARIO ='" + funcionario.Email + "',TEL_RES_FUNCIONARIO ='" + funcionario.TResidencial + "',TEL_MOV_FUNCIONARIO ='" + funcionario.TMovel + "',CEP_FUNCIONARIO ='" + funcionario.CEP + "',LOGRADOURO_FUNCIONARIO ='" + funcionario.Logradouro + "',ENDERECO_FUNCIONARIO ='" + funcionario.Endereco + "',NUMERO_FUNCIONARIO ='" + funcionario.Numero + "',COMPLEMENTO_FUNCIONARIO ='" + funcionario.Complemento + "',BAIRRO_FUNCIONARIO ='" + funcionario.Bairro + "',CIDADE_FUNCIONARIO ='" + funcionario.Cidade + "',UF_FUNCIONARIO ='" + funcionario.UF + "',CARGO_FUNCIONARIO ='" + funcionario.Cargo + "',SALARIO_FUNCIONARIO ='" + funcionario.Salario + "',USUARIO ='" + funcionario.Usuario + "',SENHA ='" + funcionario.Senha + "',SITUACAO_FUNCIONARIO ='" + funcionario.Situacao + "'WHERE CPF_FUNCIONARIO ='" + funcionario.CPF +"'";                              
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
    }
    }
}

                
        
       
    

