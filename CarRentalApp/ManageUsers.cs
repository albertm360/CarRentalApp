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
    public partial class ManageUsers: Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = _db.Users.
                Select(q => new
                {
                    q.id,
                    q.username,
                    q.isActive,
                    RoleName = q.UserRoles.FirstOrDefault().Role.name
                })
                .ToList();
            gvUserList.DataSource = users;
            gvUserList.Columns[0].Visible = false;
            gvUserList.Columns[1].HeaderText = "Username";
            gvUserList.Columns[2].HeaderText = "Active";
            gvUserList.Columns[3].HeaderText = "Role";
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
                // Query database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                var hashedPassword = Utils.DefaultHashedPassword();
                user.password = hashedPassword;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s password has been reset!");
                PopulateGrid();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You must select the row from the first column.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
                // Query database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                user.isActive = user.isActive == true ? false : true;
                
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s active status has changed.");
                PopulateGrid();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You must select the row from the first column.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
