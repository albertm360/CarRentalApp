namespace CarRentalApp
{
    partial class AddEditRentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dtDateRented = new System.Windows.Forms.DateTimePicker();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.dtDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(206, 8);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(287, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Rental Record";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(9, 117);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(188, 26);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(5, 93);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(127, 21);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // dtDateRented
            // 
            this.dtDateRented.CalendarFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateRented.Location = new System.Drawing.Point(13, 195);
            this.dtDateRented.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDateRented.Name = "dtDateRented";
            this.dtDateRented.Size = new System.Drawing.Size(188, 20);
            this.dtDateRented.TabIndex = 3;
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRented.Location = new System.Drawing.Point(9, 171);
            this.lblDateRented.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(109, 21);
            this.lblDateRented.TabIndex = 4;
            this.lblDateRented.Text = "Date rented";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(247, 171);
            this.lblDateReturned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(127, 21);
            this.lblDateReturned.TabIndex = 6;
            this.lblDateReturned.Text = "Date returned";
            // 
            // dtDateReturned
            // 
            this.dtDateReturned.CalendarFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateReturned.Location = new System.Drawing.Point(250, 195);
            this.dtDateReturned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDateReturned.Name = "dtDateReturned";
            this.dtDateReturned.Size = new System.Drawing.Size(192, 20);
            this.dtDateReturned.TabIndex = 5;
            // 
            // cbCarType
            // 
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(13, 275);
            this.cbCarType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(188, 29);
            this.cbCarType.TabIndex = 7;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarType.Location = new System.Drawing.Point(9, 251);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(82, 21);
            this.lblCarType.TabIndex = 8;
            this.lblCarType.Text = "Car Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(250, 267);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(188, 43);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(250, 117);
            this.tbCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(188, 26);
            this.tbCost.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(247, 93);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 21);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(39, 43);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 13);
            this.lblRecordId.TabIndex = 12;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 368);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.dtDateReturned);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.dtDateRented);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DateTimePicker dtDateRented;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.DateTimePicker dtDateReturned;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblRecordId;
    }
}

