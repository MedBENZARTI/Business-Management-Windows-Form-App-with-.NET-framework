using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace Project
{
    public partial class AjoutClient : Form
    {
        DataGridView clients;
        public AjoutClient(DataGridView dgv)
        {
            InitializeComponent();
            clients = dgv;
        }

        private void ValiderAjoutClientbtn_Click(object sender, EventArgs e)
        {
            DAL.Client client = new DAL.Client(clientBox.Text,rueBox.Text,villeBox.Text,Int32.Parse(cpBox.Text), Int32.Parse(telBox.Text));
            BALClient.addClient(client);
            BALClient.loadClients(clients);
            this.Close();
        }

        private void AnnulerAjoutClientbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
