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
    public partial class AddRentalRecord : System.Windows.Forms.Form
    {
        // Every entity represented in the DB Diagram
        private readonly CarRentalEntities carRentalEntities;
        public AddRentalRecord()
        {
            InitializeComponent();
            // Initialize a new instance of CarRentalEntities:
            carRentalEntities = new CarRentalEntities();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
                    // Instantiate a new object of the CarRentalRecord table:
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customerName;
                    // You can also do implicit casts to variables to convert to another type.
                    // Instead of:
                    // rentalRecord.Cost = Convert.ToDecimal(cost);
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.DateRented = dateRented;
                    rentalRecord.DateReturned = dateReturned;
                    rentalRecord.TypeOfCarId = (int)cbCarType.SelectedValue;
                    
                    // Adds the content of rentalRecord to the database:
                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    // But nothing gets registered until you save the changes:
                    carRentalEntities.SaveChanges();

                    MessageBox.Show($"Customer name: {customerName}\n\r" +
                        $"Date rented: {dateRented}\n\r" +
                        $"Date returned: {dateReturned}\n\r" +
                        $"Type of car: {carType}\n\r" +
                        $"Cost: {cost}\n\r\n\r" +
                        $"Thank you for your bussiness!");

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
            var cars = carRentalEntities.TypesOfCars.ToList();
            // DisplayMember: display the name:
            cbCarType.DisplayMember = "name";
            // ValueMember: store the id:
            cbCarType.ValueMember = "id";
            // DataSource: the source for the combo box comes from cars:
            cbCarType.DataSource = cars;
        }
        
    }
}
