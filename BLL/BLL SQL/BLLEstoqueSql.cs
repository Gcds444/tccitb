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
    public class BLLEstoqueSql
    {
        DAO.EstoqueSql estoque;
        DAO.DAOEstoqueSql DAOEstoque;
      

        public void Inserir( int id, string Quantidade, double custo, double custo2)
        {
            
            int id_estoque_produtofinal = id;         
            int Quantidade_final = Convert.ToInt32(Quantidade);
            estoque = new DAO.EstoqueSql();
            estoque.Quantidade = Quantidade_final;
            estoque.id_estoque_produto = id_estoque_produtofinal;
            estoque.custo = custo;
            estoque.custo2 = custo2;

            DAOEstoque = new DAO.DAOEstoqueSql();
            DAOEstoque.inserirEstoque(estoque);
        }

        public DataTable SelecionarIdProdutoEstoque(string IdProduto)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarID(IdProduto);
        }
        public DataTable SelecionarIDEstoque(string validade, int idproduto)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarIDEstoque(validade, idproduto);
        }
        public DataTable SelecionarQuantidade(string id)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarQuantidade(id);
        }
       public DataTable TabelaProduto(int ID)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarProdutoTabela(ID);
        }
        public DataTable SelecionarEstoque()
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarEstoque();

        
        }
        public DataTable SelecionarEsgotado()
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarEsgotado();

        }
        public DataTable SelecionarVencimento()
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarVencimento();

        }
        public DataTable SelecionarInativo()
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.BuscarInativo();

        }
        public DataTable SelecionarQuantidadeProduto(string Quantidade)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
             return DAOEstoque.SelecionarSomaQuantidade(Quantidade);
        }
        public DataTable MostrarQuantidadeVencimento(string data)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.SelecionarQuantidadeValidade(data);
        }
        public DataTable VencimentoAutomatico()
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.VencimentoAutomatico();
        }
        public DataTable EsgotamentoAutomatico()
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.EsgotamentoAutomatico();
        }
        public DataTable AtualizarQuantidade(decimal Quantidade, string Id)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.AtualizarQuantidade(Quantidade, Id);
        }
        public DataTable Atualizar(int idproduto, int quantidade, double custototal, string id)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.Atualizar(idproduto, quantidade, custototal, id);
        }
        public DataTable Inativar(string ID)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.Inativar(ID);
        }
        public DataTable Pendente(int ID)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.Pendente(ID);
        }

        public DataTable Ativar(string ID)
        {
            DAOEstoque = new DAO.DAOEstoqueSql();
            return DAOEstoque.Ativar(ID);
        }
    }
}
