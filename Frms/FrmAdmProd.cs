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
    public partial class FrmAdmProd : Form
    {
        ProdutoBLL bll = new ProdutoBLL();

        int codigoproduto = 0;

        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens = null;
        public FrmAdmProd()
        {
            InitializeComponent();
        }

        public void dgvBuscar_ObterDadosProd(string nome)
        {
            List<ProdutoMOD> produtos = bll.BuscarPorNome(nome);
            produtos = produtos.OrderBy(produto => produto.Tipo).ToList();
            dgvBuscar.DataSource = produtos;
        }
        public void ObterDadosCell()
        {
            txtId.Text = dgvBuscar.CurrentRow.Cells["Id"].Value.ToString();
            txtNome.Text = dgvBuscar.CurrentRow.Cells["Nome"].Value.ToString();
            txtPreco.Text = dgvBuscar.CurrentRow.Cells["Preco"].Value.ToString();
            txtDescricao.Text = dgvBuscar.CurrentRow.Cells["Descricao"].Value.ToString();
            txtIngredientes.Text = dgvBuscar.CurrentRow.Cells["Ingredientes"].Value.ToString();

            if ((char)dgvBuscar.CurrentRow.Cells["Tipo"].Value == 'L')
            {
                rdoLanche.Checked = true;
                rdoBebida.Checked = false;
                rdoAcomp.Checked = false;
            }
            else
            {
                if ((char)dgvBuscar.CurrentRow.Cells["Tipo"].Value == 'B')
                {
                    rdoLanche.Checked = false;
                    rdoBebida.Checked = true;
                    rdoAcomp.Checked = false;
                }
                else
                {
                    rdoLanche.Checked = false;
                    rdoBebida.Checked = false;
                    rdoAcomp.Checked = true;
                }
            }

            if (dgvBuscar.CurrentRow.Cells["Foto"].Value != null)
            {
                byte[] data = (byte[])dgvBuscar.CurrentRow.Cells["Foto"].Value;
                MemoryStream ms = new MemoryStream(data);
                picFoto.Image = Image.FromStream(ms);
                vetorImagens = data;
            }
            else
            {
                picFoto.Image = null;
            }
        }

        private void FrmAdmProd_Load(object sender, EventArgs e)
        {
            dgvBuscar_ObterDadosProd("");

            dgvBuscar.Columns["Id"].Width = 64;
            dgvBuscar.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvBuscar.Columns["Nome"].Width = 160;

            dgvBuscar.Columns["preco"].DefaultCellStyle.Format = "R$0.00";
            dgvBuscar.Columns["Preco"].HeaderText = "Preço";
            dgvBuscar.Columns["Preco"].Width = 64;

            dgvBuscar.Columns["Descricao"].HeaderText = "Descrição";
            dgvBuscar.Columns["Descricao"].Width = 246;

            dgvBuscar.Columns["Ingredientes"].Width = 132;

            dgvBuscar.Columns["Foto"].Width = 50;

            dgvBuscar.Columns["Tipo"].Width = 50;
            dgvBuscar.Columns["Tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvBuscar.RowTemplate.Height = 50;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoMOD produto = new ProdutoMOD
            {
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPreco.Text),
                Descricao = txtDescricao.Text,
                Ingredientes = txtIngredientes.Text,
                Foto = vetorImagens,
                Tipo = rdoLanche.Checked ? 'L' : rdoBebida.Checked ? 'B' : 'A'
            };
            try
            {
                bll.Inserir(produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            MessageBox.Show("Produto gravado com sucesso!");
            dgvBuscar_ObterDadosProd("");
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog(this);
                string strFn = openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.picFoto.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObterDadosCell();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvBuscar_ObterDadosProd(txtBuscar.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtIngredientes.Text = string.Empty;
            picFoto.Image = null;
            vetorImagens = null;
            rdoLanche.Checked = true;
            rdoBebida.Checked = false;
            rdoAcomp.Checked = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar este produto?",
                 "Importante",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                codigoproduto = Convert.ToInt32(txtId.Text);
                ProdutoBLL objExcluir = new ProdutoBLL();
                objExcluir.Excluir(codigoproduto);

                MessageBox.Show("Produto alterado com sucesso!");

                dgvBuscar_ObterDadosProd("");
            }
            ProdutoMOD produto = new ProdutoMOD
            {
                Id = Convert.ToInt32(txtId.Text),
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPreco.Text),
                Descricao = txtDescricao.Text,
                Ingredientes = txtIngredientes.Text,
                Foto = vetorImagens,
                Tipo = rdoLanche.Checked ? 'L' : rdoBebida.Checked ? 'B' : 'A'
            };

            bll.Alterar(produto);

            dgvBuscar_ObterDadosProd("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este produto?",
                             "Importante",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                codigoproduto = Convert.ToInt32(txtId.Text);
                ProdutoBLL objExcluir = new ProdutoBLL();
                objExcluir.Excluir(codigoproduto);

                MessageBox.Show("Produto excluído com sucesso!");

                dgvBuscar_ObterDadosProd("");
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtNome.Text.Length > 0 && txtPreco.Text.Length >= 0)
                {
                    btnSalvar.Enabled = true;
                }
                if (txtPreco.Text.Length == 4 && !txtPreco.Text.Contains(","))
                {
                    string preco = txtPreco.Text;
                    preco = preco.Insert(2, ",");
                    txtPreco.Text = preco;
                }
            }
            else
            {
                if (!char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                ObterDadosCell();
            }
            else
            {
                e.Handled = true;
            }
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0 && txtPreco.Text.Length > 0)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0 && txtPreco.Text.Length > 0)
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