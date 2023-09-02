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
        private Login _login;
        public User _User;
        public string _roleName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _User = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.short_name;
        }

        private void btnCarRentalSystem_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord rentalRecord = new AddEditRentalRecord();
            rentalRecord.Show();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog(); // Doesn't allow Mdichild.
            //addRentalRecord.MdiParent = this;
            //addRentalRecord.WindowState = FormWindowState.Maximized;

        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // See what forms are open and check if the one we are trying to open
            // is already opened. If not, open it.
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");
            if (!isOpen)
            {
                ManageVehicleListing vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.WindowState = FormWindowState.Maximized;
                vehicleListing.Show();                
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
            manageRentalRecords.WindowState = FormWindowState.Maximized;
            manageRentalRecords.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageUsers");
            if (!isOpen)
            {
                ManageUsers manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.WindowState = FormWindowState.Maximized;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_User.password == Utils.DefaultHashedPassword())
            {
                var resetPassword = new ResetPassword(_User);
                resetPassword.ShowDialog();
            }

            var username = _User.username;
            tsiLoginText.Text = $"Logged in as: {username}";
            if(_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Enabled = false;
            }
        }
    }
}
