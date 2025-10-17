namespace SmartCamping.Forms.Controls
{
    partial class ViewLighting
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
            lbllight = new Label();
            trbIntensity = new TrackBar();
            btnColor = new Button();
            btnNight = new Button();
            btnParty = new Button();
            ledPanel = new Panel();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)trbIntensity).BeginInit();
            SuspendLayout();
            // 
            // lbllight
            // 
            lbllight.AutoSize = true;
            lbllight.Location = new Point(3, 14);
            lbllight.Name = "lbllight";
            lbllight.Size = new Size(167, 25);
            lbllight.TabIndex = 0;
            lbllight.Text = "Ρύθμιση Φωτισμού";
            // 
            // trbIntensity
            // 
            trbIntensity.Location = new Point(3, 612);
            trbIntensity.Maximum = 100;
            trbIntensity.Name = "trbIntensity";
            trbIntensity.Size = new Size(969, 69);
            trbIntensity.TabIndex = 1;
            trbIntensity.Value = 40;
            trbIntensity.Scroll += trbIntensity_Scroll;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(3, 687);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(969, 34);
            btnColor.TabIndex = 2;
            btnColor.Text = "Επιλογή Χρώματος";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnNight
            // 
            btnNight.Location = new Point(3, 742);
            btnNight.Name = "btnNight";
            btnNight.Size = new Size(969, 34);
            btnNight.TabIndex = 3;
            btnNight.Text = "Night Mode";
            btnNight.UseVisualStyleBackColor = true;
            btnNight.Click += btnNight_Click;
            // 
            // btnParty
            // 
            btnParty.Location = new Point(3, 797);
            btnParty.Name = "btnParty";
            btnParty.Size = new Size(969, 34);
            btnParty.TabIndex = 4;
            btnParty.Text = "Party Mode";
            btnParty.UseVisualStyleBackColor = true;
            btnParty.Click += btnParty_Click;
            // 
            // ledPanel
            // 
            ledPanel.Location = new Point(3, 55);
            ledPanel.Name = "ledPanel";
            ledPanel.Size = new Size(969, 490);
            ledPanel.TabIndex = 5;
            
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 563);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(195, 25);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Μπάρα Φωτεινότητας";
            
            // 
            // ViewLighting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(ledPanel);
            Controls.Add(btnParty);
            Controls.Add(btnNight);
            Controls.Add(btnColor);
            Controls.Add(trbIntensity);
            Controls.Add(lbllight);
            Name = "ViewLighting";
            Size = new Size(982, 844);
            ((System.ComponentModel.ISupportInitialize)trbIntensity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllight;
        private TrackBar trbIntensity;
        private Button btnColor;
        private Button btnNight;
        private Button btnParty;
        private Panel ledPanel;
        private Label lblStatus;
    }
}
