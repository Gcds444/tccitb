using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;


namespace DAO
{
    public class DAOLucroSql
    {
        ClasseConexaoDAO conexao = new ClasseConexaoDAO();

        private OracleCommand statement;
        private DataSet rs;
        private static string SQL;



        public DataTable buscarLucro(DateTime comeco, DateTime fim)
        {
            try
            {
                var comecoo = Convert.ToString(comeco.ToShortDateString());
                var fimm = Convert.ToString(fim.ToShortDateString());

                DataTable dt = new DataTable();
                SQL = "select nvl(SUM(VALOR_TOTAL), 0) from ADMUSER.PEDIDO where DATA_HORA_PEDIDO between to_date('" +comecoo +"', 'dd/mm/yyyy') and to_date('"+ fimm +"', 'dd/mm/yyyy')  and STATUS = 'Vendido'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    

        public OracleDataReader buscarLucroTabela()
        {
            ClasseConexaoDAO conexao = new ClasseConexaoDAO();
            OracleDataReader dr;
            string SQL = "SELECT * FROM ADMUSER.LUCRO";
            dr = conexao.RetornarDataReader(SQL);
            return dr;
        }

        public string inserirLucro(double lucro)
        {
            try
            {
                string info = "";
                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "INSERT INTO ADMUSER.LUCRO VALUES('" + lucro + "',sysdate)";

                conexao.ExecutarComando(SQL);
                info = "Inserido com sucesso!";
                return info;
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
        }

        public DataTable BuscarCustoEstoque(DateTime comeco, DateTime fim)
        {
            try
            {
                var comecoo = Convert.ToString(comeco.ToShortDateString());
                var fimm = Convert.ToString(fim.ToShortDateString());

                DataTable dt = new DataTable();
                SQL = "select nvl(SUM(custo2), 0) from ADMUSER.ESTOQUE where DATA_PRODUCAO between to_date('" + comecoo + "', 'dd/mm/yyyy') and to_date('" + fimm + "', 'dd/mm/yyyy')  and  not STATUS = 'Inativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable FuncionarioSalario()
        {


            try
            {


                DataTable dt = new DataTable();
                SQL = "select sum(SALARIO) FROM ADMUSER.FUNCIONARIO WHERE SITUACAO_FUNCIONARIO = 'Ativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
                  public DataTable EstoqueCusto()
        {


            try
            {


                DataTable dt = new DataTable();
                SQL = "select sum(CUSTO_TOTAL) FROM ADMUSER.ESTOQUE WHERE to_char(DATA_PRODUCAO, 'mm') = ( select to_char(sysdate,'mm')from dual) and not STATUS = 'Inativo'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
