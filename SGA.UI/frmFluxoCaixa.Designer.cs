namespace SGA.UI
{
    partial class frmFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            this.lblMesAtual = new System.Windows.Forms.Label();
            this.mtbBegin = new System.Windows.Forms.MaskedTextBox();
            this.lblDtPagamento = new System.Windows.Forms.Label();
            this.mtbMensal = new System.Windows.Forms.MaskedTextBox();
            this.lblProjecaoAno = new System.Windows.Forms.Label();
            this.lblProjecaoMes = new System.Windows.Forms.Label();
            this.mtbAnual = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinish = new System.Windows.Forms.MaskedTextBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mtbFaturamentoDatas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblMesAtual
            // 
            this.lblMesAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMesAtual.AutoSize = true;
            this.lblMesAtual.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAtual.Location = new System.Drawing.Point(224, 106);
            this.lblMesAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesAtual.Name = "lblMesAtual";
            this.lblMesAtual.Size = new System.Drawing.Size(14, 14);
            this.lblMesAtual.TabIndex = 76;
            this.lblMesAtual.Text = "e";
            // 
            // mtbBegin
            // 
            this.mtbBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbBegin.BackColor = System.Drawing.SystemColors.Control;
            this.mtbBegin.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbBegin.Location = new System.Drawing.Point(195, 102);
            this.mtbBegin.Margin = new System.Windows.Forms.Padding(2);
            this.mtbBegin.Mask = "00";
            this.mtbBegin.Name = "mtbBegin";
            this.mtbBegin.Size = new System.Drawing.Size(21, 22);
            this.mtbBegin.TabIndex = 3;
            this.mtbBegin.Tag = "";
            this.mtbBegin.ValidatingType = typeof(System.DateTime);
            // 
            // lblDtPagamento
            // 
            this.lblDtPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDtPagamento.AutoSize = true;
            this.lblDtPagamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtPagamento.Location = new System.Drawing.Point(16, 105);
            this.lblDtPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtPagamento.Name = "lblDtPagamento";
            this.lblDtPagamento.Size = new System.Drawing.Size(175, 14);
            this.lblDtPagamento.TabIndex = 75;
            this.lblDtPagamento.Text = "Projeção de Faturamento entre";
            // 
            // mtbMensal
            // 
            this.mtbMensal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbMensal.BackColor = System.Drawing.SystemColors.Control;
            this.mtbMensal.Enabled = false;
            this.mtbMensal.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbMensal.Location = new System.Drawing.Point(207, 64);
            this.mtbMensal.Margin = new System.Windows.Forms.Padding(2);
            this.mtbMensal.Name = "mtbMensal";
            this.mtbMensal.Size = new System.Drawing.Size(74, 22);
            this.mtbMensal.TabIndex = 2;
            this.mtbMensal.Tag = "";
            // 
            // lblProjecaoAno
            // 
            this.lblProjecaoAno.AutoSize = true;
            this.lblProjecaoAno.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjecaoAno.Location = new System.Drawing.Point(16, 28);
            this.lblProjecaoAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjecaoAno.Name = "lblProjecaoAno";
            this.lblProjecaoAno.Size = new System.Drawing.Size(178, 14);
            this.lblProjecaoAno.TabIndex = 1;
            this.lblProjecaoAno.Text = "Projeção de Faturamento Anual";
            // 
            // lblProjecaoMes
            // 
            this.lblProjecaoMes.AutoSize = true;
            this.lblProjecaoMes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjecaoMes.Location = new System.Drawing.Point(16, 65);
            this.lblProjecaoMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjecaoMes.Name = "lblProjecaoMes";
            this.lblProjecaoMes.Size = new System.Drawing.Size(187, 14);
            this.lblProjecaoMes.TabIndex = 77;
            this.lblProjecaoMes.Text = "Projeção de Faturamento Mensal";
            // 
            // mtbAnual
            // 
            this.mtbAnual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbAnual.BackColor = System.Drawing.SystemColors.Control;
            this.mtbAnual.Enabled = false;
            this.mtbAnual.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbAnual.Location = new System.Drawing.Point(207, 27);
            this.mtbAnual.Margin = new System.Windows.Forms.Padding(2);
            this.mtbAnual.Name = "mtbAnual";
            this.mtbAnual.Size = new System.Drawing.Size(74, 22);
            this.mtbAnual.TabIndex = 1;
            this.mtbAnual.Tag = "";
            // 
            // mtbFinish
            // 
            this.mtbFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbFinish.BackColor = System.Drawing.SystemColors.Control;
            this.mtbFinish.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbFinish.Location = new System.Drawing.Point(245, 102);
            this.mtbFinish.Margin = new System.Windows.Forms.Padding(2);
            this.mtbFinish.Mask = "00";
            this.mtbFinish.Name = "mtbFinish";
            this.mtbFinish.Size = new System.Drawing.Size(21, 22);
            this.mtbFinish.TabIndex = 4;
            this.mtbFinish.Tag = "";
            this.mtbFinish.ValidatingType = typeof(System.DateTime);
            // 
            // cbMes
            // 
            this.cbMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMes.BackColor = System.Drawing.SystemColors.Control;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(299, 102);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(87, 22);
            this.cbMes.TabIndex = 83;
            this.cbMes.TabStop = false;
            this.cbMes.Tag = "";
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 14);
            this.label1.TabIndex = 84;
            this.label1.Text = "de ";
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnGerar.ForeColor = System.Drawing.Color.Black;
            this.btnGerar.Location = new System.Drawing.Point(322, 143);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(64, 23);
            this.btnGerar.TabIndex = 86;
            this.btnGerar.TabStop = false;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(254, 143);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 23);
            this.btnLimpar.TabIndex = 87;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mtbFaturamentoDatas
            // 
            this.mtbFaturamentoDatas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbFaturamentoDatas.BackColor = System.Drawing.SystemColors.Control;
            this.mtbFaturamentoDatas.Enabled = false;
            this.mtbFaturamentoDatas.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbFaturamentoDatas.Location = new System.Drawing.Point(19, 130);
            this.mtbFaturamentoDatas.Margin = new System.Windows.Forms.Padding(2);
            this.mtbFaturamentoDatas.Name = "mtbFaturamentoDatas";
            this.mtbFaturamentoDatas.Size = new System.Drawing.Size(74, 22);
            this.mtbFaturamentoDatas.TabIndex = 88;
            this.mtbFaturamentoDatas.Tag = "";
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 177);
            this.Controls.Add(this.mtbFaturamentoDatas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.mtbFinish);
            this.Controls.Add(this.mtbAnual);
            this.Controls.Add(this.lblProjecaoMes);
            this.Controls.Add(this.lblMesAtual);
            this.Controls.Add(this.mtbBegin);
            this.Controls.Add(this.lblDtPagamento);
            this.Controls.Add(this.mtbMensal);
            this.Controls.Add(this.lblProjecaoAno);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeção de Fluxo de Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesAtual;
        private System.Windows.Forms.MaskedTextBox mtbBegin;
        private System.Windows.Forms.Label lblDtPagamento;
        private System.Windows.Forms.MaskedTextBox mtbMensal;
        private System.Windows.Forms.Label lblProjecaoAno;
        private System.Windows.Forms.Label lblProjecaoMes;
        private System.Windows.Forms.MaskedTextBox mtbAnual;
        private System.Windows.Forms.MaskedTextBox mtbFinish;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mtbFaturamentoDatas;
    }
}