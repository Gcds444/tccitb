using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VendaSql
    {

        public int Id { get; set; }
        public int Id_Pedido{ get; set; }
        public string Forma { get; set; }
        public string Bandeira { get; set; }
        public int Parcela { get; set; }
        public double Valor { get; set; }
    }
}
