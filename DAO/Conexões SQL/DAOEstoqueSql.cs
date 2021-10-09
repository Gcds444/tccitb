using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAO
{
   public class DAOEstoqueSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

       public DataTable BuscarID(string estoque)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "SELECT * FROM ADMUSER.PRODUTO WHERE NOME_PRODUTO = '" + estoque + "'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable BuscarIDEstoque(string validade, int idproduto)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "SELECT * FROM ADMUSER.ESTOQUE WHERE to_char(DATA_VENCIMENTO, 'DD/MM/YYYY') = '" + validade + "' and ID_ESTOQUE_PRODUTO = '" + idproduto + "'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable BuscarProdutoTabela(int id)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "SELECT * FROM ADMUSER.ESTOQUE WHERE ID_ESTOQUE_PRODUTO = '" + id + "' and STATUS = 'Ativo'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }

       public DataTable BuscarQuantidade(string id)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "SELECT QUANTIDADE_ESTOQUE FROM ADMUSER.ESTOQUE WHERE ID_ESTOQUE = '" + id + "'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable BuscarEstoque()
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "Select E.ID_ESTOQUE, P.NOME_PRODUTO, E.DATA_PRODUCAO, E.DATA_VENCIMENTO, E.QUANTIDADE_ESTOQUE,E.CUSTO_TOTAL, E.STATUS FROM ADMUSER.ESTOQUE E INNER JOIN ADMUSER.PRODUTO P ON E.ID_ESTOQUE_PRODUTO = P.ID_PRODUTO WHERE STATUS = 'Ativo'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable BuscarEsgotado()
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "Select E.ID_ESTOQUE, P.NOME_PRODUTO, E.DATA_PRODUCAO, E.DATA_VENCIMENTO, E.QUANTIDADE_ESTOQUE, E.STATUS FROM ADMUSER.ESTOQUE E INNER JOIN ADMUSER.PRODUTO P ON E.ID_ESTOQUE_PRODUTO = P.ID_PRODUTO WHERE STATUS = 'Esgotado'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable BuscarVencimento()
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "Select E.ID_ESTOQUE, P.NOME_PRODUTO, E.DATA_PRODUCAO, E.DATA_VENCIMENTO, E.QUANTIDADE_ESTOQUE, E.STATUS FROM ADMUSER.ESTOQUE E INNER JOIN ADMUSER.PRODUTO P ON E.ID_ESTOQUE_PRODUTO = P.ID_PRODUTO WHERE STATUS = 'Vencido'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }


           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable BuscarInativo()
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "Select E.ID_ESTOQUE, P.NOME_PRODUTO, E.DATA_PRODUCAO, E.DATA_VENCIMENTO, E.QUANTIDADE_ESTOQUE, E.STATUS FROM ADMUSER.ESTOQUE E INNER JOIN ADMUSER.PRODUTO P ON E.ID_ESTOQUE_PRODUTO = P.ID_PRODUTO WHERE STATUS = 'Inativo'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
        public string inserirEstoque(EstoqueSql estoque)
        {
            try
            {
                
               
                var dataVencimento = System.DateTime.Now.AddDays(10).ToShortDateString();
                var data = System.DateTime.Now.ToShortDateString();
                string info ="";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "INSERT INTO ADMUSER.ESTOQUE(ID_ESTOQUE,ID_ESTOQUE_PRODUTO,DATA_PRODUCAO,DATA_VENCIMENTO,QUANTIDADE_ESTOQUE,STATUS,CUSTO_TOTAL,CUSTO2)"
                                + "VALUES (ADMUSER.SQN_ESTOQUE.NEXTVAL, '" + estoque.id_estoque_produto + "' , (SELECT SYSDATE FROM DUAL) , (SELECT SYSDATE + 10 FROM DUAL) , '" + estoque.Quantidade + "' ,'Ativo', '" +estoque.custo+"','" + estoque.custo2 + "')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
                
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }

       public DataTable SelecionarSomaQuantidade(string Quantidade)
       {
            try
           {
               DataTable dt = new DataTable();
               SQL = " SELECT sum(QUANTIDADE_ESTOQUE) FROM ADMUSER.ESTOQUE WHERE ID_ESTOQUE_PRODUTO = '" + Quantidade + "'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable SelecionarQuantidadeValidade(string data)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "SELECT QUANTIDADE_ESTOQUE FROM ADMUSER.ESTOQUE WHERE to_char(DATA_VENCIMENTO, 'DD/MM/YYYY')LIKE '"+ data +"'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable VencimentoAutomatico()
           {
           try
           {
               DataTable dt = new DataTable();
               SQL = "UPDATE admuser.ESTOQUE set STATUS = 'Vencido' where DATA_VENCIMENTO <= (select sysdate from DUAL) AND STATUS = 'Ativo'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable EsgotamentoAutomatico()
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "UPDATE admuser.ESTOQUE set STATUS = 'Esgotado' where QUANTIDADE_ESTOQUE = 0 AND STATUS = 'Ativo'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable Atualizar(int idproduto, int quantidade, double custototal, string id)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "UPDATE admuser.ESTOQUE SET ID_ESTOQUE_PRODUTO ='" + idproduto + "',QUANTIDADE_ESTOQUE ='" + quantidade + "', CUSTO_TOTAL =  '" + custototal + "' WHERE ID_ESTOQUE = '" + id + "'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable AtualizarQuantidade(decimal quantidade, string id)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "UPDATE ADMUSER.ESTOQUE SET QUANTIDADE_ESTOQUE = '" + quantidade + "' WHERE ID_ESTOQUE = '" + id + "'";
               dt = conexao.RetornarDataTable(SQL);
               return dt;
           }

           catch (Exception ex)
           {
               throw ex;
           }

       }
       public DataTable Pendente(int ID)
       {
           try
           {
               DataTable dt = new DataTable();
               SQL = "UPDATE ADMUSER.ESTOQUE SET STATUS ='Pendente' WHERE ID_ESTOQUE ='" + ID + "'";
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
               SQL = "UPDATE ADMUSER.ESTOQUE SET STATUS ='Inativo' WHERE ID_ESTOQUE ='" + ID + "'";
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
               SQL = "UPDATE ADMUSER.ESTOQUE SET STATUS ='Ativo' WHERE ID_ESTOQUE ='" + ID + "'";
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

