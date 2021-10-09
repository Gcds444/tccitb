using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAO
{
    public class DAOClienteSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string InserirCliente(ClienteSql cliente)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();

                SQL = "INSERT INTO ADMUSER.CLIENTE (ID_CLIENTE,NOME_EMPRESA,RAZAO_EMPRESA,CNPJ_EMPRESA,EMAIL_EMPRESA,TELEFONE_EMPRESA,CEP_EMPRESA,LOGRADOURO_EMPRESA,NUMERO_EMPRESA,COMPLEMENTO_EMPRESA,BAIRRO_EMPRESA,CIDADE_EMPRESA,UF_EMPRESA,NOME_REPRESENTANTE,CPF_REPRESENTANTE,TELEFONE_REPRESENTANTE,EMAIL_REPRESENTANTE,SITUACAO_CLIENTE,SENHA)"
                        + "VALUES (ADMUSER.SQN_CLIENTE.NEXTVAL,'" + cliente.Nome + "','" + cliente.Razao + "','" + cliente.CNPJ + "','" + cliente.Email + "','" + cliente.Telefone + "','" + cliente.CEP + "','" + cliente.Logradouro + "','" + cliente.Numero + "','" + cliente.Complemento + "','" + cliente.Bairro + "','" + cliente.Cidade + "','" + cliente.UF + "','" + cliente.NomeRepresentante + "','" + cliente.CPF + "','" + cliente.TelefoneRepresentante + "','" + cliente.EmailRepresentante + "','Ativo','" + cliente.Senha + "')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
        public DataTable buscarClienteCNPJ(string CNPJ)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE CNPJ_EMPRESA LIKE '%" + CNPJ + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable buscarClienteCPF(string CPF)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE CPF_REPRESENTANTE LIKE '%" + CPF + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable buscarClienteEmailRepresentante(string Email)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE EMAIL_REPRESENTANTE LIKE '%" + Email + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable buscarClienteEmail(string Email)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE EMAIL_EMPRESA LIKE '%" + Email + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable buscarClienteNome(string Nome)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE NOME_EMPRESA LIKE '%" + Nome + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable buscarClienteRazao(string Razao)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE RAZAO_EMPRESA LIKE '%" + Razao + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable buscarClienteID(string ID)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE NOME_EMPRESA LIKE '%" + ID + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MostrarCliente()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE SITUACAO_CLIENTE = 'Ativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable AtualizarCLienteDAO(ClienteSql cliente)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.CLIENTE SET NOME_EMPRESA ='" + cliente.Nome + "',RAZAO_EMPRESA ='" + cliente.Razao + "',CNPJ_EMPRESA ='" + cliente.CNPJ + "',EMAIL_EMPRESA ='" + cliente.Email + "',TELEFONE_EMPRESA ='" + cliente.Telefone + "',CEP_EMPRESA ='" + cliente.CEP + "',LOGRADOURO_EMPRESA ='" + cliente.Logradouro + "',NUMERO_EMPRESA ='" + cliente.Numero + "',COMPLEMENTO_EMPRESA='" + cliente.Complemento + "',BAIRRO_EMPRESA ='" + cliente.Bairro + "',CIDADE_EMPRESA ='" + cliente.Cidade + "',UF_EMPRESA ='" + cliente.UF + "',NOME_REPRESENTANTE ='" + cliente.NomeRepresentante + "',CPF_REPRESENTANTE = '" + cliente.CPF +"',TELEFONE_REPRESENTANTE ='" + cliente.TelefoneRepresentante + "',EMAIL_REPRESENTANTE ='" + cliente.EmailRepresentante + "',SENHA = '" +cliente.Senha + "' WHERE ID_CLIENTE ='" + cliente.Id + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public OracleDataReader buscarClienteCombo()
        {
            ClasseConexaoDAO conexao = new ClasseConexaoDAO();
            OracleDataReader dr;
            string SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE SITUACAO_CLIENTE ='Ativo'";
            dr = conexao.RetornarDataReader(SQL);
            return dr;
        }
        public DataTable BuscarClienteNome(string Nome)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE NOME_EMPRESA LIKE '%" + Nome + "%'";
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
                SQL = "UPDATE ADMUSER.CLIENTE SET SITUACAO_CLIENTE ='Inativo' WHERE ID_CLIENTE ='" + ID +"'";;
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
                    SQL = "UPDATE ADMUSER.CLIENTE SET SITUACAO_CLIENTE ='Ativo' WHERE ID_CLIENTE ='" + ID + "'"; ;
                    dt = conexao.RetornarDataTable(SQL);
                    return dt;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }
        public DataTable MostrarClienteInativo()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE WHERE SITUACAO_CLIENTE = 'Inativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MostrarPedidoCPF()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.PEDIDO WHERE SITUACAO_PEDIDO = 'Ativo'";
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


        


