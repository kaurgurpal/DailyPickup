namespace DailyPickup
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.pbSplashScreen = new System.Windows.Forms.ProgressBar();
            this.tmrSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.BackColor = System.Drawing.SystemColors.Control;
            this.pbSplashScreen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.pbSplashScreen.Location = new System.Drawing.Point(5, 181);
            this.pbSplashScreen.MarqueeAnimationSpeed = 50;
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(386, 11);
            this.pbSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbSplashScreen.TabIndex = 0;
            // 
            // tmrSplashScreen
            // 
            this.tmrSplashScreen.Interval = 600;
            this.tmrSplashScreen.Tick += new System.EventHandler(this.tmrSplashScreen_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(398, 198);
            this.ControlBox = false;
            this.Controls.Add(this.pbSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbSplashScreen;
        private System.Windows.Forms.Timer tmrSplashScreen;
    }
}