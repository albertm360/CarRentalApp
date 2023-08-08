﻿using System;
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
                .Select(q => new { q.Id, q.Make, q.Model, q.VIN, q.LicensePlateNumber, q.Year })
                .ToList(); 
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[0].Visible = false;
            gvVehicleList.Columns[1].HeaderText = "Make";        
            gvVehicleList.Columns[2].HeaderText = "Model";        
            gvVehicleList.Columns[3].HeaderText = "VIN";        
            gvVehicleList.Columns[4].HeaderText = "License Plate";        
            gvVehicleList.Columns[5].HeaderText = "Year";        
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            // We need to:
            // Get Id of selected row
            /// TODO: Implement RowIndex
            /// if (gvVehicleList.SelectedCells.Count > 0)
            //{
            //    var cell = gvVehicleList.SelectedCells[0];
            //    var row = gvVehicleList.Rows[cell.RowIndex];
            //    var id = (int)row.Cells["Id"].Value;
            //}
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            // Query database for record
            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

            // Launch AddEditVehicle window with data
            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            // Get Id of selected row
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            // Query database for record
            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

            // Delete vehicle from table
            _db.TypesOfCars.Remove(car);
            _db.SaveChanges();

            gvVehicleList.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Simple Refresh Option:
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvVehicleList.Columns["Id"].Visible = false;
        }
    }
}
