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
    public partial class ViewTouristGuide : UserControl
    {
        public ViewTouristGuide()
        {
            InitializeComponent();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            if (lstPoi.SelectedItem is null)
            {
                lblPoiInfo.Text = "Διάλεξε σημείο ενδιαφέροντος.";
                return;
            }

            string poi = lstPoi.SelectedItem.ToString();
            string info = poi switch
            {
                string s when s.Contains("Παραλία") => "• Χρόνος: 8’\n• Απόσταση: 1.2km\n• Συμβουλή: Πάρε μαγιό και πετσέτα 😎",
                string s when s.Contains("Μονοπάτι") => "• Χρόνος: 15’\n• Απόσταση: 2.3km\n• Συμβουλή: Νερό και παπούτσια",
                string s when s.Contains("Θέα") => "• Χρόνος: 5’\n• Απόσταση: 0.9km\n• Συμβουλή: Φωτογραφική 📸",
                _ => "• Χρόνος: 12’\n• Απόσταση: 1.4km\n• Συμβουλή: Απόλαυσε τη διαδρομή!"
            };

            lblPoiInfo.Text = $"Διαδρομή προς: {poi}\n{info}";
        }
    }
}
