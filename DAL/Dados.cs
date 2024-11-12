using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return "server=PPR0687565W10-1;" +
                       "database=dbhamburgueria;" +
                       "user=Aluno;" +
                       "pwd=Senac111";
            }
        }
    }
}
