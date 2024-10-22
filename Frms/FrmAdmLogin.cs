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

namespace Frms
{
    public partial class FrmAdmLogin : Form
    {
        AdministradorBLL bll = new AdministradorBLL();
        FrmAdm frmCadastros = new FrmAdm();
        public FrmAdmLogin()
        {
            InitializeComponent();
        }
        private void FrmLoginAdmin_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "admin";
            txtsenha.Text = "admin";
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtsenha.Text;
            int codigo = bll.Login(login, senha);

            if (codigo != 0)
            {
                Visible = false;
                //txtLogin.Text = "";
                //txtsenha.Text = "";
                frmCadastros.ShowDialog();
                Visible = true;
            }
            else
            {
                MessageBox.Show("O administrador não está cadastrado. Verifique o login e a senha, e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
