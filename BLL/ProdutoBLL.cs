using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {
        ProdutoDAL dal = new ProdutoDAL();

        public void Inserir(ProdutoMOD objDados)
        {
            dal.Inserir(objDados);
        }
        public byte[] CarregaFoto(int Codigo)
        {
            ProdutoDAL objAlterar = new ProdutoDAL();
            return (objAlterar.CarregaFoto(Codigo));
        }


        public void Alterar(ProdutoMOD objDados)
        {
            dal.Alterar(objDados);
        }

        public void Excluir(int id)
        {
            ProdutoDAL objExcluir = new ProdutoDAL();
            objExcluir.Excluir(id);
        }

        public List<ProdutoMOD> BuscarPorNome(string nome)
        {
            return dal.BuscarPorNome(nome);
        }
        public List<ProdutoMOD> BuscarPorTipo(string tipo)
        {
            return dal.BuscarPorTipo(tipo);
        }
    }
}
