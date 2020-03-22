namespace SGA.UI.UC
{
    partial class ucInsertQuarto
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.mtbObservacao = new System.Windows.Forms.MaskedTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.mtbCasa = new System.Windows.Forms.MaskedTextBox();
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCalção = new System.Windows.Forms.Label();
            this.lblAluguel = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mtbAluguel = new System.Windows.Forms.MaskedTextBox();
            this.mtbCalcao = new System.Windows.Forms.MaskedTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(346, 130);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(71, 23);
            this.btnAdicionar.TabIndex = 45;
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
            this.btnClear.Location = new System.Drawing.Point(271, 130);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // mtbObservacao
            // 
            this.mtbObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbObservacao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbObservacao.Location = new System.Drawing.Point(90, 90);
            this.mtbObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbObservacao.Name = "mtbObservacao";
            this.mtbObservacao.Size = new System.Drawing.Size(327, 22);
            this.mtbObservacao.TabIndex = 4;
            this.mtbObservacao.Tag = "";
            // 
            // lblObservacao
            // 
            this.lblObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(16, 93);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 14);
            this.lblObservacao.TabIndex = 41;
            this.lblObservacao.Text = "Observação";
            // 
            // mtbCasa
            // 
            this.mtbCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCasa.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCasa.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCasa.Location = new System.Drawing.Point(71, 12);
            this.mtbCasa.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCasa.Mask = "00000000";
            this.mtbCasa.Name = "mtbCasa";
            this.mtbCasa.Size = new System.Drawing.Size(31, 22);
            this.mtbCasa.TabIndex = 1;
            this.mtbCasa.Tag = "";
            this.mtbCasa.ValidatingType = typeof(int);
            // 
            // lblCasa
            // 
            this.lblCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa.Location = new System.Drawing.Point(18, 15);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(33, 14);
            this.lblCasa.TabIndex = 35;
            this.lblCasa.Text = "Casa";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(277, 54);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 14);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status";
            // 
            // lblCalção
            // 
            this.lblCalção.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalção.AutoSize = true;
            this.lblCalção.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalção.Location = new System.Drawing.Point(152, 54);
            this.lblCalção.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalção.Name = "lblCalção";
            this.lblCalção.Size = new System.Drawing.Size(43, 14);
            this.lblCalção.TabIndex = 39;
            this.lblCalção.Text = "Calção";
            // 
            // lblAluguel
            // 
            this.lblAluguel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAluguel.AutoSize = true;
            this.lblAluguel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluguel.Location = new System.Drawing.Point(18, 54);
            this.lblAluguel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAluguel.Name = "lblAluguel";
            this.lblAluguel.Size = new System.Drawing.Size(49, 14);
            this.lblAluguel.TabIndex = 33;
            this.lblAluguel.Text = "Aluguel";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(16, 134);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(226, 14);
            this.lblInfo.TabIndex = 43;
            this.lblInfo.Text = "( ! ) Insira os valores nos campos acima.";
            // 
            // mtbAluguel
            // 
            this.mtbAluguel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbAluguel.BackColor = System.Drawing.SystemColors.Control;
            this.mtbAluguel.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbAluguel.Location = new System.Drawing.Point(71, 52);
            this.mtbAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbAluguel.Name = "mtbAluguel";
            this.mtbAluguel.Size = new System.Drawing.Size(57, 22);
            this.mtbAluguel.TabIndex = 2;
            this.mtbAluguel.Tag = "";
            // 
            // mtbCalcao
            // 
            this.mtbCalcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCalcao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCalcao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCalcao.Location = new System.Drawing.Point(199, 52);
            this.mtbCalcao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCalcao.Name = "mtbCalcao";
            this.mtbCalcao.Size = new System.Drawing.Size(57, 22);
            this.mtbCalcao.TabIndex = 3;
            this.mtbCalcao.Tag = "2";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(323, 52);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(94, 22);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.TabStop = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // ucInsertQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.mtbCalcao);
            this.Controls.Add(this.mtbAluguel);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.mtbObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.mtbCasa);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCalção);
            this.Controls.Add(this.lblAluguel);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucInsertQuarto";
            this.Size = new System.Drawing.Size(437, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mtbObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.MaskedTextBox mtbCasa;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCalção;
        private System.Windows.Forms.Label lblAluguel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MaskedTextBox mtbAluguel;
        private System.Windows.Forms.MaskedTextBox mtbCalcao;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}
