using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport
{
    public partial class Karte : UserControl
    {
        public ITransport transport = new Transport();
        public Karte()
        {
            InitializeComponent();
        }

        public void URL()
        {
            Uri u = new Uri("https://www.google.ch/maps/dir/Luzern/Sempach+Station/");

            webBrowserkarte.Url = u;
        }

        private void webBrowserkarte_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
