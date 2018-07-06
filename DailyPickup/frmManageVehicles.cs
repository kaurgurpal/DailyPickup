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
    public partial class frmManageVehicles : Form
    {
        public frmManageVehicles()
        {
            InitializeComponent();
        }
        SqlConnection conDailyPickup = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());

        SqlCommand cmdManageVehicles;
        SqlDataAdapter dadManageVehicles;
        DataTable dtblVehicles, dtblVehicleTypes;
        string strQry = "";
        int intVehiclesID, intRowIndex = 0;

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
            try
            {
                strQry = "SELECT     Vehicle_ID, Vehicle_Type, Registeration_Number, Model_Name, Made_Year, Made_Company, Seating_Capacity, Mileage_Per_Liter, Fuel_Type  " +
                      " FROM         VehicleMaster WHERE     (IS_Deleted = 0)";
                cmdManageVehicles = new SqlCommand(strQry, conDailyPickup);
                dadManageVehicles = new SqlDataAdapter(cmdManageVehicles);
                dtblVehicles = new DataTable();
                dadManageVehicles.Fill(dtblVehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void BindVehicleTypes()
        {
            strQry = "SELECT     Vehicle_Type_ID, Vehicle_Type FROM         VehicleTypeMaster";
            cmdManageVehicles = new SqlCommand(strQry, conDailyPickup);
            dadManageVehicles = new SqlDataAdapter(cmdManageVehicles);
            dtblVehicleTypes = new DataTable();
            dadManageVehicles.Fill(dtblVehicleTypes);
            dadManageVehicles.Dispose();
            dadManageVehicles.Dispose();

            DataRow drCase = dtblVehicleTypes.NewRow();
            drCase["Vehicle_Type_ID"] = 0;
            drCase["Vehicle_Type"] = "Select";
            dtblVehicleTypes.Rows.InsertAt(drCase, 0);

            cmbVehicleType.DataSource = dtblVehicleTypes.Copy();
            cmbVehicleType.DisplayMember = "Vehicle_Type";
            cmbVehicleType.ValueMember = "Vehicle_Type_ID";
        }

        private void frmManageVehicles_Load(object sender, EventArgs e)
        {
            try
            {
                BindVehicleTypes();
                BindVehicles();
                if (dtblVehicles.Rows.Count <= 0)
                {
                    btnNewVehicle.PerformClick();
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

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                intVehiclesID = 0;
                cmbVehicleType.SelectedIndex = 0;

                txtRegistrationNumber.Text = "";
                txtModelName.Text = "";
                txtManufacturingYear.Text = "";
                txtManufacturingCompany.Text = "";
                txtSeatingCapacity.Text = "";
                txtMilagePerLiter.Text = "";
                txtFuelType.Text = "";

                cmbVehicleType.Focus();
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
                if (cmbVehicleType.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Vehicle Type", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbVehicleType.Focus();
                }
                else if (txtModelName.Text == "")
                {
                    MessageBox.Show("Enter Model Name", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelName.Focus();
                }
                else if (txtRegistrationNumber.Text == "")
                {
                    MessageBox.Show("Enter Registration Number", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegistrationNumber.Focus();
                }
                else
                {
                    if (intVehiclesID == 0)
                    {
                        strQry = "INSERT INTO VehicleMaster " +
                                    " (Vehicle_Type, Registeration_Number, Model_Name, Made_Year, Made_Company, Seating_Capacity, Mileage_Per_Liter, Fuel_Type, IS_Deleted) " +
                                    " VALUES     (@Vehicle_Type,@Registeration_Number,@Model_Name,@Made_Year,@Made_Company,@Seating_Capacity,@Mileage_Per_Liter,@Fuel_Type, 0)";
                        cmdManageVehicles = new SqlCommand(strQry, conDailyPickup);
                        cmdManageVehicles.Parameters.Add("@Vehicle_Type", SqlDbType.VarChar, 50).Value = cmbVehicleType.Text;
                        cmdManageVehicles.Parameters.Add("@Registeration_Number", SqlDbType.VarChar, 50).Value = txtRegistrationNumber.Text;
                        cmdManageVehicles.Parameters.Add("@Model_Name", SqlDbType.VarChar, 50).Value = txtModelName.Text;
                        cmdManageVehicles.Parameters.Add("@Made_Year", SqlDbType.VarChar, 10).Value = txtManufacturingYear.Text;
                        cmdManageVehicles.Parameters.Add("@Made_Company", SqlDbType.VarChar, 50).Value = txtManufacturingCompany.Text;
                        if (txtSeatingCapacity.Text == "") { txtSeatingCapacity.Text = "0"; }
                        cmdManageVehicles.Parameters.Add("@Seating_Capacity", SqlDbType.Int).Value = Convert.ToInt32(txtSeatingCapacity.Text);
                        if (txtMilagePerLiter.Text == "") { txtMilagePerLiter.Text = "0"; }
                        cmdManageVehicles.Parameters.Add("@Mileage_Per_Liter", SqlDbType.Int).Value = Convert.ToInt32(txtMilagePerLiter.Text);
                        cmdManageVehicles.Parameters.Add("@Fuel_Type", SqlDbType.VarChar, 20).Value = txtFuelType.Text;

                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageVehicles.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageVehicles.Dispose();

                        MessageBox.Show("Record saved successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        strQry = "UPDATE    VehicleMaster " +
                                    " SET              Vehicle_Type = @Vehicle_Type, Registeration_Number = @Registeration_Number, Model_Name = @Model_Name, Made_Year = @Made_Year,  " +
                                    " Made_Company = @Made_Company, Seating_Capacity = @Seating_Capacity, Mileage_Per_Liter = @Mileage_Per_Liter,  " +
                                    " Fuel_Type = @Fuel_Type " +
                                    " WHERE     (Vehicle_ID = @Vehicle_ID)";
                        cmdManageVehicles = new SqlCommand(strQry, conDailyPickup);
                        cmdManageVehicles.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = intVehiclesID;
                        cmdManageVehicles.Parameters.Add("@Vehicle_Type", SqlDbType.VarChar, 50).Value = cmbVehicleType.Text;
                        cmdManageVehicles.Parameters.Add("@Registeration_Number", SqlDbType.VarChar, 50).Value = txtRegistrationNumber.Text;
                        cmdManageVehicles.Parameters.Add("@Model_Name", SqlDbType.VarChar, 50).Value = txtModelName.Text;
                        cmdManageVehicles.Parameters.Add("@Made_Year", SqlDbType.VarChar, 10).Value = txtManufacturingYear.Text;
                        cmdManageVehicles.Parameters.Add("@Made_Company", SqlDbType.VarChar, 50).Value = txtManufacturingCompany.Text;
                        if (txtSeatingCapacity.Text == "") { txtSeatingCapacity.Text = "0"; }
                        cmdManageVehicles.Parameters.Add("@Seating_Capacity", SqlDbType.Int).Value = Convert.ToInt32(txtSeatingCapacity.Text);
                        if (txtMilagePerLiter.Text == "") { txtMilagePerLiter.Text = "0"; }
                        cmdManageVehicles.Parameters.Add("@Mileage_Per_Liter", SqlDbType.Int).Value = Convert.ToInt32(txtMilagePerLiter.Text);
                        cmdManageVehicles.Parameters.Add("@Fuel_Type", SqlDbType.VarChar, 20).Value = txtFuelType.Text;

                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageVehicles.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageVehicles.Dispose();


                        MessageBox.Show("Record updated successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    BindVehicles();
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
                btnNewVehicle.PerformClick();
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
                if (dtblVehicles.Rows.Count > 0)
                {
                    intVehiclesID = Convert.ToInt32(dtblVehicles.Rows[0]["Vehicle_ID"].ToString());
                    cmbVehicleType.Text = dtblVehicles.Rows[0]["Vehicle_Type"].ToString();
                    txtRegistrationNumber.Text = dtblVehicles.Rows[0]["Registeration_Number"].ToString();
                    txtModelName.Text = dtblVehicles.Rows[0]["Model_Name"].ToString();
                    txtManufacturingYear.Text = dtblVehicles.Rows[0]["Made_Year"].ToString();
                    txtManufacturingCompany.Text = dtblVehicles.Rows[0]["Made_Company"].ToString();
                    txtSeatingCapacity.Text = dtblVehicles.Rows[0]["Seating_Capacity"].ToString();
                    txtMilagePerLiter.Text = dtblVehicles.Rows[0]["Mileage_Per_Liter"].ToString();
                    txtFuelType.Text = dtblVehicles.Rows[0]["Fuel_Type"].ToString();
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
                    intVehiclesID = Convert.ToInt32(dtblVehicles.Rows[intRowIndex - 1]["Vehicle_ID"].ToString());
                    cmbVehicleType.Text = dtblVehicles.Rows[intRowIndex - 1]["Vehicle_Type"].ToString();
                    txtRegistrationNumber.Text = dtblVehicles.Rows[intRowIndex - 1]["Registeration_Number"].ToString();
                    txtModelName.Text = dtblVehicles.Rows[intRowIndex - 1]["Model_Name"].ToString();
                    txtManufacturingYear.Text = dtblVehicles.Rows[intRowIndex - 1]["Made_Year"].ToString();
                    txtManufacturingCompany.Text = dtblVehicles.Rows[intRowIndex - 1]["Made_Company"].ToString();
                    txtSeatingCapacity.Text = dtblVehicles.Rows[intRowIndex - 1]["Seating_Capacity"].ToString();
                    txtMilagePerLiter.Text = dtblVehicles.Rows[intRowIndex - 1]["Mileage_Per_Liter"].ToString();
                    txtFuelType.Text = dtblVehicles.Rows[intRowIndex - 1]["Fuel_Type"].ToString();

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
                if ((intRowIndex + 1) <= dtblVehicles.Rows.Count - 1)
                {
                    intVehiclesID = Convert.ToInt32(dtblVehicles.Rows[intRowIndex + 1]["Vehicle_ID"].ToString());
                    cmbVehicleType.Text = dtblVehicles.Rows[intRowIndex + 1]["Vehicle_Type"].ToString();
                    txtRegistrationNumber.Text = dtblVehicles.Rows[intRowIndex + 1]["Registeration_Number"].ToString();
                    txtModelName.Text = dtblVehicles.Rows[intRowIndex + 1]["Model_Name"].ToString();
                    txtManufacturingYear.Text = dtblVehicles.Rows[intRowIndex + 1]["Made_Year"].ToString();
                    txtManufacturingCompany.Text = dtblVehicles.Rows[intRowIndex + 1]["Made_Company"].ToString();
                    txtSeatingCapacity.Text = dtblVehicles.Rows[intRowIndex + 1]["Seating_Capacity"].ToString();
                    txtMilagePerLiter.Text = dtblVehicles.Rows[intRowIndex + 1]["Mileage_Per_Liter"].ToString();
                    txtFuelType.Text = dtblVehicles.Rows[intRowIndex + 1]["Fuel_Type"].ToString();
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
                if (dtblVehicles.Rows.Count > 0)
                {
                    intVehiclesID = Convert.ToInt32(dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Vehicle_ID"].ToString());
                    cmbVehicleType.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Vehicle_Type"].ToString();
                    txtRegistrationNumber.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Registeration_Number"].ToString();
                    txtModelName.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Model_Name"].ToString();
                    txtManufacturingYear.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Made_Year"].ToString();
                    txtManufacturingCompany.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Made_Company"].ToString();
                    txtSeatingCapacity.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Seating_Capacity"].ToString();
                    txtMilagePerLiter.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Mileage_Per_Liter"].ToString();
                    txtFuelType.Text = dtblVehicles.Rows[dtblVehicles.Rows.Count - 1]["Fuel_Type"].ToString();

                    intRowIndex = dtblVehicles.Rows.Count - 1;
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
                if (dtblVehicles.Rows.Count > 0 && intVehiclesID > 0)
                {
                    if (MessageBox.Show("Are you sure?", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        strQry = "UPDATE  VehicleMaster   SET IS_Deleted = 1 WHERE     (Vehicle_ID = @Vehicle_ID)";
                        cmdManageVehicles = new SqlCommand(strQry, conDailyPickup);
                        cmdManageVehicles.Parameters.Add("@Vehicle_ID", SqlDbType.Int).Value = intVehiclesID;
                        if (conDailyPickup.State == ConnectionState.Closed) { conDailyPickup.Open(); }
                        cmdManageVehicles.ExecuteNonQuery();
                        conDailyPickup.Close();
                        cmdManageVehicles.Dispose();
                        ///////////////////
                        BindVehicles();

                        MessageBox.Show("Vehicle deleted successfully", "Alpha Net Tech. Pvt. Ltd: Message Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

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