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

                SQL = "INSERT INTO ADMUSER.CLIENTE (ID_CLIENTE,NOME_EMPRESA,RAZAO_EMPRESA,CNPJ_EMPRESA,EMAIL_EMPRESA,TELEFONE_EMPRESA,CEP_EMPRESA,LOGRADOURO_EMPRESA,ENDERECO_EMPRESA,NUMERO_EMPRESA,COMPLEMENTO_EMPRESA,BAIRRO_EMPRESA,CIDADE_EMPRESA,UF_EMPRESA,NOME_REPRESENTANTE,CPF_REPRESENTANTE,TELEFONE_REPRESENTANTE,EMAIL_REPRESENTANTE,SITUACAO_CLIENTE)"
                        + "VALUES (ADMUSER.SQN_CLIENTE.NEXTVAL,'" + cliente.Nome + "','" + cliente.Razao + "','" + cliente.CNPJ + "','" + cliente.Email + "','" + cliente.Telefone + "','" + cliente.CEP + "','" + cliente.Logradouro + "','" + cliente.Endereco + "','" + cliente.Numero + "','" + cliente.Complemento + "','" + cliente.Bairro + "','" + cliente.Cidade + "','" + cliente.UF + "','" + cliente.NomeRepresentante + "','" + cliente.CPF + "','" + cliente.TelefoneRepresentante + "','" + cliente.EmailRepresentante + "','" + cliente.Situacao + "')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
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
        public DataTable MostrarCliente()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CLIENTE";
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
                SQL = "UPDATE ADMUSER.CLIENTE SET NOME_EMPRESA ='" + cliente.Nome + "',RAZAO_EMPRESA ='" + cliente.Razao + "',CNPJ_EMPRESA ='" + cliente.CNPJ + "',EMAIL_EMPRESA ='" + cliente.Email + "',TELEFONE_EMPRESA ='" + cliente.Telefone + "',CEP_EMPRESA ='" + cliente.CEP + "',LOGRADOURO_EMPRESA ='" + cliente.Logradouro + "',ENDERECO_EMPRESA ='" + cliente.Endereco + "',NUMERO_EMPRESA ='" + cliente.Numero + "',COMPLEMENTO_EMPRESA ='" + cliente.Complemento + "',BAIRRO_EMPRESA ='" + cliente.Bairro + "',CIDADE_EMPRESA ='" + cliente.Cidade + "',UF_EMPRESA ='" + cliente.UF + "',NOME_REPRESENTANTE ='" + cliente.NomeRepresentante + "',TELEFONE_REPRESENTANTE ='" + cliente.TelefoneRepresentante + "',EMAIL_REPRESENTANTE ='" + cliente.EmailRepresentante + "',SITUACAO_CLIENTE ='" + cliente.Situacao + "'WHERE CPF_REPRESENTANTE ='" + cliente.CPF + "'";
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

        


