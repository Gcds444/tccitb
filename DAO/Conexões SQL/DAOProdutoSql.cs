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

                SQL = "INSERT INTO ADMUSER.PRODUTO (ID_PRODUTO,NOME_PRODUTO,CATEGORIA_PRODUTO,DESCRICAO_PRODUTO,SABOR_PRODUTO,CUSTO_PRODUTO,SITUACAO_PRODUTO)"
                        + "VALUES (ADMUSER.SQN_PRODUTO.NEXTVAL,'" + produto.Nome + "','" + produto.Categoria + "','" + produto.Descricao + "','" + produto.Sabor + "','" + produto.Custo + "','Ativo')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
        public string InserirCategoria(string Nome)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();

                SQL = "INSERT INTO ADMUSER.CATEGORIA (ID_CATEGORIA,NOME_CATEGORIA)"
                        + "VALUES (ADMUSER.SQN_CATEGORIA.NEXTVAL,'" + Nome + "')";

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
        public DataTable InativarCategoria(string Nome)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "delete from admuser.categoria where id_categoria ='" + Nome + "'";
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
                SQL = "SELECT * FROM ADMUSER.PRODUTO WHERE SITUACAO_PRODUTO ='Ativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ConsultarCategoria()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.CATEGORIA";
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
                SQL = "UPDATE ADMUSER.PRODUTO SET NOME_PRODUTO ='" + produto.Nome + "',CATEGORIA_PRODUTO ='" + produto.Categoria + "',DESCRICAO_PRODUTO ='" + produto.Descricao + "',SABOR_PRODUTO ='" + produto.Sabor + "', CUSTO_PRODUTO ='" + produto.Valor + "' WHERE ID_PRODUTO ='" + produto.Id + "'";                              
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
    }
            public OracleDataReader buscarProdutoCombo()
            {
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                OracleDataReader dr;
                string SQL = "SELECT * FROM ADMUSER.PRODUTO WHERE SITUACAO_PRODUTO ='Ativo'";
                dr = conexao.RetornarDataReader(SQL);
                return dr;
            }
            public OracleDataReader ConsultarCategoriaCombo()
            {
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                OracleDataReader dr;
                string SQL = "SELECT * FROM ADMUSER.CATEGORIA";
                dr = conexao.RetornarDataReader(SQL);
                return dr;
            }
            public DataTable ConsultarCategoriaNome(string nome)
            {
                DataTable dt = new DataTable();
             
                string SQL = "SELECT * FROM ADMUSER.CATEGORIA WHERE NOME_CATEGORIA = '" + nome + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }
            public DataTable BuscarProdutoNome(string Nome)
            {

                try
                {


                    DataTable dt = new DataTable();
                    SQL = "SELECT * FROM ADMUSER.PRODUTO WHERE NOME_PRODUTO LIKE '%" + Nome + "%'";
                    dt = conexao.RetornarDataTable(SQL);
                    return dt;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public OracleDataReader BuscarProdutoVencimento(string id)
            {
                    ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                    OracleDataReader dr;
                    string SQL = "select DATA_VENCIMENTO from ADMUSER.ESTOQUE WHERE ID_ESTOQUE_PRODUTO = '" + id + "'and STATUS = 'Ativo' AND QUANTIDADE_ESTOQUE > 0 ORDER BY DATA_VENCIMENTO ASC";
                    dr = conexao.RetornarDataReader(SQL);
                    return dr;
                
            }
                public DataTable Inativar(string Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PRODUTO SET SITUACAO_PRODUTO ='Inativo' WHERE ID_PRODUTO ='" + Id +"'";;
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
                public DataTable Ativar(string Id)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        SQL = "UPDATE ADMUSER.PRODUTO SET SITUACAO_PRODUTO ='Ativo' WHERE ID_PRODUTO ='" + Id + "'"; ;
                        dt = conexao.RetornarDataTable(SQL);
                        return dt;
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
        public DataTable MostrarProdutoInativo()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.PRODUTO WHERE SITUACAO_PRODUTO = 'Inativo'";
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
