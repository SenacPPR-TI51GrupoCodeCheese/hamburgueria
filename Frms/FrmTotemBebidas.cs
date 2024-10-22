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
    public partial class FrmTotemBebidas : Form
    {
        public List<ProdutoMOD> produtos = new List<ProdutoMOD>();
        public ProdutoMOD produto = new ProdutoMOD();

        public ProdutoMOD RetornaProduto()
        {
            return produto;
        }

        FrmTotemProdutoInfo frmInfo = new FrmTotemProdutoInfo();

        ProdutoBLL bll = new ProdutoBLL();

        public FrmTotemBebidas()
        {
            InitializeComponent();
        }

        private void FrmTotemBebidas_Load(object sender, EventArgs e)
        {
            dgvBebidas.DataSource = bll.BuscarPorTipo("B");
            dgvBebidas.RowHeadersVisible = false;

            dgvBebidas.Columns["ID"].Visible = false;

            dgvBebidas.Columns["Foto"].DisplayIndex = 0;
            dgvBebidas.Columns["Foto"].Width = 100;

            dgvBebidas.Columns["Nome"].Width = 492;

            dgvBebidas.Columns["preco"].DefaultCellStyle.Format = "R$0.00";
            dgvBebidas.Columns["Preco"].HeaderText = "Preço";
            dgvBebidas.Columns["Preco"].Width = 148;

            dgvBebidas.Columns["Descricao"].HeaderText = "Descrição";
            dgvBebidas.Columns["Descricao"].Width = 704;

            dgvBebidas.Columns["Ingredientes"].Visible = false;

            dgvBebidas.Columns["Tipo"].Visible = false;

            dgvBebidas.RowTemplate.Height = 100;
        }

        private void dgvBebidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInfo.CarregaInfo(new ProdutoMOD
            {
                Id = (int)dgvBebidas.CurrentRow.Cells["Id"].Value,
                Foto = (byte[])dgvBebidas.CurrentRow.Cells["Foto"].Value,
                Nome = (string)dgvBebidas.CurrentRow.Cells["Nome"].Value,
                Preco = (double)dgvBebidas.CurrentRow.Cells["Preco"].Value,
                Descricao = (string)dgvBebidas.CurrentRow.Cells["Descricao"].Value,
                Ingredientes = (string)dgvBebidas.CurrentRow.Cells["Ingredientes"].Value,
                Tipo = (char)dgvBebidas.CurrentRow.Cells["Tipo"].Value
            });
            frmInfo.ShowDialog();
        }

        private void dgvBebidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            produto = new ProdutoMOD
            {
                Id = (int)dgvBebidas.CurrentRow.Cells["Id"].Value,
                Foto = (byte[])dgvBebidas.CurrentRow.Cells["Foto"].Value,
                Nome = (string)dgvBebidas.CurrentRow.Cells["Nome"].Value,
                Preco = (double)dgvBebidas.CurrentRow.Cells["Preco"].Value,
                Descricao = (string)dgvBebidas.CurrentRow.Cells["Descricao"].Value,
                Ingredientes = (string)dgvBebidas.CurrentRow.Cells["Ingredientes"].Value,
                Tipo = (char)dgvBebidas.CurrentRow.Cells["Tipo"].Value
            };
        }
    }
}
