namespace Ground_Station_of_Apex
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblSerialport = new System.Windows.Forms.Label();
            this.lblBoundrate = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerForBoundRate = new System.Windows.Forms.Timer(this.components);
            this.glControl1 = new OpenTK.GLControl();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblAx = new System.Windows.Forms.Label();
            this.lblAy = new System.Windows.Forms.Label();
            this.lblAz = new System.Windows.Forms.Label();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picFullScreen = new System.Windows.Forms.PictureBox();
            this.picExit2 = new System.Windows.Forms.PictureBox();
            this.picDown2 = new System.Windows.Forms.PictureBox();
            this.picFullScreen2 = new System.Windows.Forms.PictureBox();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.picStart2 = new System.Windows.Forms.PictureBox();
            this.picEnd2 = new System.Windows.Forms.PictureBox();
            this.picEnd = new System.Windows.Forms.PictureBox();
            this.picKalibre = new System.Windows.Forms.PictureBox();
            this.picKalibre2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKalibre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKalibre2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbSerialPort, "cmbSerialPort");
            this.cmbSerialPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(236)))));
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Name = "cmbSerialPort";
            // 
            // lblSerialport
            // 
            resources.ApplyResources(this.lblSerialport, "lblSerialport");
            this.lblSerialport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(236)))));
            this.lblSerialport.Name = "lblSerialport";
            // 
            // lblBoundrate
            // 
            resources.ApplyResources(this.lblBoundrate, "lblBoundrate");
            this.lblBoundrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(236)))));
            this.lblBoundrate.Name = "lblBoundrate";
            // 
            // timerForBoundRate
            // 
            this.timerForBoundRate.Tick += new System.EventHandler(this.timerForBoundRate_Tick);
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(240)))), ((int)(((byte)(167)))));
            resources.ApplyResources(this.glControl1, "glControl1");
            this.glControl1.Name = "glControl1";
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cmbBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbBaudRate, "cmbBaudRate");
            this.cmbBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(199)))), ((int)(((byte)(236)))));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Name = "cmbBaudRate";
            // 
            // picLogo
            // 
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // picExit
            // 
            resources.ApplyResources(this.picExit, "picExit");
            this.picExit.Name = "picExit";
            this.picExit.TabStop = false;
            this.picExit.MouseHover += new System.EventHandler(this.picExit_MouseHover);
            // 
            // lblAx
            // 
            resources.ApplyResources(this.lblAx, "lblAx");
            this.lblAx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAx.Name = "lblAx";
            // 
            // lblAy
            // 
            resources.ApplyResources(this.lblAy, "lblAy");
            this.lblAy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAy.Name = "lblAy";
            // 
            // lblAz
            // 
            resources.ApplyResources(this.lblAz, "lblAz");
            this.lblAz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAz.Name = "lblAz";
            // 
            // picDown
            // 
            resources.ApplyResources(this.picDown, "picDown");
            this.picDown.Name = "picDown";
            this.picDown.TabStop = false;
            this.picDown.MouseHover += new System.EventHandler(this.picDown_MouseHover);
            // 
            // picFullScreen
            // 
            resources.ApplyResources(this.picFullScreen, "picFullScreen");
            this.picFullScreen.Name = "picFullScreen";
            this.picFullScreen.TabStop = false;
            this.picFullScreen.MouseHover += new System.EventHandler(this.picFullScreen_MouseHover);
            // 
            // picExit2
            // 
            resources.ApplyResources(this.picExit2, "picExit2");
            this.picExit2.Name = "picExit2";
            this.picExit2.TabStop = false;
            this.picExit2.Click += new System.EventHandler(this.picExit_Click);
            this.picExit2.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // picDown2
            // 
            resources.ApplyResources(this.picDown2, "picDown2");
            this.picDown2.Name = "picDown2";
            this.picDown2.TabStop = false;
            this.picDown2.Click += new System.EventHandler(this.picDown_Click);
            this.picDown2.MouseLeave += new System.EventHandler(this.picDown_MouseLeave);
            // 
            // picFullScreen2
            // 
            resources.ApplyResources(this.picFullScreen2, "picFullScreen2");
            this.picFullScreen2.Name = "picFullScreen2";
            this.picFullScreen2.TabStop = false;
            this.picFullScreen2.Click += new System.EventHandler(this.picFullScreen_Click);
            this.picFullScreen2.MouseLeave += new System.EventHandler(this.picFullScreen_MouseLeave);
            // 
            // picStart
            // 
            resources.ApplyResources(this.picStart, "picStart");
            this.picStart.Name = "picStart";
            this.picStart.TabStop = false;
            this.picStart.MouseHover += new System.EventHandler(this.picStart_MouseHover);
            // 
            // picStart2
            // 
            resources.ApplyResources(this.picStart2, "picStart2");
            this.picStart2.Name = "picStart2";
            this.picStart2.TabStop = false;
            this.picStart2.Click += new System.EventHandler(this.btnStart_Click);
            this.picStart2.MouseLeave += new System.EventHandler(this.picStart_MouseLeave);
            // 
            // picEnd2
            // 
            resources.ApplyResources(this.picEnd2, "picEnd2");
            this.picEnd2.Name = "picEnd2";
            this.picEnd2.TabStop = false;
            this.picEnd2.Click += new System.EventHandler(this.btnEnd_Click);
            this.picEnd2.MouseLeave += new System.EventHandler(this.picEnd2_MouseLeave);
            // 
            // picEnd
            // 
            resources.ApplyResources(this.picEnd, "picEnd");
            this.picEnd.Name = "picEnd";
            this.picEnd.TabStop = false;
            this.picEnd.MouseHover += new System.EventHandler(this.picEnd_MouseHover);
            // 
            // picKalibre
            // 
            resources.ApplyResources(this.picKalibre, "picKalibre");
            this.picKalibre.Name = "picKalibre";
            this.picKalibre.TabStop = false;
            this.picKalibre.MouseHover += new System.EventHandler(this.picKalibre_MouseHover);
            // 
            // picKalibre2
            // 
            resources.ApplyResources(this.picKalibre2, "picKalibre2");
            this.picKalibre2.Name = "picKalibre2";
            this.picKalibre2.TabStop = false;
            this.picKalibre2.Click += new System.EventHandler(this.btnKalibre_Click);
            this.picKalibre2.MouseLeave += new System.EventHandler(this.picKalibre_MouseLeave);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.picKalibre);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.picStart2);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.lblAz);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.lblAx);
            this.Controls.Add(this.lblBoundrate);
            this.Controls.Add(this.lblSerialport);
            this.Controls.Add(this.cmbSerialPort);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picFullScreen);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picExit2);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picDown2);
            this.Controls.Add(this.picFullScreen2);
            this.Controls.Add(this.picEnd);
            this.Controls.Add(this.picEnd2);
            this.Controls.Add(this.picKalibre2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKalibre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKalibre2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label lblSerialport;
        private System.Windows.Forms.Label lblBoundrate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerForBoundRate;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblAx;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblAz;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picFullScreen;
        private System.Windows.Forms.PictureBox picExit2;
        private System.Windows.Forms.PictureBox picDown2;
        private System.Windows.Forms.PictureBox picFullScreen2;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.PictureBox picStart2;
        private System.Windows.Forms.PictureBox picEnd2;
        private System.Windows.Forms.PictureBox picEnd;
        private System.Windows.Forms.PictureBox picKalibre;
        private System.Windows.Forms.PictureBox picKalibre2;
    }
}

