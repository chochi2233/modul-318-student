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

        public Button GetAcceptButton()
        {
            return btnsearch;
        }

        private void Test()
        {

        }

        /// <summary>
        /// Zeigt die gewünschte verbindung an
        /// </summary>
       private void Connection()
        {
            if (comboBoxvon.Text.Length > 0 && comboBoxnach.Text.Length > 0)
            {
                string date = "&date=" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                string time = "&time=" + dateTimePicker1.Value.Hour + ":" + dateTimePicker1.Value.Minute;
                listBoxplan.Items.Clear();
                listBoxplan.Items.Add(" " + "Startstation" + "\t" + "Endstation" + "\t\t\t" + "Abfahrt" + "\t" + "Ankunft" + "\t" + "Zeit");
                var connections = transport.GetConnections(comboBoxvon.Text, comboBoxnach.Text, date, time);
                foreach (Connection c in connections.ConnectionList)
                {
                    string departure = formatter.Dateformatter(c.From.Departure);
                    string arrival = formatter.Dateformatter(c.To.Arrival);
                    char[] sepdur = { ':' };
                    string[] duration = formatter.Splitter(c.Duration, sepdur);

                    listBoxplan.Items.Add(" " + c.From.Station.Name + "\t\t" + c.To.Station.Name + "\t" + departure + "\t" + arrival + "\t" + duration[1] + "MIN");
                }
            }
            else if(comboBoxvon.Text.Length <= 0 && comboBoxnach.Text.Length > 0)
            {
                MessageBox.Show("Geben Sie ihren Startbahnhof ein");
            }
            if(comboBoxnach.Text.Length <= 0 && comboBoxvon.Text.Length > 0)
            {
                MessageBox.Show("Geben Sie ihren Zielbahnhof ein");
            }
            if (comboBoxvon.Text.Length <= 0 && comboBoxnach.Text.Length <= 0)
            {
                MessageBox.Show("Geben Sie die Bahnhöfe ein");
            }
            timer1.Start();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Verbindungen_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
