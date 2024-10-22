using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItensSacolaBLL
    {
        ItensSacolaDAL dal = new ItensSacolaDAL();
        public void Inserir(ItensSacolaMOD objDados)
        {
            dal.Inserir(objDados);
        }
        public List<ItensSacolaMOD> BuscaPorIdSacola(string id)
        {
            return dal.BuscarPorIdSacola(id);
        }
        public void Excluir(int codigo)
        {
            dal.Excluir(codigo);
        }
        public List<ItensSacolaMOD> BuscaPorId(string id)
        {
            return dal.BuscarPorId(id);
        }
    }

}



