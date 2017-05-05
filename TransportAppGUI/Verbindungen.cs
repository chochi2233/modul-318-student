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
        Karte karte = new Karte();
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
                    listBoxplan.Items.Add(" " + "Startstation" + "\t" + "Endstation" + "\t\t\t" + "Abfahrt" + "\t\t" + "Ankunft" + "\t\t" + "Zeit");
                    try
                    {
                        var connections = transport.GetConnections(comboBoxvon.Text, comboBoxnach.Text, date, time);
                        foreach (Connection c in connections.ConnectionList)
                        {
                            string departure = formatter.Dateformatter(c.From.Departure) + "   " + formatter.Timeformatter(c.From.Departure);
                            string arrival = formatter.Dateformatter(c.To.Arrival) + "   " + formatter.Timeformatter(c.To.Arrival);
                            char[] sepdur = { ':' };
                            string[] duration = formatter.Splitter(c.Duration, sepdur);

                            listBoxplan.Items.Add(" " + c.From.Station.Name + "\t\t" + c.To.Station.Name + "\t" + departure + "\t" + arrival + "\t" + duration[1] + "min");
                        }
                    }
                    catch
                    {
                    MessageBox.Show("Zu viele Server Requests");
                    }
                }
            else if (comboBoxvon.Text.Length <= 0 && comboBoxnach.Text.Length > 0)
            {
                MessageBox.Show("Geben Sie ihren Startbahnhof ein");
            }
            if (comboBoxnach.Text.Length <= 0 && comboBoxvon.Text.Length > 0)
            {
                MessageBox.Show("Geben Sie ihren Zielbahnhof ein");
            }
            if (comboBoxvon.Text.Length <= 0 && comboBoxnach.Text.Length <= 0)
            {
                MessageBox.Show("Geben Sie die Bahnhöfe ein");
            }
            

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            btnsave.Visible = true;
            btnkartevon.Visible = true;
            btnkartenach.Visible = true;
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
            btnsave.Visible = false;
            btnkartevon.Visible = false;
            btnkartenach.Visible = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            /*if (listBoxplan.Items.Count != 0)
            {
                foreach(string s in listBoxplan)
                MessageBox.Show(listBoxplan.Items.ToString());

            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/place/" + comboBoxvon.Text);
            }
            catch
            {
                MessageBox.Show("Ort wurde nicht gefunden", "try again", MessageBoxButtons.OK);
            }
        }

        private void btnkartenach_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/place/" + comboBoxnach.Text);
            }
            catch
            {
                MessageBox.Show("Ort wurde nicht gefunden", "try again", MessageBoxButtons.OK);
            }
        }

        private void comboBoxnach_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnkartenach.Visible = false;
        }

        private void comboBoxvon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnkartevon.Visible = false;
        }
    }
}
