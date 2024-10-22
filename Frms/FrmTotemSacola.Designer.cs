namespace Frms
{
    partial class FrmTotemSacola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTotemSacola));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDebito = new System.Windows.Forms.Label();
            this.picDebito = new System.Windows.Forms.PictureBox();
            this.radDebito = new System.Windows.Forms.RadioButton();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblPix = new System.Windows.Forms.Label();
            this.picCredito = new System.Windows.Forms.PictureBox();
            this.radCredito = new System.Windows.Forms.RadioButton();
            this.picDinheiro = new System.Windows.Forms.PictureBox();
            this.radDinheiro = new System.Windows.Forms.RadioButton();
            this.picPix = new System.Windows.Forms.PictureBox();
            this.radPix = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSacola = new System.Windows.Forms.DataGridView();
            this.pnlPix = new System.Windows.Forms.Panel();
            this.pnlDinheiro = new System.Windows.Forms.Panel();
            this.pnlCredito = new System.Windows.Forms.Panel();
            this.pnlDebito = new System.Windows.Forms.Panel();
            this.pnlSacola = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblSacola = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDinheiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSacola)).BeginInit();
            this.pnlSacola.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.BackColor = System.Drawing.Color.Gold;
            this.lblDebito.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDebito.Location = new System.Drawing.Point(575, 880);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(68, 25);
            this.lblDebito.TabIndex = 173;
            this.lblDebito.Text = "Débito";
            this.lblDebito.Click += new System.EventHandler(this.pnlDebito_Click);
            // 
            // picDebito
            // 
            this.picDebito.BackColor = System.Drawing.Color.Gold;
            this.picDebito.Image = ((System.Drawing.Image)(resources.GetObject("picDebito.Image")));
            this.picDebito.Location = new System.Drawing.Point(566, 803);
            this.picDebito.Name = "picDebito";
            this.picDebito.Size = new System.Drawing.Size(86, 74);
            this.picDebito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDebito.TabIndex = 172;
            this.picDebito.TabStop = false;
            this.picDebito.Click += new System.EventHandler(this.pnlDebito_Click);
            // 
            // radDebito
            // 
            this.radDebito.AutoSize = true;
            this.radDebito.Location = new System.Drawing.Point(545, 834);
            this.radDebito.Name = "radDebito";
            this.radDebito.Size = new System.Drawing.Size(14, 13);
            this.radDebito.TabIndex = 160;
            this.radDebito.TabStop = true;
            this.radDebito.UseVisualStyleBackColor = true;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.BackColor = System.Drawing.Color.Gold;
            this.lblCredito.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblCredito.Location = new System.Drawing.Point(446, 879);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(74, 25);
            this.lblCredito.TabIndex = 170;
            this.lblCredito.Text = "Crédito";
            this.lblCredito.Click += new System.EventHandler(this.pnlCredito_Click);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.BackColor = System.Drawing.Color.Gold;
            this.lblDinheiro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDinheiro.Location = new System.Drawing.Point(317, 879);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(85, 25);
            this.lblDinheiro.TabIndex = 169;
            this.lblDinheiro.Text = "Dinheiro";
            this.lblDinheiro.Click += new System.EventHandler(this.pnlDinheiro_Click);
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.BackColor = System.Drawing.Color.Gold;
            this.lblPix.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPix.Location = new System.Drawing.Point(217, 879);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(39, 25);
            this.lblPix.TabIndex = 168;
            this.lblPix.Text = "PIX";
            this.lblPix.Click += new System.EventHandler(this.pnlPix_Click);
            // 
            // picCredito
            // 
            this.picCredito.BackColor = System.Drawing.Color.Gold;
            this.picCredito.Image = ((System.Drawing.Image)(resources.GetObject("picCredito.Image")));
            this.picCredito.Location = new System.Drawing.Point(440, 802);
            this.picCredito.Name = "picCredito";
            this.picCredito.Size = new System.Drawing.Size(86, 74);
            this.picCredito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCredito.TabIndex = 167;
            this.picCredito.TabStop = false;
            this.picCredito.Click += new System.EventHandler(this.pnlCredito_Click);
            // 
            // radCredito
            // 
            this.radCredito.AutoSize = true;
            this.radCredito.Location = new System.Drawing.Point(419, 833);
            this.radCredito.Name = "radCredito";
            this.radCredito.Size = new System.Drawing.Size(14, 13);
            this.radCredito.TabIndex = 159;
            this.radCredito.TabStop = true;
            this.radCredito.UseVisualStyleBackColor = true;
            // 
            // picDinheiro
            // 
            this.picDinheiro.BackColor = System.Drawing.Color.Gold;
            this.picDinheiro.Image = ((System.Drawing.Image)(resources.GetObject("picDinheiro.Image")));
            this.picDinheiro.Location = new System.Drawing.Point(316, 802);
            this.picDinheiro.Name = "picDinheiro";
            this.picDinheiro.Size = new System.Drawing.Size(86, 74);
            this.picDinheiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDinheiro.TabIndex = 166;
            this.picDinheiro.TabStop = false;
            this.picDinheiro.Click += new System.EventHandler(this.pnlDinheiro_Click);
            // 
            // radDinheiro
            // 
            this.radDinheiro.AutoSize = true;
            this.radDinheiro.Location = new System.Drawing.Point(295, 833);
            this.radDinheiro.Name = "radDinheiro";
            this.radDinheiro.Size = new System.Drawing.Size(14, 13);
            this.radDinheiro.TabIndex = 158;
            this.radDinheiro.TabStop = true;
            this.radDinheiro.UseVisualStyleBackColor = true;
            // 
            // picPix
            // 
            this.picPix.BackColor = System.Drawing.Color.Gold;
            this.picPix.Image = ((System.Drawing.Image)(resources.GetObject("picPix.Image")));
            this.picPix.Location = new System.Drawing.Point(193, 802);
            this.picPix.Name = "picPix";
            this.picPix.Size = new System.Drawing.Size(86, 74);
            this.picPix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPix.TabIndex = 165;
            this.picPix.TabStop = false;
            this.picPix.Click += new System.EventHandler(this.pnlPix_Click);
            // 
            // radPix
            // 
            this.radPix.AutoSize = true;
            this.radPix.Location = new System.Drawing.Point(172, 833);
            this.radPix.Name = "radPix";
            this.radPix.Size = new System.Drawing.Size(14, 13);
            this.radPix.TabIndex = 157;
            this.radPix.TabStop = true;
            this.radPix.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Gold;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTotal.Location = new System.Drawing.Point(1189, 803);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 31);
            this.lblTotal.TabIndex = 164;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 802);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 163;
            this.label1.Text = "Preço Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(244, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(647, 79);
            this.label10.TabIndex = 162;
            this.label10.Text = "CONFIRA SEUS ITENS";
            // 
            // dgvSacola
            // 
            this.dgvSacola.AllowUserToAddRows = false;
            this.dgvSacola.AllowUserToDeleteRows = false;
            this.dgvSacola.AllowUserToResizeColumns = false;
            this.dgvSacola.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgvSacola.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSacola.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvSacola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSacola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSacola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSacola.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSacola.EnableHeadersVisualStyles = false;
            this.dgvSacola.GridColor = System.Drawing.Color.Black;
            this.dgvSacola.Location = new System.Drawing.Point(12, 62);
            this.dgvSacola.MaximumSize = new System.Drawing.Size(1525, 790);
            this.dgvSacola.MinimumSize = new System.Drawing.Size(10, 10);
            this.dgvSacola.Name = "dgvSacola";
            this.dgvSacola.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSacola.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSacola.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSacola.Size = new System.Drawing.Size(1468, 482);
            this.dgvSacola.TabIndex = 174;
            // 
            // pnlPix
            // 
            this.pnlPix.Location = new System.Drawing.Point(193, 802);
            this.pnlPix.Name = "pnlPix";
            this.pnlPix.Size = new System.Drawing.Size(86, 103);
            this.pnlPix.TabIndex = 175;
            this.pnlPix.Click += new System.EventHandler(this.pnlPix_Click);
            // 
            // pnlDinheiro
            // 
            this.pnlDinheiro.Location = new System.Drawing.Point(315, 802);
            this.pnlDinheiro.Name = "pnlDinheiro";
            this.pnlDinheiro.Size = new System.Drawing.Size(87, 103);
            this.pnlDinheiro.TabIndex = 176;
            this.pnlDinheiro.Click += new System.EventHandler(this.pnlDinheiro_Click);
            // 
            // pnlCredito
            // 
            this.pnlCredito.Location = new System.Drawing.Point(439, 802);
            this.pnlCredito.Name = "pnlCredito";
            this.pnlCredito.Size = new System.Drawing.Size(87, 103);
            this.pnlCredito.TabIndex = 177;
            this.pnlCredito.Click += new System.EventHandler(this.pnlCredito_Click);
            // 
            // pnlDebito
            // 
            this.pnlDebito.Location = new System.Drawing.Point(566, 803);
            this.pnlDebito.Name = "pnlDebito";
            this.pnlDebito.Size = new System.Drawing.Size(86, 102);
            this.pnlDebito.TabIndex = 178;
            this.pnlDebito.Click += new System.EventHandler(this.pnlDebito_Click);
            // 
            // pnlSacola
            // 
            this.pnlSacola.BackColor = System.Drawing.Color.Khaki;
            this.pnlSacola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSacola.Controls.Add(this.btnRemover);
            this.pnlSacola.Controls.Add(this.lblSacola);
            this.pnlSacola.Controls.Add(this.dgvSacola);
            this.pnlSacola.Location = new System.Drawing.Point(12, 177);
            this.pnlSacola.Name = "pnlSacola";
            this.pnlSacola.Size = new System.Drawing.Size(1495, 619);
            this.pnlSacola.TabIndex = 179;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(10, 555);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(194, 49);
            this.btnRemover.TabIndex = 176;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblSacola
            // 
            this.lblSacola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSacola.AutoSize = true;
            this.lblSacola.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSacola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSacola.Location = new System.Drawing.Point(12, 2);
            this.lblSacola.Name = "lblSacola";
            this.lblSacola.Size = new System.Drawing.Size(149, 59);
            this.lblSacola.TabIndex = 175;
            this.lblSacola.Text = "Sacola";
            // 
            // FrmTotemSacola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1519, 948);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.picDebito);
            this.Controls.Add(this.radDebito);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.picCredito);
            this.Controls.Add(this.radCredito);
            this.Controls.Add(this.radDinheiro);
            this.Controls.Add(this.picPix);
            this.Controls.Add(this.radPix);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlDebito);
            this.Controls.Add(this.pnlCredito);
            this.Controls.Add(this.pnlPix);
            this.Controls.Add(this.picDinheiro);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.pnlDinheiro);
            this.Controls.Add(this.pnlSacola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTotemSacola";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSacola";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmTotemSacola_Load_AND_VisibleChanged);
            this.VisibleChanged += new System.EventHandler(this.FrmTotemSacola_Load_AND_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDinheiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSacola)).EndInit();
            this.pnlSacola.ResumeLayout(false);
            this.pnlSacola.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.PictureBox picDebito;
        private System.Windows.Forms.RadioButton radDebito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblPix;
        private System.Windows.Forms.PictureBox picCredito;
        private System.Windows.Forms.RadioButton radCredito;
        private System.Windows.Forms.PictureBox picDinheiro;
        private System.Windows.Forms.RadioButton radDinheiro;
        private System.Windows.Forms.PictureBox picPix;
        private System.Windows.Forms.RadioButton radPix;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlPix;
        private System.Windows.Forms.Panel pnlDinheiro;
        private System.Windows.Forms.Panel pnlCredito;
        private System.Windows.Forms.Panel pnlDebito;
        private System.Windows.Forms.Panel pnlSacola;
        private System.Windows.Forms.Label lblSacola;
        private System.Windows.Forms.Button btnRemover;
        public System.Windows.Forms.DataGridView dgvSacola;
    }
}