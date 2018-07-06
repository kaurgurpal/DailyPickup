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
    public partial class frmViewVehicleMaintenanceReport : Form
    {
        public frmViewVehicleMaintenanceReport()
        {
            InitializeComponent();
        }

        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdViewVehicleMaintenanceReport;
        SqlDataAdapter dadViewVehicleMaintenanceReport;
        SqlDataReader dtrViewVehicleMaintenanceReport;
        DataTable dtblVehicles, dtblVehicleMaintenanceCharges;
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
            cmdViewVehicleMaintenanceReport = new SqlCommand(strQry, conDailyPickup);
            dadViewVehicleMaintenanceReport = new SqlDataAdapter(cmdViewVehicleMaintenanceReport);
            dtblVehicles = new DataTable();
            dadViewVehicleMaintenanceReport.Fill(dtblVehicles);
            dadViewVehicleMaintenanceReport.Dispose();
            cmdViewVehicleMaintenanceReport.Dispose();

            DataRow drVehicle = dtblVehicles.NewRow();
            drVehicle["Vehicle_ID"] = 0;
            drVehicle["Vehicle"] = "Select";
            dtblVehicles.Rows.InsertAt(drVehicle, 0);

            cmbVehicle.DataSource = dtblVehicles.Copy();
            cmbVehicle.DisplayMember = "Vehicle";
            cmbVehicle.ValueMember = "Vehicle_ID";
        }

        private void frmViewVehicleMaintenanceReport_Load(object sender, EventArgs e)
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

                dgvMaintenanceCharges.DataSource = null;
                dgvMaintenanceCharges.AutoGenerateColumns = false;
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
                cmdViewVehicleMaintenanceReport = new SqlCommand(strQry, conDailyPickup);
                cmdViewVehicleMaintenanceReport.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                try
                {
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }

                    dtrViewVehicleMaintenanceReport = cmdViewVehicleMaintenanceReport.ExecuteReader();
                    if (dtrViewVehicleMaintenanceReport.HasRows)
                    {
                        dtrViewVehicleMaintenanceReport.Read();

                        lblModelName.Text = dtrViewVehicleMaintenanceReport["Model_Name"].ToString();
                        lblType.Text = dtrViewVehicleMaintenanceReport["Vehicle_Type"].ToString();
                        lblManufacturingYear.Text = dtrViewVehicleMaintenanceReport["Made_Year"].ToString();
                        lblCompany.Text = dtrViewVehicleMaintenanceReport["Made_Company"].ToString();
                        lblSeatingCapacity.Text = dtrViewVehicleMaintenanceReport["Seating_Capacity"].ToString();
                        lblFuelType.Text = dtrViewVehicleMaintenanceReport["Fuel_Type"].ToString();
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
                    dtrViewVehicleMaintenanceReport.Close();
                    conDailyPickup.Close();
                    cmdViewVehicleMaintenanceReport.Dispose();
                }
                /////////////////////
                strQry = "SELECT     Maintenance_Description, Maintenance_Cost, CONVERT(varchar, DATEPART(dd, Date)) + '/' + CONVERT(varchar, DATEPART(mm, Date)) + '/' + CONVERT(varchar, DATEPART(yyyy, Date)) AS Date FROM         VehicleMaintenance WHERE     (Vehicle_ID = @Vehicle_ID)";
                cmdViewVehicleMaintenanceReport = new SqlCommand(strQry, conDailyPickup);
                cmdViewVehicleMaintenanceReport.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                dadViewVehicleMaintenanceReport = new SqlDataAdapter(cmdViewVehicleMaintenanceReport);
                dtblVehicleMaintenanceCharges = new DataTable();
                dadViewVehicleMaintenanceReport.Fill(dtblVehicleMaintenanceCharges);
                dadViewVehicleMaintenanceReport.Dispose();
                cmdViewVehicleMaintenanceReport.Dispose();

                dgvMaintenanceCharges.DataSource = dtblVehicleMaintenanceCharges.Copy();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}