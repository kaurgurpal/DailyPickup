namespace DailyPickup
{
    partial class frmManageDrivers
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDrivingLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewDriver = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Driver",
            "Subordinate"});
            this.cmbType.Location = new System.Drawing.Point(214, 120);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(214, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtDrivingLicenseNumber
            // 
            this.txtDrivingLicenseNumber.Location = new System.Drawing.Point(263, 85);
            this.txtDrivingLicenseNumber.Name = "txtDrivingLicenseNumber";
            this.txtDrivingLicenseNumber.Size = new System.Drawing.Size(123, 20);
            this.txtDrivingLicenseNumber.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(214, 147);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(200, 46);
            this.txtAddress.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(214, 199);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(123, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(214, 265);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(123, 20);
            this.txtState.TabIndex = 7;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(214, 232);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(123, 20);
            this.txtZipCode.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(214, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Driving License Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Zip Code";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(358, 432);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 19;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(269, 432);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(180, 432);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(90, 432);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 16;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAddNew
            // 
            this.btnSaveAddNew.Location = new System.Drawing.Point(199, 403);
            this.btnSaveAddNew.Name = "btnSaveAddNew";
            this.btnSaveAddNew.Size = new System.Drawing.Size(134, 23);
            this.btnSaveAddNew.TabIndex = 13;
            this.btnSaveAddNew.Text = "Save && Add New";
            this.btnSaveAddNew.UseVisualStyleBackColor = true;
            this.btnSaveAddNew.Click += new System.EventHandler(this.btnSaveAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewDriver
            // 
            this.btnNewDriver.Location = new System.Drawing.Point(10, 403);
            this.btnNewDriver.Name = "btnNewDriver";
            this.btnNewDriver.Size = new System.Drawing.Size(88, 23);
            this.btnNewDriver.TabIndex = 11;
            this.btnNewDriver.Text = "New Driver";
            this.btnNewDriver.UseVisualStyleBackColor = true;
            this.btnNewDriver.Click += new System.EventHandler(this.btnNewDriver_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(214, 298);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Phone";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(214, 331);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(123, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Mobile";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(214, 364);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(123, 20);
            this.txtSalary.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(114, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Salary";
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(521, 470);
            this.ControlBox = false;
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtDrivingLicenseNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewDriver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDrivingLicenseNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewDriver;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label11;
    }
}