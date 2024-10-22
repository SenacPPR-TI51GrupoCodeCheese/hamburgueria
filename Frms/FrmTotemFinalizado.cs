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
    public partial class FrmTotemFinalizado : Form
    {
        public int senha = 0;
        private static int segundos = 10;

        public FrmTotemFinalizado()
        {
            InitializeComponent();
        }

        private void FrmTotemFinalizado_Leave(object sender, EventArgs e)
        {
            Close();
        }

        private void timerSair_Tick(object sender, EventArgs e)
        {
            if (segundos > 0)
            {
                lblTimer.Text = segundos.ToString();
                segundos--;
            }
            else
            {
                Close();
            }
        }

        private void FrmTotemFinalizado_Load(object sender, EventArgs e)
        {
            lblSenha.Text = senha.ToString();
        }
    }
}
