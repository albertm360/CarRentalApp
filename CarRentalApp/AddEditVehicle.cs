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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditVehicle()
        {
            InitializeComponent();
            lbl_title.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypesOfCar carToEdit)
        {
            InitializeComponent();
            lbl_title.Text = "Edit Vehicle";
            isEditMode = true;
            _db = new CarRentalEntities();
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypesOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicensePlateNumber.Text = car.LicensePlateNumber;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                try
                {
                    // Edit code here
                    var id = int.Parse(lblId.Text);
                    var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                    car.Make = tbMake.Text;
                    car.Model = tbModel.Text;
                    car.VIN = tbVIN.Text;
                    car.Year = int.Parse(tbYear.Text);
                    car.LicensePlateNumber = tbLicensePlateNumber.Text;

                    _db.SaveChanges();
                    MessageBox.Show("Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    // Add code here
                    var newCar = new TypesOfCar
                    {
                        Make = tbMake.Text,
                        Model = tbModel.Text,
                        VIN = tbVIN.Text,
                        Year = int.Parse(tbYear.Text),
                        LicensePlateNumber = tbLicensePlateNumber.Text,
                    };

                    _db.TypesOfCars.Add(newCar);
                    _db.SaveChanges();
                    MessageBox.Show("Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
