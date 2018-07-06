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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection conEducationGuru = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdChangePassword;
        string strQry = "";

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

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            try
            {
                strQry = "SELECT     First_Name + ' ' + Last_Name AS UserName FROM         UserDetail WHERE     (User_ID = @User_ID)";
                cmdChangePassword = new SqlCommand(strQry, conEducationGuru);
                cmdChangePassword.Parameters.Add("@User_ID", SqlDbType.Int).Value = frmMain.intUserID;
                if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                lblUserName.Text = cmdChangePassword.ExecuteScalar().ToString();
                conEducationGuru.Close();
                cmdChangePassword.Dispose();

                txtOldPassword.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassword.Text == "")
                {
                    MessageBox.Show("Enter Old Password", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.Focus();
                }
                else if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("Enter New Password", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                }
                else if (txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Enter Confirm Password", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Focus();
                }
                else
                {
                    strQry = "SELECT     COUNT(*) AS Expr1 FROM         UserMaster WHERE     (Password = @Password) AND (User_Id = @User_Id)";
                    cmdChangePassword = new SqlCommand(strQry, conEducationGuru);
                    cmdChangePassword.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = txtOldPassword.Text;
                    cmdChangePassword.Parameters.Add("@User_Id", SqlDbType.Int).Value = frmMain.intUserID;
                    if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                    int intCount = Convert.ToInt32(cmdChangePassword.ExecuteScalar().ToString());
                    conEducationGuru.Close();
                    cmdChangePassword.Dispose();

                    if (intCount <= 0)
                    {
                        MessageBox.Show("Please enter correct Old Password", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtOldPassword.Text = "";
                        txtOldPassword.Focus();
                    }
                    else
                    {
                        if (txtNewPassword.Text != txtConfirmPassword.Text)
                        {
                            MessageBox.Show("Please Confirm Password Again", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtConfirmPassword.Text = "";
                            txtConfirmPassword.Focus();
                        }
                        else
                        {
                            strQry = "UPDATE    UserMaster SET              Password = @Password WHERE     (User_Id = @User_Id)";
                            cmdChangePassword = new SqlCommand(strQry, conEducationGuru);
                            cmdChangePassword.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = txtNewPassword.Text;
                            cmdChangePassword.Parameters.Add("@User_Id", SqlDbType.Int).Value = frmMain.intUserID;
                            if (conEducationGuru.State == ConnectionState.Closed) { conEducationGuru.Open(); }
                            cmdChangePassword.ExecuteNonQuery();
                            conEducationGuru.Close();
                            cmdChangePassword.Dispose();

                            MessageBox.Show("Password Changed Successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
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