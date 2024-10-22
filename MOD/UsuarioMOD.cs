using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class UsuarioMOD
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public char Genero { get; set; }
        public string Endereco { get; set; }
        public int Pontos { get; set; }
        public string Senha { get; set; }
        public bool Convidado { get; set; }
    }
}
