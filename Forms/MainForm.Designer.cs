namespace SmartCamping
{
    partial class MainForm
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
            panelSidebar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSetup = new Button();
            btnLighting = new Button();
            btnEnergy = new Button();
            btnShelter = new Button();
            btnTour = new Button();
            btnWeather = new Button();
            btnOrders = new Button();
            btnHelp = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(296, 844);
            panelSidebar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Controls.Add(btnSetup);
            flowLayoutPanel1.Controls.Add(btnLighting);
            flowLayoutPanel1.Controls.Add(btnEnergy);
            flowLayoutPanel1.Controls.Add(btnShelter);
            flowLayoutPanel1.Controls.Add(btnTour);
            flowLayoutPanel1.Controls.Add(btnWeather);
            flowLayoutPanel1.Controls.Add(btnOrders);
            flowLayoutPanel1.Controls.Add(btnHelp);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(296, 844);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSetup
            // 
            btnSetup.BackColor = SystemColors.ControlLight;
            btnSetup.FlatStyle = FlatStyle.Flat;
            btnSetup.Font = new Font("Segoe UI", 10F);
            btnSetup.Location = new Point(3, 3);
            btnSetup.Name = "btnSetup";
            btnSetup.Padding = new Padding(10, 0, 0, 0);
            btnSetup.Size = new Size(289, 40);
            btnSetup.TabIndex = 0;
            btnSetup.Text = "🏕️ Στήσιμο Σκηνής";
            btnSetup.TextAlign = ContentAlignment.MiddleLeft;
            btnSetup.UseVisualStyleBackColor = false;
            btnSetup.Click += btnSetup_Click;
            // 
            // btnLighting
            // 
            btnLighting.BackColor = SystemColors.ControlLight;
            btnLighting.FlatStyle = FlatStyle.Flat;
            btnLighting.Font = new Font("Segoe UI", 10F);
            btnLighting.Location = new Point(3, 49);
            btnLighting.Name = "btnLighting";
            btnLighting.Padding = new Padding(10, 0, 0, 0);
            btnLighting.Size = new Size(289, 40);
            btnLighting.TabIndex = 1;
            btnLighting.Text = "💡 Ρύθμιση Φωτισμού";
            btnLighting.TextAlign = ContentAlignment.MiddleLeft;
            btnLighting.UseVisualStyleBackColor = false;
            btnLighting.Click += btnLighting_Click;
            // 
            // btnEnergy
            // 
            btnEnergy.BackColor = SystemColors.ControlLight;
            btnEnergy.FlatStyle = FlatStyle.Flat;
            btnEnergy.Font = new Font("Segoe UI", 10F);
            btnEnergy.Location = new Point(3, 95);
            btnEnergy.Name = "btnEnergy";
            btnEnergy.Padding = new Padding(10, 0, 0, 0);
            btnEnergy.Size = new Size(289, 40);
            btnEnergy.TabIndex = 2;
            btnEnergy.Text = "🔋 Διαχείριση Ενέργειας";
            btnEnergy.TextAlign = ContentAlignment.MiddleLeft;
            btnEnergy.UseVisualStyleBackColor = false;
            btnEnergy.Click += btnEnergy_Click;
            // 
            // btnShelter
            // 
            btnShelter.BackColor = SystemColors.ControlLight;
            btnShelter.FlatStyle = FlatStyle.Flat;
            btnShelter.Font = new Font("Segoe UI", 10F);
            btnShelter.Location = new Point(3, 141);
            btnShelter.Name = "btnShelter";
            btnShelter.Padding = new Padding(10, 0, 0, 0);
            btnShelter.Size = new Size(289, 40);
            btnShelter.TabIndex = 3;
            btnShelter.Text = "\U0001f9ed Καταφύγιο-Πλοήγηση";
            btnShelter.TextAlign = ContentAlignment.MiddleLeft;
            btnShelter.UseVisualStyleBackColor = false;
            btnShelter.Click += btnShelter_Click;
            // 
            // btnTour
            // 
            btnTour.BackColor = SystemColors.ControlLight;
            btnTour.FlatStyle = FlatStyle.Flat;
            btnTour.Font = new Font("Segoe UI", 10F);
            btnTour.Location = new Point(3, 187);
            btnTour.Name = "btnTour";
            btnTour.Padding = new Padding(10, 0, 0, 0);
            btnTour.Size = new Size(289, 40);
            btnTour.TabIndex = 4;
            btnTour.Text = "🗺️ Τουριστική Πλοήγηση";
            btnTour.TextAlign = ContentAlignment.MiddleLeft;
            btnTour.UseVisualStyleBackColor = false;
            btnTour.Click += btnTour_Click;
            // 
            // btnWeather
            // 
            btnWeather.BackColor = SystemColors.ControlLight;
            btnWeather.FlatStyle = FlatStyle.Flat;
            btnWeather.Font = new Font("Segoe UI", 10F);
            btnWeather.Location = new Point(3, 233);
            btnWeather.Name = "btnWeather";
            btnWeather.Padding = new Padding(10, 0, 0, 0);
            btnWeather.Size = new Size(289, 40);
            btnWeather.TabIndex = 5;
            btnWeather.Text = "🌦️ Καιρικές Συνθήκες";
            btnWeather.TextAlign = ContentAlignment.MiddleLeft;
            btnWeather.UseVisualStyleBackColor = false;
            btnWeather.Click += btnWeather_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.ControlLight;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 10F);
            btnOrders.Location = new Point(3, 279);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(10, 0, 0, 0);
            btnOrders.Size = new Size(289, 40);
            btnOrders.TabIndex = 6;
            btnOrders.Text = "☕ Παραγγελίες-Εκδηλώσεις";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlLight;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 10F);
            btnHelp.Location = new Point(3, 325);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(10, 0, 0, 0);
            btnHelp.Size = new Size(289, 40);
            btnHelp.TabIndex = 7;
            btnHelp.Text = "❓ Βοήθεια (Online Help)";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(296, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(982, 844);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 844);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartCamping – Έξυπνη Σκηνή";
            KeyDown += MainForm_KeyDown;
            panelSidebar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSetup;
        private Panel panelMain;
        private Button btnLighting;
        private Button btnEnergy;
        private Button btnShelter;
        private Button btnTour;
        private Button btnWeather;
        private Button btnOrders;
        private Button btnHelp;
    }
}