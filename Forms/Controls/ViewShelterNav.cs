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
    public partial class ViewShelterNav : UserControl
    {
        Point sailGrab; bool sailDrag;
        public ViewShelterNav()
        {
            InitializeComponent();
        }

        // Hotspots(3 σημεία)
        List<Rectangle> hotspots = new() {
            new Rectangle(120,120,18,18), // Shelter A
            new Rectangle(460,200,18,18), // Shelter B
            new Rectangle(800,450,18,18)  // Shelter C
        };
        List<Point> path = new();

        private void picMap_Paint(object sender, PaintEventArgs e)
        {
            using var b = new SolidBrush(Color.DarkRed);
            foreach (var r in hotspots) e.Graphics.FillRectangle(b, r);
            if (path.Count > 1)
                using (var pen = new Pen(Color.Navy, 3)) e.Graphics.DrawLines(pen, path.ToArray());
        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            var hit = hotspots.FirstOrDefault(h => h.Contains(e.Location));
            picMap.Cursor = hit.IsEmpty ? Cursors.Default : Cursors.Hand;

            if (hit == hotspots[0])
                lblShelterInfo.Text = "Καταφύγιο Α – εκτ. χρόνος 7’";
            else if (hit == hotspots[1])
                lblShelterInfo.Text = "Καταφύγιο Β – εκτ. χρόνος 14’";
            else if (hit == hotspots[2])
                lblShelterInfo.Text = "Καταφύγιο Γ – εκτ. χρόνος 20’";
            else
                lblShelterInfo.Text = "Πλοήγηση: επέλεξε καταφύγιο.";
        }

        private void picMap_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = hotspots.FirstOrDefault(h => h.Contains(e.Location));
            if (hit.IsEmpty) return;

            // ίδια λογική διαδρομής
            path = new List<Point> { new Point(30, 30), new Point(150, 100), new Point(hit.X, hit.Y) };
            picMap.Invalidate();

            // ίδιος έλεγχος χρόνου για το click
            if (hit == hotspots[0])
                lblShelterInfo.Text = "Διαδρομή προς Καταφύγιο Α – χρόνος 7’";
            else if (hit == hotspots[1])
                lblShelterInfo.Text = "Διαδρομή προς Καταφύγιο Β – χρόνος 14’";
            else if (hit == hotspots[2])
                lblShelterInfo.Text = "Διαδρομή προς Καταφύγιο Γ – χρόνος 20’";
        }

        private void sail_MouseDown(object sender, MouseEventArgs e)
        {
            sailDrag = true; sailGrab = e.Location;
            pnlSail.BringToFront();
        }

        private void sail_MouseMove(object sender, MouseEventArgs e)
        {
            if (!sailDrag) return;
            pnlSail.Left += e.X - sailGrab.X;
            pnlSail.Top += e.Y - sailGrab.Y;
        }

        private void sail_MouseUp(object sender, MouseEventArgs e)
        {
            sailDrag = false;
            bool nearHotspot = hotspots.Any(h => Distance(h.Location, pnlSail.Location) < 40);
            pnlSail.BackColor = nearHotspot ? Color.LightGreen : Color.LightSkyBlue;
            lblShelterInfo.Text = nearHotspot
                ? "Πανί ασφαλίστηκε ✅"
                : "Πανί τοποθετήθηκε (σύρε για αλλαγή)";
        }

        private static double Distance(Point a, Point b)
        {
            int dx = a.X - b.X;
            int dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
