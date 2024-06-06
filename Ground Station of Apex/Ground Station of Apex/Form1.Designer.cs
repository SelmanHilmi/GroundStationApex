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
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.SuspendLayout();
            // 
            // angularGauge1
            // 
            this.angularGauge1.Location = new System.Drawing.Point(274, 129);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(200, 100);
            this.angularGauge1.TabIndex = 0;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1896, 1080);
            this.Controls.Add(this.angularGauge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "APEX AMK";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.AngularGauge angularGauge1;
    }
}

