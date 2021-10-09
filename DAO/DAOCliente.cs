using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class DAOCliente
    {
        private OleDbCommand cmd;
        private Conexao cn;
        private OleDbDataAdapter da;
        
        //passar referencia da classe

        public void Inserir(Cliente cliente) 
        {
            cn = new Conexao();
            cmd = new OleDbCommand("Insert into Cliente(Cliente_Empresa,Cliente_Nome,Cliente_Email,Cliente_Tel,Cliente_CPF) values ('" + cliente.Empresa + "','" + cliente.Nome + "','" + cliente.Email + "','" + cliente.Tel + "','" + cliente.CPF + "')", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }

        public DataTable buscarClienteCPF(string CPF) 
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Cliente where Cliente_CPF ='" + CPF + "'", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public DataTable MostrarClienteCPF()
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Cliente where Cliente_Ativo=1", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public void AtualizarClienteDAO(Cliente cliente) 
        {
            cn = new Conexao();
            cmd = new OleDbCommand("update Cliente set Cliente_Empresa='" + cliente.Empresa + "',Cliente_Nome='" + cliente.Nome + "',Cliente_Email='" + cliente.Email + "',Cliente_Tel='" + cliente.Tel + "'where Cliente_CPF='"+ cliente.CPF +"'", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }

        public void ExcluirClienteDAO(Cliente cliente)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("update Cliente set Cliente_Ativo=0 where Cliente_CPF='" + cliente.CPF + "'", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();

        }
        public DataTable MostrarClienteInativo()
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Cliente where Cliente_Ativo=0", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }
    }
}
