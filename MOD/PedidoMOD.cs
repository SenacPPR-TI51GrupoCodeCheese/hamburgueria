using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class PedidoMOD
    {
        public int Id { get; set; }
        public string CpfUsuario { get; set; }
        public char MetPag { get; set; }
        public char Status { get; set; }
        public double Total { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
