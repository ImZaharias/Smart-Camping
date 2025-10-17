namespace SmartCamping.Forms.Controls
{
    partial class ViewSetupTent
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
            label1 = new Label();
            canvas = new Panel();
            stake4 = new Panel();
            stake3 = new Panel();
            stake2 = new Panel();
            stake1 = new Panel();
            lblInfo = new Label();
            canvas.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 0;
            label1.Text = "Ημι-Αυτόματο Στήσιμο Σκηνής";
            // 
            // canvas
            // 
            canvas.BackColor = Color.AliceBlue;
            canvas.Controls.Add(stake4);
            canvas.Controls.Add(stake3);
            canvas.Controls.Add(stake2);
            canvas.Controls.Add(stake1);
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(0, 0);
            canvas.Name = "canvas";
            canvas.Size = new Size(982, 844);
            canvas.TabIndex = 1;
            canvas.Tag = "0";
            canvas.Paint += canvas_Paint;
            // 
            // stake4
            // 
            stake4.BackColor = Color.SaddleBrown;
            stake4.Cursor = Cursors.SizeAll;
            stake4.Location = new Point(48, 269);
            stake4.Name = "stake4";
            stake4.Size = new Size(12, 40);
            stake4.TabIndex = 3;
            stake4.Tag = "0";
            stake4.MouseDown += stake_MouseDown;
            stake4.MouseMove += stake_MouseMove;
            stake4.MouseUp += stake_MouseUp;
            // 
            // stake3
            // 
            stake3.BackColor = Color.SaddleBrown;
            stake3.Cursor = Cursors.SizeAll;
            stake3.Location = new Point(48, 192);
            stake3.Name = "stake3";
            stake3.Size = new Size(12, 40);
            stake3.TabIndex = 2;
            stake3.Tag = "0";
            stake3.MouseDown += stake_MouseDown;
            stake3.MouseMove += stake_MouseMove;
            stake3.MouseUp += stake_MouseUp;
            // 
            // stake2
            // 
            stake2.BackColor = Color.SaddleBrown;
            stake2.Cursor = Cursors.SizeAll;
            stake2.Location = new Point(48, 50);
            stake2.Name = "stake2";
            stake2.Size = new Size(12, 40);
            stake2.TabIndex = 1;
            stake2.MouseDown += stake_MouseDown;
            stake2.MouseMove += stake_MouseMove;
            stake2.MouseUp += stake_MouseUp;
            // 
            // stake1
            // 
            stake1.BackColor = Color.SaddleBrown;
            stake1.Cursor = Cursors.SizeAll;
            stake1.Location = new Point(48, 123);
            stake1.Name = "stake1";
            stake1.Size = new Size(12, 40);
            stake1.TabIndex = 0;
            stake1.Tag = "0";
            stake1.MouseDown += stake_MouseDown;
            stake1.MouseMove += stake_MouseMove;
            stake1.MouseUp += stake_MouseUp;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Dock = DockStyle.Bottom;
            lblInfo.Location = new Point(0, 819);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 25);
            lblInfo.TabIndex = 2;
            // 
            // ViewSetupTent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblInfo);
            Controls.Add(canvas);
            Controls.Add(label1);
            Name = "ViewSetupTent";
            Size = new Size(982, 844);
            canvas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel canvas;
        private Panel stake4;
        private Panel stake3;
        private Panel stake2;
        private Panel stake1;
        private Label lblInfo;
    }
}
