namespace Frms
{
    partial class FrmAdmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBuscarPedidos = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblBuscarPedidos = new System.Windows.Forms.Label();
            this.txtBuscarPedidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBuscarItens = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.lblBuscarItens = new System.Windows.Forms.Label();
            this.txtBuscarItens = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radAndamento = new System.Windows.Forms.RadioButton();
            this.radConcluido = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pnlBuscarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnlBuscarItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscarPedidos
            // 
            this.pnlBuscarPedidos.Controls.Add(this.dgvPedidos);
            this.pnlBuscarPedidos.Controls.Add(this.lblBuscarPedidos);
            this.pnlBuscarPedidos.Controls.Add(this.txtBuscarPedidos);
            this.pnlBuscarPedidos.Location = new System.Drawing.Point(12, 215);
            this.pnlBuscarPedidos.Name = "pnlBuscarPedidos";
            this.pnlBuscarPedidos.Size = new System.Drawing.Size(642, 737);
            this.pnlBuscarPedidos.TabIndex = 1;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 103);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 50;
            this.dgvPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedidos.Size = new System.Drawing.Size(636, 631);
            this.dgvPedidos.StandardTab = true;
            this.dgvPedidos.TabIndex = 1;
            // 
            // lblBuscarPedidos
            // 
            this.lblBuscarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarPedidos.AutoSize = true;
            this.lblBuscarPedidos.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarPedidos.Location = new System.Drawing.Point(3, 0);
            this.lblBuscarPedidos.Name = "lblBuscarPedidos";
            this.lblBuscarPedidos.Size = new System.Drawing.Size(330, 59);
            this.lblBuscarPedidos.TabIndex = 27;
            this.lblBuscarPedidos.Text = "Buscar Pedidos";
            this.lblBuscarPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarPedidos
            // 
            this.txtBuscarPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPedidos.Location = new System.Drawing.Point(0, 59);
            this.txtBuscarPedidos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtBuscarPedidos.MaxLength = 100;
            this.txtBuscarPedidos.Name = "txtBuscarPedidos";
            this.txtBuscarPedidos.Size = new System.Drawing.Size(642, 38);
            this.txtBuscarPedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pedidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBuscarItens
            // 
            this.pnlBuscarItens.Controls.Add(this.dgvItens);
            this.pnlBuscarItens.Controls.Add(this.lblBuscarItens);
            this.pnlBuscarItens.Controls.Add(this.txtBuscarItens);
            this.pnlBuscarItens.Location = new System.Drawing.Point(877, 215);
            this.pnlBuscarItens.Name = "pnlBuscarItens";
            this.pnlBuscarItens.Size = new System.Drawing.Size(642, 737);
            this.pnlBuscarItens.TabIndex = 28;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(3, 103);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 50;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.Size = new System.Drawing.Size(636, 631);
            this.dgvItens.StandardTab = true;
            this.dgvItens.TabIndex = 1;
            // 
            // lblBuscarItens
            // 
            this.lblBuscarItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarItens.AutoSize = true;
            this.lblBuscarItens.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarItens.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarItens.Location = new System.Drawing.Point(3, 0);
            this.lblBuscarItens.Name = "lblBuscarItens";
            this.lblBuscarItens.Size = new System.Drawing.Size(270, 59);
            this.lblBuscarItens.TabIndex = 27;
            this.lblBuscarItens.Text = "Buscar Itens";
            this.lblBuscarItens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarItens
            // 
            this.txtBuscarItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarItens.Location = new System.Drawing.Point(0, 59);
            this.txtBuscarItens.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtBuscarItens.MaxLength = 100;
            this.txtBuscarItens.Name = "txtBuscarItens";
            this.txtBuscarItens.Size = new System.Drawing.Size(642, 38);
            this.txtBuscarItens.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radAndamento);
            this.panel1.Controls.Add(this.radConcluido);
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 60);
            this.panel1.TabIndex = 29;
            // 
            // radAndamento
            // 
            this.radAndamento.AutoSize = true;
            this.radAndamento.Location = new System.Drawing.Point(26, 23);
            this.radAndamento.Name = "radAndamento";
            this.radAndamento.Size = new System.Drawing.Size(97, 17);
            this.radAndamento.TabIndex = 29;
            this.radAndamento.TabStop = true;
            this.radAndamento.Text = "Em Andamento";
            this.radAndamento.UseVisualStyleBackColor = true;
            // 
            // radConcluido
            // 
            this.radConcluido.AutoSize = true;
            this.radConcluido.Location = new System.Drawing.Point(214, 23);
            this.radConcluido.Name = "radConcluido";
            this.radConcluido.Size = new System.Drawing.Size(140, 17);
            this.radConcluido.TabIndex = 30;
            this.radConcluido.TabStop = true;
            this.radConcluido.Text = "Aguardando Pagamento";
            this.radConcluido.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(129, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Concluídos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(360, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pagamento Concluído";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmAdmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1531, 1074);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBuscarItens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBuscarPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmPedidos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmAdmPedidos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAdmPedidos_Load);
            this.pnlBuscarPedidos.ResumeLayout(false);
            this.pnlBuscarPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.pnlBuscarItens.ResumeLayout(false);
            this.pnlBuscarItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscarPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblBuscarPedidos;
        private System.Windows.Forms.TextBox txtBuscarPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBuscarItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label lblBuscarItens;
        private System.Windows.Forms.TextBox txtBuscarItens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radAndamento;
        private System.Windows.Forms.RadioButton radConcluido;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}