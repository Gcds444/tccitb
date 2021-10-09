/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace DAO
{
    public class DAOFuncionario
    {
        private OleDbCommand cmd;
        private Conexao cn;
        private OleDbDataAdapter da;

        //passar referencia da classe

        public void Inserir(Funcionario funcionario)
        {
            cn = new Conexao();
            cmd = new OleDbCommand
            ("Insert into Funcionario(Funcionario_Nome,Funcionario_DataNasc,Funcionario_RG,Funcionario_CPF,Funcionario_Email,Funcionario_TResidencial,Funcionario_TMovel,Funcionario_CEP,Funcionario_Senha,Funcionario_Usuario) values ('"
            + funcionario.Nome + "','" + funcionario.DataNasc + "','" + funcionario.RG + "','" + funcionario.CPF + "','" + funcionario.Email + "','" + funcionario.TResidencial + "','" + funcionario.TMovel + "','" + funcionario.CEP + "','" + funcionario.Senha + "','" + funcionario.Usuario + "')", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }

        public DataTable buscarFuncionarioCPF(string CPF)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Funcionario where Funcionario_CPF ='" + CPF + "'", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public DataTable buscarFuncionarioCadastro(string Usuario, string Senha)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Funcionario where Funcionario_Usuario ='" + Usuario + "' and Funcionario_Senha ='" + Senha + "'", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public DataTable MostrarFuncionarioCPF()
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Funcionario ", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

        public void AtualizarFuncionarioDAO(Funcionario funcionario)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("update Funcionario set Funcionario_Nome='" + funcionario.Nome + "',Funcionario_DataNasc='" + funcionario.DataNasc + "',Funcionario_RG='" + funcionario.RG + "',Funcionario_Email='" + funcionario.Email + "',Funcionario_TResidencial='" + funcionario.TResidencial + "',Funcionario_TMovel='" + funcionario.TMovel + "',Funcionario_CEP='" + funcionario.CEP + "',Funcionario_Senha='" + funcionario.Senha + "',Funcionario_Usuario='" + funcionario.Usuario + "'where Funcionario_CPF='" + funcionario.CPF + "'", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();

        }

        public void ExcluirFuncionarioDAO(Funcionario funcionario)
        {
            cn = new Conexao();
            cmd = new OleDbCommand("update Funcionario set Funcionario_Ativo=0 where Funcionario_CPF='" + funcionario.CPF + "'", cn.Conectar());
            cmd.ExecuteNonQuery();
            cn.Desconectar();
        }

        public DataTable MostrarFuncionarioInativo()
        {
            cn = new Conexao();
            cmd = new OleDbCommand("select * from Funcionario where Funcionario_Ativo=0", cn.Conectar());
            cmd.ExecuteNonQuery();

            da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cn.Desconectar();
            return dt;
        }

    }
}*/
