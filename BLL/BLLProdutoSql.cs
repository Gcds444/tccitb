using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
   public class BLLProdutoSql
    {
        DAO.ProdutoSql prod;
        DAO.DAOProdutoSql DAOProduto;

        public void Inserir(string Nome, string Categoria, string Descricao, string Unidade, string Sabor, string Situacao)
        {
            prod = new DAO.ProdutoSql();

            prod.Nome = Nome;
            prod.Categoria = Categoria;
            prod.Descricao = Descricao;
            prod.Unidade = Unidade;
            prod.Sabor = Sabor;
            prod.Situacao = Situacao;
            

            DAOProduto = new DAO.DAOProdutoSql();
            DAOProduto.InserirProduto(prod);
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
        public void AtualizarPrdoutoID(string id, string Nome, string Categoria, string Descricao, string Unidade, string Sabor, string Situacao)
        {
            int IDPronto = Convert.ToInt32(id);
            prod = new DAO.ProdutoSql();

            prod.Id = IDPronto;
            prod.Nome = Nome;
            prod.Categoria = Categoria;
            prod.Descricao = Descricao;
            prod.Unidade = Unidade;
            prod.Sabor = Sabor;
            prod.Situacao = Situacao;


            DAOProduto = new DAO.DAOProdutoSql();
            DAOProduto.AtualizarProdutoDAO(prod);
        }
    }
}