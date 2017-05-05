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
                listViewplan.Clear();
                
                    try
                    {
                        listViewplan.Columns.Add("", 0);
                        listViewplan.Columns.Add("Startstation", 200);
                        listViewplan.Columns.Add("Endstation", 200);
                        listViewplan.Columns.Add("Abfahrt", 120);
                        listViewplan.Columns.Add("Ankunft", 120);
                        listViewplan.Columns.Add("Zeit", 50);
                        var connections = transport.GetConnections(comboBoxvon.Text, comboBoxnach.Text, date, time);
                        foreach (Connection c in connections.ConnectionList)
                        {
                            ListViewItem item1 = new ListViewItem("");
                            string departure = formatter.Dateformatter(c.From.Departure) + "   " + formatter.Timeformatter(c.From.Departure);
                            string arrival = formatter.Dateformatter(c.To.Arrival) + "   " + formatter.Timeformatter(c.To.Arrival);
                            char[] sepdur = { ':' };
                            string[] duration = formatter.Splitter(c.Duration, sepdur);

                            item1.SubItems.Add(c.From.Station.Name);
                            item1.SubItems.Add(c.To.Station.Name);
                            item1.SubItems.Add(departure);
                            item1.SubItems.Add(arrival);
                            item1.SubItems.Add(duration[1] + "min");

                            listViewplan.Items.Add(item1);
                            listViewplan.View = View.Details;
                            listViewplan.FullRowSelect = true;
                        }
                    }
                    catch
                    {
                    MessageBox.Show("Zu viele Server Requests");
                    }
                btnkartevon.Visible = true;
                btnkartenach.Visible = true;
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
            btnkartevon.Visible = false;
            btnkartenach.Visible = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
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
