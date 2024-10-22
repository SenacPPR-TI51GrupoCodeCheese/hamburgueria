using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItensPedidoBLL
    {
        ItensPedidoDAL dal = new ItensPedidoDAL();

        public void Inserir(ItensPedidoMOD objDados)
        {
            dal.Inserir(objDados);
        }
    }
}
