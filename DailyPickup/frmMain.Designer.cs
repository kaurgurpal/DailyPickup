namespace DailyPickup
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstripMain = new System.Windows.Forms.MenuStrip();
            this.menuItemManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManageVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManageDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVehicleFuel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVehicleMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllocate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRouteAndDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFuelCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMaintenanceCost = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripMain
            // 
            this.mstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemManage,
            this.menuItemChanges,
            this.menuItemAllocate,
            this.menuItemView,
            this.menuItemUser,
            this.menuItemAdmin});
            this.mstripMain.Location = new System.Drawing.Point(0, 0);
            this.mstripMain.Name = "mstripMain";
            this.mstripMain.Size = new System.Drawing.Size(834, 24);
            this.mstripMain.TabIndex = 1;
            this.mstripMain.Text = "menuStrip1";
            // 
            // menuItemManage
            // 
            this.menuItemManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemManageVehicle,
            this.menuItemManageDrivers,
            this.menuItemSeparator1,
            this.menuItemExit});
            this.menuItemManage.Name = "menuItemManage";
            this.menuItemManage.Size = new System.Drawing.Size(57, 20);
            this.menuItemManage.Text = "Manage";
            // 
            // menuItemManageVehicle
            // 
            this.menuItemManageVehicle.Name = "menuItemManageVehicle";
            this.menuItemManageVehicle.Size = new System.Drawing.Size(119, 22);
            this.menuItemManageVehicle.Text = "Vehicle";
            this.menuItemManageVehicle.Click += new System.EventHandler(this.menuItemManageVehicle_Click);
            // 
            // menuItemManageDrivers
            // 
            this.menuItemManageDrivers.Name = "menuItemManageDrivers";
            this.menuItemManageDrivers.Size = new System.Drawing.Size(119, 22);
            this.menuItemManageDrivers.Text = "Drivers";
            this.menuItemManageDrivers.Click += new System.EventHandler(this.menuItemManageDrivers_Click);
            // 
            // menuItemSeparator1
            // 
            this.menuItemSeparator1.Name = "menuItemSeparator1";
            this.menuItemSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(119, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemChanges
            // 
            this.menuItemChanges.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemVehicleFuel,
            this.menuItemVehicleMaintenance});
            this.menuItemChanges.Name = "menuItemChanges";
            this.menuItemChanges.Size = new System.Drawing.Size(59, 20);
            this.menuItemChanges.Text = "Charges";
            // 
            // menuItemVehicleFuel
            // 
            this.menuItemVehicleFuel.Name = "menuItemVehicleFuel";
            this.menuItemVehicleFuel.Size = new System.Drawing.Size(182, 22);
            this.menuItemVehicleFuel.Text = "Vehicle Fuel";
            this.menuItemVehicleFuel.Click += new System.EventHandler(this.menuItemVehicleFuel_Click);
            // 
            // menuItemVehicleMaintenance
            // 
            this.menuItemVehicleMaintenance.Name = "menuItemVehicleMaintenance";
            this.menuItemVehicleMaintenance.Size = new System.Drawing.Size(182, 22);
            this.menuItemVehicleMaintenance.Text = "Vehicle Maintenance";
            this.menuItemVehicleMaintenance.Click += new System.EventHandler(this.menuItemVehicleMaintenance_Click);
            // 
            // menuItemAllocate
            // 
            this.menuItemAllocate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRouteAndDriver});
            this.menuItemAllocate.Name = "menuItemAllocate";
            this.menuItemAllocate.Size = new System.Drawing.Size(57, 20);
            this.menuItemAllocate.Text = "Allocate";
            // 
            // menuItemRouteAndDriver
            // 
            this.menuItemRouteAndDriver.Name = "menuItemRouteAndDriver";
            this.menuItemRouteAndDriver.Size = new System.Drawing.Size(156, 22);
            this.menuItemRouteAndDriver.Text = "Route && Driver";
            this.menuItemRouteAndDriver.Click += new System.EventHandler(this.menuItemRouteAndDriver_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFuelCharges,
            this.menuItemMaintenanceCost});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(41, 20);
            this.menuItemView.Text = "View";
            // 
            // menuItemFuelCharges
            // 
            this.menuItemFuelCharges.Name = "menuItemFuelCharges";
            this.menuItemFuelCharges.Size = new System.Drawing.Size(171, 22);
            this.menuItemFuelCharges.Text = "Fuel Charges";
            this.menuItemFuelCharges.Click += new System.EventHandler(this.menuItemFuelCharges_Click);
            // 
            // menuItemMaintenanceCost
            // 
            this.menuItemMaintenanceCost.Name = "menuItemMaintenanceCost";
            this.menuItemMaintenanceCost.Size = new System.Drawing.Size(171, 22);
            this.menuItemMaintenanceCost.Text = "Maintenance Cost";
            this.menuItemMaintenanceCost.Click += new System.EventHandler(this.menuItemMaintenanceCost_Click);
            // 
            // menuItemUser
            // 
            this.menuItemUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemChangePassword});
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(41, 20);
            this.menuItemUser.Text = "User";
            // 
            // menuItemChangePassword
            // 
            this.menuItemChangePassword.Name = "menuItemChangePassword";
            this.menuItemChangePassword.Size = new System.Drawing.Size(171, 22);
            this.menuItemChangePassword.Text = "Change Password";
            this.menuItemChangePassword.Click += new System.EventHandler(this.menuItemChangePassword_Click);
            // 
            // menuItemAdmin
            // 
            this.menuItemAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemManageUser});
            this.menuItemAdmin.Name = "menuItemAdmin";
            this.menuItemAdmin.Size = new System.Drawing.Size(48, 20);
            this.menuItemAdmin.Text = "Admin";
            // 
            // menuItemManageUser
            // 
            this.menuItemManageUser.Name = "menuItemManageUser";
            this.menuItemManageUser.Size = new System.Drawing.Size(148, 22);
            this.menuItemManageUser.Text = "Manage User";
            this.menuItemManageUser.Click += new System.EventHandler(this.menuItemManageUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(834, 540);
            this.Controls.Add(this.mstripMain);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mstripMain.ResumeLayout(false);
            this.mstripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstripMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemManage;
        private System.Windows.Forms.ToolStripMenuItem menuItemManageVehicle;
        private System.Windows.Forms.ToolStripMenuItem menuItemManageDrivers;
        private System.Windows.Forms.ToolStripSeparator menuItemSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemChanges;
        private System.Windows.Forms.ToolStripMenuItem menuItemVehicleFuel;
        private System.Windows.Forms.ToolStripMenuItem menuItemVehicleMaintenance;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllocate;
        private System.Windows.Forms.ToolStripMenuItem menuItemRouteAndDriver;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemFuelCharges;
        private System.Windows.Forms.ToolStripMenuItem menuItemMaintenanceCost;
        private System.Windows.Forms.ToolStripMenuItem menuItemUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuItemManageUser;
    }
}

