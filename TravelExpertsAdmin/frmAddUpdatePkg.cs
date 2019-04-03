using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsAdmin
{
    public partial class frmAddUpdatePkg : Form
    {

        Packages singlePkg;
        Packages newPackage;
        public frmAddUpdatePkg()
        {
            InitializeComponent();
        }

        //Validate All user inputs if all Validate send the Class object with validate values set, to the caller

        public bool ValidateAllInputFields()
        {

            newPackage = new Packages();
            if (Validator.IsPresent(comPackageId)&&
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtBasePrice) &&

                Validator.IsDecimal(txtBasePrice) &&
                Validator.IsDecimal(txtAgencyCommission)&&
                Validator.IsvalidDate(txtStartDate)&&
                Validator.IsvalidDate(txtEndDate)
                //check the date validation here
                )
            {
                newPackage.PkgId = (int)comPackageId.SelectedValue;
                newPackage.PkgName = txtName.Text;
                newPackage.PkgSartDate = txtStartDate.Text;
                newPackage.PkgEndDate = txtEndDate.Text;
                newPackage.PkgDescription = txtDescrip.Text;
                newPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                newPackage.PkgAgencyCommition = Convert.ToDecimal(txtAgencyCommission.Text);
                return true;

            }
            else

                return false;


        }

        // To Enable Editing   
      private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            //txtStartDate.ReadOnly = false;
            txtEndDate.ReadOnly = false;
            txtDescrip.ReadOnly = false;
            txtBasePrice.ReadOnly = false;
            txtAgencyCommission.ReadOnly = false;
            btnDone.Visible = true;

        }
        // To Udate the Changes in the records
        private void btnDone_Click(object sender, EventArgs e)
        {
          

            if (ValidateAllInputFields())
            {
                bool success = false;// To verifiy that data was successfully updated.

                //CALL TO UPDATE METHOD WHERE singlePkg contains the values currently in databse
                //and newPackage contains editied values.
                success = PackagesDB.UpdatePackage(singlePkg, newPackage);
            if (success)
                {
                    MessageBox.Show("Selected Pacakges has been Updated Successfully");
                }
            }
            //else
            //    MessageBox.Show("There are some Input Errors");
            btnDone.Visible = false;
            //to Reload the form if you want to keep editing .

            frmAddUpdatePkg_Load(btnDone, null);
        }

        






        // AT THE TIME OF FORM LOAD EVENT LOAD THE PACKAGE DETAIL FOR THE USER
        private void frmAddUpdatePkg_Load(object sender, EventArgs e)
        {

            comPackageId.DataSource = PackagesDB.GetAllPacakgeIds();
           

        }

        private void comPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            singlePkg = PackagesDB.GetPackageById((int)comPackageId.SelectedValue);

            txtName.Text = singlePkg.PkgName;
            txtStartDate.Text = singlePkg.PkgSartDate;
            txtEndDate.Text = singlePkg.PkgEndDate;
            txtDescrip.Text = singlePkg.PkgDescription;
            txtBasePrice.Text = singlePkg.PkgBasePrice.ToString();
            txtAgencyCommission.Text = singlePkg.PkgAgencyCommition.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comPackageId.Visible = false;
            btnDone.Visible = false;
            btnEdit.Visible = false;
            lblSelectPackage.Visible = false;

            lblAddmessage.Visible = true;
            btnAddThisPkg.Visible = true;

            txtName.Text = "";
            txtDescrip.Text = "";
            txtBasePrice.Text = "";
            txtEndDate.Text = "";
            txtStartDate.Text = "";
            txtAgencyCommission.Text = "";
            txtName.ReadOnly = false;
            txtStartDate.ReadOnly = false;
            txtEndDate.ReadOnly = false;
            txtDescrip.ReadOnly = false;
            txtBasePrice.ReadOnly = false;
            txtAgencyCommission.ReadOnly = false;

        }

        private void btnAddThisPkg_Click(object sender, EventArgs e)
        {

            //First we will check that all requied input fields have valid data and then we will add the new package.
            if (ValidateAllInputFields())
            {
                bool success = false;// To verifiy that data was successfully updated.

                //CALL TO UPDATE METHOD WHERE singlePkg contains the values currently in databse
                //and newPackage contains editied values.
                success = PackagesDB.AddNewPackage(newPackage);
                if (success)
                {
                    MessageBox.Show("New  Pacakges has been Added Successfully");
                }
            }
            //else
            //    MessageBox.Show("There are some Input Errors");
            btnAddThisPkg.Visible = true;
            //to Reload the form if you want to keep editing .

           // frmAddUpdatePkg_Load(btnDone, null);
        }

        // use this to validate the postal code.

        //private void txtpostalcode_Validating(object sender, CancelEventArgs e)
        //{
        //    TextBox tb = (TextBox)sender;
        //    if ((tb.Text).Length != 6)
        //    {
        //        MessageBox.Show("Postal code must be 6 characters");
        //        tb.SelectAll();// to select the wrong entry so that when we will start typing again it will be repalced.
        //        tb.Focus();
        //    }
        //    else
        //    {
        //        // we have six cahracter lets check pattrent.
        //        Regex pattren = new Regex("[a-zA-z][0-9]{3}"); //
        //        if (!pattren.IsMatch(tb.Text))
        //        {
        //            MessageBox.Show("Postal code must have Format T3H6Y7");
        //            tb.SelectAll();
        //            tb.Focus();
        //        }
        //    }
        //}

    }
}
