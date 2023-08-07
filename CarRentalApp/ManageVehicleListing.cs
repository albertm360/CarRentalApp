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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            // This is like doing: SELECT * FROM TypesOfCars:
            // var cars = _db.TypesOfCars.ToList();
            // This is like doing: SELECT Id as CardId, Name as CarName from TypesofCars:
            var cars = _db.TypesOfCars
                .Select(q => new { CarId = q.Id, CarMake = q.Make, CarModel = q.Model, CarVIN = q.VIN, LicensePlate = q.LicensePlateNumber, Year = q.Year})
                .ToList(); 
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[1].HeaderText = "Make";        
            gvVehicleList.Columns[2].HeaderText = "Model";        
            gvVehicleList.Columns[3].HeaderText = "VIN";        
            gvVehicleList.Columns[4].HeaderText = "License Plate";        
            gvVehicleList.Columns[5].HeaderText = "Year";        
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}
