using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAO
{
   public class DAOVendaSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;

        public string InserirVenda(VendaSql venda)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();

                SQL = "INSERT INTO ADMUSER.VENDA (ID_VENDA,ID_PEDIDO_VENDA,FORMA_PAGAMENTO,BANDEIRA,PARCELAS,VALOR,STATUS)"
                 //   + "SELECT SYSDATE FROM DUAL as DataHoje"
                        + "VALUES (ADMUSER.SQN_VENDA.NEXTVAL,'" + venda.Id_Pedido + "','" + venda.Forma + "','" + venda.Bandeira + "','" + venda.Parcela + "','" + venda.Valor + "', 'Ativo')";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }
              public DataTable BuscarVendaID(string Id)
        {

            try
            {


                DataTable dt = new DataTable();
                SQL = "select P.ID_PEDIDO, F.NOME_FUNCIONARIO, K.NOME_EMPRESA, P.VALOR_TOTAL, P.DATA_HORA_PEDIDO, P.STATUS FROM ADMUSER.PEDIDO P INNER JOIN ADMUSER.FUNCIONARIO F ON P.ID_FUNCIONARIO_PEDIDO = F.ID_FUNCIONARIO JOIN ADMUSER.CLIENTE K ON P.ID_CLIENTE_PEDIDO = K.ID_CLIENTE WHERE ID_PEDIDO = '" + Id + "' and P.STATUS = 'Vendido'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
              public DataTable BuscarVendaTotal(string Id)
              {

                  try
                  {


                      DataTable dt = new DataTable();
                      SQL = "SELECT * FROM ADMUSER.VENDA WHERE ID_PEDIDO_VENDA = " + Id + " and status = 'Ativo'";
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
                      SQL = "UPDATE ADMUSER.VENDA SET STATUS ='Inativo' WHERE ID_VENDA ='" + ID + "'";
                      dt = conexao.RetornarDataTable(SQL);
                      return dt;
                  }

                  catch (Exception ex)
                  {
                      throw ex;
                  }
              }
              public DataTable ValorVenda(string ID)
              {
                  try
                  {
                      DataTable dt = new DataTable();
                      SQL = "select nvl(sum(valor),0) from admuser.venda where ID_PEDIDO_VENDA = " + ID + " and status = 'Ativo'";
                      dt = conexao.RetornarDataTable(SQL);
                      return dt;
                  }

                  catch (Exception ex)
                  {
                      throw ex;
                  }
              }
              public DataTable BuscarVenda()
              {

                  try
                  {


                      DataTable dt = new DataTable();
                      SQL = "select P.ID_PEDIDO, F.NOME_FUNCIONARIO, K.NOME_EMPRESA, P.VALOR_TOTAL, P.DATA_HORA_PEDIDO, P.STATUS FROM ADMUSER.PEDIDO P INNER JOIN ADMUSER.FUNCIONARIO F ON P.ID_FUNCIONARIO_PEDIDO = F.ID_FUNCIONARIO JOIN ADMUSER.CLIENTE K ON P.ID_CLIENTE_PEDIDO = K.ID_CLIENTE WHERE P.STATUS = 'Vendido' ";
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

