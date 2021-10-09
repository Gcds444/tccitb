using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class ProdutoSql
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }       
        public string Sabor { get; set; }
        public double Valor { get; set; }
        public double Custo { get; set; }
    }
}
