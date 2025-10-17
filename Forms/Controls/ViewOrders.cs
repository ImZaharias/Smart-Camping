using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SmartCamping.Forms.Controls
{
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        int nextId = 1;
        int maxOrders = 4;

        private void AddOrder(string what, string when)
        {

            // Έλεγχος αν έχει ήδη 4 επιλογές
            if (lvOrders.Items.Count >= maxOrders)
            {
                MessageBox.Show("Το ημερήσιο πρόγραμμα ολοκληρώθηκε.", "Περιορισμός");
                return;
            }

            // Έλεγχος για διπλότυπο (ίδια περιγραφή)
            if (lvOrders.Items.Cast<ListViewItem>().Any(i => i.SubItems[1].Text == what))
            {
                MessageBox.Show("Αυτή η επιλογή υπάρχει ήδη.", "Διπλότυπο");
                return;
            }

            // Αν υπάρχει άλλη επιλογή ίδιας κατηγορίας (π.χ. ώρας)
            if (lvOrders.Items.Cast<ListViewItem>().Any(i => i.SubItems[2].Text == when))
            {
                MessageBox.Show("Έχεις ήδη επιλέξει αυτό το είδος.", "Περιορισμός");
                return;
            }

            var item = new ListViewItem(new[] { (nextId++).ToString(), what, when, "Επεξεργασία.." });
            lvOrders.Items.Add(item);

            // Μικρή καθυστέρηση και μετά "Έτοιμο"
            var t = new Timer { Interval = 3000 };
            t.Tick += (s, e) => { item.SubItems[3].Text = "Επιτυχία!"; ((Timer)s).Stop(); ((Timer)s).Dispose(); };
            t.Start();
        }

        private void lvOrders_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lvOrders.FocusedItem != null)
            {
                var it = lvOrders.FocusedItem;
                lvOrders.Items.Remove(it);

                MessageBox.Show("Η επιλογή αφαιρέθηκε", "Ενημέρωση",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void breakfast_Click(object sender, EventArgs e) => AddOrder("Τοστ και Χυμός", "10:00");

        private void breakfast_Click2(object sender, EventArgs e) => AddOrder("Ομελέτα και Καφές", "10:00");

        private void lunch_Click(object sender, EventArgs e) => AddOrder("Ομελέτα και Καφές", "14:00");

        private void lunch_Click2(object sender, EventArgs e) => AddOrder("Κοτόπουλο σχάρας και ρύζι", "14:00");


        private void dinner_Click(object sender, EventArgs e) => AddOrder("Ψητά σουβλάκια και σαλάτα", "20:00");

        private void dinner_Click2(object sender, EventArgs e) => AddOrder("Μπριζόλα και πατάτες", "20:00");

        private void fun_Click(object sender, EventArgs e) => AddOrder("Σινεμά στο κάμπινγκ", "22:00");

        private void fun_Click2(object sender, EventArgs e) => AddOrder("Χορός στο κάμπινγκ", "22:00");

    }
}
