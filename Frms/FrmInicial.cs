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
    /// <summary>
    /// Formulário inicial.
    /// </summary>
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        // Abre o FrmAdm
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmLogin frmAdminLogin = new FrmAdmLogin();
            this.Visible = false;
            frmAdminLogin.ShowDialog();
            frmAdminLogin.Close();
            this.Visible = true;
        }

        // Abre o FrmTotem
        private void btnTotem_Click(object sender, EventArgs e)
        {
            FrmTotem frmTotem = new FrmTotem();
            this.Visible = false;
            frmTotem.ShowDialog();
            this.Visible = true;
        }
    }
}
