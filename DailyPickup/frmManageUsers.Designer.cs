namespace DailyPickup
{
    partial class frmManageUsers
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
            this.grpAccountInfo = new System.Windows.Forms.GroupBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grpAccountInfo.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountInfo
            // 
            this.grpAccountInfo.Controls.Add(this.cmbUserType);
            this.grpAccountInfo.Controls.Add(this.label3);
            this.grpAccountInfo.Controls.Add(this.txtPassword);
            this.grpAccountInfo.Controls.Add(this.txtUserName);
            this.grpAccountInfo.Controls.Add(this.label2);
            this.grpAccountInfo.Controls.Add(this.label1);
            this.grpAccountInfo.Location = new System.Drawing.Point(115, 12);
            this.grpAccountInfo.Name = "grpAccountInfo";
            this.grpAccountInfo.Size = new System.Drawing.Size(346, 110);
            this.grpAccountInfo.TabIndex = 0;
            this.grpAccountInfo.TabStop = false;
            this.grpAccountInfo.Text = "Account Info";
            // 
            // cmbUserType
            // 
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Clerk"});
            this.cmbUserType.Location = new System.Drawing.Point(127, 75);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(142, 21);
            this.cmbUserType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Type";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(126, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.label15);
            this.grpPersonalInfo.Controls.Add(this.txtMobile);
            this.grpPersonalInfo.Controls.Add(this.label12);
            this.grpPersonalInfo.Controls.Add(this.txtPhone);
            this.grpPersonalInfo.Controls.Add(this.label13);
            this.grpPersonalInfo.Controls.Add(this.txtCountry);
            this.grpPersonalInfo.Controls.Add(this.label10);
            this.grpPersonalInfo.Controls.Add(this.txtState);
            this.grpPersonalInfo.Controls.Add(this.label11);
            this.grpPersonalInfo.Controls.Add(this.txtZipCode);
            this.grpPersonalInfo.Controls.Add(this.label8);
            this.grpPersonalInfo.Controls.Add(this.txtCity);
            this.grpPersonalInfo.Controls.Add(this.label9);
            this.grpPersonalInfo.Controls.Add(this.txtAddress);
            this.grpPersonalInfo.Controls.Add(this.dtpDOB);
            this.grpPersonalInfo.Controls.Add(this.txtLastName);
            this.grpPersonalInfo.Controls.Add(this.label7);
            this.grpPersonalInfo.Controls.Add(this.label4);
            this.grpPersonalInfo.Controls.Add(this.txtFirstName);
            this.grpPersonalInfo.Controls.Add(this.label5);
            this.grpPersonalInfo.Controls.Add(this.label6);
            this.grpPersonalInfo.Location = new System.Drawing.Point(12, 133);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(561, 255);
            this.grpPersonalInfo.TabIndex = 1;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Email ID";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(379, 197);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(160, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mobile";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 197);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Phone";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(379, 170);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(160, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Country";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(115, 170);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(160, 20);
            this.txtState.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "State";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(379, 142);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(160, 20);
            this.txtZipCode.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Zip Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(115, 142);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(160, 20);
            this.txtCity.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(115, 75);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(299, 60);
            this.txtAddress.TabIndex = 3;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd\'-\'MMM\'-\'yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(115, 46);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 2;
            this.dtpDOB.Value = new System.DateTime(2008, 7, 10, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(379, 20);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(77, 402);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(88, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAddNew
            // 
            this.btnSaveAddNew.Location = new System.Drawing.Point(278, 402);
            this.btnSaveAddNew.Name = "btnSaveAddNew";
            this.btnSaveAddNew.Size = new System.Drawing.Size(134, 23);
            this.btnSaveAddNew.TabIndex = 4;
            this.btnSaveAddNew.Text = "Save and Add New";
            this.btnSaveAddNew.UseVisualStyleBackColor = true;
            this.btnSaveAddNew.Click += new System.EventHandler(this.btnSaveAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(373, 431);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(284, 431);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(195, 431);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(105, 431);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(580, 464);
            this.ControlBox = false;
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.grpAccountInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.grpAccountInfo.ResumeLayout(false);
            this.grpAccountInfo.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
    }
}