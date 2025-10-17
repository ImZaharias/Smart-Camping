namespace SmartCamping.Forms.Controls
{
    partial class ViewOrders
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
            canvasOrders = new Panel();
            ctxOrders = new ContextMenuStrip(components);
            breakfast1 = new ToolStripMenuItem();
            breakfast2 = new ToolStripMenuItem();
            lunch1 = new ToolStripMenuItem();
            lunch2 = new ToolStripMenuItem();
            dinner1 = new ToolStripMenuItem();
            dinner2 = new ToolStripMenuItem();
            Fun1 = new ToolStripMenuItem();
            Fun2 = new ToolStripMenuItem();
            label1 = new Label();
            lvOrders = new ListView();
            colID = new ColumnHeader();
            colDesc = new ColumnHeader();
            colTime = new ColumnHeader();
            colStatus = new ColumnHeader();
            canvasOrders.SuspendLayout();
            ctxOrders.SuspendLayout();
            SuspendLayout();
            // 
            // canvasOrders
            // 
            canvasOrders.BackColor = Color.Beige;
            canvasOrders.ContextMenuStrip = ctxOrders;
            canvasOrders.Controls.Add(label1);
            canvasOrders.Dock = DockStyle.Left;
            canvasOrders.Location = new Point(0, 0);
            canvasOrders.Name = "canvasOrders";
            canvasOrders.Size = new Size(390, 844);
            canvasOrders.TabIndex = 0;
            // 
            // ctxOrders
            // 
            ctxOrders.ImageScalingSize = new Size(24, 24);
            ctxOrders.Items.AddRange(new ToolStripItem[] { breakfast1, breakfast2, lunch1, lunch2, dinner1, dinner2, Fun1, Fun2 });
            ctxOrders.Name = "ctxOrders";
            ctxOrders.Size = new Size(480, 260);
            // 
            // breakfast1
            // 
            breakfast1.Name = "breakfast1";
            breakfast1.Size = new Size(479, 32);
            breakfast1.Text = "Πρωινό: Τοστ και Χυμός 9:00";
            breakfast1.Click += breakfast_Click;
            // 
            // breakfast2
            // 
            breakfast2.Name = "breakfast2";
            breakfast2.Size = new Size(479, 32);
            breakfast2.Text = "Πρωινό: Ομελέτα και Καφές 09:00";
            breakfast2.Click += breakfast_Click2;
            // 
            // lunch1
            // 
            lunch1.Name = "lunch1";
            lunch1.Size = new Size(479, 32);
            lunch1.Text = "Μεσημεριανό: Μακαρόνια με σάλτσα 14:00";
            lunch1.Click += lunch_Click;
            // 
            // lunch2
            // 
            lunch2.Name = "lunch2";
            lunch2.Size = new Size(479, 32);
            lunch2.Text = "Μεσημεριανό: Κοτόπουλο σχάρας και ρύζι 14:00";
            lunch2.Click += lunch_Click2;
            // 
            // dinner1
            // 
            dinner1.Name = "dinner1";
            dinner1.Size = new Size(479, 32);
            dinner1.Text = "Βραδυνό: Ψητά σουβλάκια και σαλάτα 20:00";
            dinner1.Click += dinner_Click;
            // 
            // dinner2
            // 
            dinner2.Name = "dinner2";
            dinner2.Size = new Size(479, 32);
            dinner2.Text = "Βραδυνό: Μπριζόλα και πατάτες 20:00";
            dinner2.Click += dinner_Click2;
            // 
            // Fun1
            // 
            Fun1.Name = "Fun1";
            Fun1.Size = new Size(479, 32);
            Fun1.Text = "Ψυχαγωγία: Σινεμά στο κάμπινγκ 22:00";
            Fun1.Click += fun_Click;
            // 
            // Fun2
            // 
            Fun2.Name = "Fun2";
            Fun2.Size = new Size(479, 32);
            Fun2.Text = "Ψυχαγωγία: Χορός στο κάμπινγκ 22:00";
            Fun2.Click += fun_Click2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(365, 25);
            label1.TabIndex = 0;
            label1.Text = "Δεξί κλικ για να κλείσεις το πρόγραμμά σου";
            // 
            // lvOrders
            // 
            lvOrders.Columns.AddRange(new ColumnHeader[] { colID, colDesc, colTime, colStatus });
            lvOrders.Dock = DockStyle.Fill;
            lvOrders.FullRowSelect = true;
            lvOrders.GridLines = true;
            lvOrders.Location = new Point(390, 0);
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(592, 844);
            lvOrders.TabIndex = 1;
            lvOrders.UseCompatibleStateImageBehavior = false;
            lvOrders.View = View.Details;
            lvOrders.MouseClick += lvOrders_MouseClick;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 50;
            // 
            // colDesc
            // 
            colDesc.Text = "Περιγραφή";
            colDesc.Width = 260;
            // 
            // colTime
            // 
            colTime.Text = "Ώρα";
            colTime.TextAlign = HorizontalAlignment.Center;
            colTime.Width = 100;
            // 
            // colStatus
            // 
            colStatus.Text = "Κατάσταση";
            colStatus.TextAlign = HorizontalAlignment.Center;
            colStatus.Width = 130;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvOrders);
            Controls.Add(canvasOrders);
            Name = "ViewOrders";
            Size = new Size(982, 844);
            canvasOrders.ResumeLayout(false);
            canvasOrders.PerformLayout();
            ctxOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel canvasOrders;
        private ListView lvOrders;
        private ColumnHeader colID;
        private ColumnHeader colDesc;
        private ColumnHeader colTime;
        private ColumnHeader colStatus;
        private ContextMenuStrip ctxOrders;
        private ToolStripMenuItem breakfast1;
        private ToolStripMenuItem breakfast2;
        private ToolStripMenuItem lunch1;
        private ToolStripMenuItem lunch2;
        private ToolStripMenuItem dinner1;
        private ToolStripMenuItem dinner2;
        private ToolStripMenuItem Fun1;
        private ToolStripMenuItem Fun2;
        private Label label1;
    }
}
