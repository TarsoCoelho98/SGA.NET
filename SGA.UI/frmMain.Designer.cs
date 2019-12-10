namespace SGA.UI
{
    partial class frmMain
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMenuInicial = new System.Windows.Forms.MenuStrip();
            this.tsmItemCasa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemQueryFromCasa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemQuarto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemLocatario = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.adicionarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuInicial
            // 
            this.msMenuInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemCasa,
            this.tsmItemQuarto,
            this.tsmItemLocatario,
            this.tsmItemOpcoes,
            this.tsmItemAjuda});
            this.msMenuInicial.Location = new System.Drawing.Point(0, 0);
            this.msMenuInicial.Name = "msMenuInicial";
            this.msMenuInicial.Size = new System.Drawing.Size(800, 24);
            this.msMenuInicial.TabIndex = 0;
            this.msMenuInicial.Text = "menuStrip1";
            // 
            // tsmItemCasa
            // 
            this.tsmItemCasa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemQueryFromCasa,
            this.toolStripSeparator1,
            this.adicionarToolStripMenuItem});
            this.tsmItemCasa.Name = "tsmItemCasa";
            this.tsmItemCasa.Size = new System.Drawing.Size(44, 20);
            this.tsmItemCasa.Text = "Casa";
            // 
            // tsmItemQueryFromCasa
            // 
            this.tsmItemQueryFromCasa.Name = "tsmItemQueryFromCasa";
            this.tsmItemQueryFromCasa.Size = new System.Drawing.Size(180, 22);
            this.tsmItemQueryFromCasa.Text = "Consultar";
            this.tsmItemQueryFromCasa.Click += new System.EventHandler(this.tsmItemQueryFromCasa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // tsmItemQuarto
            // 
            this.tsmItemQuarto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.toolStripSeparator2,
            this.adicionarToolStripMenuItem1});
            this.tsmItemQuarto.Name = "tsmItemQuarto";
            this.tsmItemQuarto.Size = new System.Drawing.Size(56, 20);
            this.tsmItemQuarto.Text = "Quarto";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            // 
            // tsmItemLocatario
            // 
            this.tsmItemLocatario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem1,
            this.toolStripSeparator3,
            this.adicionarToolStripMenuItem2});
            this.tsmItemLocatario.Name = "tsmItemLocatario";
            this.tsmItemLocatario.Size = new System.Drawing.Size(68, 20);
            this.tsmItemLocatario.Text = "Locatário";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // adicionarToolStripMenuItem2
            // 
            this.adicionarToolStripMenuItem2.Name = "adicionarToolStripMenuItem2";
            this.adicionarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem2.Text = "Adicionar";
            // 
            // tsmItemOpcoes
            // 
            this.tsmItemOpcoes.Name = "tsmItemOpcoes";
            this.tsmItemOpcoes.Size = new System.Drawing.Size(59, 20);
            this.tsmItemOpcoes.Text = "Opções";
            // 
            // tsmItemAjuda
            // 
            this.tsmItemAjuda.Name = "tsmItemAjuda";
            this.tsmItemAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsmItemAjuda.Text = "Ajuda";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenuInicial);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuInicial;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestão de Aluguéis";
            this.msMenuInicial.ResumeLayout(false);
            this.msMenuInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuInicial;
        private System.Windows.Forms.ToolStripMenuItem tsmItemCasa;
        private System.Windows.Forms.ToolStripMenuItem tsmItemQueryFromCasa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmItemQuarto;
        private System.Windows.Forms.ToolStripMenuItem tsmItemLocatario;
        private System.Windows.Forms.ToolStripMenuItem tsmItemOpcoes;
        private System.Windows.Forms.ToolStripMenuItem tsmItemAjuda;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem2;
    }
}

