using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DailyPickup
{
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdManageDrivers;
        SqlDataAdapter dadManageDrivers;
        DataTable dtblDrivers;
        string strQry = "";
        int intDriverID, intRowIndex = 0;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void BindDrivers()
        {
            try
            {
                strQry = "SELECT     Driver_ID, First_Name, Last_Name, Address, City, Zip_Code, State, Phone, Mobile, Salary, DriverLicenseNumber, Type " +
                        " FROM         DriverMaster WHERE     (IS_Deleted = 0)";
                cmdManageDrivers = new SqlCommand(strQry, conDailyPickup);
                dadManageDrivers = new SqlDataAdapter(cmdManageDrivers);
                dtblDrivers = new DataTable();
                dadManageDrivers.Fill(dtblDrivers);
                dadManageDrivers.Dispose();
                cmdManageDrivers.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            try
            {
                BindDrivers();
                if (dtblDrivers.Rows.Count <= 0)
                {
                    btnNewDriver.PerformClick();
                }
                else
                {
                    btnFirst.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewDriver_Click(object sender, EventArgs e)
        {
            try
            {
                intDriverID = 0;

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtDrivingLicenseNumber.Text = "";
                cmbType.SelectedIndex = 0;
                txtAddress.Text = "";
                txtCity.Text = "";
                txtZipCode.Text = "";
                txtState.Text = "";
                txtPhone.Text = "";
                txtMobile.Text = "";
                txtSalary.Text = "";

                txtFirstName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Enter First Name", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
                else if (txtDrivingLicenseNumber.Text == "")
                {
                    MessageBox.Show("Enter Driving License Number", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDrivingLicenseNumber.Focus();
                }
                else
                {
                    if (intDriverID == 0)
                    {
                        strQry = "INSERT INTO DriverMaster " +
                                    " (First_Name, Last_Name, Address, City, Zip_Code, State, Phone, Mobile, Salary, DriverLicenseNumber, Type, IS_Deleted) " +
                                    " VALUES     (@First_Name,@Last_Name,@Address,@City,@Zip_Code,@State,@Phone,@Mobile,@Salary,@DriverLicenseNumber,@Type, 0)";
                        cmdManageDrivers = new SqlCommand(strQry, conDailyPickup);

                        cmdManageDrivers.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                        cmdManageDrivers.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                        cmdManageDrivers.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                        cmdManageDrivers.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = txtCity.Text;
                        cmdManageDrivers.Parameters.Add("@Zip_Code", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                        cmdManageDrivers.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = txtState.Text;
                        cmdManageDrivers.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                        cmdManageDrivers.Parameters.Add("@Mobile", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                        if (txtSalary.Text == "") { txtSalary.Text = "0"; }
                        cmdManageDrivers.Parameters.Add("@Salary", SqlDbType.Decimal).Value = Convert.ToDecimal(txtSalary.Text);
                        cmdManageDrivers.Parameters.Add("@DriverLicenseNumber", SqlDbType.VarChar, 50).Value = txtDrivingLicenseNumber.Text;
                        cmdManageDrivers.Parameters.Add("@Type", SqlDbType.VarChar, 20).Value = cmbType.Text;


                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageDrivers.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageDrivers.Dispose();

                        MessageBox.Show("Record saved successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        strQry = "UPDATE    DriverMaster " +
                                    " SET              First_Name = @First_Name, Last_Name = @Last_Name, Address = @Address, City = @City, Zip_Code = @Zip_Code, State = @State,  " +
                                    " Phone = @Phone, Mobile = @Mobile, Salary = @Salary, DriverLicenseNumber = @DriverLicenseNumber, Type = @Type " +
                                    " WHERE     (Driver_ID = @Driver_ID)";
                        cmdManageDrivers = new SqlCommand(strQry, conDailyPickup);
                        cmdManageDrivers.Parameters.Add("@Driver_ID", SqlDbType.Int).Value = intDriverID;
                        cmdManageDrivers.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                        cmdManageDrivers.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                        cmdManageDrivers.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                        cmdManageDrivers.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = txtCity.Text;
                        cmdManageDrivers.Parameters.Add("@Zip_Code", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                        cmdManageDrivers.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = txtState.Text;
                        cmdManageDrivers.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                        cmdManageDrivers.Parameters.Add("@Mobile", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                        if (txtSalary.Text == "") { txtSalary.Text = "0"; }
                        cmdManageDrivers.Parameters.Add("@Salary", SqlDbType.Decimal).Value = Convert.ToDecimal(txtSalary.Text);
                        cmdManageDrivers.Parameters.Add("@DriverLicenseNumber", SqlDbType.VarChar, 50).Value = txtDrivingLicenseNumber.Text;
                        cmdManageDrivers.Parameters.Add("@Type", SqlDbType.VarChar, 20).Value = cmbType.Text;


                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageDrivers.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageDrivers.Dispose();


                        MessageBox.Show("Record updated successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    BindDrivers();
                    intRowIndex = 0;
                    btnFirst.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.PerformClick();
                btnNewDriver.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtblDrivers.Rows.Count > 0)
                {
                    intDriverID = Convert.ToInt32(dtblDrivers.Rows[0]["Driver_ID"].ToString());
                    txtFirstName.Text = dtblDrivers.Rows[0]["First_Name"].ToString();
                    txtLastName.Text = dtblDrivers.Rows[0]["Last_Name"].ToString();
                    txtAddress.Text = dtblDrivers.Rows[0]["Address"].ToString();
                    txtCity.Text = dtblDrivers.Rows[0]["City"].ToString();
                    txtZipCode.Text = dtblDrivers.Rows[0]["Zip_Code"].ToString();
                    txtState.Text = dtblDrivers.Rows[0]["State"].ToString();
                    txtPhone.Text = dtblDrivers.Rows[0]["Phone"].ToString();
                    txtMobile.Text = dtblDrivers.Rows[0]["Mobile"].ToString();
                    txtSalary.Text = dtblDrivers.Rows[0]["Salary"].ToString();
                    txtDrivingLicenseNumber.Text = dtblDrivers.Rows[0]["DriverLicenseNumber"].ToString();
                    cmbType.Text = dtblDrivers.Rows[0]["Type"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if ((intRowIndex - 1) >= 0)
                {
                    intDriverID = Convert.ToInt32(dtblDrivers.Rows[intRowIndex - 1]["Driver_ID"].ToString());
                    txtFirstName.Text = dtblDrivers.Rows[intRowIndex - 1]["First_Name"].ToString();
                    txtLastName.Text = dtblDrivers.Rows[intRowIndex - 1]["Last_Name"].ToString();
                    txtAddress.Text = dtblDrivers.Rows[intRowIndex - 1]["Address"].ToString();
                    txtCity.Text = dtblDrivers.Rows[intRowIndex - 1]["City"].ToString();
                    txtZipCode.Text = dtblDrivers.Rows[intRowIndex - 1]["Zip_Code"].ToString();
                    txtState.Text = dtblDrivers.Rows[intRowIndex - 1]["State"].ToString();
                    txtPhone.Text = dtblDrivers.Rows[intRowIndex - 1]["Phone"].ToString();
                    txtMobile.Text = dtblDrivers.Rows[intRowIndex - 1]["Mobile"].ToString();
                    txtSalary.Text = dtblDrivers.Rows[intRowIndex - 1]["Salary"].ToString();
                    txtDrivingLicenseNumber.Text = dtblDrivers.Rows[intRowIndex - 1]["DriverLicenseNumber"].ToString();
                    cmbType.Text = dtblDrivers.Rows[intRowIndex - 1]["Type"].ToString();

                    intRowIndex -= 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if ((intRowIndex + 1) <= dtblDrivers.Rows.Count - 1)
                {
                    intDriverID = Convert.ToInt32(dtblDrivers.Rows[intRowIndex + 1]["Driver_ID"].ToString());
                    txtFirstName.Text = dtblDrivers.Rows[intRowIndex + 1]["First_Name"].ToString();
                    txtLastName.Text = dtblDrivers.Rows[intRowIndex + 1]["Last_Name"].ToString();
                    txtAddress.Text = dtblDrivers.Rows[intRowIndex + 1]["Address"].ToString();
                    txtCity.Text = dtblDrivers.Rows[intRowIndex + 1]["City"].ToString();
                    txtZipCode.Text = dtblDrivers.Rows[intRowIndex + 1]["Zip_Code"].ToString();
                    txtState.Text = dtblDrivers.Rows[intRowIndex + 1]["State"].ToString();
                    txtPhone.Text = dtblDrivers.Rows[intRowIndex + 1]["Phone"].ToString();
                    txtMobile.Text = dtblDrivers.Rows[intRowIndex + 1]["Mobile"].ToString();
                    txtSalary.Text = dtblDrivers.Rows[intRowIndex + 1]["Salary"].ToString();
                    txtDrivingLicenseNumber.Text = dtblDrivers.Rows[intRowIndex + 1]["DriverLicenseNumber"].ToString();
                    cmbType.Text = dtblDrivers.Rows[intRowIndex + 1]["Type"].ToString();
                    intRowIndex += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtblDrivers.Rows.Count > 0)
                {
                    intDriverID = Convert.ToInt32(dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Driver_ID"].ToString());
                    txtFirstName.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["First_Name"].ToString();
                    txtLastName.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Last_Name"].ToString();
                    txtAddress.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Address"].ToString();
                    txtCity.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["City"].ToString();
                    txtZipCode.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Zip_Code"].ToString();
                    txtState.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["State"].ToString();
                    txtPhone.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Phone"].ToString();
                    txtMobile.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Mobile"].ToString();
                    txtSalary.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Salary"].ToString();
                    txtDrivingLicenseNumber.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["DriverLicenseNumber"].ToString();
                    cmbType.Text = dtblDrivers.Rows[dtblDrivers.Rows.Count - 1]["Type"].ToString();

                    intRowIndex = dtblDrivers.Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtblDrivers.Rows.Count > 0 && intDriverID > 0)
                {
                    if (MessageBox.Show("Are you sure?", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        strQry = "UPDATE  DriverMaster   SET IS_Deleted = 1 WHERE     (Driver_ID = @Driver_ID)";
                        cmdManageDrivers = new SqlCommand(strQry, conDailyPickup);
                        cmdManageDrivers.Parameters.Add("@Driver_ID", SqlDbType.Int).Value = intDriverID;
                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageDrivers.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageDrivers.Dispose();
                        ///////////////////
                        BindDrivers();

                        MessageBox.Show("Driver deleted successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnFirst.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}