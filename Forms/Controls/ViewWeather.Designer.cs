namespace SmartCamping.Forms.Controls
{
    partial class ViewWeather
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
            lblNow = new Label();
            lblSuggestion = new Label();
            tmrWeather = new System.Windows.Forms.Timer(components);
            lblweather = new Label();
            lnkDeploy = new LinkLabel();
            SuspendLayout();
            // 
            // lblNow
            // 
            lblNow.AutoSize = true;
            lblNow.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNow.Location = new Point(292, 289);
            lblNow.Name = "lblNow";
            lblNow.Size = new Size(0, 45);
            lblNow.TabIndex = 0;
            lblNow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuggestion
            // 
            lblSuggestion.Dock = DockStyle.Bottom;
            lblSuggestion.Location = new Point(0, 804);
            lblSuggestion.Name = "lblSuggestion";
            lblSuggestion.Size = new Size(982, 40);
            lblSuggestion.TabIndex = 1;
            lblSuggestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrWeather
            // 
            tmrWeather.Enabled = true;
            tmrWeather.Interval = 1000;
            tmrWeather.Tick += tmrWeather_Tick;
            // 
            // lblweather
            // 
            lblweather.AutoSize = true;
            lblweather.Font = new Font("Segoe UI", 10F);
            lblweather.Location = new Point(14, 12);
            lblweather.Name = "lblweather";
            lblweather.Size = new Size(234, 28);
            lblweather.TabIndex = 2;
            lblweather.Text = "Παρακολούθηση Καιρού";
            // 
            // lnkDeploy
            // 
            lnkDeploy.AutoSize = true;
            lnkDeploy.Location = new Point(725, 15);
            lnkDeploy.Name = "lnkDeploy";
            lnkDeploy.Size = new Size(157, 25);
            lnkDeploy.TabIndex = 3;
            lnkDeploy.TabStop = true;
            lnkDeploy.Text = "Ανάπτυξη πανιών";
            lnkDeploy.Visible = false;
            lnkDeploy.Click += lnkDeploy_LinkClicked;
            // 
            // ViewWeather
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lnkDeploy);
            Controls.Add(lblweather);
            Controls.Add(lblSuggestion);
            Controls.Add(lblNow);
            Name = "ViewWeather";
            Size = new Size(982, 844);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNow;
        private Label lblSuggestion;
        private System.Windows.Forms.Timer tmrWeather;
        private Label lblweather;
        private LinkLabel lnkDeploy;
    }
}
