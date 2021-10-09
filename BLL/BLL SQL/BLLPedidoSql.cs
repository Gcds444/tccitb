using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using System.Data;


namespace BLL
{
    public class BLLPedidoSql
    {
        DAO.PedidoSql pedido;
        DAO.DAOPedidoSql DAOPedido;

        public void Inserir( int id_funcionario, int id_cliente, int ValorTotal)
        {
            int ValorFinal = Convert.ToInt32(ValorTotal);
            
            int id_funcionario_final = Convert.ToInt32(id_funcionario);
            int id_cliente_final = Convert.ToInt32(id_cliente);
             


            pedido = new DAO.PedidoSql();


            pedido.id_funcionario = id_funcionario_final;
            pedido.id_cliente = id_cliente_final;
          
            pedido.ValorTotal = ValorFinal;
            

            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.inserirPedido(pedido);
        }
        public void InserirEntrega(int IDpedido)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.InserirEntrega(IDpedido);
        }
        public DataTable BuscarEntrega()
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.BuscarEntrega();

        }
        public DataTable BuscarEntregaID(string ID)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.BuscarEntregaID(ID);

        }
        public DataTable MostrarUltimoID()
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.SelecionarUltimoID();
        }

        public DataTable BuscarProdutoID(string ID)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.BuscarPedidoID(ID);

        }
        public DataTable BuscarPedidoID(string IDPedido) 
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.BuscarPedidoIDPedido(IDPedido);
        }       
        public void Inativar(string Id)
        {
         /*   pedido = new DAO.PedidoSql();
            int IDPronto = Convert.ToInt32(Id);
            pedido.id_pedido = IDPronto;*/

            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.Inativar(Id);
        }
        public void Ativar(string Id)
        {
            /*   pedido = new DAO.PedidoSql();
               int IDPronto = Convert.ToInt32(Id);
               pedido.id_pedido = IDPronto;*/

            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.Ativar(Id);
        }
        public void AtualizarValor(int Id, string Valor)
        {
            /*   pedido = new DAO.PedidoSql();
               int IDPronto = Convert.ToInt32(Id);
               pedido.id_pedido = IDPronto;*/

            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.AtualizarValor(Id, Valor);
        }
      
        public void Vender(int Id)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.Finalizar(Id);

        }
        public void AtualizarPedido(string ID, string IDFuncionario, string IDCliente, string Valor)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.AtualizarPedido(ID, IDFuncionario, IDCliente,Valor);

        }
        public DataTable SelecionarPedidoInativo()
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.MostrarPedidoInativo();
        }
        public DataTable SelecionarPedidoIncompleto()
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.MostrarPedidoIncompleto();
        }
        public DataTable PegarUF(int ID)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.PegarUF(ID);
        }
        public void AtualizarPedidoID(string id_pedido, string id_produto, string id_funcionario, string id_cliente, string Quantidade, string ValorTotal)
        {
            decimal ValorFinal = Convert.ToDecimal(ValorTotal);
         //   int id_pedido_final = Convert.ToInt32(id_pedido);
            int id_produto_final = Convert.ToInt32(id_produto);
            int id_funcionario_final = Convert.ToInt32(id_funcionario);
            int id_cliente_final = Convert.ToInt32(id_cliente);
            int Quantidade_final = Convert.ToInt32(Quantidade);

            pedido = new DAO.PedidoSql();

            pedido.id_pedido = id_pedido;
            pedido.id_produto = id_produto_final;
            pedido.id_funcionario = id_funcionario_final;
            pedido.id_cliente = id_cliente_final;
      
            pedido.ValorTotal = ValorFinal;


            DAOPedido = new DAO.DAOPedidoSql();
            DAOPedido.AtualizarPedidoDAO(pedido);
        }
        public DataTable SelecionarPedidoInteiro()
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.MostrarPedidoInteiro();
        }

        public void carregarComboPedido(ComboBox cbx)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            OracleDataReader dr = DAOPedido.buscarPedidoCombo();
            while (dr.Read())
            {
                cbx.Items.Add(dr.GetString(1));
            }
        }
        public DataTable InativarIncompleto(string id)
        {
            pedido = new DAO.PedidoSql();
            pedido.id_pedido = id;
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.InativarIncompleto(pedido);
        }
        public DataTable ValorTotal(string Valor, string id)
        {
            DAOPedido = new DAO.DAOPedidoSql();
            return DAOPedido.ValorTotal(Valor, id);
        }
    }
}
