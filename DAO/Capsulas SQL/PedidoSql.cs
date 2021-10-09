using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PedidoSql
    {
        public string id_pedido { get; set; }
        public int id_produto { get; set; }
        public int id_funcionario { get; set; }
        public int id_cliente { get; set; }
        public int valor_total { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
