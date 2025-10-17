using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCamping.Forms.Controls
{
    public partial class ViewSetupTent : UserControl
    {

        bool dragging = false;
        Point grab;
        Panel currentStake;

        public ViewSetupTent()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            canvas.TabStop = true;                 // να μπορεί να πάρει focus
            canvas.Focus();                        // δώσε του focus στην αρχή
            canvas.MouseWheel += canvas_MouseWheel;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.SeaGreen, 2);
            e.Graphics.DrawEllipse(pen, new Rectangle(300, 150, 30, 30));
            e.Graphics.DrawEllipse(pen, new Rectangle(700, 150, 30, 30));
            e.Graphics.DrawEllipse(pen, new Rectangle(300, 450, 30, 30));
            e.Graphics.DrawEllipse(pen, new Rectangle(700, 450, 30, 30));
        }

        private void stake_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            currentStake = (Panel)sender;
            grab = e.Location;
        }

        private void stake_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;
            var st = (Panel)sender;
            st.Left += e.X - grab.X;
            st.Top += e.Y - grab.Y;
            ValidateStake(st);
        }

        private void stake_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            currentStake = null;
        }

        // ROTATE με ροδέλα: το βάζουμε στο canvas για να μην χρειαζόμαστε focus στο Panel
        private void canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (currentStake == null) return;

            // Χρησιμοποιούμε Tag για να κρατάμε “γωνία”
            double ang = currentStake.Tag is double d ? d : 0d;
            ang += Math.Sign(e.Delta) * 5;     // ±5°
            currentStake.Tag = ang;

            // Οπτικό hint περιστροφής (αλλάζουμε ύψος)
            currentStake.Height = 40 + (int)Math.Max(-30, Math.Min(30, ang));
            ValidateStake(currentStake);
        }

        // Έλεγχος εγκυρότητας τοποθέτησης
        private void ValidateStake(Panel st)
        {
            var centers = new[] {
                new Point(315,165), new Point(715,165),
                new Point(315,465), new Point(715,465)
            };

            bool ok = centers.Any(c => Distance(new Point(st.Left, st.Top), c) < 40);
            st.BackColor = ok ? Color.ForestGreen : Color.SaddleBrown;
            lblInfo.Text = ok
                ? "Καλή τοποθέτηση πασάλου ✅"
                : "Σύρε τον πάσαλο κοντά στους πράσινους κύκλους…";
        }

        private static double Distance(Point a, Point b)
        {
            int dx = a.X - b.X, dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
