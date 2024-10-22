using BLL;
using MOD;
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
    public partial class FrmTotemAcomp : Form
    {
        public List<ProdutoMOD> produtos = new List<ProdutoMOD>();
        public ProdutoMOD produto = new ProdutoMOD();

        public ProdutoMOD RetornaProduto()
        {
            return produto;
        }

        FrmTotemProdutoInfo frmInfo = new FrmTotemProdutoInfo();

        ProdutoBLL bll = new ProdutoBLL();
        public FrmTotemAcomp()
        {
            InitializeComponent();
        }

        private void FrmTotemAcomp_Load(object sender, EventArgs e)
        {
            dgvAcomp.DataSource = bll.BuscarPorTipo("A");
            dgvAcomp.RowHeadersVisible = false;

            dgvAcomp.Columns["ID"].Visible = false;

            dgvAcomp.Columns["Foto"].DisplayIndex = 0;
            dgvAcomp.Columns["Foto"].Width = 100;

            dgvAcomp.Columns["Nome"].Width = 492;

            dgvAcomp.Columns["preco"].DefaultCellStyle.Format = "R$0.00";
            dgvAcomp.Columns["Preco"].HeaderText = "Preço";
            dgvAcomp.Columns["Preco"].Width = 148;

            dgvAcomp.Columns["Descricao"].HeaderText = "Descrição";
            dgvAcomp.Columns["Descricao"].Width = 704;

            dgvAcomp.Columns["Ingredientes"].Visible = false;

            dgvAcomp.Columns["Tipo"].Visible = false;

            dgvAcomp.RowTemplate.Height = 100;
        }

        private void dgvAcomp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInfo.CarregaInfo(new ProdutoMOD
            {
                Id = (int)dgvAcomp.CurrentRow.Cells["Id"].Value,
                Foto = (byte[])dgvAcomp.CurrentRow.Cells["Foto"].Value,
                Nome = (string)dgvAcomp.CurrentRow.Cells["Nome"].Value,
                Preco = (double)dgvAcomp.CurrentRow.Cells["Preco"].Value,
                Descricao = (string)dgvAcomp.CurrentRow.Cells["Descricao"].Value,
                Ingredientes = (string)dgvAcomp.CurrentRow.Cells["Ingredientes"].Value,
                Tipo = (char)dgvAcomp.CurrentRow.Cells["Tipo"].Value
            });
            frmInfo.ShowDialog();
        }

        private void dgvAcomp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            produto = new ProdutoMOD
            {
                Id = (int)dgvAcomp.CurrentRow.Cells["Id"].Value,
                Foto = (byte[])dgvAcomp.CurrentRow.Cells["Foto"].Value,
                Nome = (string)dgvAcomp.CurrentRow.Cells["Nome"].Value,
                Preco = (double)dgvAcomp.CurrentRow.Cells["Preco"].Value,
                Descricao = (string)dgvAcomp.CurrentRow.Cells["Descricao"].Value,
                Ingredientes = (string)dgvAcomp.CurrentRow.Cells["Ingredientes"].Value,
                Tipo = (char)dgvAcomp.CurrentRow.Cells["Tipo"].Value
            };
        }
    }
}
