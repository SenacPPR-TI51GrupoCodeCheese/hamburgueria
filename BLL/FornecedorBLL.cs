using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class FornecedorBLL
    {
        FornecedorDAL dal = new FornecedorDAL();
        public void Inserir(FornecedorMOD objDados)
        {
            dal.Inserir(objDados);
        }
        public void Alterar(FornecedorMOD objDados)
        {
            dal.Alterar(objDados);
        }
        public void Excluir(int codigo)
        {
            dal.Excluir(codigo);
        }
        public List<FornecedorMOD> BuscaPorNome(string nome)
        {
            return dal.BuscaPorNome(nome);
        }
    }
}
