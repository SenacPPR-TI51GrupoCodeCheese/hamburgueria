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

namespace Frms
{
    public partial class FrmLanches : Form
    {
        private static ProdutoMOD produtoLanche = new ProdutoMOD();

        public ProdutoMOD RetornaProduto()
        {
            return produtoLanche;
        }

        FrmTotemProdutoInfo frmInfo = new FrmTotemProdutoInfo();

        ProdutoBLL bll = new ProdutoBLL();
        public FrmLanches()
        {
            InitializeComponent();
        }

        private void FrmLanches_Load(object sender, EventArgs e)
        {
            dgvLanches.DataSource = bll.BuscarPorTipo("L");
            dgvLanches.RowHeadersVisible = false;
            dgvLanches.Columns["ID"].Visible = false;
            dgvLanches.Columns["Foto"].DisplayIndex = 0;
            dgvLanches.Columns["Foto"].Width = 100;
            dgvLanches.Columns["Nome"].Width = 492;
            dgvLanches.Columns["preco"].DefaultCellStyle.Format = "R$0.00";
            dgvLanches.Columns["Preco"].HeaderText = "Preço";
            dgvLanches.Columns["Preco"].Width = 148;
            dgvLanches.Columns["Ingredientes"].Width = 704;
            dgvLanches.Columns["Descricao"].Visible = false;
            dgvLanches.Columns["Tipo"].Visible = false;
            dgvLanches.RowTemplate.Height = 100;
        }

        private void dgvLanches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInfo.CarregaInfo(new ProdutoMOD
            {
                Id = (int)dgvLanches.CurrentRow.Cells["Id"].Value,
                Foto = (byte[])dgvLanches.CurrentRow.Cells["Foto"].Value,
                Nome = (string)dgvLanches.CurrentRow.Cells["Nome"].Value,
                Preco = (double)dgvLanches.CurrentRow.Cells["Preco"].Value,
                Descricao = (string)dgvLanches.CurrentRow.Cells["Descricao"].Value,
                Ingredientes = (string)dgvLanches.CurrentRow.Cells["Ingredientes"].Value,
                Tipo = (char)dgvLanches.CurrentRow.Cells["Tipo"].Value
            });

            frmInfo.ShowDialog();
        }

        private void dgvLanches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            produtoLanche = new ProdutoMOD
            {
                Id = (int)dgvLanches.CurrentRow.Cells["Id"].Value,
                Foto = (byte[])dgvLanches.CurrentRow.Cells["Foto"].Value,
                Nome = (string)dgvLanches.CurrentRow.Cells["Nome"].Value,
                Preco = (double)dgvLanches.CurrentRow.Cells["Preco"].Value,
                Descricao = (string)dgvLanches.CurrentRow.Cells["Descricao"].Value,
                Ingredientes = (string)dgvLanches.CurrentRow.Cells["Ingredientes"].Value,
                Tipo = (char)dgvLanches.CurrentRow.Cells["Tipo"].Value
            };
        }
    }
}
