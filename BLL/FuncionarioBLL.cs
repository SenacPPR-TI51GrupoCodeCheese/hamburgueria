using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FuncionarioBLL
    {
        FuncionarioDAL dal = new FuncionarioDAL();
        public void Inserir(FuncionarioMOD objDados)
        {
            dal.Inserir(objDados);
        }
        public void Alterar(FuncionarioMOD objDados)
        {
            dal.Alterar(objDados);
        }
        public void Excluir(int codigo)
        {
            dal.Excluir(codigo);
        }
        public List<FuncionarioMOD> BuscaPorNome(string nome)
        {
            return dal.BuscaPorNome(nome);
        }
    }
}
