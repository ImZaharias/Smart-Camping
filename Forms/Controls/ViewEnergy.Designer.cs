namespace SmartCamping.Forms.Controls
{
    partial class ViewEnergy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblEnergyTitle = new Label();
            prgBattery = new ProgressBar();
            lblBattery = new Label();
            btnSaver = new Button();
            btnAC = new Button();
            lblTip = new Label();
            tmrEnergy = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblEnergyTitle
            // 
            lblEnergyTitle.AutoSize = true;
            lblEnergyTitle.Dock = DockStyle.Top;
            lblEnergyTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnergyTitle.Location = new Point(0, 0);
            lblEnergyTitle.Name = "lblEnergyTitle";
            lblEnergyTitle.Size = new Size(574, 30);
            lblEnergyTitle.TabIndex = 0;
            lblEnergyTitle.Text = "Διαχείριση Ενέργειας (Φωτοβολταϊκά / Κατανάλωση)";
            // 
            // prgBattery
            // 
            prgBattery.Location = new Point(3, 50);
            prgBattery.Name = "prgBattery";
            prgBattery.Size = new Size(976, 55);
            prgBattery.TabIndex = 1;
            // 
            // lblBattery
            // 
            lblBattery.AutoSize = true;
            lblBattery.Location = new Point(3, 130);
            lblBattery.Name = "lblBattery";
            lblBattery.Size = new Size(101, 25);
            lblBattery.TabIndex = 2;
            lblBattery.Text = "Μπαταρία:";
            // 
            // btnSaver
            // 
            btnSaver.Location = new Point(3, 186);
            btnSaver.Name = "btnSaver";
            btnSaver.Size = new Size(976, 34);
            btnSaver.TabIndex = 3;
            btnSaver.Text = "Energy Saver (OFF)";
            btnSaver.UseVisualStyleBackColor = true;
            btnSaver.Click += btnSaver_Click;
            // 
            // btnAC
            // 
            btnAC.Location = new Point(3, 246);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(963, 34);
            btnAC.TabIndex = 4;
            btnAC.Text = "AC: ON";
            btnAC.UseVisualStyleBackColor = true;
            btnAC.Click += btnAC_Click;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTip.ForeColor = Color.DarkRed;
            lblTip.Location = new Point(232, 460);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(20, 25);
            lblTip.TabIndex = 5;
            lblTip.Text = "..";
            // 
            // tmrEnergy
            // 
            tmrEnergy.Enabled = true;
            tmrEnergy.Interval = 800;
            tmrEnergy.Tick += tmrEnergy_Tick;
            // 
            // ViewEnergy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTip);
            Controls.Add(btnAC);
            Controls.Add(btnSaver);
            Controls.Add(lblBattery);
            Controls.Add(prgBattery);
            Controls.Add(lblEnergyTitle);
            Name = "ViewEnergy";
            Size = new Size(982, 844);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnergyTitle;
        private ProgressBar prgBattery;
        private Label lblBattery;
        private Button btnSaver;
        private Button btnAC;
        private Label lblTip;
        private System.Windows.Forms.Timer tmrEnergy;
    }
}
