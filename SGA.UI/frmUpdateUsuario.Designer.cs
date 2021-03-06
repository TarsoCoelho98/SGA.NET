﻿namespace SGA.UI
{
    partial class frmUpdateUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateUsuario));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.mtbSenhaEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblSenhaEmail = new System.Windows.Forms.Label();
            this.mtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbSenha = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbBairro = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mtbRua = new System.Windows.Forms.MaskedTextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(559, 264);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 23);
            this.btnAtualizar.TabIndex = 131;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(484, 264);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 130;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblInfo.Location = new System.Drawing.Point(18, 268);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(205, 14);
            this.lblInfo.TabIndex = 129;
            this.lblInfo.Text = "( ! ) Insira os seus dados cadastrais.";
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.mtbSenhaEmail);
            this.gbUsuario.Controls.Add(this.lblSenhaEmail);
            this.gbUsuario.Controls.Add(this.mtbEmail);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Controls.Add(this.mtbSenha);
            this.gbUsuario.Controls.Add(this.lblCpf);
            this.gbUsuario.Controls.Add(this.mtbRg);
            this.gbUsuario.Controls.Add(this.lblRg);
            this.gbUsuario.Controls.Add(this.mtbCpf);
            this.gbUsuario.Controls.Add(this.mtbNumero);
            this.gbUsuario.Controls.Add(this.lblNumero);
            this.gbUsuario.Controls.Add(this.mtbBairro);
            this.gbUsuario.Controls.Add(this.lblBairro);
            this.gbUsuario.Controls.Add(this.mtbRua);
            this.gbUsuario.Controls.Add(this.lblRua);
            this.gbUsuario.Controls.Add(this.lblSenha);
            this.gbUsuario.Controls.Add(this.mtbNome);
            this.gbUsuario.Controls.Add(this.lblNome);
            this.gbUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbUsuario.Location = new System.Drawing.Point(21, 15);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(609, 229);
            this.gbUsuario.TabIndex = 132;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = " Usuário ";
            // 
            // mtbSenhaEmail
            // 
            this.mtbSenhaEmail.BackColor = System.Drawing.SystemColors.Control;
            this.mtbSenhaEmail.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbSenhaEmail.Location = new System.Drawing.Point(66, 147);
            this.mtbSenhaEmail.Margin = new System.Windows.Forms.Padding(2);
            this.mtbSenhaEmail.Name = "mtbSenhaEmail";
            this.mtbSenhaEmail.Size = new System.Drawing.Size(224, 22);
            this.mtbSenhaEmail.TabIndex = 7;
            this.mtbSenhaEmail.Tag = "";
            this.mtbSenhaEmail.UseSystemPasswordChar = true;
            // 
            // lblSenhaEmail
            // 
            this.lblSenhaEmail.AutoSize = true;
            this.lblSenhaEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaEmail.Location = new System.Drawing.Point(14, 150);
            this.lblSenhaEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaEmail.Name = "lblSenhaEmail";
            this.lblSenhaEmail.Size = new System.Drawing.Size(41, 14);
            this.lblSenhaEmail.TabIndex = 146;
            this.lblSenhaEmail.Text = "Senha";
            // 
            // mtbEmail
            // 
            this.mtbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.mtbEmail.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbEmail.Location = new System.Drawing.Point(66, 108);
            this.mtbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.Size = new System.Drawing.Size(224, 22);
            this.mtbEmail.TabIndex = 5;
            this.mtbEmail.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 144;
            this.label1.Text = "E-mail";
            // 
            // mtbSenha
            // 
            this.mtbSenha.BackColor = System.Drawing.SystemColors.Control;
            this.mtbSenha.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbSenha.Location = new System.Drawing.Point(66, 70);
            this.mtbSenha.MaxLength = 6;
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.Size = new System.Drawing.Size(50, 22);
            this.mtbSenha.TabIndex = 3;
            this.mtbSenha.UseSystemPasswordChar = true;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(320, 150);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(128, 14);
            this.lblCpf.TabIndex = 142;
            this.lblCpf.Text = "CPF (apenas números)";
            // 
            // mtbRg
            // 
            this.mtbRg.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRg.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRg.Location = new System.Drawing.Point(456, 187);
            this.mtbRg.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRg.Mask = "00000000000000";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(93, 22);
            this.mtbRg.TabIndex = 9;
            this.mtbRg.Tag = "";
            this.mtbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(320, 190);
            this.lblRg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(125, 14);
            this.lblRg.TabIndex = 140;
            this.lblRg.Text = "RG (apenas números)";
            // 
            // mtbCpf
            // 
            this.mtbCpf.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCpf.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCpf.Location = new System.Drawing.Point(456, 147);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCpf.Mask = "000 000 000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(83, 22);
            this.mtbCpf.TabIndex = 8;
            this.mtbCpf.Tag = "";
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbNumero
            // 
            this.mtbNumero.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNumero.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNumero.Location = new System.Drawing.Point(456, 108);
            this.mtbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNumero.Mask = "000000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(43, 22);
            this.mtbNumero.TabIndex = 6;
            this.mtbNumero.Tag = "";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(320, 111);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(118, 14);
            this.lblNumero.TabIndex = 138;
            this.lblNumero.Text = "Número Residencial";
            // 
            // mtbBairro
            // 
            this.mtbBairro.BackColor = System.Drawing.SystemColors.Control;
            this.mtbBairro.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbBairro.Location = new System.Drawing.Point(371, 30);
            this.mtbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.mtbBairro.Name = "mtbBairro";
            this.mtbBairro.Size = new System.Drawing.Size(224, 22);
            this.mtbBairro.TabIndex = 2;
            this.mtbBairro.Tag = "";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(320, 34);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 14);
            this.lblBairro.TabIndex = 136;
            this.lblBairro.Text = "Bairro";
            // 
            // mtbRua
            // 
            this.mtbRua.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRua.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRua.Location = new System.Drawing.Point(371, 70);
            this.mtbRua.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRua.Name = "mtbRua";
            this.mtbRua.Size = new System.Drawing.Size(224, 22);
            this.mtbRua.TabIndex = 4;
            this.mtbRua.Tag = "";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(320, 74);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(28, 14);
            this.lblRua.TabIndex = 134;
            this.lblRua.Text = "Rua";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(14, 74);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 14);
            this.lblSenha.TabIndex = 130;
            this.lblSenha.Text = "Senha";
            // 
            // mtbNome
            // 
            this.mtbNome.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNome.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNome.Location = new System.Drawing.Point(66, 30);
            this.mtbNome.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(224, 22);
            this.mtbNome.TabIndex = 1;
            this.mtbNome.Tag = "";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 129;
            this.lblNome.Text = "Nome";
            // 
            // frmUpdateUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 300);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de Dados Cadastrais";
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mtbRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox mtbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox mtbSenha;
        private System.Windows.Forms.MaskedTextBox mtbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbSenhaEmail;
        private System.Windows.Forms.Label lblSenhaEmail;
    }
}