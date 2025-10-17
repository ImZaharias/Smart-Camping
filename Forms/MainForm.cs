using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCamping
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += (_, __) => LoadView(new Forms.Controls.ViewSetupTent());
        }

        private void LoadView(UserControl view)
        {
            // βασικό loader views
            panelMain.SuspendLayout();
            panelMain.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
            panelMain.ResumeLayout();
        }

        private void btnSetup_Click(object sender, EventArgs e) => LoadView(new Forms.Controls.ViewSetupTent());
        private void btnLighting_Click(object sender, EventArgs e) => LoadView(new Forms.Controls.ViewLighting());
        private void btnEnergy_Click(object sender, EventArgs e) => LoadView(new Forms.Controls.ViewEnergy());
        private void btnShelter_Click(object sender, EventArgs e) => LoadView(new Forms.Controls.ViewShelterNav());
        private void btnTour_Click(object sender, EventArgs e) => LoadView(new Forms.Controls.ViewTouristGuide());
        private void btnOrders_Click(object sender, EventArgs e) => LoadView(new Forms.Controls.ViewOrders());

        private void btnHelp_Click(object sender, EventArgs e)
        {
            using var f = new Forms.FormHelp(); // φορτώνει Docs/help.html
            f.ShowDialog(this);
        }

        private void btnWeather_Click(object s, EventArgs e)
        {
            var vw = new Forms.Controls.ViewWeather();
            vw.DeployRequested += () =>
            {
                // Άνοιξε το Shelter view όταν πατηθεί το link
                LoadView(new Forms.Controls.ViewShelterNav());
            };
            LoadView(vw);
        }

        // Συντομεύσεις πληκτρολογίου
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Αν πατηθεί Ctrl+L → Χαμηλός φωτισμός
            if (e.Control && e.KeyCode == Keys.L && panelMain.Controls.Count > 0 && panelMain.Controls[0] is Forms.Controls.ViewLighting vl)
                vl.btnNight_Click(sender, e);

            // Αν πατηθεί Ctrl+E → Energy Saver
            if (e.Control && e.KeyCode == Keys.E && panelMain.Controls.Count > 0 && panelMain.Controls[0] is Forms.Controls.ViewEnergy ve)
                ve.btnSaver_Click(sender, e);
        }
    }
}