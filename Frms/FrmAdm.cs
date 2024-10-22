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
    public partial class FrmAdm : Form
    {
        private static FrmAdmProd frmCadastroProd = new FrmAdmProd();
        private static FrmAdmFunc frmCadastroFunc = new FrmAdmFunc();
        private static FrmAdmAdmin frmCadastroAdmin = new FrmAdmAdmin();
        private static FrmAdmPedidos frmAdmPedidos = new FrmAdmPedidos();

        public FrmAdm()
        {
            InitializeComponent();

            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            frmCadastroAdmin.MdiParent = this;
            frmCadastroFunc.MdiParent = this;
            frmCadastroProd.MdiParent = this;
            frmAdmPedidos.MdiParent = this;

            frmCadastroAdmin.Size = new Size(this.Width - panel1.Size.Width - 4, this.Height + 36);
            frmCadastroFunc.Size = new Size(this.Width - panel1.Size.Width - 4, this.Height + 36);
            frmCadastroProd.Size = new Size(this.Width - panel1.Size.Width - 4, this.Height + 36);
        }
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            btnprodutos_Click(sender, e);

        }

        private void btnprodutos_Click(object sender, EventArgs e)
        {
            btnprodutos.FlatAppearance.BorderSize = 5;
            btnfuncionarios.FlatAppearance.BorderSize = 0;
            btnadmin.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.BorderSize = 0;

            btnprodutos.Enabled = false;

            //btnfuncionarios.Enabled = true;

            btnadmin.Enabled = true;

            frmCadastroProd.Show();
            frmCadastroFunc.Visible = false;
            frmCadastroAdmin.Visible = false;
            frmAdmPedidos.Visible = false;
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            btnprodutos.FlatAppearance.BorderSize = 0;
            btnfuncionarios.FlatAppearance.BorderSize = 5;
            btnadmin.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.BorderSize = 0;

            btnprodutos.Enabled = true;
            btnfuncionarios.Enabled = false;
            btnadmin.Enabled = true;

            frmCadastroFunc.Show();
            frmCadastroProd.Visible = false;
            frmCadastroProd.Visible = false;
            frmAdmPedidos.Visible = false;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            btnprodutos.FlatAppearance.BorderSize = 0;
            btnfuncionarios.FlatAppearance.BorderSize = 0;
            btnadmin.FlatAppearance.BorderSize = 5;
            btnPedidos.FlatAppearance.BorderSize = 0;

            btnprodutos.Enabled = true;

            //btnfuncionarios.Enabled = true;

            btnadmin.Enabled = false;

            frmCadastroAdmin.Show();
            frmCadastroFunc.Visible = false;
            frmCadastroProd.Visible = false;
            frmAdmPedidos.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            frmCadastroAdmin.Close();
            frmCadastroFunc.Close();
            frmCadastroProd.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            btnprodutos.FlatAppearance.BorderSize = 0;
            btnfuncionarios.FlatAppearance.BorderSize = 0;
            btnadmin.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.BorderSize = 5;
            btnprodutos.Enabled = true;

            //btnfuncionarios.Enabled = true;

            btnPedidos.Enabled = false;


            frmAdmPedidos.Show();
            frmCadastroAdmin.Visible = false;
            frmCadastroFunc.Visible = false;
            frmCadastroProd.Visible = false;
        }
    }
}
