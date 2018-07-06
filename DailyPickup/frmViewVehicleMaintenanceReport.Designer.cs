namespace DailyPickup
{
    partial class frmViewVehicleMaintenanceReport
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
            this.dgvMaintenanceCharges = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maintenance_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maintenance_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSeatingCapacity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblManufacturingYear = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceCharges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaintenanceCharges
            // 
            this.dgvMaintenanceCharges.AllowUserToAddRows = false;
            this.dgvMaintenanceCharges.AllowUserToDeleteRows = false;
            this.dgvMaintenanceCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceCharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Maintenance_Description,
            this.Maintenance_Cost});
            this.dgvMaintenanceCharges.Location = new System.Drawing.Point(57, 154);
            this.dgvMaintenanceCharges.Name = "dgvMaintenanceCharges";
            this.dgvMaintenanceCharges.ReadOnly = true;
            this.dgvMaintenanceCharges.Size = new System.Drawing.Size(364, 270);
            this.dgvMaintenanceCharges.TabIndex = 99;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Maintenance_Description
            // 
            this.Maintenance_Description.DataPropertyName = "Maintenance_Description";
            this.Maintenance_Description.HeaderText = "Description";
            this.Maintenance_Description.Name = "Maintenance_Description";
            this.Maintenance_Description.ReadOnly = true;
            // 
            // Maintenance_Cost
            // 
            this.Maintenance_Cost.DataPropertyName = "Maintenance_Cost";
            this.Maintenance_Cost.HeaderText = "Charges";
            this.Maintenance_Cost.Name = "Maintenance_Cost";
            this.Maintenance_Cost.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Model Name";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelName.Location = new System.Drawing.Point(147, 55);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(67, 13);
            this.lblModelName.TabIndex = 97;
            this.lblModelName.Text = "Model Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 96;
            this.label14.Text = "Type";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(353, 55);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 95;
            this.lblType.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Manufacturing Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Seating Capacity";
            // 
            // lblSeatingCapacity
            // 
            this.lblSeatingCapacity.AutoSize = true;
            this.lblSeatingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatingCapacity.Location = new System.Drawing.Point(147, 119);
            this.lblSeatingCapacity.Name = "lblSeatingCapacity";
            this.lblSeatingCapacity.Size = new System.Drawing.Size(87, 13);
            this.lblSeatingCapacity.TabIndex = 92;
            this.lblSeatingCapacity.Text = "Seating Capacity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "Fuel Type";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(353, 119);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(54, 13);
            this.lblFuelType.TabIndex = 90;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Company";
            // 
            // lblManufacturingYear
            // 
            this.lblManufacturingYear.AutoSize = true;
            this.lblManufacturingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturingYear.Location = new System.Drawing.Point(147, 89);
            this.lblManufacturingYear.Name = "lblManufacturingYear";
            this.lblManufacturingYear.Size = new System.Drawing.Size(100, 13);
            this.lblManufacturingYear.TabIndex = 88;
            this.lblManufacturingYear.Text = "Manufacturing Year";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(353, 89);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 87;
            this.lblCompany.Text = "Company";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(102, 16);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(188, 21);
            this.cmbVehicle.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Vehicle";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(307, 16);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(87, 23);
            this.btnProceed.TabIndex = 1;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // frmViewVehicleMaintenanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(495, 445);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMaintenanceCharges);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSeatingCapacity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblManufacturingYear);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProceed);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewVehicleMaintenanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Vehicle Maintenance Report";
            this.Load += new System.EventHandler(this.frmViewVehicleMaintenanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceCharges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaintenanceCharges;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSeatingCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblManufacturingYear;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maintenance_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maintenance_Cost;
    }
}