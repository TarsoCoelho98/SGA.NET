namespace SGA.UI.UC
{
    partial class ucUpdateCasa
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
            this.gbAtualizacao = new System.Windows.Forms.GroupBox();
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.mtbCidade = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.gbAtualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAtualizacao
            // 
            this.gbAtualizacao.BackColor = System.Drawing.Color.White;
            this.gbAtualizacao.Controls.Add(this.mtbCidade);
            this.gbAtualizacao.Controls.Add(this.lblCidade);
            this.gbAtualizacao.Controls.Add(this.mtbObservacao);
            this.gbAtualizacao.Controls.Add(this.lblObservacao);
            this.gbAtualizacao.Controls.Add(this.mtbNumero);
            this.gbAtualizacao.Controls.Add(this.lblNumero);
            this.gbAtualizacao.Controls.Add(this.mtbRua);
            this.gbAtualizacao.Controls.Add(this.mtbCEP);
            this.gbAtualizacao.Controls.Add(this.mtbBairro);
            this.gbAtualizacao.Controls.Add(this.lblCEP);
            this.gbAtualizacao.Controls.Add(this.lblBairro);
            this.gbAtualizacao.Controls.Add(this.lblRua);
            this.gbAtualizacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAtualizacao.Location = new System.Drawing.Point(22, 18);
            this.gbAtualizacao.Name = "gbAtualizacao";
            this.gbAtualizacao.Size = new System.Drawing.Size(454, 196);
            this.gbAtualizacao.TabIndex = 0;
            this.gbAtualizacao.TabStop = false;
            this.gbAtualizacao.Text = " Casa ";
            // 
            // mtbObservacao
            // 
            this.mtbObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbObservacao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbObservacao.Location = new System.Drawing.Point(105, 154);
            this.mtbObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbObservacao.Name = "mtbObservacao";
            this.mtbObservacao.Size = new System.Drawing.Size(327, 22);
            this.mtbObservacao.TabIndex = 6;
            this.mtbObservacao.Tag = "";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(23, 157);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 14);
            this.lblObservacao.TabIndex = 15;
            this.lblObservacao.Text = "Observação";
            // 
            // mtbNumero
            // 
            this.mtbNumero.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNumero.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNumero.Location = new System.Drawing.Point(401, 33);
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
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(345, 34);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 14);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número";
            // 
            // mtbRua
            // 
            this.mtbRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbRua.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRua.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRua.Location = new System.Drawing.Point(72, 31);
            this.mtbRua.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRua.Name = "mtbRua";
            this.mtbRua.Size = new System.Drawing.Size(239, 22);
            this.mtbRua.TabIndex = 1;
            this.mtbRua.Tag = "";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCEP.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCEP.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCEP.Location = new System.Drawing.Point(374, 72);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(58, 22);
            this.mtbCEP.TabIndex = 4;
            this.mtbCEP.Tag = "";
            // 
            // mtbBairro
            // 
            this.mtbBairro.BackColor = System.Drawing.SystemColors.Control;
            this.mtbBairro.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbBairro.Location = new System.Drawing.Point(72, 74);
            this.mtbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.mtbBairro.Name = "mtbBairro";
            this.mtbBairro.Size = new System.Drawing.Size(239, 22);
            this.mtbBairro.TabIndex = 3;
            this.mtbBairro.Tag = "";
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(345, 75);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(25, 14);
            this.lblCEP.TabIndex = 11;
            this.lblCEP.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(23, 75);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 14);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(23, 34);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(28, 14);
            this.lblRua.TabIndex = 9;
            this.lblRua.Text = "Rua";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 235);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(236, 14);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "( ! ) Insira os novos valores para atualizar.";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(406, 231);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 23);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(331, 231);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // mtbCidade
            // 
            this.mtbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCidade.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCidade.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCidade.Location = new System.Drawing.Point(72, 114);
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
            this.lblCidade.Location = new System.Drawing.Point(23, 117);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(45, 14);
            this.lblCidade.TabIndex = 36;
            this.lblCidade.Text = "Cidade";
            // 
            // ucUpdateCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbAtualizacao);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "ucUpdateCasa";
            this.Size = new System.Drawing.Size(500, 272);
            this.gbAtualizacao.ResumeLayout(false);
            this.gbAtualizacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAtualizacao;
        private System.Windows.Forms.MaskedTextBox mtbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mtbRua;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mtbCidade;
        private System.Windows.Forms.Label lblCidade;
    }
}
