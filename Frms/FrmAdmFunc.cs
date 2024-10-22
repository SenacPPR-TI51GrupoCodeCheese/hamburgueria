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
    public partial class FrmAdmFunc : Form
    {
        int codigoproduto = 0;

        public FrmAdmFunc()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ProdutoBLL bll = new ProdutoBLL();
            dgvBuscar.DataSource = bll.BuscarPorNome(txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (pnlBuscar.Visible)
            {
                pnlBuscar.Visible = false;
                btnBuscar.Text = "Buscar";
            }
            else
            {
                pnlBuscar.Visible = true;
                btnBuscar.Text = "Fechar";
            }
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvBuscar.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvBuscar.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = dgvBuscar.CurrentRow.Cells[2].Value.ToString();
            cmbCargo.Text = dgvBuscar.CurrentRow.Cells[3].Value.ToString();
            txtEndereco.Text = dgvBuscar.CurrentRow.Cells[4].Value.ToString();
            cmbSexo.Text = dgvBuscar.CurrentRow.Cells[5].Value.ToString();
            dtpNascimento.Value = Convert.ToDateTime(dgvBuscar.CurrentRow.Cells[6].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FuncionarioMOD funcionario = new FuncionarioMOD
            {
                ID = Convert.ToInt32(txtID.Text),
                Nome = txtNome.Text,
                CPF = txtCPF.Text,
                DataNascimento = dtpNascimento.Value,
                Sexo = cmbSexo.Text,
                Cargo = cmbCargo.Text,
                Endereco = txtEndereco.Text,

            };
            FuncionarioBLL bll = new FuncionarioBLL();
            bll.Alterar(funcionario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cmbsexotxt = cmbSexo.Text;
            switch (cmbsexotxt)
            {
                case "Masculino":
                    cmbsexotxt = "M";
                    break;
                case "Feminino":
                    cmbsexotxt = "F";
                    break;
                case "Outro":
                    cmbsexotxt = "O";
                    break;
            }

            FuncionarioMOD funcionario = new FuncionarioMOD
            {
                Nome = txtNome.Text,
                CPF = txtCPF.Text,
                DataNascimento = dtpNascimento.Value,
                Sexo = cmbsexotxt,
                Endereco = txtEndereco.Text,
                Cargo = cmbCargo.Text,
            };

            FuncionarioBLL bll = new FuncionarioBLL();
            bll.Inserir(funcionario);

            MessageBox.Show("Funcionario gravado com sucesso!");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            dtpNascimento.Text = string.Empty;
            cmbSexo.Text = string.Empty;
            cmbCargo.Text = string.Empty;
            txtEndereco.Text = string.Empty;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse funcionário?",
                         "Importante",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FuncionarioBLL objExcluir = new FuncionarioBLL();
                objExcluir.Excluir(codigoproduto);


                MessageBox.Show("Funcionario excluído com sucesso!");
            }
        }
    }
}
