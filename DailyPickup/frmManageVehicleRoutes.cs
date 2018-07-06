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
    public partial class frmManageVehicleRoutes : Form
    {
        public frmManageVehicleRoutes()
        {
            InitializeComponent();
        }
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdManageVehicleRoutes;
        SqlDataAdapter dadManageVehicleRoutes;
        SqlDataReader dtrManageVehicleRoutes;
        DataTable dtblVehicles, dtblDrivers, dtblSubordinates;
        string strQry = "";
        Boolean blnHasRecord = false;

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

        void BindDrivers()
        {
            strQry = "SELECT     Driver_ID, First_Name + ' ' + Last_Name AS DriverName FROM         DriverMaster WHERE     (Type = 'Driver')";
            cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
            dadManageVehicleRoutes = new SqlDataAdapter(cmdManageVehicleRoutes);
            dtblDrivers = new DataTable();
            dadManageVehicleRoutes.Fill(dtblDrivers);
            dadManageVehicleRoutes.Dispose();
            cmdManageVehicleRoutes.Dispose();

            DataRow drDriver = dtblDrivers.NewRow();
            drDriver["Driver_ID"] = 0;
            drDriver["DriverName"] = "Select";
            dtblDrivers.Rows.InsertAt(drDriver, 0);

            cmbDriver.DataSource = dtblDrivers.Copy();
            cmbDriver.DisplayMember = "DriverName";
            cmbDriver.ValueMember = "Driver_ID";
        }

        void BindSubordinates()
        {
            strQry = "SELECT Driver_ID AS Subordinate_ID, First_Name + ' ' + Last_Name AS SubordinateName FROM  DriverMaster WHERE(Type = 'Subordinate')";
            cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
            dadManageVehicleRoutes = new SqlDataAdapter(cmdManageVehicleRoutes);
            dtblSubordinates = new DataTable();
            dadManageVehicleRoutes.Fill(dtblSubordinates);
            dadManageVehicleRoutes.Dispose();
            cmdManageVehicleRoutes.Dispose();

            DataRow drSubordinate = dtblSubordinates.NewRow();
            drSubordinate["Subordinate_ID"] = 0;
            drSubordinate["SubordinateName"] = "Select";
            dtblSubordinates.Rows.InsertAt(drSubordinate, 0);

            cmbSubordinate.DataSource = dtblSubordinates.Copy();
            cmbSubordinate.DisplayMember = "SubordinateName";
            cmbSubordinate.ValueMember = "Subordinate_ID";
        }

        private void frmManageVehicleRoutes_Load(object sender, EventArgs e)
        {
            try
            {
                BindDrivers();
                BindSubordinates();
                BindVehicles();

                lblModelName.Text = "";
                lblType.Text = "";
                lblManufacturingYear.Text = "";
                lblCompany.Text = "";
                lblSeatingCapacity.Text = "";
                lblFuelType.Text = "";
                txtRoute.Text = "";
                cmbDriver.SelectedIndex = 0;
                cmbSubordinate.SelectedIndex = 0;
                cmbVehicle.SelectedIndex = 0;

                blnHasRecord = false;
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
                strQry = "SELECT     Model_Name, Vehicle_Type, Made_Year, Made_Company, Seating_Capacity, Fuel_Type " +
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
                        lblSeatingCapacity.Text = dtrManageVehicleRoutes["Seating_Capacity"].ToString();
                        lblFuelType.Text = dtrManageVehicleRoutes["Fuel_Type"].ToString();
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
                    dtrManageVehicleRoutes.Close();
                    conDailyPickup.Close();
                    cmdManageVehicleRoutes.Dispose();
                }
                /////////////////////
                strQry = "SELECT     VehicleAllocation.Vehicle_Route, ISNULL(DriverMaster.First_Name + ' ' + DriverMaster.Last_Name, '') AS Vehicle_Driver, " +
                        " ISNULL(SubordinateMaster.First_Name + ' ' + SubordinateMaster.Last_Name, '') AS Vehicle_Subordinate " +
                        " FROM         VehicleAllocation LEFT OUTER JOIN " +
                        " DriverMaster ON DriverMaster.Driver_ID = VehicleAllocation.Vehicle_Driver LEFT OUTER JOIN " +
                        " DriverMaster AS SubordinateMaster ON SubordinateMaster.Driver_ID = VehicleAllocation.Vehicle_Subordinate " +
                        " WHERE     (VehicleAllocation.Vehicle_ID = @Vehicle_ID)";
                cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
                cmdManageVehicleRoutes.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                try
                {
                    if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }

                    dtrManageVehicleRoutes = cmdManageVehicleRoutes.ExecuteReader();
                    if (dtrManageVehicleRoutes.HasRows)
                    {
                        dtrManageVehicleRoutes.Read();

                        txtRoute.Text = dtrManageVehicleRoutes["Vehicle_Route"].ToString();
                        cmbDriver.Text = dtrManageVehicleRoutes["Vehicle_Driver"].ToString();
                        cmbSubordinate.Text = dtrManageVehicleRoutes["Vehicle_Subordinate"].ToString();
                        blnHasRecord = true;
                    }
                    else
                    {
                        txtRoute.Text = "";
                        cmbDriver.SelectedIndex = 0;
                        cmbSubordinate.SelectedIndex = 0;

                        blnHasRecord = false;
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

        private void btnAssignRouteAndDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehicle.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Vehicle", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbVehicle.Focus();
                }
                else if (cmbDriver.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Driver", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbDriver.Focus();
                }
                else
                {
                    if (!blnHasRecord)
                    {
                        strQry = "INSERT INTO VehicleAllocation " +
                                    " (Vehicle_ID, Vehicle_Route, Vehicle_Driver, Vehicle_Subordinate) " +
                                    " VALUES     (@Vehicle_ID,@Vehicle_Route,@Vehicle_Driver,@Vehicle_Subordinate)";
                        cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_Route", SqlDbType.VarChar, 50).Value = txtRoute.Text;
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_Driver", SqlDbType.Int).Value = Convert.ToInt32(cmbDriver.SelectedValue.ToString());
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_Subordinate", SqlDbType.Int).Value = Convert.ToInt32(cmbSubordinate.SelectedValue.ToString()); ;
                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageVehicleRoutes.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageVehicleRoutes.Dispose();

                        MessageBox.Show("Record Saved successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        strQry = "update VehicleAllocation set " +
                                    " Vehicle_Route=@Vehicle_Route, Vehicle_Driver=@Vehicle_Driver, Vehicle_Subordinate=@Vehicle_Subordinate " +
                                    " where Vehicle_ID=@Vehicle_ID ";
                        cmdManageVehicleRoutes = new SqlCommand(strQry, conDailyPickup);
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = Convert.ToInt32(cmbVehicle.SelectedValue.ToString());
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_Route", SqlDbType.VarChar, 50).Value = txtRoute.Text;
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_Driver", SqlDbType.Int).Value = Convert.ToInt32(cmbDriver.SelectedValue.ToString());
                        cmdManageVehicleRoutes.Parameters.Add("@Vehicle_Subordinate", SqlDbType.Int).Value = Convert.ToInt32(cmbSubordinate.SelectedValue.ToString()); ;
                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageVehicleRoutes.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageVehicleRoutes.Dispose();

                        MessageBox.Show("Record updated successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void btnManageDrivers_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageDrivers frmManageDrivers = new frmManageDrivers();
                frmManageDrivers.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}