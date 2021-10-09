using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAO
{

  public class DAOLogin
    {
        private OleDbCommand cmd;
        private Conexao cn;
        private OleDbDataAdapter da;

       public void Inserir(Login login)
        {
            cn = new Conexao();
            cmd = new OleDbCommand
            ("Insert into Produto(Login_Nome,Login_Senha) values ('" + login.Nome + "','"  + login.Senha + "')", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }

        public DataTable buscarProdutoid(int id)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Login where Nome =" + Nome + "'senha= +"'", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
    }
}
