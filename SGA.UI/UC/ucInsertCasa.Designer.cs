namespace SGA.UI.UC
{
    partial class ucInsertCasa
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbObservacao = new System.Windows.Forms.MaskedTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbRua = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtbBairro = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.mtbCidade = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbObservacao
            // 
            this.mtbObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbObservacao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbObservacao.Location = new System.Drawing.Point(89, 146);
            this.mtbObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbObservacao.Name = "mtbObservacao";
            this.mtbObservacao.Size = new System.Drawing.Size(363, 22);
            this.mtbObservacao.TabIndex = 6;
            this.mtbObservacao.Tag = "2";
            // 
            // lblObservacao
            // 
            this.lblObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(16, 149);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 14);
            this.lblObservacao.TabIndex = 28;
            this.lblObservacao.Text = "Observação";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbNumero.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNumero.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNumero.Location = new System.Drawing.Point(421, 18);
            this.mtbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNumero.Mask = "0000000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(31, 22);
            this.mtbNumero.TabIndex = 2;
            this.mtbNumero.Tag = "";
            this.mtbNumero.ValidatingType = typeof(int);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(366, 21);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 14);
            this.lblNumero.TabIndex = 22;
            this.lblNumero.Text = "Número";
            // 
            // mtbRua
            // 
            this.mtbRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbRua.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRua.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRua.Location = new System.Drawing.Point(70, 18);
            this.mtbRua.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRua.Name = "mtbRua";
            this.mtbRua.Size = new System.Drawing.Size(239, 22);
            this.mtbRua.TabIndex = 1;
            this.mtbRua.Tag = "";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCEP.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCEP.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCEP.Location = new System.Drawing.Point(394, 61);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(58, 22);
            this.mtbCEP.TabIndex = 4;
            this.mtbCEP.Tag = "";
            // 
            // mtbBairro
            // 
            this.mtbBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbBairro.BackColor = System.Drawing.SystemColors.Control;
            this.mtbBairro.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbBairro.Location = new System.Drawing.Point(70, 61);
            this.mtbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.mtbBairro.Name = "mtbBairro";
            this.mtbBairro.Size = new System.Drawing.Size(239, 22);
            this.mtbBairro.TabIndex = 3;
            this.mtbBairro.Tag = "";
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(366, 64);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(25, 14);
            this.lblCEP.TabIndex = 23;
            this.lblCEP.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(16, 64);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 14);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(16, 21);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(28, 14);
            this.lblRua.TabIndex = 20;
            this.lblRua.Text = "Rua";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 190);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(226, 14);
            this.lblInfo.TabIndex = 30;
            this.lblInfo.Text = "( ! ) Insira os valores nos campos acima.";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(381, 186);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(71, 23);
            this.btnAdicionar.TabIndex = 32;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(306, 186);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // mtbCidade
            // 
            this.mtbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCidade.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCidade.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCidade.Location = new System.Drawing.Point(70, 104);
            this.mtbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCidade.Name = "mtbCidade";
            this.mtbCidade.Size = new System.Drawing.Size(172, 22);
            this.mtbCidade.TabIndex = 5;
            this.mtbCidade.Tag = "";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(16, 107);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(45, 14);
            this.lblCidade.TabIndex = 34;
            this.lblCidade.Text = "Cidade";
            // 
            // ucInsertCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mtbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.mtbObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.mtbRua);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.mtbBairro);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblInfo);
            this.Name = "ucInsertCasa";
            this.Size = new System.Drawing.Size(475, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbRua;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.MaskedTextBox mtbBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mtbCidade;
        private System.Windows.Forms.Label lblCidade;
    }
}
