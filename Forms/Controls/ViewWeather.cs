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
    public partial class ViewWeather : UserControl
    {
        Random rng = new Random();
        int temp = 22, wind = 12, humidity = 55;
        public event Action? DeployRequested;

        public ViewWeather()
        {
            InitializeComponent();
        }

        private void ViewWeather_Load(object sender, EventArgs e)
        {
            tmrWeather.Interval = 2000; // κάθε 2 δευτ.
            tmrWeather.Start();          // ξεκινάει ο Timer
            UpdateUi();
        }
        private void lnkDeploy_LinkClicked(object sender, EventArgs e)
        {
            DeployRequested?.Invoke();
        }

        private void tmrWeather_Tick(object sender, EventArgs e)
        {
            // Τυχαίες αλλά λογικές μεταβολές, πιο "ζωντανές"
            if (temp < 10)
            {
                // Κρύος καιρός → ήπια μεταβολή, υψηλή υγρασία
                temp = Math.Max(2, Math.Min(10, temp + rng.Next(-1, 3)));
                wind = rng.Next(8, 22);
                humidity = rng.Next(70, 90);
            }
            else if (temp < 25)
            {
                // Ήπιος καιρός → μεταβολές μέτριες
                temp = Math.Max(10, Math.Min(25, temp + rng.Next(-2, 3)));
                wind = rng.Next(8, 26);
                humidity = rng.Next(45, 70);
            }
            else
            {
                // Ζεστός καιρός → μεταβολές πιο έντονες, ξηρή ατμόσφαιρα
                temp = Math.Max(25, Math.Min(38, temp + rng.Next(-3, 4)));
                wind = rng.Next(12, 30);
                humidity = rng.Next(30, 55);
            }
            // 25% πιθανότητα για “ριπή” ανέμου
            if (rng.NextDouble() < 0.25)
                wind = Math.Max(wind, rng.Next(28, 45));

            UpdateUi(); // ενημέρωση UI
        }

        private void UpdateUi()
        {
            lblNow.Text = $"Θερμοκρασία: {temp}°C\nΆνεμος: {wind} km/h\nΥγρασία: {humidity}%";

            // Προεπιλογές εμφάνισης
            lblSuggestion.ForeColor = Color.Black;

            // ---- Άνεμος ----
            if (wind >= 28)
            {
                lblSuggestion.Text = "Ισχυροί άνεμοι – δέσε καλά τη σκηνή, απόφυγε τέντες.";
                lblSuggestion.ForeColor = Color.DarkRed;
                lnkDeploy.Visible = true;
                return;
            }

            lnkDeploy.Visible = false;

            // ---- Θερμοκρασία ----
            if (temp <= 8)
            {
                lblSuggestion.Text = "Πολύ κρύο – ντύσου ζεστά, πρόσθεσε επιπλέον μόνωση.";
                lblSuggestion.ForeColor = Color.RoyalBlue;
            }
            else if (temp <= 12)
            {
                lblSuggestion.Text = "Δροσιά – χρειάζεται ελαφριά θέρμανση τη νύχτα.";
                lblSuggestion.ForeColor = Color.SteelBlue;
            }
            else if (temp >= 33)
            {
                lblSuggestion.Text = "Ζέστη – σκιά & νερό, άνοιξε αερισμούς στη σκηνή.";
                lblSuggestion.ForeColor = Color.OrangeRed;
            }
            else if (temp >= 28)
            {
                lblSuggestion.Text = "Ζεστός καιρός – προτείνεται σκιά και καπέλο.";
                lblSuggestion.ForeColor = Color.Orange;
            }
            else
            {
                lblSuggestion.Text = "Συνθήκες ομαλές.";
                lblSuggestion.ForeColor = Color.DarkGreen;
            }

            // ---- Υγρασία ----
            if (humidity >= 85)
                lblSuggestion.Text += " Υψηλή υγρασία – αέρισε καλά τον χώρο.";
            else if (humidity <= 25)
                lblSuggestion.Text += " Χαμηλή υγρασία – ενυδατώσου συχνά.";
        }
        
    }
}
