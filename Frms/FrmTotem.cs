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
    /// <summary>
    /// Esse é o formulário principal do totem, 
    /// servindo como mdiContainer para os Frms produto.
    /// </summary>

    public partial class FrmTotem : Form
    {
        //  Inicia os formulários
        private static FrmLanches frmLanches = new FrmLanches();
        private static FrmTotemBebidas frmBebidas = new FrmTotemBebidas();
        private static FrmTotemAcomp frmAcomp = new FrmTotemAcomp();
        private static FrmTotemSacola frmSacola = new FrmTotemSacola();
        private static FrmTotemProdutoInfo frmInfo = new FrmTotemProdutoInfo();

        //  Inicia os BLL
        private static PedidoBLL pedidoBLL = new PedidoBLL();
        private static ItensPedidoBLL itensPedidoBLL = new ItensPedidoBLL();
        private static UsuarioBLL usuarioBLL = new UsuarioBLL();

        //  Declara o CPF do usuário logado
        private static string cpfTotem = "";

        //  Declara a variável que salva o último botão que o usuário clicou
        private static char btnAtual = 'L';

        public FrmTotem()
        {
            InitializeComponent();

            //  TODO: Adaptar o programa à tela (incompleto)

            //  Redimensiona o tamanho do form para tela cheia
            this.Size = new Size(
                Screen.PrimaryScreen.WorkingArea.Width, 
                Screen.PrimaryScreen.WorkingArea.Height);

            //  Torna esse formulário pai desses formulários
            frmAcomp.MdiParent = this;
            frmBebidas.MdiParent = this;
            frmLanches.MdiParent = this;
            frmSacola.MdiParent = this;

            //  Redimensiona os formulários para a área do container
            frmLanches.Size = new Size(
                this.Width - panel1.Size.Width - SystemInformation.FrameBorderSize.Width,
                this.Height - panel2.Size.Height + 36
                );
            frmBebidas.Size = new Size(
                this.Width - panel1.Size.Width - SystemInformation.FrameBorderSize.Width,
                this.Height - panel2.Size.Height + 36
                );
            frmAcomp.Size = new Size(
                this.Width - panel1.Size.Width - SystemInformation.FrameBorderSize.Width,
                this.Height - panel2.Size.Height + 36
                );
            frmSacola.Size = new Size(
                this.Width - panel1.Size.Width - SystemInformation.FrameBorderSize.Width, 
                this.Height - panel2.Size.Height + 36
                );
        }

        //  Ao carregar, prepara os elementos do form e inicia o login.
        private void FrmTotem_Load(object sender, EventArgs e)
        {
            //  Excluir o convidado para garantir o próximo login de convidado
            usuarioBLL.ExcluirConvidado();

            //  Limpar dados do pedido anterior
            frmSacola.listaSacola.Clear();
            frmSacola.totalPedido = 0.00;
            numQuantidade.Value = 1;
            frmLanches.Visible = false;
            frmBebidas.Visible = false;
            frmAcomp.Visible = false;
            frmInfo.Visible = false;
            frmSacola.Visible = false;
            btnFinalizar.Visible = false;
            btnVoltar.Visible = false;
            pcbSacola.Visible = false;
            numQuantidade.Visible = true;
            btnAdicionar.Visible = true;

            //  Deixa a tela de lanches aberta
            btnLanches_Click(sender, e);

            //  Abre o login
            FrmTotemLogin frmLogin = new FrmTotemLogin();
            frmLogin.ShowDialog();

            //  Traz o CPF do login
            cpfTotem = frmLogin.RetornaCpf();
            frmSacola.cpfPedido = cpfTotem;

            //  Fecha o login
            frmLogin.Close();
        }

        //método para abrir o form anterior da sacola
        private void BtnAtual(object sender, EventArgs e)
        {
            switch (btnAtual)
            {
                case 'L':
                    btnLanches_Click(sender, e);
                    break;
                case 'B':
                    btnBebidas_Click(sender, e);
                    break;
                case 'A':
                    btnAconpanhamentos_Click(sender, e);
                    break;
                default:
                    btnLanches_Click(sender, e);
                    break;
            }
        }

        //Clique no botão Lanches
        private void btnLanches_Click(object sender, EventArgs e)
        {
            //Define o botão atual 'Lanches'
            btnAtual = 'L';

            //Destaca o botão
            btnLanches.FlatAppearance.BorderSize = 5;
            btnBebidas.FlatAppearance.BorderSize = 0;
            btnAcompanhamentos.FlatAppearance.BorderSize = 0;

            //Desabilita o botão e habilita os outros
            btnLanches.Enabled = false;
            btnAcompanhamentos.Enabled = true;
            btnBebidas.Enabled = true;

            //Deixa o form visível
            frmLanches.Show();
            frmBebidas.Visible = false;
            frmAcomp.Visible = false;
        }

        //Clique no botão bebidas
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            //Define o botão atual 'Bebidas'
            btnAtual = 'B';

            //Destaca o botão
            btnLanches.FlatAppearance.BorderSize = 0;
            btnBebidas.FlatAppearance.BorderSize = 5;
            btnAcompanhamentos.FlatAppearance.BorderSize = 0;

            //Desabilita o botão e habilita os outros
            btnBebidas.Enabled = false;
            btnLanches.Enabled = true;
            btnAcompanhamentos.Enabled = true;

            //Deixa o form visível
            frmBebidas.Show();
            frmLanches.Visible = false;
            frmAcomp.Visible = false;
        }

        private void btnAconpanhamentos_Click(object sender, EventArgs e)
        {
            //Define o botão atual 'Acompanhamentos'
            btnAtual = 'A';

            btnLanches.FlatAppearance.BorderSize = 0;
            btnBebidas.FlatAppearance.BorderSize = 0;
            btnAcompanhamentos.FlatAppearance.BorderSize = 5;

            btnAcompanhamentos.Enabled = false;
            btnLanches.Enabled = true;
            btnBebidas.Enabled = true;

            frmAcomp.Show();
            frmLanches.Visible = false;
            frmBebidas.Visible = false;
        }

        private void pcbSacola_Click(object sender, EventArgs e)
        {
            if (frmSacola.Visible == false)
            {
                frmSacola.Show();

                btnFinalizar.Visible = true;

                btnVoltar.Visible = true;
                btnLanches.Enabled = false;
                btnBebidas.Enabled = false;
                btnAcompanhamentos.Enabled = false;

                numQuantidade.Visible = false;
                btnAdicionar.Visible = false;

                pcbSacola.Visible = false;

                frmLanches.Visible = false;
                frmBebidas.Visible = false;
                frmAcomp.Visible = false;
            }
            else
            {
                frmSacola.Visible = false;
                btnFinalizar.Visible = false;

                btnVoltar.Visible = false;
                btnLanches.Enabled = true;
                btnBebidas.Enabled = true;
                btnAcompanhamentos.Enabled = true;

                numQuantidade.Visible = true;
                btnAdicionar.Visible = true;

                pcbSacola.Visible = true;

                BtnAtual(sender, e);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ProdutoMOD produtoAdicionar = new ProdutoMOD();

            if (frmLanches.Visible == true)
            {
                produtoAdicionar = frmLanches.RetornaProduto();
            }
            else
            {
                if (frmBebidas.Visible == true)
                {
                    produtoAdicionar = frmBebidas.RetornaProduto();
                }
                else
                {
                    if (frmAcomp.Visible == true)
                    {
                        produtoAdicionar = frmAcomp.RetornaProduto();
                    }
                }
            }

            for (int quantidade = 0; quantidade < numQuantidade.Value; quantidade++)
            {
                frmSacola.listaSacola.Add(produtoAdicionar);
            }
            pcbSacola_Click(sender, e);
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar o pedido?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FrmTotem_Load(sender, e);
            }
        }

        private void FrmTotem_FormClosed(object sender, FormClosedEventArgs e)
        {
            usuarioBLL.ExcluirConvidado();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            PedidoMOD pedido = new PedidoMOD();
            pedido.CpfUsuario = frmSacola.cpfPedido;
            pedido.MetPag = frmSacola.RetornarMetPag(pedido);
            pedido.Total = frmSacola.totalPedido;

            int idPedido = pedidoBLL.Inserir(pedido);

            foreach (ProdutoMOD produtoPedido in frmSacola.listaSacola)
            {
                itensPedidoBLL.Inserir(new ItensPedidoMOD
                {
                    IdPedido = idPedido,
                    NomeProduto = produtoPedido.Nome,
                    PrecoProduto = produtoPedido.Preco
                });
            }

            FrmTotemFinalizado frmFinalizado = new FrmTotemFinalizado();
            frmFinalizado.senha = idPedido;
            frmFinalizado.ShowDialog();

            frmFinalizado.Close();

            FrmTotem_Load(sender, e);
        }
    }
}
