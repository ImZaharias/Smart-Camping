namespace SmartCamping.Forms.Controls
{
    partial class ViewTouristGuide
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
            lstPoi = new ListBox();
            btnRoute = new Button();
            lblPoiInfo = new Label();
            panelLeft = new Panel();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // lstPoi
            // 
            lstPoi.Dock = DockStyle.Fill;
            lstPoi.Font = new Font("Segoe UI", 10F);
            lstPoi.FormattingEnabled = true;
            lstPoi.IntegralHeight = false;
            lstPoi.ItemHeight = 28;
            lstPoi.Items.AddRange(new object[] { "Παραλία – Ακρογιάλι", "Μονοπάτι – Πεύκα", "Θέα – Λοφάκι", "Εστιατόριο – Ταβερνάκι" });
            lstPoi.Location = new Point(0, 0);
            lstPoi.Name = "lstPoi";
            lstPoi.Size = new Size(280, 844);
            lstPoi.TabIndex = 0;
            // 
            // btnRoute
            // 
            btnRoute.Dock = DockStyle.Top;
            btnRoute.Font = new Font("Segoe UI", 10F);
            btnRoute.Location = new Point(280, 0);
            btnRoute.Name = "btnRoute";
            btnRoute.Size = new Size(702, 35);
            btnRoute.TabIndex = 1;
            btnRoute.Text = "Διαδρομή →";
            btnRoute.UseVisualStyleBackColor = true;
            btnRoute.Click += btnRoute_Click;
            // 
            // lblPoiInfo
            // 
            lblPoiInfo.AutoSize = true;
            lblPoiInfo.Location = new Point(443, 360);
            lblPoiInfo.Name = "lblPoiInfo";
            lblPoiInfo.Size = new Size(467, 25);
            lblPoiInfo.TabIndex = 2;
            lblPoiInfo.Text = "Διάλεξε σημείο ενδιαφέροντος και πάτα «Διαδρομή →».";
            lblPoiInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(lstPoi);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(280, 844);
            panelLeft.TabIndex = 3;
            // 
            // ViewTouristGuide
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRoute);
            Controls.Add(panelLeft);
            Controls.Add(lblPoiInfo);
            Name = "ViewTouristGuide";
            Size = new Size(982, 844);
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPoi;
        private Button btnRoute;
        private Label lblPoiInfo;
        private Panel panelLeft;
    }
}
