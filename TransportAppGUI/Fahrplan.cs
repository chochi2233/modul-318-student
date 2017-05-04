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
        StationBoardRoot station = new StationBoardRoot();
        Formatter formatter = new Formatter();
        public ITransport transport = new Transport();
        public Fahrplan()
        {
            InitializeComponent();
        }
        
        private void comboboxstation_TextUpdate(object sender, EventArgs e)
        {
            formatter.Combosearch(comboboxstation);
            
        }
        /// <summary>
        /// gibt die Verbindungen von der jeweiligen Station aus
        /// </summary>
        private void stationboard()
        {
            listBoxplan.Items.Clear();
            station = transport.GetStationBoard(comboboxstation.Text, comboboxstation.Text);

            foreach (StationBoard s in station.Entries)
            {
                char[] sep = { ' ' };
                string[] departure = formatter.Splitter(Convert.ToString(s.Stop.Departure.Date), sep);
                listBoxplan.Items.Add(" " + s.Name + "\t" + s.To + "\t" + s.Stop.Departure.ToShortTimeString());
            }
            lblstation.Text = comboboxstation.Text;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            stationboard();
        }
        
        public Button GetAcceptButton()
        {
            return btnsearch;
        }
    }
}
