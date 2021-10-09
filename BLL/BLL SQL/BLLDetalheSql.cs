using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
   public class BLLDetalheSql
    {
        DAO.DAODetalheSql detalhe;

        public void InserirDetalhe(string id_pedido, string cep, string bairro, string cidade, string uf, string numero, string complemento, string logradouro)
        {
            detalhe = new DAO.DAODetalheSql();
            detalhe.inserirDetalhe(id_pedido, cep, bairro, cidade, uf, numero, complemento, logradouro);
        }
        public DataTable BuscarEndereco(string id)
        {
            detalhe = new DAO.DAODetalheSql();
            return detalhe.BuscarEndereco(id);

        }
        public void Atualizar(string id_pedido, string cep, string bairro, string cidade, string uf, string numero, string complemento, string logradouro)
        {
            detalhe = new DAO.DAODetalheSql();
            detalhe.Atualizar(id_pedido, cep, bairro, cidade, uf, numero, complemento, logradouro);
        }
    }
}
