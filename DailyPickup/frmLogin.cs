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
    public partial class frmLogin : Form
    {
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
        SqlCommand cmdLogin;
        SqlDataReader dtrLogin;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                else
                {
                    string strQry = "SELECT     User_Id, User_Type FROM         UserMaster WHERE     (User_Name = @User_Name) AND (Password = @Password)";
                    cmdLogin = new SqlCommand(strQry, conDailyPickup);
                    cmdLogin.Parameters.Add("@User_Name", SqlDbType.VarChar, 50).Value = txtUserName.Text;
                    cmdLogin.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = txtPassword.Text;
                    try
                    {
                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        dtrLogin = cmdLogin.ExecuteReader();
                        if (dtrLogin.HasRows)
                        {
                            dtrLogin.Read();
                            frmMain.intUserID = Convert.ToInt32(dtrLogin["User_Id"].ToString());
                            frmMain.strUserType = dtrLogin["User_Type"].ToString();
                            frmMain.strUserName = txtUserName.Text;

                            frmMain frmMain1 = new frmMain();
                            frmMain1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User Name or Password doesn't exists", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            txtUserName.Text = "";
                            txtUserName.Focus();
                        }
                    }
                    finally
                    {
                        dtrLogin.Close();
                        dtrLogin.Dispose();
                        conDailyPickup.Close();
                        cmdLogin.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = "";
                txtUserName.Text = "";
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}