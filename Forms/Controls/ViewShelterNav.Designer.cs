namespace SmartCamping.Forms.Controls
{
    partial class ViewShelterNav
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
            picMap = new PictureBox();
            lblShelterInfo = new Label();
            pnlSail = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            SuspendLayout();
            // 
            // picMap
            // 
            picMap.BackColor = Color.LightGray;
            picMap.Dock = DockStyle.Fill;
            picMap.Location = new Point(0, 0);
            picMap.Name = "picMap";
            picMap.Size = new Size(982, 844);
            picMap.TabIndex = 0;
            picMap.TabStop = false;
            picMap.Paint += picMap_Paint;
            picMap.MouseClick += picMap_MouseClick;
            picMap.MouseMove += picMap_MouseMove;
            // 
            // lblShelterInfo
            // 
            lblShelterInfo.Dock = DockStyle.Bottom;
            lblShelterInfo.Location = new Point(0, 816);
            lblShelterInfo.Name = "lblShelterInfo";
            lblShelterInfo.Size = new Size(982, 28);
            lblShelterInfo.TabIndex = 1;
            // 
            // pnlSail
            // 
            pnlSail.BackColor = Color.LightSteelBlue;
            pnlSail.BorderStyle = BorderStyle.FixedSingle;
            pnlSail.Location = new Point(431, 56);
            pnlSail.Name = "pnlSail";
            pnlSail.Size = new Size(60, 30);
            pnlSail.TabIndex = 2;
            pnlSail.MouseDown += sail_MouseDown;
            pnlSail.MouseMove += sail_MouseMove;
            pnlSail.MouseUp += sail_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(477, 25);
            label1.TabIndex = 3;
            label1.Text = "Σύρε το πανί κοντά στο καταφύγιο για να το ασφαλίσεις.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewShelterNav
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pnlSail);
            Controls.Add(lblShelterInfo);
            Controls.Add(picMap);
            Name = "ViewShelterNav";
            Size = new Size(982, 844);
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picMap;
        private Label lblShelterInfo;
        private Panel pnlSail;
        private Label label1;
    }
}
