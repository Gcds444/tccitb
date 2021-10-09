using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace BLL
{
    public class BLLItemSql
    {
        DAO.ItemSql item;
        DAO.DAOItemSql DAOItem;

        public void InserirItemPedido(int idestoque, int id_pedido, int idProduto)
        {
            DAOItem = new DAO.DAOItemSql();
            DAOItem.inserirItemPedido(idestoque,id_pedido, idProduto);
        }
        public DataTable SelecionarItemPedido(string id)
        {
            DAOItem = new DAO.DAOItemSql();
            return DAOItem.BuscarItemPedido(id);

        }
        public DataTable SelecionarValorPedido(string id)
        {
            DAOItem = new DAO.DAOItemSql();
            return DAOItem.BuscarValorPedido(id);

        }
        public DataTable SelecionarItemPedidoAtivo(string id)
        {
            DAOItem = new DAO.DAOItemSql();
            return DAOItem.BuscarItemPedidoAtivo(id);

        }

        public void Inativar(string id)
        {
            item = new DAO.ItemSql();
            item.id = id;

            DAOItem = new DAO.DAOItemSql();
            DAOItem.Retirar(item);
        }
        public DataTable Valor(string id)
        {
            DAOItem = new DAO.DAOItemSql();
            return DAOItem.BuscarValorTotal(id);
        }
    }
}
