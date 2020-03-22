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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMenuInicial = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.atualizarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.projeçãoDeFluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.msMenuInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuInicial
            // 
            this.msMenuInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem,
            this.tsmItemCasa,
            this.tsmItemQuarto,
            this.tsmItemLocatario,
            this.tsmItemOpcoes});
            this.msMenuInicial.Location = new System.Drawing.Point(0, 0);
            this.msMenuInicial.Name = "msMenuInicial";
            this.msMenuInicial.Size = new System.Drawing.Size(800, 24);
            this.msMenuInicial.TabIndex = 0;
            this.msMenuInicial.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
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
            this.tsmItemQueryFromCasa.Size = new System.Drawing.Size(125, 22);
            this.tsmItemQueryFromCasa.Text = "Consultar";
            this.tsmItemQueryFromCasa.Click += new System.EventHandler(this.tsmItemQueryFromCasa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
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
            this.tsmItemQuarto.ToolTipText = "R";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
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
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(122, 6);
            // 
            // adicionarToolStripMenuItem2
            // 
            this.adicionarToolStripMenuItem2.Name = "adicionarToolStripMenuItem2";
            this.adicionarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem2.Text = "Adicionar";
            this.adicionarToolStripMenuItem2.Click += new System.EventHandler(this.adicionarToolStripMenuItem2_Click);
            // 
            // tsmItemOpcoes
            // 
            this.tsmItemOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarCadastroToolStripMenuItem,
            this.toolStripSeparator4,
            this.projeçãoDeFluxoDeCaixaToolStripMenuItem});
            this.tsmItemOpcoes.Name = "tsmItemOpcoes";
            this.tsmItemOpcoes.Size = new System.Drawing.Size(59, 20);
            this.tsmItemOpcoes.Text = "Opções";
            // 
            // atualizarCadastroToolStripMenuItem
            // 
            this.atualizarCadastroToolStripMenuItem.Name = "atualizarCadastroToolStripMenuItem";
            this.atualizarCadastroToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.atualizarCadastroToolStripMenuItem.Text = "Atualizar Cadastro";
            this.atualizarCadastroToolStripMenuItem.Click += new System.EventHandler(this.atualizarCadastroToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // projeçãoDeFluxoDeCaixaToolStripMenuItem
            // 
            this.projeçãoDeFluxoDeCaixaToolStripMenuItem.Name = "projeçãoDeFluxoDeCaixaToolStripMenuItem";
            this.projeçãoDeFluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.projeçãoDeFluxoDeCaixaToolStripMenuItem.Text = "Projeção de Fluxo de Caixa";
            this.projeçãoDeFluxoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.projeçãoDeFluxoDeCaixaToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Calibri", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 426);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.msMenuInicial);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMenuInicial;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestão de Aluguéis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.ToolStripMenuItem atualizarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem projeçãoDeFluxoDeCaixaToolStripMenuItem;
    }
}

