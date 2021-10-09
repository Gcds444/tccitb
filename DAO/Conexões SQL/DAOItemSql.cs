using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAO
{
    public class DAOItemSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string inserirItemPedido(int idestoque, int id_pedido, int idProduto)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "INSERT INTO ADMUSER.ITEM_PEDIDO(ID_ITEM,ID_ESTOQUE_PEDIDO,ID_ITEM_PEDIDO,ID_ITEM_PRODUTO)"
                                + "VALUES (ADMUSER.SQN_ITEM.NEXTVAL," + idestoque + "," + id_pedido + ", " + idProduto +")";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
        public DataTable BuscarItemPedido(string id)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = " select I.ID_ITEM ,X.ID_PEDIDO, E.ID_ESTOQUE,P.NOME_PRODUTO, E.QUANTIDADE_ESTOQUE, E.CUSTO_TOTAL,E.STATUS FROM ADMUSER.ITEM_PEDIDO I INNER JOIN ADMUSER.PEDIDO X ON I.ID_ITEM_PEDIDO = X.ID_PEDIDO JOIN ADMUSER.PRODUTO P ON I.ID_ITEM_PRODUTO = P.ID_PRODUTO JOIN ADMUSER.ESTOQUE E ON I.ID_ESTOQUE_PEDIDO = E.ID_ESTOQUE WHERE X.ID_PEDIDO = "+ id +" AND E.STATUS = 'Pendente'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarValorPedido(string id)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = " select sum(E.CUSTO_TOTAL) FROM ADMUSER.ITEM_PEDIDO I INNER JOIN ADMUSER.ESTOQUE E ON I.ID_ESTOQUE_PEDIDO = E.ID_ESTOQUE WHERE I.ID_ITEM_PEDIDO = " + id + " AND E.STATUS = 'Pendente'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarItemPedidoAtivo(string id)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.ITEM_PEDIDO where ID_ITEM_PEDIDO LIKE '" + id + "' and STATUS = 'Ativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataTable Retirar(ItemSql item)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "DELETE ADMUSER.ITEM_PEDIDO WHERE ID_ITEM = '" + item.id +"'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable BuscarValorTotal(string id)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT sum(TOTAL) FROM ADMUSER.ITEM_PEDIDO where STATUS = 'Ativo' and ID_ITEM_PEDIDO LIKE '" + id + "'";
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

