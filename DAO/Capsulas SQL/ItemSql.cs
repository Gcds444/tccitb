using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ItemSql
    {
        public string id { get; set; }
        public int Id_pedido { get; set; }
        public int Id_produto { get; set; }
        public string Total { get; set; }
        public decimal quantiade { get; set; }
        public string id_estoque { get; set; }
    }
}
