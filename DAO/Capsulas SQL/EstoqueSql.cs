using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class EstoqueSql
    {
        
        public int id_estoque { get; set; }
        public int id_estoque_produto { get; set; }
        public int data_producao { get; set; }
        public int data_vencimento { get; set; }
        public int Quantidade { get; set; }
        public double custo { get; set; }
        public double custo2 { get; set; }
    
}
}