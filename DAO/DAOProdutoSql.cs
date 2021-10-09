using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAO
{
    public class DAOProdutoSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string InserirProduto(ProdutoSql produto)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();

                SQL = "INSERT INTO ADMUSER.PRODUTO (ID_PRODUTO,NOME_PRODUTO,CATEGORIA_PRODUTO,DESCRICAO_PRODUTO,UNIDADE_MEDIDA,SABOR_PRODUTO,SITUACAO_PRODUTO)"
                        + "VALUES (ADMUSER.SQN_PRODUTO.NEXTVAL,'" + produto.Nome + "','" + produto.Categoria + "','" + produto.Descricao + "','" + produto.Unidade + "','" + produto.Sabor + "','" + produto.Situacao + "')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
        public DataTable BuscarProdutoID(string ID)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.PRODUTO WHERE ID_PRODUTO LIKE '%" + ID + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MostrarProduto()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.PRODUTO";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
            public DataTable AtualizarProdutoDAO(ProdutoSql produto)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PRODUTO SET NOME_PRODUTO ='" + produto.Nome + "',CATEGORIA_PRODUTO ='" + produto.Categoria + "',DESCRICAO_PRODUTO ='" + produto.Descricao + "',UNIDADE_MEDIDA ='" + produto.Unidade + "',SABOR_PRODUTO ='" + produto.Sabor + "',SITUACAO_PRODUTO ='" + produto.Situacao + "'WHERE ID_PRODUTO ='" + produto.Id +"'";                              
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
