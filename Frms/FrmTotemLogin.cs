using BLL;
using MOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frms
{
    public partial class FrmTotemLogin : Form
    {
        private static UsuarioBLL bll = new UsuarioBLL();

        private static string cpfLogin = ""; // 

        public FrmTotemLogin()
        {
            InitializeComponent();
        }

        public string RetornaCpf()
        {
            return cpfLogin;
        }
        private void Btnentrar_Click(object sender, EventArgs e)
        {
            cpfLogin = txtcpf.Text;
            int codigo = bll.LoginTotem(cpfLogin);

            if (codigo != 0)
            {
                Visible = false;
            }
            else
            {
                MessageBox.Show("O CPF informado não está cadastrado. Verifique o CPF e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnconvidado_Click(object sender, EventArgs e)
        {
            try
            {
                bll.Inserir(new UsuarioMOD
                {
                    NomeCompleto = "",
                    NomeUsuario = "Convidado",
                    Email = "",
                    Cpf = "",
                    Telefone = "",
                    Nascimento = DateTime.Now,
                    Genero = 'N',
                    Endereco = "",
                    Senha = "",
                    Convidado = true
                });
                Close();
            }
            catch 
            {
                MessageBox.Show("Erro no sistema: não podem existir dois convidados de um mesmo totem!", "Desculpe!", MessageBoxButtons.OK);
            }
        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {
            cpfLogin = txtcpf.Text;
            if (CpfValido(ref cpfLogin) != true)
            {
                btnentrar.Enabled = false;
            }
            else
            {
                btnentrar.Enabled = true;
            }
        }
        public static bool CpfValido(ref string cpf)    // Função que verifica o CPF
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

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmLoginTotem_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            FrmTotemCadUsuario frmNovoUsr = new FrmTotemCadUsuario();
            this.Visible = false;
            frmNovoUsr.ShowDialog();
            frmNovoUsr.Close();
            this.Visible = true;
        }
    }
}
