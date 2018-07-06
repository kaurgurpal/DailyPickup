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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection conEducationGuru = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdManageUsers;
        SqlDataAdapter dadManageUsers;
        DataTable dtblUsers;
        string strQry = "";
        int intUserID, intRowIndex = 0;

        void GetUsers()
        {
            try
            {
                strQry = "SELECT     UserMaster.User_Id, UserMaster.User_Name, UserMaster.Password, UserMaster.User_Type, UserDetail.First_Name, UserDetail.Last_Name, " +
                          " UserDetail.DOB, UserDetail.Address, UserDetail.City, UserDetail.State, UserDetail.ZIP_Code, UserDetail.Country, UserDetail.Phone_Number,  " +
                          " UserDetail.Mobile_Number, UserDetail.Email_ID " +
                          " FROM         UserDetail INNER JOIN " +
                          " UserMaster ON UserDetail.User_ID = UserMaster.User_Id";
                cmdManageUsers = new SqlCommand(strQry, conEducationGuru);
                dadManageUsers = new SqlDataAdapter(cmdManageUsers);
                dtblUsers = new DataTable();
                dadManageUsers.Fill(dtblUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

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

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                GetUsers();
                if (dtblUsers.Rows.Count <= 0)
                {
                    btnAddNew.PerformClick();
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                intUserID = 0;
                txtUserName.Text = "";
                txtPassword.Text = "";
                cmbUserType.SelectedIndex = 0;

                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtpDOB.Value = DateTime.Now;
                txtAddress.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtZipCode.Text = "";
                txtCountry.Text = "";
                txtPhone.Text = "";
                txtMobile.Text = "";
                txtEmail.Text = "";

                txtUserName.Focus();
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
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Enter User Name", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter Password", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Enter First Name", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
                else
                {
                    if (intUserID == 0)
                    {
                        strQry = "INSERT INTO UserMaster (User_Name, Password, User_Type) VALUES (@User_Name,@Password,@User_Type)";
                        cmdManageUsers = new SqlCommand(strQry, conEducationGuru);
                        cmdManageUsers.Parameters.Add("@User_Name", SqlDbType.VarChar, 50).Value = txtUserName.Text;
                        cmdManageUsers.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = txtPassword.Text;
                        cmdManageUsers.Parameters.Add("@User_Type", SqlDbType.VarChar, 20).Value = cmbUserType.Text;
                        if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                        cmdManageUsers.ExecuteNonQuery();
                        conEducationGuru.Close();
                        cmdManageUsers.Dispose();

                        ///////////////////////////////////
                        strQry = "SELECT MAX(User_Id) FROM  UserMaster;";
                        cmdManageUsers = new SqlCommand(strQry, conEducationGuru);
                        if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                        int intEmployeeID = Convert.ToInt32(cmdManageUsers.ExecuteScalar().ToString());
                        conEducationGuru.Close();
                        cmdManageUsers.Dispose();


                        ////////////////////////////////////
                        strQry = "INSERT INTO UserDetail " +
                          " (User_ID, First_Name, Last_Name, DOB, Address, City, State, ZIP_Code, Country, Phone_Number, Mobile_Number, Email_ID) " +
                          " VALUES     (@User_ID,@First_Name,@Last_Name,@DOB,@Address,@City,@State,@ZIP_Code,@Country,@Phone_Number,@Mobile_Number,@Email_ID)";
                        cmdManageUsers = new SqlCommand(strQry, conEducationGuru);
                        cmdManageUsers.Parameters.Add("@User_ID", SqlDbType.Int).Value = intEmployeeID;
                        cmdManageUsers.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                        cmdManageUsers.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                        cmdManageUsers.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dtpDOB.Value;
                        cmdManageUsers.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                        cmdManageUsers.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = txtCity.Text;
                        cmdManageUsers.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = txtState.Text;
                        cmdManageUsers.Parameters.Add("@ZIP_Code", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                        cmdManageUsers.Parameters.Add("@Country", SqlDbType.VarChar, 50).Value = txtCountry.Text;
                        cmdManageUsers.Parameters.Add("@Phone_Number", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                        cmdManageUsers.Parameters.Add("@Mobile_Number", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                        cmdManageUsers.Parameters.Add("@Email_ID", SqlDbType.VarChar, 50).Value = txtEmail.Text;

                        if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                        cmdManageUsers.ExecuteNonQuery();
                        conEducationGuru.Close();
                        cmdManageUsers.Dispose();

                        MessageBox.Show("Record saved successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        strQry = "update UserMaster set User_Name=@User_Name, Password=@Password, User_Type=@User_Type where User_ID=@User_ID";
                        cmdManageUsers = new SqlCommand(strQry, conEducationGuru);
                        cmdManageUsers.Parameters.Add("@User_ID", SqlDbType.Int).Value = intUserID;
                        cmdManageUsers.Parameters.Add("@User_Name", SqlDbType.VarChar, 50).Value = txtUserName.Text;
                        cmdManageUsers.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = txtPassword.Text;
                        cmdManageUsers.Parameters.Add("@User_Type", SqlDbType.VarChar, 20).Value = cmbUserType.Text;
                        if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                        cmdManageUsers.ExecuteNonQuery();
                        conEducationGuru.Close();
                        cmdManageUsers.Dispose();
                        ////////////////////////////////////
                        strQry = "update UserDetail " +
                          " set First_Name=@First_Name, Last_Name=@Last_Name, DOB=@DOB, Address=@Address, City=@City, State=@State, ZIP_Code=@ZIP_Code, Country=@Country, Phone_Number=@Phone_Number, Mobile_Number=@Mobile_Number, Email_ID=@Email_ID where  User_ID=@User_ID";
                        cmdManageUsers = new SqlCommand(strQry, conEducationGuru);
                        cmdManageUsers.Parameters.Add("@User_ID", SqlDbType.Int).Value = intUserID;
                        cmdManageUsers.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                        cmdManageUsers.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                        cmdManageUsers.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dtpDOB.Value;
                        cmdManageUsers.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                        cmdManageUsers.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = txtCity.Text;
                        cmdManageUsers.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = txtState.Text;
                        cmdManageUsers.Parameters.Add("@ZIP_Code", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                        cmdManageUsers.Parameters.Add("@Country", SqlDbType.VarChar, 50).Value = txtCountry.Text;
                        cmdManageUsers.Parameters.Add("@Phone_Number", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                        cmdManageUsers.Parameters.Add("@Mobile_Number", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                        cmdManageUsers.Parameters.Add("@Email_ID", SqlDbType.VarChar, 50).Value = txtEmail.Text;

                        if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                        cmdManageUsers.ExecuteNonQuery();
                        conEducationGuru.Close();
                        cmdManageUsers.Dispose();

                        MessageBox.Show("Record updated successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    GetUsers();
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
                btnAddNew.PerformClick();
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
                if (dtblUsers.Rows.Count > 0)
                {
                    intUserID = Convert.ToInt32(dtblUsers.Rows[0]["User_ID"].ToString());
                    txtUserName.Text = dtblUsers.Rows[0]["User_Name"].ToString();
                    txtPassword.Text = dtblUsers.Rows[0]["Password"].ToString();
                    cmbUserType.Text = dtblUsers.Rows[0]["User_Type"].ToString();
                    txtFirstName.Text = dtblUsers.Rows[0]["First_Name"].ToString();
                    txtLastName.Text = dtblUsers.Rows[0]["Last_Name"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(dtblUsers.Rows[0]["DOB"].ToString());
                    txtAddress.Text = dtblUsers.Rows[0]["Address"].ToString();
                    txtCity.Text = dtblUsers.Rows[0]["City"].ToString();
                    txtState.Text = dtblUsers.Rows[0]["State"].ToString();
                    txtZipCode.Text = dtblUsers.Rows[0]["ZIP_Code"].ToString();
                    txtCountry.Text = dtblUsers.Rows[0]["Country"].ToString();
                    txtPhone.Text = dtblUsers.Rows[0]["Phone_Number"].ToString();
                    txtMobile.Text = dtblUsers.Rows[0]["Mobile_Number"].ToString();
                    txtEmail.Text = dtblUsers.Rows[0]["Email_ID"].ToString();
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
                    intUserID = Convert.ToInt32(dtblUsers.Rows[intRowIndex - 1]["User_ID"].ToString());
                    txtUserName.Text = dtblUsers.Rows[intRowIndex - 1]["User_Name"].ToString();
                    txtPassword.Text = dtblUsers.Rows[intRowIndex - 1]["Password"].ToString();
                    cmbUserType.Text = dtblUsers.Rows[intRowIndex - 1]["User_Type"].ToString();
                    txtFirstName.Text = dtblUsers.Rows[intRowIndex - 1]["First_Name"].ToString();
                    txtLastName.Text = dtblUsers.Rows[intRowIndex - 1]["Last_Name"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(dtblUsers.Rows[intRowIndex - 1]["DOB"].ToString());
                    txtAddress.Text = dtblUsers.Rows[intRowIndex - 1]["Address"].ToString();
                    txtCity.Text = dtblUsers.Rows[intRowIndex - 1]["City"].ToString();
                    txtState.Text = dtblUsers.Rows[intRowIndex - 1]["State"].ToString();
                    txtZipCode.Text = dtblUsers.Rows[intRowIndex - 1]["ZIP_Code"].ToString();
                    txtCountry.Text = dtblUsers.Rows[intRowIndex - 1]["Country"].ToString();
                    txtPhone.Text = dtblUsers.Rows[intRowIndex - 1]["Phone_Number"].ToString();
                    txtMobile.Text = dtblUsers.Rows[intRowIndex - 1]["Mobile_Number"].ToString();
                    txtEmail.Text = dtblUsers.Rows[intRowIndex - 1]["Email_ID"].ToString();
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
                if ((intRowIndex + 1) <= dtblUsers.Rows.Count - 1)
                {
                    intUserID = Convert.ToInt32(dtblUsers.Rows[intRowIndex + 1]["User_ID"].ToString());
                    txtUserName.Text = dtblUsers.Rows[intRowIndex + 1]["User_Name"].ToString();
                    txtPassword.Text = dtblUsers.Rows[intRowIndex + 1]["Password"].ToString();
                    cmbUserType.Text = dtblUsers.Rows[intRowIndex + 1]["User_Type"].ToString();
                    txtFirstName.Text = dtblUsers.Rows[intRowIndex + 1]["First_Name"].ToString();
                    txtLastName.Text = dtblUsers.Rows[intRowIndex + 1]["Last_Name"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(dtblUsers.Rows[intRowIndex + 1]["DOB"].ToString());
                    txtAddress.Text = dtblUsers.Rows[intRowIndex + 1]["Address"].ToString();
                    txtCity.Text = dtblUsers.Rows[intRowIndex + 1]["City"].ToString();
                    txtState.Text = dtblUsers.Rows[intRowIndex + 1]["State"].ToString();
                    txtZipCode.Text = dtblUsers.Rows[intRowIndex + 1]["ZIP_Code"].ToString();
                    txtCountry.Text = dtblUsers.Rows[intRowIndex + 1]["Country"].ToString();
                    txtPhone.Text = dtblUsers.Rows[intRowIndex + 1]["Phone_Number"].ToString();
                    txtMobile.Text = dtblUsers.Rows[intRowIndex + 1]["Mobile_Number"].ToString();
                    txtEmail.Text = dtblUsers.Rows[intRowIndex + 1]["Email_ID"].ToString();
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
                if (dtblUsers.Rows.Count > 0)
                {
                    intUserID = Convert.ToInt32(dtblUsers.Rows[dtblUsers.Rows.Count - 1]["User_ID"].ToString());
                    txtUserName.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["User_Name"].ToString();
                    txtPassword.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Password"].ToString();
                    cmbUserType.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["User_Type"].ToString();
                    txtFirstName.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["First_Name"].ToString();
                    txtLastName.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Last_Name"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(dtblUsers.Rows[dtblUsers.Rows.Count - 1]["DOB"].ToString());
                    txtAddress.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Address"].ToString();
                    txtCity.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["City"].ToString();
                    txtState.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["State"].ToString();
                    txtZipCode.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["ZIP_Code"].ToString();
                    txtCountry.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Country"].ToString();
                    txtPhone.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Phone_Number"].ToString();
                    txtMobile.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Mobile_Number"].ToString();
                    txtEmail.Text = dtblUsers.Rows[dtblUsers.Rows.Count - 1]["Email_ID"].ToString();

                    intRowIndex = dtblUsers.Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}