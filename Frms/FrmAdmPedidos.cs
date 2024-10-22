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
    public partial class FrmAdmPedidos : Form
    {
        private static PedidoBLL pedidoBLL = new PedidoBLL();
        private static ItensPedidoBLL itensBLL = new ItensPedidoBLL();

        private static List<PedidoMOD> pedidos = new List<PedidoMOD>();
        private static List<ItensPedidoMOD> itens = new List<ItensPedidoMOD>();

        private static char status = 'A';

        private void DgvPedidos()
        {
            pedidos = pedidoBLL.BuscaPorStatus(status);
        }

        public FrmAdmPedidos()
        {
            InitializeComponent();
        }

        private void FrmAdmPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pedidos;
            dgvItens.DataSource = itens;
        }
    }
}
