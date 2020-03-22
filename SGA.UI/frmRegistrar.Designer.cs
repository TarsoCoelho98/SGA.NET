namespace SGA.UI
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.lblSenha = new System.Windows.Forms.Label();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblRacf = new System.Windows.Forms.Label();
            this.mtbRua = new System.Windows.Forms.MaskedTextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.mtbBairro = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbSenha = new System.Windows.Forms.TextBox();
            this.mtbRacf = new System.Windows.Forms.TextBox();
            this.mtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbEmailSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(22, 109);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 14);
            this.lblSenha.TabIndex = 112;
            this.lblSenha.Text = "Senha";
            // 
            // mtbNome
            // 
            this.mtbNome.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNome.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNome.Location = new System.Drawing.Point(74, 28);
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
            this.lblNome.Location = new System.Drawing.Point(22, 31);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 109;
            this.lblNome.Text = "Nome";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(529, 243);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(71, 23);
            this.btnAdicionar.TabIndex = 101;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "Cadastrar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(454, 243);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 100;
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
            this.lblInfo.Location = new System.Drawing.Point(22, 247);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(205, 14);
            this.lblInfo.TabIndex = 99;
            this.lblInfo.Text = "( ! ) Insira os seus dados cadastrais.";
            // 
            // lblRacf
            // 
            this.lblRacf.AutoSize = true;
            this.lblRacf.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacf.Location = new System.Drawing.Point(22, 71);
            this.lblRacf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacf.Name = "lblRacf";
            this.lblRacf.Size = new System.Drawing.Size(50, 14);
            this.lblRacf.TabIndex = 116;
            this.lblRacf.Text = "Usuário";
            // 
            // mtbRua
            // 
            this.mtbRua.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRua.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRua.Location = new System.Drawing.Point(370, 67);
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
            this.lblRua.Location = new System.Drawing.Point(319, 71);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(28, 14);
            this.lblRua.TabIndex = 118;
            this.lblRua.Text = "Rua";
            // 
            // mtbBairro
            // 
            this.mtbBairro.BackColor = System.Drawing.SystemColors.Control;
            this.mtbBairro.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbBairro.Location = new System.Drawing.Point(370, 28);
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
            this.lblBairro.Location = new System.Drawing.Point(319, 31);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 14);
            this.lblBairro.TabIndex = 120;
            this.lblBairro.Text = "Bairro";
            // 
            // mtbNumero
            // 
            this.mtbNumero.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNumero.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNumero.Location = new System.Drawing.Point(453, 105);
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
            this.lblNumero.Location = new System.Drawing.Point(319, 109);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(118, 14);
            this.lblNumero.TabIndex = 122;
            this.lblNumero.Text = "Número Residencial";
            // 
            // mtbCpf
            // 
            this.mtbCpf.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCpf.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCpf.Location = new System.Drawing.Point(453, 142);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCpf.Mask = "000 000 000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(83, 22);
            this.mtbCpf.TabIndex = 8;
            this.mtbCpf.Tag = "";
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(319, 187);
            this.lblRg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(125, 14);
            this.lblRg.TabIndex = 124;
            this.lblRg.Text = "RG (apenas números)";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(319, 145);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(128, 14);
            this.lblCpf.TabIndex = 126;
            this.lblCpf.Text = "CPF (apenas números)";
            // 
            // mtbRg
            // 
            this.mtbRg.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRg.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRg.Location = new System.Drawing.Point(453, 184);
            this.mtbRg.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRg.Mask = "00000000000000";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(93, 22);
            this.mtbRg.TabIndex = 10;
            this.mtbRg.Tag = "";
            this.mtbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbSenha
            // 
            this.mtbSenha.BackColor = System.Drawing.SystemColors.Control;
            this.mtbSenha.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbSenha.Location = new System.Drawing.Point(75, 105);
            this.mtbSenha.MaxLength = 6;
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.Size = new System.Drawing.Size(50, 22);
            this.mtbSenha.TabIndex = 5;
            this.mtbSenha.UseSystemPasswordChar = true;
            // 
            // mtbRacf
            // 
            this.mtbRacf.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRacf.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbRacf.Location = new System.Drawing.Point(75, 67);
            this.mtbRacf.MaxLength = 7;
            this.mtbRacf.Name = "mtbRacf";
            this.mtbRacf.Size = new System.Drawing.Size(50, 22);
            this.mtbRacf.TabIndex = 3;
            // 
            // mtbEmail
            // 
            this.mtbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.mtbEmail.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbEmail.Location = new System.Drawing.Point(75, 142);
            this.mtbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.Size = new System.Drawing.Size(224, 22);
            this.mtbEmail.TabIndex = 7;
            this.mtbEmail.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 146;
            this.label1.Text = "E-mail";
            // 
            // mtbEmailSenha
            // 
            this.mtbEmailSenha.BackColor = System.Drawing.SystemColors.Control;
            this.mtbEmailSenha.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbEmailSenha.Location = new System.Drawing.Point(75, 184);
            this.mtbEmailSenha.Margin = new System.Windows.Forms.Padding(2);
            this.mtbEmailSenha.Name = "mtbEmailSenha";
            this.mtbEmailSenha.Size = new System.Drawing.Size(224, 22);
            this.mtbEmailSenha.TabIndex = 9;
            this.mtbEmailSenha.Tag = "";
            this.mtbEmailSenha.UseSystemPasswordChar = true;
            // 
            // lblEmailSenha
            // 
            this.lblEmailSenha.AutoSize = true;
            this.lblEmailSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSenha.Location = new System.Drawing.Point(22, 187);
            this.lblEmailSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailSenha.Name = "lblEmailSenha";
            this.lblEmailSenha.Size = new System.Drawing.Size(44, 14);
            this.lblEmailSenha.TabIndex = 148;
            this.lblEmailSenha.Text = "Senha ";
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 279);
            this.Controls.Add(this.mtbEmailSenha);
            this.Controls.Add(this.lblEmailSenha);
            this.Controls.Add(this.mtbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbRacf);
            this.Controls.Add(this.mtbSenha);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mtbRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.mtbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.mtbRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblRacf);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.mtbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox mtbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblRacf;
        private System.Windows.Forms.MaskedTextBox mtbRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.MaskedTextBox mtbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.TextBox mtbSenha;
        private System.Windows.Forms.TextBox mtbRacf;
        private System.Windows.Forms.MaskedTextBox mtbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbEmailSenha;
        private System.Windows.Forms.Label lblEmailSenha;
    }
}