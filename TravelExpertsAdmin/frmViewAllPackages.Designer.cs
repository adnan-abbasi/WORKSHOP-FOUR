namespace TravelExpertsAdmin
{
    partial class frmViewAllPackages
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
            this.GridViewAllPkg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAllPkg)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewAllPkg
            // 
            this.GridViewAllPkg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewAllPkg.BackgroundColor = System.Drawing.Color.Snow;
            this.GridViewAllPkg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewAllPkg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GridViewAllPkg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAllPkg.Location = new System.Drawing.Point(66, -2);
            this.GridViewAllPkg.Name = "GridViewAllPkg";
            this.GridViewAllPkg.ReadOnly = true;
            this.GridViewAllPkg.RowTemplate.Height = 28;
            this.GridViewAllPkg.Size = new System.Drawing.Size(1375, 561);
            this.GridViewAllPkg.TabIndex = 0;
            this.GridViewAllPkg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmViewAllPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 589);
            this.Controls.Add(this.GridViewAllPkg);
            this.Name = "frmViewAllPackages";
            this.Text = "Packages View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAllPkg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewAllPkg;
    }
}

