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
            this.txtBoundRate = new System.Windows.Forms.TextBox();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblSerialport = new System.Windows.Forms.Label();
            this.lblBoundrate = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerForBoundRate = new System.Windows.Forms.Timer(this.components);
            this.lblAx = new System.Windows.Forms.Label();
            this.lblAy = new System.Windows.Forms.Label();
            this.lblAz = new System.Windows.Forms.Label();
            this.glControl1 = new OpenTK.GLControl();
            this.SuspendLayout();
            // 
            // txtBoundRate
            // 
            resources.ApplyResources(this.txtBoundRate, "txtBoundRate");
            this.txtBoundRate.Name = "txtBoundRate";
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSerialPort, "cmbSerialPort");
            this.cmbSerialPort.Name = "cmbSerialPort";
            // 
            // lblSerialport
            // 
            resources.ApplyResources(this.lblSerialport, "lblSerialport");
            this.lblSerialport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSerialport.Name = "lblSerialport";
            // 
            // lblBoundrate
            // 
            resources.ApplyResources(this.lblBoundrate, "lblBoundrate");
            this.lblBoundrate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBoundrate.Name = "lblBoundrate";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            resources.ApplyResources(this.btnEnd, "btnEnd");
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // timerForBoundRate
            // 
            this.timerForBoundRate.Tick += new System.EventHandler(this.timerForBoundRate_Tick);
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
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(240)))), ((int)(((byte)(167)))));
            resources.ApplyResources(this.glControl1, "glControl1");
            this.glControl1.Name = "glControl1";
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.lblAz);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.lblAx);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBoundrate);
            this.Controls.Add(this.lblSerialport);
            this.Controls.Add(this.cmbSerialPort);
            this.Controls.Add(this.txtBoundRate);
            this.Controls.Add(this.glControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBoundRate;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label lblSerialport;
        private System.Windows.Forms.Label lblBoundrate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerForBoundRate;
        private System.Windows.Forms.Label lblAx;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblAz;
        private OpenTK.GLControl glControl1;
    }
}

