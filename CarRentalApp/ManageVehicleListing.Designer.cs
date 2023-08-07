namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.lbl_titleManageVehicleListing = new System.Windows.Forms.Label();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(9, 98);
            this.gvVehicleList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.RowHeadersWidth = 51;
            this.gvVehicleList.RowTemplate.Height = 24;
            this.gvVehicleList.Size = new System.Drawing.Size(853, 258);
            this.gvVehicleList.TabIndex = 0;
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicles.Location = new System.Drawing.Point(9, 73);
            this.lblVehicles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(82, 21);
            this.lblVehicles.TabIndex = 3;
            this.lblVehicles.Text = "Vehicles";
            // 
            // lbl_titleManageVehicleListing
            // 
            this.lbl_titleManageVehicleListing.AutoSize = true;
            this.lbl_titleManageVehicleListing.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleManageVehicleListing.Location = new System.Drawing.Point(133, 7);
            this.lbl_titleManageVehicleListing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titleManageVehicleListing.Name = "lbl_titleManageVehicleListing";
            this.lbl_titleManageVehicleListing.Size = new System.Drawing.Size(367, 35);
            this.lbl_titleManageVehicleListing.TabIndex = 4;
            this.lbl_titleManageVehicleListing.Text = "Manage Vehicle Listing";
            this.lbl_titleManageVehicleListing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.Location = new System.Drawing.Point(13, 388);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(188, 43);
            this.btnAddNewCar.TabIndex = 10;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(674, 388);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(188, 43);
            this.btnDeleteCar.TabIndex = 11;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(336, 388);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(188, 43);
            this.btnEditCar.TabIndex = 12;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.lbl_titleManageVehicleListing);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.gvVehicleList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Label lbl_titleManageVehicleListing;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnEditCar;
    }
}