using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace BLL
{
   public class BLLCepSql
    {
       public OracleDataReader RetornarCEPPorFavor(string CEP)
        {
            DAO.DAOCepSql FuncionaAmem = new DAO.DAOCepSql();

            CEP = Convert.ToString(CEP);
            return FuncionaAmem.RetornarCEP(CEP);


        }

    }
}
