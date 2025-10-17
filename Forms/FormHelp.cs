using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace SmartCamping.Forms
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            var web = new WebView2 { Dock = DockStyle.Fill };
            this.Controls.Add(web);

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docs", "help.html");
            web.Source = new Uri(path);
        }
    }
}
