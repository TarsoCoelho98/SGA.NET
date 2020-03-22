namespace SGA.UI.UC
{
    partial class ucQueryLocatario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvLocatario = new System.Windows.Forms.DataGridView();
            this.locatarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblStatusPagamento = new System.Windows.Forms.Label();
            this.cbStatusCalcao = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.mtbQuarto = new System.Windows.Forms.MaskedTextBox();
            this.mtbCalcao = new System.Windows.Forms.MaskedTextBox();
            this.lblCalcao = new System.Windows.Forms.Label();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.mtbCasa = new System.Windows.Forms.MaskedTextBox();
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblDtPagamento = new System.Windows.Forms.Label();
            this.mtbDtPagamento = new System.Windows.Forms.MaskedTextBox();
            this.lblStatusCalcao = new System.Windows.Forms.Label();
            this.mtbAluguel = new System.Windows.Forms.MaskedTextBox();
            this.mtbId = new System.Windows.Forms.MaskedTextBox();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.lblAluguel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnResetarStatusPagamento = new System.Windows.Forms.Button();
            this.idLocatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlAluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlCalcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCalcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEditar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.columnRemover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.columnCobranca = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(44, 398);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 14);
            this.lblCount.TabIndex = 18;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(11, 398);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(40, 15);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Total: ";
            // 
            // dgvLocatario
            // 
            this.dgvLocatario.AllowUserToAddRows = false;
            this.dgvLocatario.AllowUserToDeleteRows = false;
            this.dgvLocatario.AllowUserToResizeColumns = false;
            this.dgvLocatario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvLocatario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocatario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocatario.AutoGenerateColumns = false;
            this.dgvLocatario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLocatario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLocatario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLocatario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocatario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocatario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLocatarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.vlAluguelDataGridViewTextBoxColumn,
            this.statusPagamentoDataGridViewTextBoxColumn,
            this.diaPagamentoDataGridViewTextBoxColumn,
            this.vlCalcaoDataGridViewTextBoxColumn,
            this.statusCalcaoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.fkCasaDataGridViewTextBoxColumn,
            this.fkQuartoDataGridViewTextBoxColumn,
            this.debitoDataGridViewTextBoxColumn,
            this.creditoDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.Cpf,
            this.Rg,
            this.NomePai,
            this.NomeMae,
            this.columnEditar,
            this.columnRemover,
            this.columnCobranca});
            this.dgvLocatario.DataSource = this.locatarioBindingSource;
            this.dgvLocatario.EnableHeadersVisualStyles = false;
            this.dgvLocatario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLocatario.Location = new System.Drawing.Point(12, 117);
            this.dgvLocatario.MultiSelect = false;
            this.dgvLocatario.Name = "dgvLocatario";
            this.dgvLocatario.ReadOnly = true;
            this.dgvLocatario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocatario.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvLocatario.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvLocatario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLocatario.Size = new System.Drawing.Size(778, 260);
            this.dgvLocatario.TabIndex = 16;
            this.dgvLocatario.TabStop = false;
            this.dgvLocatario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocatario_CellContentClick);
            // 
            // locatarioBindingSource
            // 
            this.locatarioBindingSource.DataSource = typeof(SGA.DAL.Entity.Locatario);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(719, 394);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(644, 394);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.BackColor = System.Drawing.Color.White;
            this.gbFiltro.Controls.Add(this.cbPagamento);
            this.gbFiltro.Controls.Add(this.cbSexo);
            this.gbFiltro.Controls.Add(this.lblStatusPagamento);
            this.gbFiltro.Controls.Add(this.cbStatusCalcao);
            this.gbFiltro.Controls.Add(this.lblSexo);
            this.gbFiltro.Controls.Add(this.mtbQuarto);
            this.gbFiltro.Controls.Add(this.mtbCalcao);
            this.gbFiltro.Controls.Add(this.lblCalcao);
            this.gbFiltro.Controls.Add(this.lblQuarto);
            this.gbFiltro.Controls.Add(this.mtbCasa);
            this.gbFiltro.Controls.Add(this.lblCasa);
            this.gbFiltro.Controls.Add(this.lblDtPagamento);
            this.gbFiltro.Controls.Add(this.mtbDtPagamento);
            this.gbFiltro.Controls.Add(this.lblStatusCalcao);
            this.gbFiltro.Controls.Add(this.mtbAluguel);
            this.gbFiltro.Controls.Add(this.mtbId);
            this.gbFiltro.Controls.Add(this.mtbNome);
            this.gbFiltro.Controls.Add(this.lblAluguel);
            this.gbFiltro.Controls.Add(this.lblNome);
            this.gbFiltro.Controls.Add(this.lblId);
            this.gbFiltro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.ForeColor = System.Drawing.Color.Black;
            this.gbFiltro.Location = new System.Drawing.Point(13, 7);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.gbFiltro.Size = new System.Drawing.Size(777, 93);
            this.gbFiltro.TabIndex = 13;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = " Filtro ";
            // 
            // cbPagamento
            // 
            this.cbPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Location = new System.Drawing.Point(450, 59);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(78, 22);
            this.cbPagamento.TabIndex = 23;
            this.cbPagamento.TabStop = false;
            this.cbPagamento.Tag = "";
            this.cbPagamento.SelectedIndexChanged += new System.EventHandler(this.cbPagamento_SelectedIndexChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.SystemColors.Control;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(706, 21);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(56, 22);
            this.cbSexo.TabIndex = 18;
            this.cbSexo.TabStop = false;
            this.cbSexo.Tag = "";
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // lblStatusPagamento
            // 
            this.lblStatusPagamento.AutoSize = true;
            this.lblStatusPagamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPagamento.ForeColor = System.Drawing.Color.Black;
            this.lblStatusPagamento.Location = new System.Drawing.Point(359, 62);
            this.lblStatusPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusPagamento.Name = "lblStatusPagamento";
            this.lblStatusPagamento.Size = new System.Drawing.Size(86, 14);
            this.lblStatusPagamento.TabIndex = 22;
            this.lblStatusPagamento.Text = "Status Aluguel";
            // 
            // cbStatusCalcao
            // 
            this.cbStatusCalcao.BackColor = System.Drawing.SystemColors.Control;
            this.cbStatusCalcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusCalcao.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbStatusCalcao.FormattingEnabled = true;
            this.cbStatusCalcao.Location = new System.Drawing.Point(666, 59);
            this.cbStatusCalcao.Name = "cbStatusCalcao";
            this.cbStatusCalcao.Size = new System.Drawing.Size(96, 22);
            this.cbStatusCalcao.TabIndex = 0;
            this.cbStatusCalcao.TabStop = false;
            this.cbStatusCalcao.Tag = "";
            this.cbStatusCalcao.SelectedIndexChanged += new System.EventHandler(this.cbStatusCalcao_SelectedIndexChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(672, 24);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 14);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo";
            // 
            // mtbQuarto
            // 
            this.mtbQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.mtbQuarto.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbQuarto.Location = new System.Drawing.Point(295, 59);
            this.mtbQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.mtbQuarto.Mask = "00000000";
            this.mtbQuarto.Name = "mtbQuarto";
            this.mtbQuarto.Size = new System.Drawing.Size(31, 22);
            this.mtbQuarto.TabIndex = 7;
            this.mtbQuarto.Tag = "";
            this.mtbQuarto.ValidatingType = typeof(int);
            // 
            // mtbCalcao
            // 
            this.mtbCalcao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCalcao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCalcao.Location = new System.Drawing.Point(597, 21);
            this.mtbCalcao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCalcao.Name = "mtbCalcao";
            this.mtbCalcao.Size = new System.Drawing.Size(57, 22);
            this.mtbCalcao.TabIndex = 4;
            this.mtbCalcao.Tag = "";
            // 
            // lblCalcao
            // 
            this.lblCalcao.AutoSize = true;
            this.lblCalcao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcao.ForeColor = System.Drawing.Color.Black;
            this.lblCalcao.Location = new System.Drawing.Point(544, 24);
            this.lblCalcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalcao.Name = "lblCalcao";
            this.lblCalcao.Size = new System.Drawing.Size(43, 14);
            this.lblCalcao.TabIndex = 20;
            this.lblCalcao.Text = "Calção";
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarto.ForeColor = System.Drawing.Color.Black;
            this.lblQuarto.Location = new System.Drawing.Point(247, 62);
            this.lblQuarto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(44, 14);
            this.lblQuarto.TabIndex = 13;
            this.lblQuarto.Text = "Quarto";
            // 
            // mtbCasa
            // 
            this.mtbCasa.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCasa.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCasa.Location = new System.Drawing.Point(195, 59);
            this.mtbCasa.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCasa.Mask = "00000000";
            this.mtbCasa.Name = "mtbCasa";
            this.mtbCasa.Size = new System.Drawing.Size(31, 22);
            this.mtbCasa.TabIndex = 6;
            this.mtbCasa.Tag = "";
            this.mtbCasa.ValidatingType = typeof(int);
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa.ForeColor = System.Drawing.Color.Black;
            this.lblCasa.Location = new System.Drawing.Point(158, 62);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(33, 14);
            this.lblCasa.TabIndex = 11;
            this.lblCasa.Text = "Casa";
            // 
            // lblDtPagamento
            // 
            this.lblDtPagamento.AutoSize = true;
            this.lblDtPagamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtPagamento.ForeColor = System.Drawing.Color.Black;
            this.lblDtPagamento.Location = new System.Drawing.Point(10, 62);
            this.lblDtPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtPagamento.Name = "lblDtPagamento";
            this.lblDtPagamento.Size = new System.Drawing.Size(107, 14);
            this.lblDtPagamento.TabIndex = 10;
            this.lblDtPagamento.Text = "Dia de Pagamento";
            // 
            // mtbDtPagamento
            // 
            this.mtbDtPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.mtbDtPagamento.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbDtPagamento.Location = new System.Drawing.Point(121, 59);
            this.mtbDtPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.mtbDtPagamento.Mask = "00";
            this.mtbDtPagamento.Name = "mtbDtPagamento";
            this.mtbDtPagamento.Size = new System.Drawing.Size(21, 22);
            this.mtbDtPagamento.TabIndex = 5;
            this.mtbDtPagamento.Tag = "";
            this.mtbDtPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblStatusCalcao
            // 
            this.lblStatusCalcao.AutoSize = true;
            this.lblStatusCalcao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCalcao.ForeColor = System.Drawing.Color.Black;
            this.lblStatusCalcao.Location = new System.Drawing.Point(574, 62);
            this.lblStatusCalcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusCalcao.Name = "lblStatusCalcao";
            this.lblStatusCalcao.Size = new System.Drawing.Size(80, 14);
            this.lblStatusCalcao.TabIndex = 8;
            this.lblStatusCalcao.Text = "Status Calção";
            // 
            // mtbAluguel
            // 
            this.mtbAluguel.BackColor = System.Drawing.SystemColors.Control;
            this.mtbAluguel.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbAluguel.Location = new System.Drawing.Point(471, 20);
            this.mtbAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbAluguel.Name = "mtbAluguel";
            this.mtbAluguel.Size = new System.Drawing.Size(57, 22);
            this.mtbAluguel.TabIndex = 3;
            this.mtbAluguel.Tag = "";
            // 
            // mtbId
            // 
            this.mtbId.BackColor = System.Drawing.SystemColors.Control;
            this.mtbId.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbId.Location = new System.Drawing.Point(58, 21);
            this.mtbId.Margin = new System.Windows.Forms.Padding(2);
            this.mtbId.Mask = "00000000";
            this.mtbId.Name = "mtbId";
            this.mtbId.Size = new System.Drawing.Size(31, 22);
            this.mtbId.TabIndex = 1;
            this.mtbId.Tag = "";
            this.mtbId.ValidatingType = typeof(int);
            // 
            // mtbNome
            // 
            this.mtbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbNome.BackColor = System.Drawing.SystemColors.Control;
            this.mtbNome.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbNome.Location = new System.Drawing.Point(153, 21);
            this.mtbNome.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(249, 22);
            this.mtbNome.TabIndex = 2;
            this.mtbNome.Tag = "";
            // 
            // lblAluguel
            // 
            this.lblAluguel.AutoSize = true;
            this.lblAluguel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluguel.ForeColor = System.Drawing.Color.Black;
            this.lblAluguel.Location = new System.Drawing.Point(418, 24);
            this.lblAluguel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAluguel.Name = "lblAluguel";
            this.lblAluguel.Size = new System.Drawing.Size(49, 14);
            this.lblAluguel.TabIndex = 4;
            this.lblAluguel.Text = "Aluguel";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(110, 24);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(10, 24);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 14);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Código";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(569, 394);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(71, 23);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.TabStop = false;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnResetarStatusPagamento
            // 
            this.btnResetarStatusPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetarStatusPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.btnResetarStatusPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResetarStatusPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetarStatusPagamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetarStatusPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResetarStatusPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResetarStatusPagamento.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnResetarStatusPagamento.ForeColor = System.Drawing.Color.Black;
            this.btnResetarStatusPagamento.Location = new System.Drawing.Point(390, 394);
            this.btnResetarStatusPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetarStatusPagamento.Name = "btnResetarStatusPagamento";
            this.btnResetarStatusPagamento.Size = new System.Drawing.Size(175, 23);
            this.btnResetarStatusPagamento.TabIndex = 20;
            this.btnResetarStatusPagamento.TabStop = false;
            this.btnResetarStatusPagamento.Text = "Reiniciar Status Pagamento";
            this.btnResetarStatusPagamento.UseVisualStyleBackColor = false;
            this.btnResetarStatusPagamento.Click += new System.EventHandler(this.btnResetarStatusPagamento_Click);
            // 
            // idLocatarioDataGridViewTextBoxColumn
            // 
            this.idLocatarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idLocatarioDataGridViewTextBoxColumn.DataPropertyName = "IdLocatario";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.idLocatarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idLocatarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idLocatarioDataGridViewTextBoxColumn.Name = "idLocatarioDataGridViewTextBoxColumn";
            this.idLocatarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLocatarioDataGridViewTextBoxColumn.Width = 64;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 59;
            // 
            // vlAluguelDataGridViewTextBoxColumn
            // 
            this.vlAluguelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vlAluguelDataGridViewTextBoxColumn.DataPropertyName = "VlAluguel";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.vlAluguelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vlAluguelDataGridViewTextBoxColumn.HeaderText = "Aluguel";
            this.vlAluguelDataGridViewTextBoxColumn.Name = "vlAluguelDataGridViewTextBoxColumn";
            this.vlAluguelDataGridViewTextBoxColumn.ReadOnly = true;
            this.vlAluguelDataGridViewTextBoxColumn.Width = 66;
            // 
            // statusPagamentoDataGridViewTextBoxColumn
            // 
            this.statusPagamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.statusPagamentoDataGridViewTextBoxColumn.DataPropertyName = "StatusPagamento";
            this.statusPagamentoDataGridViewTextBoxColumn.HeaderText = "Status (A) ";
            this.statusPagamentoDataGridViewTextBoxColumn.Name = "statusPagamentoDataGridViewTextBoxColumn";
            this.statusPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusPagamentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // diaPagamentoDataGridViewTextBoxColumn
            // 
            this.diaPagamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DiaPagamento";
            dataGridViewCellStyle5.Format = "M";
            dataGridViewCellStyle5.NullValue = null;
            this.diaPagamentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.diaPagamentoDataGridViewTextBoxColumn.HeaderText = "Pagamento";
            this.diaPagamentoDataGridViewTextBoxColumn.Name = "diaPagamentoDataGridViewTextBoxColumn";
            this.diaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaPagamentoDataGridViewTextBoxColumn.Width = 85;
            // 
            // vlCalcaoDataGridViewTextBoxColumn
            // 
            this.vlCalcaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vlCalcaoDataGridViewTextBoxColumn.DataPropertyName = "VlCalcao";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.vlCalcaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.vlCalcaoDataGridViewTextBoxColumn.HeaderText = "Calção";
            this.vlCalcaoDataGridViewTextBoxColumn.Name = "vlCalcaoDataGridViewTextBoxColumn";
            this.vlCalcaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vlCalcaoDataGridViewTextBoxColumn.Width = 64;
            // 
            // statusCalcaoDataGridViewTextBoxColumn
            // 
            this.statusCalcaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.statusCalcaoDataGridViewTextBoxColumn.DataPropertyName = "StatusCalcao";
            this.statusCalcaoDataGridViewTextBoxColumn.HeaderText = "Status (C)";
            this.statusCalcaoDataGridViewTextBoxColumn.Name = "statusCalcaoDataGridViewTextBoxColumn";
            this.statusCalcaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusCalcaoDataGridViewTextBoxColumn.Width = 77;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 59;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            dataGridViewCellStyle7.NullValue = null;
            this.celularDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 63;
            // 
            // fkCasaDataGridViewTextBoxColumn
            // 
            this.fkCasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fkCasaDataGridViewTextBoxColumn.DataPropertyName = "FkCasa";
            this.fkCasaDataGridViewTextBoxColumn.HeaderText = "Casa";
            this.fkCasaDataGridViewTextBoxColumn.Name = "fkCasaDataGridViewTextBoxColumn";
            this.fkCasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkCasaDataGridViewTextBoxColumn.Width = 55;
            // 
            // fkQuartoDataGridViewTextBoxColumn
            // 
            this.fkQuartoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fkQuartoDataGridViewTextBoxColumn.DataPropertyName = "FkQuarto";
            this.fkQuartoDataGridViewTextBoxColumn.HeaderText = "Quarto";
            this.fkQuartoDataGridViewTextBoxColumn.Name = "fkQuartoDataGridViewTextBoxColumn";
            this.fkQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkQuartoDataGridViewTextBoxColumn.Width = 63;
            // 
            // debitoDataGridViewTextBoxColumn
            // 
            this.debitoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.debitoDataGridViewTextBoxColumn.DataPropertyName = "Debito";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.debitoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.debitoDataGridViewTextBoxColumn.HeaderText = "Débito";
            this.debitoDataGridViewTextBoxColumn.Name = "debitoDataGridViewTextBoxColumn";
            this.debitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitoDataGridViewTextBoxColumn.Width = 62;
            // 
            // creditoDataGridViewTextBoxColumn
            // 
            this.creditoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.creditoDataGridViewTextBoxColumn.DataPropertyName = "Credito";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.creditoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.creditoDataGridViewTextBoxColumn.HeaderText = "Crédito";
            this.creditoDataGridViewTextBoxColumn.Name = "creditoDataGridViewTextBoxColumn";
            this.creditoDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditoDataGridViewTextBoxColumn.Width = 64;
            // 
            // dtNascimentoDataGridViewTextBoxColumn
            // 
            this.dtNascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DtNascimento";
            dataGridViewCellStyle10.NullValue = null;
            this.dtNascimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtNascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.Name = "dtNascimentoDataGridViewTextBoxColumn";
            this.dtNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtNascimentoDataGridViewTextBoxColumn.Width = 87;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 89;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 51;
            // 
            // Rg
            // 
            this.Rg.DataPropertyName = "Rg";
            this.Rg.HeaderText = "RG";
            this.Rg.Name = "Rg";
            this.Rg.ReadOnly = true;
            this.Rg.Width = 47;
            // 
            // NomePai
            // 
            this.NomePai.DataPropertyName = "NomePai";
            this.NomePai.HeaderText = "Pai";
            this.NomePai.Name = "NomePai";
            this.NomePai.ReadOnly = true;
            this.NomePai.Width = 46;
            // 
            // NomeMae
            // 
            this.NomeMae.DataPropertyName = "NomeMae";
            this.NomeMae.HeaderText = "Mãe";
            this.NomeMae.Name = "NomeMae";
            this.NomeMae.ReadOnly = true;
            this.NomeMae.Width = 52;
            // 
            // columnEditar
            // 
            this.columnEditar.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.columnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnEditar.HeaderText = "Editar";
            this.columnEditar.Name = "columnEditar";
            this.columnEditar.ReadOnly = true;
            this.columnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnEditar.Text = "Editar";
            this.columnEditar.UseColumnTextForLinkValue = true;
            this.columnEditar.Width = 58;
            // 
            // columnRemover
            // 
            this.columnRemover.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.columnRemover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnRemover.HeaderText = "Remover";
            this.columnRemover.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.columnRemover.Name = "columnRemover";
            this.columnRemover.ReadOnly = true;
            this.columnRemover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnRemover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnRemover.Text = "Remover";
            this.columnRemover.UseColumnTextForLinkValue = true;
            this.columnRemover.Width = 74;
            // 
            // columnCobranca
            // 
            this.columnCobranca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.columnCobranca.DefaultCellStyle = dataGridViewCellStyle11;
            this.columnCobranca.HeaderText = "Cobrança";
            this.columnCobranca.Name = "columnCobranca";
            this.columnCobranca.ReadOnly = true;
            this.columnCobranca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCobranca.Text = "Enviar ";
            this.columnCobranca.UseColumnTextForButtonValue = true;
            this.columnCobranca.Width = 58;
            // 
            // ucQueryLocatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnResetarStatusPagamento);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dgvLocatario);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbFiltro);
            this.Name = "ucQueryLocatario";
            this.Size = new System.Drawing.Size(802, 425);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvLocatario;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.MaskedTextBox mtbId;
        private System.Windows.Forms.MaskedTextBox mtbNome;
        private System.Windows.Forms.Label lblAluguel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MaskedTextBox mtbAluguel;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox mtbQuarto;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.MaskedTextBox mtbCasa;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblDtPagamento;
        private System.Windows.Forms.MaskedTextBox mtbDtPagamento;
        private System.Windows.Forms.Label lblStatusCalcao;
        private System.Windows.Forms.ComboBox cbStatusCalcao;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox mtbCalcao;
        private System.Windows.Forms.Label lblCalcao;
        private System.Windows.Forms.Label lblStatusPagamento;
        private System.Windows.Forms.BindingSource locatarioBindingSource;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnResetarStatusPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlAluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlCalcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCalcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMae;
        private System.Windows.Forms.DataGridViewLinkColumn columnEditar;
        private System.Windows.Forms.DataGridViewLinkColumn columnRemover;
        private System.Windows.Forms.DataGridViewButtonColumn columnCobranca;
    }
}
