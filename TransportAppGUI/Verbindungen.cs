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
    
    public partial class Verbindungen : UserControl
    {
        Formatter formatter = new Formatter();
        public ITransport transport = new Transport();
        public Verbindungen()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Zeigt die gewünschte verbindung an
        /// </summary>
       public void Connection()
        {
            listBoxplan.Items.Add(" " + "Startstation" + "\t" + "Endstation" + "\t\t\t" + "Abfahrt" + "\t" + "Ankunft" + "\t" + "Zeit");
            var connections = transport.GetConnections(comboBoxvon.Text, comboBoxnach.Text);
            foreach(Connection c in connections.ConnectionList)
            {
                
                string departure = formatter.Dateformatter(c.From.Departure);
                string arrival = formatter.Dateformatter(c.To.Arrival);
                char[] sepdur = { ':' };
                string[] duration = formatter.Splitter(c.Duration, sepdur);
                
                listBoxplan.Items.Add(" " + c.From.Station.Name + "\t\t" + c.To.Station.Name + "\t" + departure + "\t" + arrival + "\t" + duration[1] + "MIN");
            }
            
            



        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            listBoxplan.Items.Clear();
            Connection();
        }

        private void comboBoxvon_TextUpdate(object sender, EventArgs e)
        {
            formatter.Combosearch(comboBoxvon);
        }

        private void comboBoxnach_TextUpdate(object sender, EventArgs e)
        {
            formatter.Combosearch(comboBoxnach);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
