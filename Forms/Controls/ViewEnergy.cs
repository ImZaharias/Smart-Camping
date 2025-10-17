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
    public partial class ViewEnergy : UserControl
    {
        int battery = 85;
        bool energySaver = false;
        bool acOn = true;

        public ViewEnergy()
        {
            InitializeComponent();
        }

        // Επανασχεδιάζει UI βάσει κατάστασης
        private void UpdateUi()
        {
            prgBattery.Value = Math.Max(0, Math.Min(100, battery));
            lblBattery.Text = $"Μπαταρία: {battery}%";
            btnSaver.Text = energySaver ? "Energy Saver (ON)" : "Energy Saver (OFF)";
            btnAC.Text = acOn ? "AC: ON" : "AC: OFF";
            lblTip.Text = battery < 20
                ? "Χαμηλή μπαταρία – προτείνεται Energy Saver και μείωση φωτισμού."
                : "";
        }

        // Timer
        private void tmrEnergy_Tick(object sender, EventArgs e)
        {
            int load = acOn ? 2 : 1;
            if (energySaver) load = 1;
            battery = Math.Max(0, battery - load);
            UpdateUi();
        }

        // Κουμπί Energy Saver
        public void btnSaver_Click(object sender, EventArgs e)
        {
            energySaver = !energySaver; // toggle
            UpdateUi();
        }

        // Κουμπί AC ON/OFF
        private void btnAC_Click(object sender, EventArgs e)
        {
            acOn = !acOn; // toggle
            UpdateUi();
        }
    }
}
