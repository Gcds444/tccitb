using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace BLL
{
    public class BLLLucroSql
    {
        DAO.DAOLucroSql DAOLucro;

        
        public void InserirLucro(double lucro)
        {
            
            DAOLucro = new DAO.DAOLucroSql();
            DAOLucro.inserirLucro(lucro);
        }


        public DataTable EstoqueCusto(DateTime comeco, DateTime fim)
        {
            DAOLucro = new DAO.DAOLucroSql();
            return DAOLucro.BuscarCustoEstoque(comeco,fim);
        }

        public DataTable LucroVenda(DateTime comeco, DateTime fim)
        {
            DAOLucro = new DAO.DAOLucroSql();
            return DAOLucro.buscarLucro(comeco,fim);
        }

        public DataTable FuncionarioSalario()
        {
            DAOLucro = new DAO.DAOLucroSql();
            return DAOLucro.FuncionarioSalario();
        }
    }
}
