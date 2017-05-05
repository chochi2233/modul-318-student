using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport
{
    public partial class Form1 : Form
    {
        
        Verbindungen verbindungen = new Verbindungen();
        Fahrplan fahrplan = new Fahrplan();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(verbindungen);
            this.AcceptButton = verbindungen.GetAcceptButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(fahrplan);
            this.AcceptButton = fahrplan.GetAcceptButton();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(verbindungen);
            this.AcceptButton = verbindungen.GetAcceptButton();
            

        }
    }
}
