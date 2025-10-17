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
    public partial class ViewLighting : UserControl
    {
        public ViewLighting()
        {
            InitializeComponent();

        }

        private void UpdateIntensity()
        {
            int pct = trbIntensity.Value;
            int a = Math.Min(255, Math.Max(20, pct * 255 / 100));
            var baseColor = ledPanel.BackColor.IsEmpty ? Color.LightGoldenrodYellow : ledPanel.BackColor;
            ledPanel.BackColor = Color.FromArgb(a, baseColor);
            lblStatus.Text = $"Ένταση: {pct}%";
        }

        private void trbIntensity_Scroll(object sender, EventArgs e) => UpdateIntensity();

        private void btnColor_Click(object sender, EventArgs e)
        {
            using var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                ledPanel.BackColor = Color.FromArgb(ledPanel.BackColor.A, cd.Color);
            UpdateIntensity();
        }

        public void btnNight_Click(object sender, EventArgs e)
        {
            trbIntensity.Value = 15;
            ledPanel.BackColor = Color.FromArgb(60, Color.LightGoldenrodYellow);
            UpdateIntensity();
        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            trbIntensity.Value = 80;
            ledPanel.BackColor = Color.FromArgb(200, Color.MediumPurple);
            UpdateIntensity();
        }
    }
}
