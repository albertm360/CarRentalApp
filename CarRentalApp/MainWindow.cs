using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCarRentalSystem_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord rentalRecord = new AddEditRentalRecord();
            rentalRecord.Show();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this;
            addRentalRecord.WindowState = FormWindowState.Maximized;
            addRentalRecord.Show();
            
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVehicleListing vehicleListing = new ManageVehicleListing();
            vehicleListing.MdiParent = this;
            vehicleListing.WindowState = FormWindowState.Maximized;
            vehicleListing.Show();
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
            manageRentalRecords.WindowState = FormWindowState.Maximized;
            manageRentalRecords.Show();
        }
    }
}
