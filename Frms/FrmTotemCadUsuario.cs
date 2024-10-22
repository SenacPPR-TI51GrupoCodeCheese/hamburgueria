using MOD;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Frms
{
    public partial class FrmTotemCadUsuario : Form
    {
        UsuarioBLL bll = new UsuarioBLL();
        public FrmTotemCadUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string sexo = cmbSexo.Text;
            switch (sexo)
            {
                case "":
                    sexo = "N";
                    break;
                case "Masculino":
                    sexo = "M";
                    break;
                case "Feminino":
                    sexo = "F";
                    break;
                case "Outro":
                    sexo = "O";
                    break;
            }

            UsuarioMOD usuario = new UsuarioMOD
            {
                NomeCompleto = txtNome.Text,
                NomeUsuario = txtNomeUsuario.Text,
                Email = txtEmail.Text,
                Cpf = txtCpf.Text,
                Telefone = txtTelefone.Text,
                Nascimento = dtpNascimento.Value,
                Genero = Convert.ToChar(sexo),
                Endereco = txtEndereco.Text,
                Senha = txtSenha.Text,
                Convidado = false
            };

            bll.Inserir(usuario);

            MessageBox.Show("Usuário cadastrado com sucesso!");
            Close();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            if (CpfValido(cpf) != true)
            {
                lblCpfInvalido.Visible = true;
                btnConfirmar.Enabled = false;
            }
            else
            {
                lblCpfInvalido.Visible = false;
                btnConfirmar.Enabled = true;
            }
        }
        public static bool CpfValido(string cpf)    // Função que verifica o CPF
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
