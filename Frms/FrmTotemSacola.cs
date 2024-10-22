using BLL;
using MOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frms
{
    public partial class FrmTotemSacola : Form
    {
        public List<ProdutoMOD> listaSacola = new List<ProdutoMOD>();

        public string cpfPedido = "";

        PedidoBLL bll = new PedidoBLL();

        public double totalPedido = 0.00;

        public void CarregarDgv()
        {
            listaSacola = listaSacola.OrderBy(produto => produto.Tipo).ToList();

            dgvSacola.DataSource = listaSacola;

            dgvSacola.RowHeadersVisible = false;
            dgvSacola.Columns["Id"].Visible = false;
            dgvSacola.Columns["Foto"].DisplayIndex = 0;
            dgvSacola.Columns["Foto"].Width = 100;
            dgvSacola.Columns["Nome"].Width = 512;
            dgvSacola.Columns["Preco"].DefaultCellStyle.Format = "R$0.00";
            dgvSacola.Columns["Preco"].HeaderText = "Preço";
            dgvSacola.Columns["Preco"].Width = 128;
            dgvSacola.Columns["Descricao"].HeaderText = "Descrição";
            dgvSacola.Columns["Descricao"].Width = 704;
            dgvSacola.Columns["Ingredientes"].Visible = false;
            dgvSacola.Columns["Tipo"].Visible = false;
            dgvSacola.RowTemplate.Height = 100;

            double total = 0.00;
            foreach (DataGridViewRow linha in dgvSacola.Rows)
            {
                double preco = Convert.ToDouble(linha.Cells["Preco"].Value);
                total += preco;
            }
            totalPedido = total;
            lblTotal.Text = String.Format("R$ {0:C}", Convert.ToString(totalPedido));

            if (dgvSacola.Rows.Count > 0)
            {
                btnRemover.Enabled = true;
            }
            else
            {
                btnRemover.Enabled = false;
            }
        }

        public FrmTotemSacola()
        {
            InitializeComponent();
        }

        private void FrmTotemSacola_Load_AND_VisibleChanged(object sender, EventArgs e)
        {
            CarregarDgv();
            radPix.Checked = true;
        }
        public char RetornarMetPag(PedidoMOD pedido)
        {
            if (radPix.Checked)
            {
                return 'P';
            }
            else
            {
                if (radDinheiro.Checked)
                {
                    return 'R';
                }
                else
                {
                    if (radCredito.Checked)
                    {
                        return 'C';
                    }
                    else
                    {
                        if (radDebito.Checked)
                        {
                            return 'D';
                        }
                    }
                }
            }
            return 'P';
        }

        private void pnlPix_Click(object sender, EventArgs e)
        {
            if (!radPix.Checked)
            {
                radPix.Checked = true;
            }
        }

        private void pnlDinheiro_Click(object sender, EventArgs e)
        {
            if (!radDinheiro.Checked)
            {
                radDinheiro.Checked = true;
            }
        }

        private void pnlCredito_Click(object sender, EventArgs e)
        {
            if (!radCredito.Checked)
            {
                radCredito.Checked = true;
            }
        }

        private void pnlDebito_Click(object sender, EventArgs e)
        {
            if (!radDebito.Checked)
            {
                radDebito.Checked = true;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja remover esse item?", "Sacola", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int index = dgvSacola.CurrentCell.RowIndex;
                listaSacola.Remove(listaSacola[index]);
                CarregarDgv();
            }
        }
    }
}
