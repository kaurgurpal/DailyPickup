namespace DailyPickup
{
    partial class frmManageVehicleRoutes
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
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnManageDrivers = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnManageVehicle = new System.Windows.Forms.Button();
            this.btnAssignRouteAndDriver = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblManufacturingYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSeatingCapacity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.cmbSubordinate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(121, 12);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(188, 21);
            this.cmbVehicle.TabIndex = 0;
            this.cmbVehicle.SelectedIndexChanged += new System.EventHandler(this.cmbVehicle_SelectedIndexChanged);
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(121, 141);
            this.txtRoute.Multiline = true;
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(244, 20);
            this.txtRoute.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Vehicle";
            // 
            // btnManageDrivers
            // 
            this.btnManageDrivers.Location = new System.Drawing.Point(287, 258);
            this.btnManageDrivers.Name = "btnManageDrivers";
            this.btnManageDrivers.Size = new System.Drawing.Size(113, 23);
            this.btnManageDrivers.TabIndex = 6;
            this.btnManageDrivers.Text = "Manage Drivers";
            this.btnManageDrivers.UseVisualStyleBackColor = true;
            this.btnManageDrivers.Click += new System.EventHandler(this.btnManageDrivers_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnManageVehicle
            // 
            this.btnManageVehicle.Location = new System.Drawing.Point(170, 258);
            this.btnManageVehicle.Name = "btnManageVehicle";
            this.btnManageVehicle.Size = new System.Drawing.Size(111, 23);
            this.btnManageVehicle.TabIndex = 5;
            this.btnManageVehicle.Text = "Manage Vehicle";
            this.btnManageVehicle.UseVisualStyleBackColor = true;
            this.btnManageVehicle.Click += new System.EventHandler(this.btnManageVehicle_Click);
            // 
            // btnAssignRouteAndDriver
            // 
            this.btnAssignRouteAndDriver.Location = new System.Drawing.Point(12, 258);
            this.btnAssignRouteAndDriver.Name = "btnAssignRouteAndDriver";
            this.btnAssignRouteAndDriver.Size = new System.Drawing.Size(149, 23);
            this.btnAssignRouteAndDriver.TabIndex = 4;
            this.btnAssignRouteAndDriver.Text = "Assign Route && Driver";
            this.btnAssignRouteAndDriver.UseVisualStyleBackColor = true;
            this.btnAssignRouteAndDriver.Click += new System.EventHandler(this.btnAssignRouteAndDriver_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(372, 85);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 43;
            this.lblCompany.Text = "Company";
            // 
            // lblManufacturingYear
            // 
            this.lblManufacturingYear.AutoSize = true;
            this.lblManufacturingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturingYear.Location = new System.Drawing.Point(166, 85);
            this.lblManufacturingYear.Name = "lblManufacturingYear";
            this.lblManufacturingYear.Size = new System.Drawing.Size(100, 13);
            this.lblManufacturingYear.TabIndex = 44;
            this.lblManufacturingYear.Text = "Manufacturing Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Subordinate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Driver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Route";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(372, 115);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(54, 13);
            this.lblFuelType.TabIndex = 49;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Fuel Type";
            // 
            // lblSeatingCapacity
            // 
            this.lblSeatingCapacity.AutoSize = true;
            this.lblSeatingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatingCapacity.Location = new System.Drawing.Point(166, 115);
            this.lblSeatingCapacity.Name = "lblSeatingCapacity";
            this.lblSeatingCapacity.Size = new System.Drawing.Size(87, 13);
            this.lblSeatingCapacity.TabIndex = 51;
            this.lblSeatingCapacity.Text = "Seating Capacity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Seating Capacity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Manufacturing Year";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(372, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 54;
            this.lblType.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(307, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Type";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelName.Location = new System.Drawing.Point(166, 51);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(67, 13);
            this.lblModelName.TabIndex = 56;
            this.lblModelName.Text = "Model Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Model Name";
            // 
            // cmbDriver
            // 
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(121, 179);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(188, 21);
            this.cmbDriver.TabIndex = 2;
            // 
            // cmbSubordinate
            // 
            this.cmbSubordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubordinate.FormattingEnabled = true;
            this.cmbSubordinate.Location = new System.Drawing.Point(121, 216);
            this.cmbSubordinate.Name = "cmbSubordinate";
            this.cmbSubordinate.Size = new System.Drawing.Size(188, 21);
            this.cmbSubordinate.TabIndex = 3;
            // 
            // frmManageVehicleRoutes
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(494, 295);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSubordinate);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSeatingCapacity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblManufacturingYear);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnManageDrivers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnManageVehicle);
            this.Controls.Add(this.btnAssignRouteAndDriver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageVehicleRoutes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicle Routes";
            this.Load += new System.EventHandler(this.frmManageVehicleRoutes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnManageDrivers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnManageVehicle;
        private System.Windows.Forms.Button btnAssignRouteAndDriver;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblManufacturingYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSeatingCapacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.ComboBox cmbSubordinate;
    }
}