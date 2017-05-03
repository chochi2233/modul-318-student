using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransport
{
    public partial class Fahrplan : UserControl
    {
        Formatter formatter = new Formatter();
        public Fahrplan()
        {
            InitializeComponent();
        }
        public ITransport transport = new Transport();
        private void Fahrplan_Load(object sender, EventArgs e)
        {

        }

        private void comboboxstation_TextUpdate(object sender, EventArgs e)
        {
            formatter.Combosearch(comboboxstation);
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            StationBoardRoot station = new StationBoardRoot();
            station = transport.GetStationBoard(comboboxstation.Text, comboboxstation.Text);
            
            foreach (StationBoard s in station.Entries)
            {
                char[] sep = { ' ' };
                string[] departure = formatter.Splitter(Convert.ToString(s.Stop.Departure.Date), sep);
                listBoxplan.Items.Add(" " + s.Name + "\t" + s.To + "\t" + s.Stop.Departure.ToShortTimeString());
            }
            lblstation.Text = comboboxstation.Text;
        }
    }
}
