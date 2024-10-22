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
using System.IO;

namespace Frms
{
    public partial class FrmTotemProdutoInfo : Form
    {
        MemoryStream fotoms;

        public FrmTotemProdutoInfo()
        {
            InitializeComponent();
        }
        public void CarregaInfo(ProdutoMOD produtoCarregado)
        {
            if (produtoCarregado.Foto != null)
            {
                fotoms = new MemoryStream(produtoCarregado.Foto);
            }
            lblNome.Text = produtoCarregado.Nome;
            lblPreco.Text = String.Format("{0:C}", produtoCarregado.Preco);
            lblDescricao.Text = produtoCarregado.Descricao;
            lblIngredientes.Text = produtoCarregado.Ingredientes;
        }


        private void FrmTotemLancheInfo_Load(object sender, EventArgs e)
        {
            if (fotoms != null)
            {
                picFoto.Image = Image.FromStream(fotoms);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
