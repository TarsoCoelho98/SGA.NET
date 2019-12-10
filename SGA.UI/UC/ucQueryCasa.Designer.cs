namespace SGA.UI.UC
{
    partial class ucQueryCasa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.lblQueryLocatario = new System.Windows.Forms.Label();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.mtbId = new System.Windows.Forms.MaskedTextBox();
            this.mtbBairro = new System.Windows.Forms.MaskedTextBox();
            this.mtbRua = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCasa = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesign
            // 
            this.pnlDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesign.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlDesign.Location = new System.Drawing.Point(3, 29);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(689, 1);
            this.pnlDesign.TabIndex = 0;
            // 
            // lblQueryLocatario
            // 
            this.lblQueryLocatario.AutoSize = true;
            this.lblQueryLocatario.BackColor = System.Drawing.Color.Maroon;
            this.lblQueryLocatario.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblQueryLocatario.ForeColor = System.Drawing.Color.White;
            this.lblQueryLocatario.Location = new System.Drawing.Point(3, 2);
            this.lblQueryLocatario.Name = "lblQueryLocatario";
            this.lblQueryLocatario.Size = new System.Drawing.Size(151, 23);
            this.lblQueryLocatario.TabIndex = 1;
            this.lblQueryLocatario.Text = "Consulta de Casas";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltro.Controls.Add(this.mtbId);
            this.gbFiltro.Controls.Add(this.mtbBairro);
            this.gbFiltro.Controls.Add(this.mtbRua);
            this.gbFiltro.Controls.Add(this.mtbCep);
            this.gbFiltro.Controls.Add(this.lblCep);
            this.gbFiltro.Controls.Add(this.lblBairro);
            this.gbFiltro.Controls.Add(this.lblRua);
            this.gbFiltro.Controls.Add(this.lblId);
            this.gbFiltro.Font = new System.Drawing.Font("Calibri", 9F);
            this.gbFiltro.Location = new System.Drawing.Point(5, 35);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltro.Size = new System.Drawing.Size(607, 55);
            this.gbFiltro.TabIndex = 2;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // mtbId
            // 
            this.mtbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbId.Location = new System.Drawing.Point(55, 18);
            this.mtbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbId.Mask = "0000000";
            this.mtbId.Name = "mtbId";
            this.mtbId.Size = new System.Drawing.Size(31, 22);
            this.mtbId.TabIndex = 10;
            this.mtbId.ValidatingType = typeof(int);
            // 
            // mtbBairro
            // 
            this.mtbBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbBairro.Location = new System.Drawing.Point(147, 18);
            this.mtbBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbBairro.Name = "mtbBairro";
            this.mtbBairro.Size = new System.Drawing.Size(139, 22);
            this.mtbBairro.TabIndex = 9;
            // 
            // mtbRua
            // 
            this.mtbRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbRua.Location = new System.Drawing.Point(336, 18);
            this.mtbRua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbRua.Name = "mtbRua";
            this.mtbRua.Size = new System.Drawing.Size(136, 22);
            this.mtbRua.TabIndex = 8;
            // 
            // mtbCep
            // 
            this.mtbCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCep.Location = new System.Drawing.Point(531, 18);
            this.mtbCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(58, 22);
            this.mtbCep.TabIndex = 5;
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(502, 20);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(25, 14);
            this.lblCep.TabIndex = 5;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(107, 21);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 14);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(304, 20);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(28, 14);
            this.lblRua.TabIndex = 1;
            this.lblRua.Text = "Rua";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 20);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 14);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Código";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(616, 41);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 22);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvCasa
            // 
            this.dgvCasa.AllowUserToAddRows = false;
            this.dgvCasa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            this.dgvCasa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCasa.AutoGenerateColumns = false;
            this.dgvCasa.BackgroundColor = System.Drawing.Color.White;
            this.dgvCasa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCasaDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.Editar,
            this.Excluir});
            this.dgvCasa.DataSource = this.casaBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCasa.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCasa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCasa.Location = new System.Drawing.Point(0, 100);
            this.dgvCasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCasa.Name = "dgvCasa";
            this.dgvCasa.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Bisque;
            this.dgvCasa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCasa.Size = new System.Drawing.Size(694, 297);
            this.dgvCasa.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(616, 68);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 22);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.DataPropertyName = "Observacao";
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar Item";
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Excluir.DataPropertyName = "Observacao";
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir Item";
            // 
            // idCasaDataGridViewTextBoxColumn
            // 
            this.idCasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCasaDataGridViewTextBoxColumn.DataPropertyName = "IdCasa";
            this.idCasaDataGridViewTextBoxColumn.HeaderText = "Casa";
            this.idCasaDataGridViewTextBoxColumn.Name = "idCasaDataGridViewTextBoxColumn";
            this.idCasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casaBindingSource
            // 
            this.casaBindingSource.DataSource = typeof(SGA.DAL.Entity.Casa);
            // 
            // ucQueryCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCasa);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.lblQueryLocatario);
            this.Controls.Add(this.pnlDesign);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "ucQueryCasa";
            this.Size = new System.Drawing.Size(694, 397);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Label lblQueryLocatario;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mtbId;
        private System.Windows.Forms.MaskedTextBox mtbBairro;
        private System.Windows.Forms.MaskedTextBox mtbRua;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.DataGridView dgvCasa;
        private System.Windows.Forms.BindingSource casaBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}
