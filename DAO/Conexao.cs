using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

using System.Windows.Forms;

namespace DAO
{
   public class Conexao
    {
       public static OleDbConnection cn;
       private static string banco = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\TCC REAL OFICIAL\Sistema_FM\Banco\Banco.mdb; Persist Security Info=False;";
        
       public OleDbConnection Conectar()
        {
            try
            {

                cn = new OleDbConnection(banco);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
            
                }
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
       }

       public OleDbConnection Desconectar()
        {
            try
            {

                
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    
                }
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        }
    }


