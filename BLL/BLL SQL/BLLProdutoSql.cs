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
   public class BLLProdutoSql
    {

        DAO.ProdutoSql prod;
        DAO.DAOProdutoSql DAOProduto;

        public void Inserir(string Nome, string Categoria, string Descricao, string Sabor, double Custo)
        {
            

            prod = new DAO.ProdutoSql();
            
            prod.Nome = Nome;
            prod.Categoria = Categoria;
            prod.Descricao = Descricao;            
            prod.Sabor = Sabor;
            prod.Custo = Custo;

            DAOProduto = new DAO.DAOProdutoSql();
            DAOProduto.InserirProduto(prod);
        }
        public void InserirCategoria(string Categoria)
        {
            DAOProduto = new DAO.DAOProdutoSql();
            DAOProduto.InserirCategoria(Categoria);
        }

        public DataTable BuscarProdutoID(string ID) 
        {
            DAOProduto = new DAO.DAOProdutoSql();
            return DAOProduto.BuscarProdutoID(ID);
        
        }
        public DataTable BuscarProduto() 
        {
            DAOProduto = new DAO.DAOProdutoSql();
            return DAOProduto.MostrarProduto();
       
        }
        public DataTable InativarCategoria(string Nome)
        {
            DAOProduto = new DAO.DAOProdutoSql();
            return DAOProduto.InativarCategoria(Nome);

        }
        public DataTable ConsultarCategoria()
        {
            DAOProduto = new DAO.DAOProdutoSql();
            return DAOProduto.ConsultarCategoria();

        }
        public void AtualizarProdutoID(string id, string Nome, string Categoria, string Descricao, string Sabor, double Valor)
        {
            decimal ValorFinal = Convert.ToDecimal(Valor);
            int IDPronto = Convert.ToInt32(id);
            prod = new DAO.ProdutoSql();

            prod.Id = IDPronto;
            prod.Nome = Nome;
            prod.Categoria = Categoria;
            prod.Descricao = Descricao;
            prod.Sabor = Sabor;
            prod.Valor = Valor;
          

            DAOProduto = new DAO.DAOProdutoSql();
            DAOProduto.AtualizarProdutoDAO(prod);
        }
        public void carregarComboProduto(ComboBox cbx)
        {
            DAOProduto = new DAO.DAOProdutoSql();
            OracleDataReader dr = DAOProduto.buscarProdutoCombo();
            while (dr.Read())
            {
                cbx.Items.Add(dr.GetString(1));
            }
        }
        public void carregarComboCategoria(ComboBox cbx)
        {
            DAOProduto = new DAO.DAOProdutoSql();
            OracleDataReader dr = DAOProduto.ConsultarCategoriaCombo();
            while (dr.Read())
            {
                cbx.Items.Add(dr.GetString(1));
            }
        }
        public DataTable ConsultarCategoriaNome(string Nome)
        {
            DAOProduto = new DAO.DAOProdutoSql();
            return DAOProduto.ConsultarCategoriaNome(Nome);

        }
       
       public DataTable BuscarProdutoNome(string Nome) 
        {
            DAOProduto = new DAO.DAOProdutoSql();
            return DAOProduto.BuscarProdutoNome(Nome);
        
        }
       public void BuscarProdutoVencimento(ComboBox cbx, string id)
       {
           DAOProduto = new DAO.DAOProdutoSql();
           OracleDataReader dr = DAOProduto.BuscarProdutoVencimento(id);
           while (dr.Read())
            {
                cbx.Items.Add(dr.GetDateTime(0));
            }
        }

       
       public void Inativar(string Id)
       {

           DAOProduto = new DAO.DAOProdutoSql();
           DAOProduto.Inativar(Id);
       }
       public void Ativar(string Id)
       {

           DAOProduto = new DAO.DAOProdutoSql();
           DAOProduto.Ativar(Id);
       }
       public DataTable SelecionarProdutoInativo()
       {
           DAOProduto = new DAO.DAOProdutoSql();
           return DAOProduto.MostrarProdutoInativo();
       }
    }
}