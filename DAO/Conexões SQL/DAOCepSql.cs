using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAO
{
    public class DAOCepSql
    {

        private static string SQL;


        public OracleDataReader RetornarCEP(string CEP)
        {
            try
            {

                ClasseConexaoDAO conexao = new ClasseConexaoDAO();
                SQL = "SELECT * FROM ADMUSER.CEP WHERE CEP ='" + CEP + "' ";
                return conexao.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
