/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLLProduto
    {
        DAO.Produto produto;
        DAO.DAOProduto DAOProduto;

        public void Inserir(string Nome, string Descricao, string Preco,string Quantidade)
        {
            int cQuantidade = Convert.ToInt32(Quantidade);
            decimal cPreco = Convert.ToDecimal(Preco);

            produto = new DAO.Produto();
            produto.Nome = Nome;
            produto.Descricao = Descricao;
            produto.Preco = cPreco;
            produto.Quantidade = cQuantidade;

            DAOProduto = new DAO.DAOProduto();
            DAOProduto.Inserir(produto);
        }
        public DataTable SelecionarProdutoid(int id)
        {
            DAOProduto = new DAO.DAOProduto();
            return DAOProduto.buscarProdutoid(id);
        }

        public DataTable SelecionarProdutoInteiro()
        {
            DAOProduto = new DAO.DAOProduto();
            return DAOProduto.MostrarProdutoid();
        }

        public void AtualizarProdutoid(string id ,string Nome, string Descricao, string Quantidade, string Preco)
        {
            int IDPronto = Convert.ToInt32(id);
            int cQuantidade = Convert.ToInt32(Quantidade);
            decimal cPreco = Convert.ToDecimal(Preco);

            produto = new DAO.Produto();
            produto.Id = IDPronto;
            produto.Nome = Nome;
            produto.Descricao = Descricao;
            produto.Quantidade = cQuantidade;
            produto.Preco = cPreco;


            DAOProduto = new DAO.DAOProduto();
            DAOProduto.AtualizarProdutoDAO(produto);


        }

        public void ExcluirProdutoid(int Id)
        {
            produto = new DAO.Produto();
            produto.Id = Id;

            DAOProduto = new DAO.DAOProduto();
            DAOProduto.ExcluirProdutoDAO(produto);
        }

        public DataTable SelecionarProdutoInativo()
        {
            DAOProduto = new DAO.DAOProduto();
            return DAOProduto.MostrarProdutoInativo();
        }

    }
}*/
