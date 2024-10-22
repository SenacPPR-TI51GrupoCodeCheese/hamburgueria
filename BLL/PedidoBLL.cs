using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PedidoBLL
    {
        PedidoDAL dal = new PedidoDAL();

        public int Inserir(PedidoMOD objDados)
        {
            return dal.Inserir(objDados);
        }
        public void Alterar(PedidoMOD objDados)
        {
            dal.Alterar(objDados);
        }
        public void Excluir(int codigo)
        {
            dal.Excluir(codigo);
        }
        public List<PedidoMOD> BuscaPorStatus(char status)
        {
            return dal.BuscaPorStatus(status);
        }
    }
}