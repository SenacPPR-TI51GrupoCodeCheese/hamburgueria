using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class ProdutoMOD
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public byte[] Foto { get; set; }
        public char Tipo { get; set; }
    }
}
