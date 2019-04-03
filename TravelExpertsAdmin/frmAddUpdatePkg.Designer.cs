namespace TravelExpertsAdmin
{
    partial class frmAddUpdatePkg
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
            this.PkggroupBox = new System.Windows.Forms.GroupBox();
            this.PkgFieldgroupBox = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblSelectPackage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comPackageId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddThisPkg = new System.Windows.Forms.Button();
            this.lblAddmessage = new System.Windows.Forms.Label();
            this.PkggroupBox.SuspendLayout();
            this.PkgFieldgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PkggroupBox
            // 
            this.PkggroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PkggroupBox.Controls.Add(this.PkgFieldgroupBox);
            this.PkggroupBox.Location = new System.Drawing.Point(107, 31);
            this.PkggroupBox.Name = "PkggroupBox";
            this.PkggroupBox.Size = new System.Drawing.Size(747, 598);
            this.PkggroupBox.TabIndex = 0;
            this.PkggroupBox.TabStop = false;
            this.PkggroupBox.Text = "Package Data";
            // 
            // PkgFieldgroupBox
            // 
            this.PkgFieldgroupBox.Controls.Add(this.lblAddmessage);
            this.PkgFieldgroupBox.Controls.Add(this.btnAddThisPkg);
            this.PkgFieldgroupBox.Controls.Add(this.btnAdd);
            this.PkgFieldgroupBox.Controls.Add(this.btnExit);
            this.PkgFieldgroupBox.Controls.Add(this.btnEdit);
            this.PkgFieldgroupBox.Controls.Add(this.btnDone);
            this.PkgFieldgroupBox.Controls.Add(this.txtAgencyCommission);
            this.PkgFieldgroupBox.Controls.Add(this.txtBasePrice);
            this.PkgFieldgroupBox.Controls.Add(this.txtDescrip);
            this.PkgFieldgroupBox.Controls.Add(this.txtEndDate);
            this.PkgFieldgroupBox.Controls.Add(this.txtStartDate);
            this.PkgFieldgroupBox.Controls.Add(this.lblSelectPackage);
            this.PkgFieldgroupBox.Controls.Add(this.txtName);
            this.PkgFieldgroupBox.Controls.Add(this.label2);
            this.PkgFieldgroupBox.Controls.Add(this.comPackageId);
            this.PkgFieldgroupBox.Controls.Add(this.label3);
            this.PkgFieldgroupBox.Controls.Add(this.label7);
            this.PkgFieldgroupBox.Controls.Add(this.label4);
            this.PkgFieldgroupBox.Controls.Add(this.label6);
            this.PkgFieldgroupBox.Controls.Add(this.label5);
            this.PkgFieldgroupBox.Location = new System.Drawing.Point(27, 29);
            this.PkgFieldgroupBox.Name = "PkgFieldgroupBox";
            this.PkgFieldgroupBox.Size = new System.Drawing.Size(701, 529);
            this.PkgFieldgroupBox.TabIndex = 9;
            this.PkgFieldgroupBox.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(551, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(38, 456);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(180, 456);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(140, 36);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Update";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.Location = new System.Drawing.Point(308, 350);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.ReadOnly = true;
            this.txtAgencyCommission.Size = new System.Drawing.Size(393, 30);
            this.txtAgencyCommission.TabIndex = 7;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(308, 300);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(393, 30);
            this.txtBasePrice.TabIndex = 6;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(308, 250);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.ReadOnly = true;
            this.txtDescrip.Size = new System.Drawing.Size(393, 30);
            this.txtDescrip.TabIndex = 5;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(308, 200);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(393, 30);
            this.txtEndDate.TabIndex = 4;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(308, 150);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(393, 30);
            this.txtStartDate.TabIndex = 3;
            // 
            // lblSelectPackage
            // 
            this.lblSelectPackage.AutoSize = true;
            this.lblSelectPackage.Location = new System.Drawing.Point(21, 50);
            this.lblSelectPackage.Name = "lblSelectPackage";
            this.lblSelectPackage.Size = new System.Drawing.Size(268, 25);
            this.lblSelectPackage.TabIndex = 9;
            this.lblSelectPackage.Text = "Select a Package For Editing ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(308, 100);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(393, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = " Name";
            // 
            // comPackageId
            // 
            this.comPackageId.FormattingEnabled = true;
            this.comPackageId.Location = new System.Drawing.Point(577, 50);
            this.comPackageId.Name = "comPackageId";
            this.comPackageId.Size = new System.Drawing.Size(121, 33);
            this.comPackageId.TabIndex = 1;
            this.comPackageId.Tag = "Package ID";
            this.comPackageId.SelectedIndexChanged += new System.EventHandler(this.comPackageId_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = " Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Agency Commission";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = " End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(404, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddThisPkg
            // 
            this.btnAddThisPkg.Location = new System.Drawing.Point(551, 414);
            this.btnAddThisPkg.Name = "btnAddThisPkg";
            this.btnAddThisPkg.Size = new System.Drawing.Size(140, 36);
            this.btnAddThisPkg.TabIndex = 12;
            this.btnAddThisPkg.Text = "Add Package";
            this.btnAddThisPkg.UseVisualStyleBackColor = true;
            this.btnAddThisPkg.Visible = false;
            this.btnAddThisPkg.Click += new System.EventHandler(this.btnAddThisPkg_Click);
            // 
            // lblAddmessage
            // 
            this.lblAddmessage.AutoSize = true;
            this.lblAddmessage.Location = new System.Drawing.Point(175, 13);
            this.lblAddmessage.Name = "lblAddmessage";
            this.lblAddmessage.Size = new System.Drawing.Size(308, 25);
            this.lblAddmessage.TabIndex = 13;
            this.lblAddmessage.Text = "Enter information for new Package";
            this.lblAddmessage.Visible = false;
            // 
            // frmAddUpdatePkg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 668);
            this.Controls.Add(this.PkggroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddUpdatePkg";
            this.Text = "Package ADD/UPDATE";
            this.Load += new System.EventHandler(this.frmAddUpdatePkg_Load);
            this.PkggroupBox.ResumeLayout(false);
            this.PkgFieldgroupBox.ResumeLayout(false);
            this.PkgFieldgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PkggroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox PkgFieldgroupBox;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblSelectPackage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comPackageId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddThisPkg;
        private System.Windows.Forms.Label lblAddmessage;
    }
}