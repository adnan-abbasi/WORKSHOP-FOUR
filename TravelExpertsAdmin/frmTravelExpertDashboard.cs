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
    public partial class frmTravelExpertDashboard : Form
    {
        public frmTravelExpertDashboard()
        {
            InitializeComponent();
        }

        private void showAllPacakagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showAllPcakgeFrom = new frmViewAllPackages();
            
            showAllPcakgeFrom.ShowDialog();

        }

        private void addUpdatePackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showUpdatePakageForm = new frmAddUpdatePkg();
            showUpdatePakageForm.ShowDialog();
        }

        private void addUpdateSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
