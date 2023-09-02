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
    public partial class AddEditRentalRecord : System.Windows.Forms.Form
    {
        // Every entity represented in the DB Diagram
        private bool isEditMode;
        private ManageRentalRecords _manageRentalRecords;
        private readonly CarRentalEntities _db;
        public AddEditRentalRecord(ManageRentalRecords manageRentalRecords = null)
        {
            InitializeComponent();
            Text = "Add new Rental Record";
            lbl_title.Text = "Add New Record";
            isEditMode = false;
            _manageRentalRecords = manageRentalRecords;
            _db = new CarRentalEntities();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit, ManageRentalRecords manageRentalRecords = null)
        {
            InitializeComponent();
            Text = "Edit Rental Record";
            lbl_title.Text = "Edit rental record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please, ensure that you selected a valid record to edit.");
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                _manageRentalRecords = manageRentalRecords;
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dtDateRented.Value = (DateTime)recordToEdit.DateRented;
            dtDateReturned.Value = (DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                DateTime dateRented = dtDateRented.Value;
                DateTime dateReturned = dtDateReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);
                var carType = cbCarType.Text;
                var isValid = true;
                var errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please, enter missing data.\n\r";
                }

                if (dateRented > dateReturned)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal date selection.\n\r";
                }

                // if(isValid == true)
                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        // If in edit mode, then get the ID and retrieve the record from the database
                        // and place the result in the record object:
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);                        
                    }
                    // Populate record object with values from the form:
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.DateRented = dateRented;
                    rentalRecord.DateReturned = dateReturned;
                    rentalRecord.TypeOfCarId = (int)cbCarType.SelectedValue;
                    // If not in edit mode, then add the record object to the database:
                    if (!isEditMode)
                    {
                        _db.CarRentalRecords.Add(rentalRecord);
                    }
                    // Save changes made to the entity:
                    _db.SaveChanges();
                    MessageBox.Show($"Customer name: {customerName}\n\r" +
                        $"Date rented: {dateRented}\n\r" +
                        $"Date returned: {dateReturned}\n\r" +
                        $"Type of car: {carType}\n\r" +
                        $"Cost: {cost}\n\r\n\r" +
                        $"Thank you for your bussiness!");
                        Close();
                    _manageRentalRecords.PopulateGrid();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw; // 
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Native C# but the library is called LINQ:
            // select * from TypesOfCars
            var cars = _db.TypesOfCars
                .Select(q => new { TypeOfCar = q.Make + " " + q.Model, Id = q.Id }).ToList();
            // DisplayMember: display the name:
            cbCarType.DisplayMember = "TypeOfCar";
            // ValueMember: store the id:
            cbCarType.ValueMember = "Id";
            // DataSource: the source for the combo box comes from cars:
            cbCarType.DataSource = cars;
        }
        
    }
}
