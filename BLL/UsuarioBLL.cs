using DAL;
using MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class UsuarioBLL
	{
        UsuarioDAL dal = new UsuarioDAL();

        public void Inserir(UsuarioMOD objDados)
        {
            dal.Inserir(objDados);
        }

        public void Alterar(UsuarioMOD objDados)
		{
			dal.Alterar(objDados);
		}
        
		public void ExcluirPorId(int codigo)
		{
			dal.ExcluirPorId(codigo);
		}

        public void ExcluirConvidado()
        {
            dal.ExcluirConvidado();
        }

        public List<UsuarioMOD> BuscaPorNome(string nome)
		{
			return dal.BuscaPorNome(nome);
		}
        
		public int Login(string nomeUsuario, string senha)
		{
			return dal.Login(nomeUsuario, senha);
		}
		
		public int LoginTotem(string cpf)
		{
			return dal.LoginTotem(cpf);
		}
    }
}
