namespace PartyLights
{
    partial class MainWindow
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
            this.labelSensorValue = new System.Windows.Forms.Label();
            this.labelPartyMode = new System.Windows.Forms.Label();
            this.lblSensorValue = new System.Windows.Forms.Label();
            this.lblPartyMode = new System.Windows.Forms.Label();
            this.tmrMotion = new System.Windows.Forms.Timer(this.components);
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.labelCO2 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelHumid = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCO2 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelSensorValue
            // 
            this.labelSensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensorValue.Location = new System.Drawing.Point(26, 71);
            this.labelSensorValue.Name = "labelSensorValue";
            this.labelSensorValue.Size = new System.Drawing.Size(115, 42);
            this.labelSensorValue.TabIndex = 0;
            this.labelSensorValue.Text = "Motion Sensor Value";
            // 
            // labelPartyMode
            // 
            this.labelPartyMode.AutoSize = true;
            this.labelPartyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartyMode.Location = new System.Drawing.Point(26, 24);
            this.labelPartyMode.Name = "labelPartyMode";
            this.labelPartyMode.Size = new System.Drawing.Size(84, 18);
            this.labelPartyMode.TabIndex = 1;
            this.labelPartyMode.Text = "Party Mode";
            // 
            // lblSensorValue
            // 
            this.lblSensorValue.AutoSize = true;
            this.lblSensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorValue.Location = new System.Drawing.Point(203, 71);
            this.lblSensorValue.Name = "lblSensorValue";
            this.lblSensorValue.Size = new System.Drawing.Size(16, 18);
            this.lblSensorValue.TabIndex = 2;
            this.lblSensorValue.Text = "0";
            // 
            // lblPartyMode
            // 
            this.lblPartyMode.AutoSize = true;
            this.lblPartyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyMode.Location = new System.Drawing.Point(203, 24);
            this.lblPartyMode.Name = "lblPartyMode";
            this.lblPartyMode.Size = new System.Drawing.Size(38, 18);
            this.lblPartyMode.TabIndex = 3;
            this.lblPartyMode.Text = "OFF";
            // 
            // tmrMotion
            // 
            this.tmrMotion.Interval = 5000;
            this.tmrMotion.Tick += new System.EventHandler(this.tmrMotion_Tick);
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 40;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // labelCO2
            // 
            this.labelCO2.AutoSize = true;
            this.labelCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCO2.Location = new System.Drawing.Point(26, 179);
            this.labelCO2.Name = "labelCO2";
            this.labelCO2.Size = new System.Drawing.Size(43, 18);
            this.labelCO2.TabIndex = 5;
            this.labelCO2.Text = "CO2:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(26, 220);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(96, 18);
            this.labelTemp.TabIndex = 6;
            this.labelTemp.Text = "Temperature:";
            // 
            // labelHumid
            // 
            this.labelHumid.AutoSize = true;
            this.labelHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumid.Location = new System.Drawing.Point(26, 261);
            this.labelHumid.Name = "labelHumid";
            this.labelHumid.Size = new System.Drawing.Size(69, 18);
            this.labelHumid.TabIndex = 7;
            this.labelHumid.Text = "Humidity:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(276, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCO2
            // 
            this.lblCO2.AutoSize = true;
            this.lblCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO2.Location = new System.Drawing.Point(203, 179);
            this.lblCO2.Name = "lblCO2";
            this.lblCO2.Size = new System.Drawing.Size(16, 18);
            this.lblCO2.TabIndex = 9;
            this.lblCO2.Text = "0";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(203, 220);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(16, 18);
            this.lblTemp.TabIndex = 10;
            this.lblTemp.Text = "0";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(203, 261);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(16, 18);
            this.lblHumidity.TabIndex = 11;
            this.lblHumidity.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Serial Port:";
            // 
            // cmbCOM
            // 
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(170, 134);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(85, 21);
            this.cmbCOM.TabIndex = 13;
            this.cmbCOM.SelectedIndexChanged += new System.EventHandler(this.cmbCOM_SelectedIndexChanged);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 15000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(276, 369);
            this.Controls.Add(this.cmbCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCO2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelHumid);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelCO2);
            this.Controls.Add(this.lblPartyMode);
            this.Controls.Add(this.lblSensorValue);
            this.Controls.Add(this.labelPartyMode);
            this.Controls.Add(this.labelSensorValue);
            this.Name = "MainWindow";
            this.Text = "Party Light GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label labelSensorValue;
        private System.Windows.Forms.Label labelPartyMode;
        private System.Windows.Forms.Label lblSensorValue;
        private System.Windows.Forms.Label lblPartyMode;
        private System.Windows.Forms.Timer tmrMotion;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Label labelCO2;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHumid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblCO2;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}

