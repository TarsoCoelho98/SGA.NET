namespace SGA.UI
{
    partial class frmInsertCasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertCasa));
            this.ucInsertCasa1 = new SGA.UI.UC.ucInsertCasa();
            this.SuspendLayout();
            // 
            // ucInsertCasa1
            // 
            this.ucInsertCasa1.BackColor = System.Drawing.Color.White;
            this.ucInsertCasa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInsertCasa1.Location = new System.Drawing.Point(0, 0);
            this.ucInsertCasa1.Name = "ucInsertCasa1";
            this.ucInsertCasa1.Size = new System.Drawing.Size(476, 241);
            this.ucInsertCasa1.TabIndex = 0;
            // 
            // frmInsertCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 241);
            this.Controls.Add(this.ucInsertCasa1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmInsertCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Casa";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucInsertCasa ucInsertCasa1;
    }
}