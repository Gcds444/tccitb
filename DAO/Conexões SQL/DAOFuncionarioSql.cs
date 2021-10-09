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


        private ClasseConexaoDAO cn;
        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string inserirFuncionario(FuncionarioSql funcionario)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();

                SQL = "INSERT INTO ADMUSER.FUNCIONARIO (ID_FUNCIONARIO,NOME_FUNCIONARIO,DT_NASC_FUNCIONARIO,SEXO_FUNCIONARIO,CPF_FUNCIONARIO,EMAIL_FUNCIONARIO,TEL_RES_FUNCIONARIO,TEL_MOV_FUNCIONARIO,CEP_FUNCIONARIO,LOGRADOURO_FUNCIONARIO,NUMERO_FUNCIONARIO,COMPLEMENTO_FUNCIONARIO,BAIRRO_FUNCIONARIO,CIDADE_FUNCIONARIO,UF_FUNCIONARIO,USUARIO,SENHA,FUNCAO_FUNCIONARIO,SITUACAO_FUNCIONARIO)"
                        + "VALUES (ADMUSER.SQN_FUNCIONARIO.NEXTVAL,'" + funcionario.Nome + "','" + funcionario.DataNasc + "','" + funcionario.Sexo + "','" + funcionario.CPF + "','" + funcionario.Email + "','" + funcionario.TResidencial + "','" + funcionario.TMovel + "','" + funcionario.CEP + "','" + funcionario.Logradouro + "','" + funcionario.Numero + "','" + funcionario.Complemento + "','" + funcionario.Bairro + "','" + funcionario.Cidade + "','" + funcionario.UF + "','" + funcionario.Usuario + "','" + funcionario.Senha + "','" + funcionario.Funcao + "','Ativo')";

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
        public DataTable buscarIDlogin(string IDpedido)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT ID_FUNCIONARIO FROM ADMUSER.FUNCIONARIO WHERE USUARIO = '" + IDpedido + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarID(string IDFuncionario)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.FUNCIONARIO WHERE NOME_FUNCIONARIO = '" + IDFuncionario + "'";
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
                SQL = "SELECT * FROM ADMUSER.FUNCIONARIO WHERE SITUACAO_FUNCIONARIO = 'Ativo'";
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
                SQL = "UPDATE ADMUSER.FUNCIONARIO SET NOME_FUNCIONARIO ='" + funcionario.Nome + "',DT_NASC_FUNCIONARIO ='" + funcionario.DataNasc + "',SEXO_FUNCIONARIO ='" + funcionario.Sexo + "',CPF_FUNCIONARIO ='" + funcionario.CPF + "',EMAIL_FUNCIONARIO ='" + funcionario.Email + "',TEL_RES_FUNCIONARIO ='" + funcionario.TResidencial + "',TEL_MOV_FUNCIONARIO ='" + funcionario.TMovel + "',CEP_FUNCIONARIO ='" + funcionario.CEP + "',LOGRADOURO_FUNCIONARIO ='" + funcionario.Logradouro + "',NUMERO_FUNCIONARIO ='" + funcionario.Numero + "',COMPLEMENTO_FUNCIONARIO ='" + funcionario.Complemento + "',BAIRRO_FUNCIONARIO ='" + funcionario.Bairro + "',CIDADE_FUNCIONARIO ='" + funcionario.Cidade + "',UF_FUNCIONARIO ='" + funcionario.UF + "',USUARIO ='" + funcionario.Usuario + "',SENHA ='" + funcionario.Senha + "', WHERE ID_FUNCIONARIO ='" + funcionario.ID +"'";                              
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
    }
        public OracleDataReader buscarFuncionario()
        {
            ClasseConexaoDAO conexao = new ClasseConexaoDAO();
            OracleDataReader dr;
            string SQL = " select * from ADMUSER.FUNCIONARIO WHERE SITUACAO_FUNCIONARIO = 'Ativo'";
            dr = conexao.RetornarDataReader(SQL);
            return dr;
        }

        public DataTable BuscarFuncionarioNome(string Nome)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.FUNCIONARIO WHERE NOME_FUNCIONARIO LIKE '%" + Nome + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Inativar(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.FUNCIONARIO SET SITUACAO_FUNCIONARIO ='Inativo' WHERE ID_FUNCIONARIO ='" + ID +"'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public DataTable Ativar(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.FUNCIONARIO SET SITUACAO_FUNCIONARIO ='Ativo' WHERE ID_FUNCIONARIO ='" + ID + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable InativarDireto(FuncionarioSql funcionario)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.FUNCIONARIO SET SITUACAO_FUNCIONARIO ='Inativo'"; 
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable MostrarFuncionarioInativo()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.FUNCIONARIO WHERE SITUACAO_FUNCIONARIO = 'Inativo'";
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

                
        
       
    

