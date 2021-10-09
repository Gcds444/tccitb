using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAO
{
    public class DAOPedidoSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string inserirPedido(PedidoSql pedido)
        {
            try
            {
                var data = System.DateTime.Now.ToShortDateString();
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "INSERT INTO ADMUSER.PEDIDO(ID_PEDIDO,ID_FUNCIONARIO_PEDIDO,ID_CLIENTE_PEDIDO,VALOR_TOTAL,DATA_HORA_PEDIDO,STATUS)"
                                + "VALUES (ADMUSER.SQN_PEDIDO.NEXTVAL,'" + pedido.id_funcionario + "','" + pedido.id_cliente + "','" + pedido.valor_total + "',(SELECT SYSDATE FROM DUAL),'Ativo')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }

        public string InserirEntrega(int idpedido )
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "INSERT INTO ADMUSER.ENTREGA(ID_ENTREGA,ID_PEDIDO_ENTREGA,DATA_VENDA,DATA_ENTREGA)"
                                + "VALUES (ADMUSER.SQN_ENTREGA.NEXTVAL,'" + idpedido + "',(SELECT SYSDATE FROM DUAL),(SELECT SYSDATE + 4 FROM DUAL))";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }

        public DataTable BuscarEntrega()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.ENTREGA";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarEntregaID(string ID)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.ENTREGA WHERE ID_PEDIDO_ENTREGA LIKE '%" + ID + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarPedidoID(string ID)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.PEDIDO WHERE ID_CLIENTE_PEDIDO LIKE '%" + ID + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarPedidoIDPedido(string IDPedido)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT * FROM ADMUSER.PEDIDO WHERE ID_PEDIDO LIKE '%" + IDPedido + "%'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SelecionarUltimoID()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "SELECT MAX(ID_PEDIDO) FROM ADMUSER.PEDIDO;";
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
                SQL = "UPDATE ADMUSER.PEDIDO SET STATUS ='Inativo' WHERE ID_PEDIDO ='" + ID + "'"; 
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
                SQL = "UPDATE ADMUSER.PEDIDO SET STATUS ='Ativo' WHERE ID_PEDIDO ='" + ID + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable AtualizarValor(int ID, string Valor)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PEDIDO SET VALOR_TOTAL ='" +Valor+ "' WHERE ID_PEDIDO ='" + ID + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable AtualizarPedido(string ID, string IDFuncionario, string IDCliente, string Valor)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PEDIDO SET ID_FUNCIONARIO_PEDIDO = " + IDFuncionario + ",ID_CLIENTE_PEDIDO = " + IDCliente + " ,VALOR_TOTAL =" + Valor + " WHERE ID_PEDIDO ='" + ID + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Finalizar(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PEDIDO SET STATUS ='Vendido' WHERE ID_PEDIDO ='" + id + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable InativarIncompleto(PedidoSql pedido)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PEDIDO SET STATUS = 'Incompleto' WHERE ID_PEDIDO ='"+ pedido.id_pedido +"'"; 
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
             }
                  public DataTable ValorTotal(string valor, string id )
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PEDIDO SET VALOR_TOTAL = '" + valor + "' WHERE ID_PEDIDO = '" + id + "'"; 
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable MostrarPedidoInativo()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "select P.ID_PEDIDO, F.NOME_FUNCIONARIO, K.NOME_EMPRESA, P.VALOR_TOTAL, P.DATA_HORA_PEDIDO, P.STATUS FROM ADMUSER.PEDIDO P INNER JOIN ADMUSER.FUNCIONARIO F ON P.ID_FUNCIONARIO_PEDIDO = F.ID_FUNCIONARIO JOIN ADMUSER.CLIENTE K ON P.ID_CLIENTE_PEDIDO = K.ID_CLIENTE WHERE P.STATUS = 'Inativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MostrarPedidoIncompleto()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "select P.ID_PEDIDO, F.NOME_FUNCIONARIO, K.NOME_EMPRESA, P.VALOR_TOTAL, P.DATA_HORA_PEDIDO, P.STATUS FROM ADMUSER.PEDIDO P INNER JOIN ADMUSER.FUNCIONARIO F ON P.ID_FUNCIONARIO_PEDIDO = F.ID_FUNCIONARIO JOIN ADMUSER.CLIENTE K ON P.ID_CLIENTE_PEDIDO = K.ID_CLIENTE WHERE P.STATUS = 'Incompleto'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable PegarUF(int ID)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "select K.UF_EMPRESA FROM ADMUSER.PEDIDO P INNER JOIN ADMUSER.CLIENTE K ON P.ID_CLIENTE_PEDIDO = K.ID_CLIENTE WHERE P.ID_PEDIDO = " + ID + "";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }       
        public DataTable AtualizarPedidoDAO(PedidoSql pedido)
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "UPDATE ADMUSER.PEDIDO SET ID_PRODUTO_PEDIDO ='" + pedido.id_produto + "',ID_FUNCIONARIO_PEDIDO ='" + pedido.id_funcionario + "',ID_CLIENTE_PEDIDO ='" + pedido.id_cliente + "',VALORTOTAL_PEDIDO ='" + pedido.ValorTotal + "'WHERE ID_PEDIDO ='" + pedido.id_pedido + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MostrarPedidoInteiro()
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "select P.ID_PEDIDO, F.NOME_FUNCIONARIO, K.NOME_EMPRESA, P.VALOR_TOTAL, P.DATA_HORA_PEDIDO, P.STATUS FROM ADMUSER.PEDIDO P INNER JOIN ADMUSER.FUNCIONARIO F ON P.ID_FUNCIONARIO_PEDIDO = F.ID_FUNCIONARIO JOIN ADMUSER.CLIENTE K ON P.ID_CLIENTE_PEDIDO = K.ID_CLIENTE WHERE P.STATUS = 'Ativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader buscarPedidoCombo()
        {
            ClasseConexaoDAO conexao = new ClasseConexaoDAO();
            OracleDataReader dr;
            string SQL = "SELECT * FROM ADMUSER.PEDIDO WHERE STATUS ='Ativo'";
            dr = conexao.RetornarDataReader(SQL);
            return dr;
        }

    }

}