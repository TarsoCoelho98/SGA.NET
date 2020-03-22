namespace SGA.UI
{
    partial class frmInsertQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertQuarto));
            this.ucInsertQuarto1 = new SGA.UI.UC.ucInsertQuarto();
            this.SuspendLayout();
            // 
            // ucInsertQuarto1
            // 
            this.ucInsertQuarto1.BackColor = System.Drawing.Color.White;
            this.ucInsertQuarto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInsertQuarto1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucInsertQuarto1.Location = new System.Drawing.Point(0, 0);
            this.ucInsertQuarto1.Name = "ucInsertQuarto1";
            this.ucInsertQuarto1.Size = new System.Drawing.Size(442, 174);
            this.ucInsertQuarto1.TabIndex = 0;
            // 
            // frmInsertQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 174);
            this.Controls.Add(this.ucInsertQuarto1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmInsertQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Quarto";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucInsertQuarto ucInsertQuarto1;
    }
}