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
    public partial class frmViewVehicleFuelReport : Form
    {
        public frmViewVehicleFuelReport()
        {
            InitializeComponent();
        }
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdViewVehicleFuelReport;
        SqlDataAdapter dadViewVehicleFuelReport;
        SqlDataReader dtrViewVehicleFuelReport;
        DataTable dtblVehicles, dtblFuelCharges;
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
            cmdViewVehicleFuelReport = new SqlCommand(strQry, conDailyPickup);
            dadViewVehicleFuelReport = new SqlDataAdapter(cmdViewVehicleFuelReport);
            dtblVehicles = new DataTable();
            dadViewVehicleFuelReport.Fill(dtblVehicles);
            dadViewVehicleFuelReport.Dispose();
            cmdViewVehicleFuelReport.Dispose();

            DataRow drVehicle = dtblVehicles.NewRow();
            drVehicle["Vehicle_ID"] = 0;
            drVehicle["Vehicle"] = "Select";
            dtblVehicles.Rows.InsertAt(drVehicle, 0);

            cmbVehicle.DataSource = dtblVehicles.Copy();
            cmbVehicle.DisplayMember = "Vehicle";
            cmbVehicle.ValueMember = "Vehicle_ID";
        }

        private void frmViewVehicleFuelReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindVehicles();

                lblModelName.Text = "";
                lblType.Text = "";
                lblManufacturingYear.Text = "";
                lblCompany.Text = "";
                lblSeatingCapacity.Text = "";
                lblFuelType.Text = "";

                dgvFuelCharges.DataSource = null;
                dgvFuelCharges.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                strQry = "SELECT     Model_Name, Vehicle_Type, Made_Year, Made_Company, Seating_Capacity, Fuel_Type " +
                            " FROM         VehicleMaster WHERE     (Vehicle_ID = @Vehicle_ID)";
                cmdViewVehicleFuelReport = new SqlCommand(strQry, conDailyPickup);
                cmdViewVehicleFuelReport.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                try
                {
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }

                    dtrViewVehicleFuelReport = cmdViewVehicleFuelReport.ExecuteReader();
                    if (dtrViewVehicleFuelReport.HasRows)
                    {
                        dtrViewVehicleFuelReport.Read();

                        lblModelName.Text = dtrViewVehicleFuelReport["Model_Name"].ToString();
                        lblType.Text = dtrViewVehicleFuelReport["Vehicle_Type"].ToString();
                        lblManufacturingYear.Text = dtrViewVehicleFuelReport["Made_Year"].ToString();
                        lblCompany.Text = dtrViewVehicleFuelReport["Made_Company"].ToString();
                        lblSeatingCapacity.Text = dtrViewVehicleFuelReport["Seating_Capacity"].ToString();
                        lblFuelType.Text = dtrViewVehicleFuelReport["Fuel_Type"].ToString();
                    }
                    else
                    {
                        lblModelName.Text = "";
                        lblType.Text = "";
                        lblManufacturingYear.Text = "";
                        lblCompany.Text = "";
                        lblSeatingCapacity.Text = "";
                        lblFuelType.Text = "";
                    }
                }
                finally
                {
                    dtrViewVehicleFuelReport.Close();
                    conDailyPickup.Close();
                    cmdViewVehicleFuelReport.Dispose();
                }
                /////////////////////
                strQry = "SELECT     Fuel_Cost, Meter_Reading, CONVERT(varchar, DATEPART(dd, Date)) + '/' + CONVERT(varchar, DATEPART(mm, Date)) + '/' + CONVERT(varchar, DATEPART(yyyy, Date)) AS Date FROM  VehicleFuel WHERE     (Vehicle_ID = @Vehicle_ID)";
                cmdViewVehicleFuelReport = new SqlCommand(strQry, conDailyPickup);
                cmdViewVehicleFuelReport.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                dadViewVehicleFuelReport = new SqlDataAdapter(cmdViewVehicleFuelReport);
                dtblFuelCharges = new DataTable();
                dadViewVehicleFuelReport.Fill(dtblFuelCharges);
                dadViewVehicleFuelReport.Dispose();
                cmdViewVehicleFuelReport.Dispose();

                dgvFuelCharges.DataSource = dtblFuelCharges.Copy();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}