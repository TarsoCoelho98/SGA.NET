namespace SGA.UI.UC
{
    partial class ucQueryQuarto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.mtbCasa = new System.Windows.Forms.MaskedTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblCasa = new System.Windows.Forms.Label();
            this.mtbCalcao = new System.Windows.Forms.MaskedTextBox();
            this.mtbId = new System.Windows.Forms.MaskedTextBox();
            this.mtbAluguel = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVlAluguel = new System.Windows.Forms.Label();
            this.lblVlCalcao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.idQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlAluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlCalcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEditar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.columnRemover = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(43, 395);
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
            this.lblQuantidade.Location = new System.Drawing.Point(10, 395);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(40, 15);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Total: ";
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.AllowUserToAddRows = false;
            this.dgvQuarto.AllowUserToDeleteRows = false;
            this.dgvQuarto.AllowUserToResizeColumns = false;
            this.dgvQuarto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvQuarto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuarto.AutoGenerateColumns = false;
            this.dgvQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuarto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQuarto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuarto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idQuartoDataGridViewTextBoxColumn,
            this.vlAluguelDataGridViewTextBoxColumn,
            this.vlCalcaoDataGridViewTextBoxColumn,
            this.fkCasaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Observacao,
            this.columnEditar,
            this.columnRemover});
            this.dgvQuarto.DataSource = this.quartoBindingSource;
            this.dgvQuarto.EnableHeadersVisualStyles = false;
            this.dgvQuarto.GridColor = System.Drawing.SystemColors.Control;
            this.dgvQuarto.Location = new System.Drawing.Point(11, 88);
            this.dgvQuarto.MultiSelect = false;
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.ReadOnly = true;
            this.dgvQuarto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuarto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvQuarto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQuarto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvQuarto.Size = new System.Drawing.Size(778, 289);
            this.dgvQuarto.TabIndex = 16;
            this.dgvQuarto.TabStop = false;
            this.dgvQuarto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuarto_CellContentClick);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(SGA.DAL.Entity.Quarto);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(718, 391);
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
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(643, 391);
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
            this.gbFiltro.Controls.Add(this.mtbCasa);
            this.gbFiltro.Controls.Add(this.cbStatus);
            this.gbFiltro.Controls.Add(this.lblCasa);
            this.gbFiltro.Controls.Add(this.mtbCalcao);
            this.gbFiltro.Controls.Add(this.mtbId);
            this.gbFiltro.Controls.Add(this.mtbAluguel);
            this.gbFiltro.Controls.Add(this.lblStatus);
            this.gbFiltro.Controls.Add(this.lblVlAluguel);
            this.gbFiltro.Controls.Add(this.lblVlCalcao);
            this.gbFiltro.Controls.Add(this.lblId);
            this.gbFiltro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.ForeColor = System.Drawing.Color.Black;
            this.gbFiltro.Location = new System.Drawing.Point(12, 11);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.gbFiltro.Size = new System.Drawing.Size(682, 60);
            this.gbFiltro.TabIndex = 13;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = " Filtro ";
            // 
            // mtbCasa
            // 
            this.mtbCasa.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCasa.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCasa.Location = new System.Drawing.Point(459, 22);
            this.mtbCasa.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCasa.Mask = "0000000";
            this.mtbCasa.Name = "mtbCasa";
            this.mtbCasa.Size = new System.Drawing.Size(31, 22);
            this.mtbCasa.TabIndex = 4;
            this.mtbCasa.Tag = "";
            this.mtbCasa.ValidatingType = typeof(int);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(573, 22);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(94, 22);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.TabStop = false;
            this.cbStatus.Tag = "";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lblCasa
            // 
            this.lblCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa.ForeColor = System.Drawing.Color.Black;
            this.lblCasa.Location = new System.Drawing.Point(422, 25);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(33, 14);
            this.lblCasa.TabIndex = 12;
            this.lblCasa.Text = "Casa";
            // 
            // mtbCalcao
            // 
            this.mtbCalcao.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCalcao.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbCalcao.Location = new System.Drawing.Point(335, 22);
            this.mtbCalcao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCalcao.Name = "mtbCalcao";
            this.mtbCalcao.Size = new System.Drawing.Size(57, 22);
            this.mtbCalcao.TabIndex = 3;
            this.mtbCalcao.Tag = "";
            // 
            // mtbId
            // 
            this.mtbId.BackColor = System.Drawing.SystemColors.Control;
            this.mtbId.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbId.Location = new System.Drawing.Point(55, 22);
            this.mtbId.Margin = new System.Windows.Forms.Padding(2);
            this.mtbId.Mask = "0000000";
            this.mtbId.Name = "mtbId";
            this.mtbId.Size = new System.Drawing.Size(31, 22);
            this.mtbId.TabIndex = 1;
            this.mtbId.Tag = "";
            this.mtbId.ValidatingType = typeof(int);
            // 
            // mtbAluguel
            // 
            this.mtbAluguel.BackColor = System.Drawing.SystemColors.Control;
            this.mtbAluguel.Font = new System.Drawing.Font("Calibri", 9F);
            this.mtbAluguel.Location = new System.Drawing.Point(203, 22);
            this.mtbAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbAluguel.Name = "mtbAluguel";
            this.mtbAluguel.Size = new System.Drawing.Size(57, 22);
            this.mtbAluguel.TabIndex = 2;
            this.mtbAluguel.Tag = "";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(527, 25);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 14);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblVlAluguel
            // 
            this.lblVlAluguel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVlAluguel.AutoSize = true;
            this.lblVlAluguel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlAluguel.ForeColor = System.Drawing.Color.Black;
            this.lblVlAluguel.Location = new System.Drawing.Point(102, 25);
            this.lblVlAluguel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVlAluguel.Name = "lblVlAluguel";
            this.lblVlAluguel.Size = new System.Drawing.Size(97, 14);
            this.lblVlAluguel.TabIndex = 4;
            this.lblVlAluguel.Text = "Valor do Aluguel";
            // 
            // lblVlCalcao
            // 
            this.lblVlCalcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVlCalcao.AutoSize = true;
            this.lblVlCalcao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlCalcao.ForeColor = System.Drawing.Color.Black;
            this.lblVlCalcao.Location = new System.Drawing.Point(288, 25);
            this.lblVlCalcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVlCalcao.Name = "lblVlCalcao";
            this.lblVlCalcao.Size = new System.Drawing.Size(43, 14);
            this.lblVlCalcao.TabIndex = 1;
            this.lblVlCalcao.Text = "Calção";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(7, 25);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 14);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Código";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(568, 391);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(71, 23);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.TabStop = false;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // idQuartoDataGridViewTextBoxColumn
            // 
            this.idQuartoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idQuartoDataGridViewTextBoxColumn.DataPropertyName = "IdQuarto";
            this.idQuartoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idQuartoDataGridViewTextBoxColumn.Name = "idQuartoDataGridViewTextBoxColumn";
            this.idQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlAluguelDataGridViewTextBoxColumn
            // 
            this.vlAluguelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vlAluguelDataGridViewTextBoxColumn.DataPropertyName = "VlAluguel";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.vlAluguelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.vlAluguelDataGridViewTextBoxColumn.HeaderText = "Aluguel";
            this.vlAluguelDataGridViewTextBoxColumn.Name = "vlAluguelDataGridViewTextBoxColumn";
            this.vlAluguelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlCalcaoDataGridViewTextBoxColumn
            // 
            this.vlCalcaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vlCalcaoDataGridViewTextBoxColumn.DataPropertyName = "VlCalcao";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.vlCalcaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vlCalcaoDataGridViewTextBoxColumn.HeaderText = "Calção";
            this.vlCalcaoDataGridViewTextBoxColumn.Name = "vlCalcaoDataGridViewTextBoxColumn";
            this.vlCalcaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkCasaDataGridViewTextBoxColumn
            // 
            this.fkCasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fkCasaDataGridViewTextBoxColumn.DataPropertyName = "FkCasa";
            this.fkCasaDataGridViewTextBoxColumn.HeaderText = "Casa";
            this.fkCasaDataGridViewTextBoxColumn.Name = "fkCasaDataGridViewTextBoxColumn";
            this.fkCasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // columnEditar
            // 
            this.columnEditar.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.columnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEditar.HeaderText = "Editar";
            this.columnEditar.Name = "columnEditar";
            this.columnEditar.ReadOnly = true;
            this.columnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnEditar.Text = "Editar";
            this.columnEditar.UseColumnTextForLinkValue = true;
            // 
            // columnRemover
            // 
            this.columnRemover.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.columnRemover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnRemover.HeaderText = "Remover";
            this.columnRemover.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.columnRemover.Name = "columnRemover";
            this.columnRemover.ReadOnly = true;
            this.columnRemover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnRemover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnRemover.Text = "Remover";
            this.columnRemover.UseColumnTextForLinkValue = true;
            // 
            // ucQueryQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dgvQuarto);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbFiltro);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "ucQueryQuarto";
            this.Size = new System.Drawing.Size(802, 425);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvQuarto;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.MaskedTextBox mtbId;
        private System.Windows.Forms.MaskedTextBox mtbAluguel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVlAluguel;
        private System.Windows.Forms.Label lblVlCalcao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MaskedTextBox mtbCalcao;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.MaskedTextBox mtbCasa;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlAluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlCalcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
        private System.Windows.Forms.DataGridViewLinkColumn columnEditar;
        private System.Windows.Forms.DataGridViewLinkColumn columnRemover;
    }
}
