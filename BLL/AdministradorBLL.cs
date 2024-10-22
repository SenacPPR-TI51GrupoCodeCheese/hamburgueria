using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class AdministradorBLL
    {
        AdministradorDAL dal = new AdministradorDAL();
        public void Inserir(AdministradorMOD objDados)
        {
            dal.Inserir(objDados);
        }
        public void Alterar(AdministradorMOD objDados)
        {
            dal.Alterar(objDados);
        }
        public void Excluir(int codigo)
        {
            dal.Excluir(codigo);
        }
        public List<AdministradorMOD> BuscaPorLogin(string login)
        {
            return dal.BuscaPorLogin(login);
        }
        public int Login(string login, string senha)
        {
            return dal.Login(login, senha);
        }
    }
}
