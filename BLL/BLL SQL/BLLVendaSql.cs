using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLLVendaSql
    {
        DAO.VendaSql venda;
        DAO.DAOVendaSql DAOVenda;

        public void Inserir(int Id_Pedido, string Forma, string Bandeira, int Parcela, double Valor)
        {
           

            venda = new DAO.VendaSql();

            venda.Id_Pedido = Id_Pedido;
            venda.Forma = Forma;
            venda.Bandeira = Bandeira;
            venda.Parcela = Parcela;
            venda.Valor = Valor;

            DAOVenda = new DAO.DAOVendaSql();
            DAOVenda.InserirVenda(venda);
        }

        public DataTable SelecionarVendaId(string Id)
        {
            DAOVenda = new DAO.DAOVendaSql();
            return DAOVenda.BuscarVendaID(Id);
        }
        public DataTable SelecionarVendaTotal(string Id)
        {
            DAOVenda = new DAO.DAOVendaSql();
            return DAOVenda.BuscarVendaTotal(Id);
        }
        public DataTable ValorVenda(string Id)
        {
            DAOVenda = new DAO.DAOVendaSql();
            return DAOVenda.ValorVenda(Id);
        }
        public DataTable SelecionarVenda()
        {
            DAOVenda = new DAO.DAOVendaSql();
            return DAOVenda.BuscarVenda();
        }
        public void Inativar(string Id)
        {
            DAOVenda = new DAO.DAOVendaSql();
            DAOVenda.Inativar(Id);
        }
    }
}
