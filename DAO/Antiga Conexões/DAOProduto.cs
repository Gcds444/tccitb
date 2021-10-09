/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class DAOProduto
    {
        private OleDbCommand cmd;
        private Conexao cn;
        private OleDbDataAdapter da;

        //passar referencia da classe

        public void Inserir(Produto produto)
        {
            cn = new Conexao();
            cmd = new OleDbCommand
            ("Insert into Produto(Produto_Nome,Produto_Descricao,Produto_Preco,Produto_Quantidade) values ('" + produto.Nome + "','" + produto.Descricao + "','" + produto.Preco + "','" + produto.Quantidade + "')", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }
        public DataTable buscarProdutoid(int id)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Produto where Id=" + id , cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public DataTable MostrarProdutoid()
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Produto ", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public void AtualizarProdutoDAO(Produto produto)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("update Produto set Produto_Nome='" + produto.Nome + "',Produto_Descricao='" + produto.Descricao + "',Produto_Quantidade='" + produto.Quantidade + "',Produto_Preco='" + produto.Preco + "' where Id=" + produto.Id, cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();

        }

        public void ExcluirProdutoDAO(Produto produto)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("update Produto set Produto_Ativo=0 where Id=" + produto.Id, cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }

        public DataTable MostrarProdutoInativo()
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Produto where Produto_Ativo=0", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

    }
}*/