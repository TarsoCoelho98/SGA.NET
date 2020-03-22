namespace SGA.UI.UC
{
    partial class ucUpdateQuarto
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbAtualizacao = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mtbObservacao = new System.Windows.Forms.MaskedTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.mtbCasa = new System.Windows.Forms.MaskedTextBox();
            this.lblCasa = new System.Windows.Forms.Label();
            this.mtbAluguel = new System.Windows.Forms.MaskedTextBox();
            this.mtbCalcao = new System.Windows.Forms.MaskedTextBox();
            this.lblCalcao = new System.Windows.Forms.Label();
            this.lblAluguel = new System.Windows.Forms.Label();
            this.gbAtualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(405, 203);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 23);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(330, 203);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(19, 205);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(217, 13);
            this.lblInfo.TabIndex = 21;
            this.lblInfo.Text = "( ! ) Insira os novos valores para atualização.";
            // 
            // gbAtualizacao
            // 
            this.gbAtualizacao.BackColor = System.Drawing.Color.White;
            this.gbAtualizacao.Controls.Add(this.cbStatus);
            this.gbAtualizacao.Controls.Add(this.lblStatus);
            this.gbAtualizacao.Controls.Add(this.mtbObservacao);
            this.gbAtualizacao.Controls.Add(this.lblObservacao);
            this.gbAtualizacao.Controls.Add(this.mtbCasa);
            this.gbAtualizacao.Controls.Add(this.lblCasa);
            this.gbAtualizacao.Controls.Add(this.mtbAluguel);
            this.gbAtualizacao.Controls.Add(this.mtbCalcao);
            this.gbAtualizacao.Controls.Add(this.lblCalcao);
            this.gbAtualizacao.Controls.Add(this.lblAluguel);
            this.gbAtualizacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAtualizacao.Location = new System.Drawing.Point(22, 16);
            this.gbAtualizacao.Name = "gbAtualizacao";
            this.gbAtualizacao.Size = new System.Drawing.Size(454, 156);
            this.gbAtualizacao.TabIndex = 20;
            this.gbAtualizacao.TabStop = false;
            this.gbAtualizacao.Text = " Quarto ";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(329, 70);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(94, 22);
            this.cbStatus.TabIndex = 18;
            this.cbStatus.TabStop = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(283, 73);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 14);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // mtbObservacao
            // 
            this.mtbObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbObservacao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbObservacao.Location = new System.Drawing.Point(96, 113);
            this.mtbObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbObservacao.Name = "mtbObservacao";
            this.mtbObservacao.Size = new System.Drawing.Size(327, 22);
            this.mtbObservacao.TabIndex = 4;
            this.mtbObservacao.Tag = "";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(22, 116);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 14);
            this.lblObservacao.TabIndex = 15;
            this.lblObservacao.Text = "Observação";
            // 
            // mtbCasa
            // 
            this.mtbCasa.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCasa.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCasa.Location = new System.Drawing.Point(79, 27);
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
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa.Location = new System.Drawing.Point(25, 30);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(33, 14);
            this.lblCasa.TabIndex = 11;
            this.lblCasa.Text = "Casa";
            // 
            // mtbAluguel
            // 
            this.mtbAluguel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbAluguel.BackColor = System.Drawing.SystemColors.Control;
            this.mtbAluguel.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbAluguel.Location = new System.Drawing.Point(79, 70);
            this.mtbAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbAluguel.Name = "mtbAluguel";
            this.mtbAluguel.Size = new System.Drawing.Size(57, 22);
            this.mtbAluguel.TabIndex = 2;
            this.mtbAluguel.Tag = "";
            // 
            // mtbCalcao
            // 
            this.mtbCalcao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCalcao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCalcao.Location = new System.Drawing.Point(206, 70);
            this.mtbCalcao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCalcao.Name = "mtbCalcao";
            this.mtbCalcao.Size = new System.Drawing.Size(57, 22);
            this.mtbCalcao.TabIndex = 3;
            this.mtbCalcao.Tag = "";
            // 
            // lblCalcao
            // 
            this.lblCalcao.AutoSize = true;
            this.lblCalcao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcao.Location = new System.Drawing.Point(159, 73);
            this.lblCalcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalcao.Name = "lblCalcao";
            this.lblCalcao.Size = new System.Drawing.Size(43, 14);
            this.lblCalcao.TabIndex = 13;
            this.lblCalcao.Text = "Calção";
            // 
            // lblAluguel
            // 
            this.lblAluguel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAluguel.AutoSize = true;
            this.lblAluguel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluguel.Location = new System.Drawing.Point(26, 73);
            this.lblAluguel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAluguel.Name = "lblAluguel";
            this.lblAluguel.Size = new System.Drawing.Size(49, 14);
            this.lblAluguel.TabIndex = 9;
            this.lblAluguel.Text = "Aluguel";
            // 
            // ucUpdateQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbAtualizacao);
            this.Name = "ucUpdateQuarto";
            this.Size = new System.Drawing.Size(500, 240);
            this.gbAtualizacao.ResumeLayout(false);
            this.gbAtualizacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbAtualizacao;
        private System.Windows.Forms.MaskedTextBox mtbObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.MaskedTextBox mtbCasa;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.MaskedTextBox mtbAluguel;
        private System.Windows.Forms.MaskedTextBox mtbCalcao;
        private System.Windows.Forms.Label lblCalcao;
        private System.Windows.Forms.Label lblAluguel;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}
