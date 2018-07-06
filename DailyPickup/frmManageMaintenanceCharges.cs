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
    public partial class frmManageMaintenanceCharges : Form
    {
        public frmManageMaintenanceCharges()
        {
            InitializeComponent();
        }
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdManageMaintenanceCharges;
        SqlDataAdapter dadManageMaintenanceCharges;
        SqlDataReader dtrManageMaintenanceCharges;
        DataTable dtblVehicles;
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

        void BindVehicles()
        {
            strQry = "SELECT     Vehicle_ID, Model_Name + ' [ ' + Vehicle_Type + ' ] ' AS Vehicle FROM         VehicleMaster";
            cmdManageMaintenanceCharges = new SqlCommand(strQry, conDailyPickup);
            dadManageMaintenanceCharges = new SqlDataAdapter(cmdManageMaintenanceCharges);
            dtblVehicles = new DataTable();
            dadManageMaintenanceCharges.Fill(dtblVehicles);
            dadManageMaintenanceCharges.Dispose();
            cmdManageMaintenanceCharges.Dispose();

            DataRow drVehicle = dtblVehicles.NewRow();
            drVehicle["Vehicle_ID"] = 0;
            drVehicle["Vehicle"] = "Select";
            dtblVehicles.Rows.InsertAt(drVehicle, 0);

            cmbVehicle.SelectedIndexChanged -= cmbVehicle_SelectedIndexChanged;
            cmbVehicle.DataSource = dtblVehicles.Copy();
            cmbVehicle.DisplayMember = "Vehicle";
            cmbVehicle.ValueMember = "Vehicle_ID";
            cmbVehicle.SelectedIndexChanged += cmbVehicle_SelectedIndexChanged;
        }

        private void frmManageMaintenanceCharges_Load(object sender, EventArgs e)
        {
            try
            {
                BindVehicles();

                lblModelName.Text = "";
                lblType.Text = "";
                lblManufacturingYear.Text = "";
                lblCompany.Text = "";
                txtMaintenanceCharges.Text = "0";
                txtDescription.Text = "";

                cmbVehicle.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                strQry = "SELECT     Model_Name, Vehicle_Type, Made_Year, Made_Company " +
                            " FROM         VehicleMaster WHERE     (Vehicle_ID = @Vehicle_ID)";
                cmdManageMaintenanceCharges = new SqlCommand(strQry, conDailyPickup);
                cmdManageMaintenanceCharges.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                try
                {
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }

                    dtrManageMaintenanceCharges = cmdManageMaintenanceCharges.ExecuteReader();
                    if (dtrManageMaintenanceCharges.HasRows)
                    {
                        dtrManageMaintenanceCharges.Read();

                        lblModelName.Text = dtrManageMaintenanceCharges["Model_Name"].ToString();
                        lblType.Text = dtrManageMaintenanceCharges["Vehicle_Type"].ToString();
                        lblManufacturingYear.Text = dtrManageMaintenanceCharges["Made_Year"].ToString();
                        lblCompany.Text = dtrManageMaintenanceCharges["Made_Company"].ToString();
                    }
                    else
                    {
                        lblModelName.Text = "";
                        lblType.Text = "";
                        lblManufacturingYear.Text = "";
                        lblCompany.Text = "";
                    }
                }
                finally
                {
                    dtrManageMaintenanceCharges.Close();
                    conDailyPickup.Close();
                    cmdManageMaintenanceCharges.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageVehicles frmManageVehicles = new frmManageVehicles();
                frmManageVehicles.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCharges_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehicle.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Vehicle", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbVehicle.Focus();
                }
                else if (txtMaintenanceCharges.Text == "")
                {
                    MessageBox.Show("Enter Maintenance Charges", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaintenanceCharges.Focus();
                }
                else
                {
                    strQry = "INSERT INTO VehicleMaintenance " +
                                " (Vehicle_ID, Maintenance_Description, Maintenance_Cost, Date) " +
                                " VALUES     (@Vehicle_ID,@Maintenance_Description,@Maintenance_Cost,GetDate())";
                    cmdManageMaintenanceCharges = new SqlCommand(strQry, conDailyPickup);
                    cmdManageMaintenanceCharges.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                    cmdManageMaintenanceCharges.Parameters.Add("@Maintenance_Description", SqlDbType.VarChar, 50).Value = txtDescription.Text;
                    cmdManageMaintenanceCharges.Parameters.Add("@Maintenance_Cost", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMaintenanceCharges.Text);
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                    cmdManageMaintenanceCharges.ExecuteNonQuery();
                    conDailyPickup.Close();
                    cmdManageMaintenanceCharges.Dispose();

                    MessageBox.Show("Record Saved successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmManageMaintenanceCharges_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}