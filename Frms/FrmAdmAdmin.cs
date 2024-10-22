using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOD;
using BLL;
using System.IO;
using System.Globalization;

namespace Frms
{
    public partial class FrmAdmAdmin : Form
    {
        private static List<AdministradorMOD> administradores = new List<AdministradorMOD>();

        AdministradorBLL bll = new AdministradorBLL();

        int codigoAdmin = 0;

        public FrmAdmAdmin()
        {
            InitializeComponent();
        }

        public void dgvBuscar_ObterDadosAdmin(string nome)
        {
            administradores = bll.BuscaPorLogin(nome);
            administradores = administradores.OrderBy(admin => admin.Login).ToList();
            dgvBuscar.DataSource = administradores;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = bll.BuscaPorLogin(txtBuscar.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdministradorMOD admin = new AdministradorMOD
            {
                NomeCompleto = txtNome.Text,
                Cpf = txtCPF.Text,
                Login = txtLogin.Text,
                Senha = txtSenha.Text,

            };

            bll.Inserir(admin);

            MessageBox.Show("Administrador gravado com sucesso!");

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AdministradorMOD admin = new AdministradorMOD
            {
                Id = Convert.ToInt32(txtId.Text),
                NomeCompleto = txtNome.Text,
                Cpf = txtCPF.Text,
                Login = txtLogin.Text,
                Senha = txtSenha.Text,

            };
            bll.Alterar(admin);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse Administrador?",
                         "Importante",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                codigoAdmin = Convert.ToInt32(txtId.Text);
                AdministradorBLL objExcluir = new AdministradorBLL();
                objExcluir.Excluir(codigoAdmin);


                MessageBox.Show("Administrador excluído com sucesso!");
            }
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvBuscar.CurrentRow.Cells["Id"].Value.ToString();
            txtCPF.Text = dgvBuscar.CurrentRow.Cells["Cpf"].Value.ToString();
            txtNome.Text = dgvBuscar.CurrentRow.Cells["NomeCompleto"].Value.ToString();
            txtLogin.Text = dgvBuscar.CurrentRow.Cells["Login"].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void FrmAdmAdmin_Load(object sender, EventArgs e)
        {
            dgvBuscar_ObterDadosAdmin("");

            dgvBuscar.Columns["Id"].Visible = true;

            dgvBuscar.Columns["NomeCompleto"].Width = 160;

            dgvBuscar.Columns["Cpf"].Width = 128;

            dgvBuscar.Columns["Login"].Width = 246;

            dgvBuscar.Columns["Senha"].Visible = false;

            dgvBuscar.RowTemplate.Height = 50;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }
    }
}
