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
            if (comboboxstation.Text.Length > 0)
            {
                try
                {
                    station = transport.GetStationBoard(comboboxstation.Text, comboboxstation.Text);
                    listViewplan.Columns.Add("", 0);
                    listViewplan.Columns.Add("Verbindung", 200);
                    listViewplan.Columns.Add("Endstation", 200);
                    listViewplan.Columns.Add("Abfahrt", 120);
                    foreach (StationBoard s in station.Entries)
                    {
                        ListViewItem item1 = new ListViewItem("");
                        item1.SubItems.Add(s.Name);
                        item1.SubItems.Add(s.To);
                        item1.SubItems.Add(s.Stop.Departure.ToShortTimeString());
                        listViewplan.Items.Add(item1);
                        listViewplan.View = View.Details;
                        listViewplan.FullRowSelect = true;
                    }
                }
                catch
                {
                    MessageBox.Show("zu viele Serverrequests");
                }
                lblstation.Text = comboboxstation.Text;
            }else
            {
                MessageBox.Show("Geben Sie ihre Station ein");
            }
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
