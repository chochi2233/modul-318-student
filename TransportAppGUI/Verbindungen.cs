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
        private ITransport transport;
        public Verbindungen()
        {
            InitializeComponent();
        }

       public void Connection()
        {
            transport = new Transport();
            if (comboBoxnach.SelectedIndex != 0 && comboBoxvon.SelectedIndex != 0)
            {
                var connections = transport.GetConnections(comboBoxvon.Text, comboBoxnach.Text);
                foreach(Connection c in connections.ConnectionList)
                {
                    listBoxplan.Items.Add(" " + c.From + " X " + c.To + " Points: " + c.Duration);
                }
            }
            else if(comboBoxvon.SelectedIndex == -1)
            {
                MessageBox.Show("Geben Sie den Startort ein");
            }
            else if (comboBoxnach.SelectedIndex == -1)
            {
                MessageBox.Show("Geben Sie den Zielort ein");
            }



        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Connection();
        }
    }
}
