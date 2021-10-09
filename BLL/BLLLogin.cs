using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
  public class BLLLogin
  {
      DAO.Login Login;
      DAO.DAOLogin DAOLogin;

      public void Incluir(string Nome, string Senha)
      {
          Login = new DAO.Login();
          Login.Nome = Nome;
          Login.Senha = Senha;
          
          DAOLogin = new DAO.DAOLogin();
          DAOLogin.Inserir(Login);
      }

      public DataTable SelecionarLogin(string CPF)
      {
          DAOLogin = new DAO.DAOLogin();
          return DAOLogin.buscarClienteCPF(CPF);
      }
  }
}