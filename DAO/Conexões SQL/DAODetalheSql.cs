using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAO
{
    public class DAODetalheSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string inserirDetalhe(string id_pedido, string cep, string bairro, string cidade, string uf, string numero, string complemento, string logradouro)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "INSERT INTO ADMUSER.DETALHE(ID_DETALHE,ID_DETALHE_PEDIDO,CEP,BAIRRO,CIDADE,UF,NUMERO,COMPLEMENTO,LOGRADOURO)"
                                + "VALUES (ADMUSER.sqn_detalhe.NEXTVAL,'" + id_pedido + "', '" + cep + "','" + bairro + "','" + cidade + "','" + uf + "','" + numero + "','" + complemento + "','" + logradouro + "')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
        public string Atualizar(string id_pedido, string cep, string bairro, string cidade, string uf, string numero, string complemento, string logradouro)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "update ADMUSER.ITEM_PEDIDO set (CEP,BAIRRO,CIDADE,UF,NUMERO,COMPLEMENTO,LOGRADOURO)"
                                + "VALUES ('" + cep + "','" + bairro + "','" + cidade + "','" + uf + "','" + numero + "','" + complemento + "','" + logradouro + "') where ID_DETALHE_PEDIDO = " + id_pedido + "";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
    
        public DataTable BuscarEndereco(string id)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "select * from admuser.detalhe where id_detalhe_pedido = " + id + "";
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
