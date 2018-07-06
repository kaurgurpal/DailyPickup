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
    public partial class frmManageVehicleFuel : Form
    {
        public frmManageVehicleFuel()
        {
            InitializeComponent();
        }
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdManageVehicleRoutes;
        SqlDataAdapter dadManageVehicleRoutes;
        SqlDataReader dtrManageVehicleRoutes;
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
            cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
            dadManageVehicleRoutes = new SqlDataAdapter(cmdManageVehicleRoutes);
            dtblVehicles = new DataTable();
            dadManageVehicleRoutes.Fill(dtblVehicles);
            dadManageVehicleRoutes.Dispose();
            cmdManageVehicleRoutes.Dispose();

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

        private void frmManageVehicleFuel_Load(object sender, EventArgs e)
        {
            try
            {
                BindVehicles();

                lblModelName.Text = "";
                lblType.Text = "";
                lblManufacturingYear.Text = "";
                lblCompany.Text = "";
                txtFuelCharges.Text = "0";
                txtVehicleMeterReading.Text = "0";
                dtpDate.Value = DateTime.Now;

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
                cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
                cmdManageVehicleRoutes.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                try
                {
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }

                    dtrManageVehicleRoutes = cmdManageVehicleRoutes.ExecuteReader();
                    if (dtrManageVehicleRoutes.HasRows)
                    {
                        dtrManageVehicleRoutes.Read();

                        lblModelName.Text = dtrManageVehicleRoutes["Model_Name"].ToString();
                        lblType.Text = dtrManageVehicleRoutes["Vehicle_Type"].ToString();
                        lblManufacturingYear.Text = dtrManageVehicleRoutes["Made_Year"].ToString();
                        lblCompany.Text = dtrManageVehicleRoutes["Made_Company"].ToString();
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
                    dtrManageVehicleRoutes.Close();
                    conDailyPickup.Close();
                    cmdManageVehicleRoutes.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveFuelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehicle.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Vehicle", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbVehicle.Focus();
                }
                else if (txtFuelCharges.Text == "")
                {
                    MessageBox.Show("Enter Fuel Charges", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFuelCharges.Focus();
                }
                else
                {
                    strQry = "INSERT INTO VehicleFuel " +
                            " (Vehicle_ID, Fuel_Cost, Meter_Reading, Date) VALUES     (@Vehicle_ID,@Fuel_Cost,@Meter_Reading,@Date)";
                    cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
                    cmdManageVehicleRoutes.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                    cmdManageVehicleRoutes.Parameters.Add("@Fuel_Cost", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFuelCharges.Text);
                    cmdManageVehicleRoutes.Parameters.Add("@Meter_Reading", SqlDbType.VarChar, 50).Value = txtVehicleMeterReading.Text;
                    cmdManageVehicleRoutes.Parameters.Add("@Date", SqlDbType.DateTime).Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                    cmdManageVehicleRoutes.ExecuteNonQuery();
                    conDailyPickup.Close();
                    cmdManageVehicleRoutes.Dispose();

                    MessageBox.Show("Record Saved successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmManageVehicleFuel_Load(null, null);
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

    }
}