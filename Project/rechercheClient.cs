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
    public partial class rechercheClient : Form
    {
        TextBox[] myClient;
        
        public rechercheClient(TextBox[] client)
        {
            InitializeComponent();
            myClient = client;

        }


        private void find()
        {
            
            TextBox[] info =
           {
                ClientTextBoxRechClient,
                RueTextBoxRechClient,
                VilleTextBoxRechClient,
                CodePostalTextBoxRechClient,
                telephoneTextBoxRechClient
            };
            BALClient.rechercheClient(dataRechClient, info);
        }

        private void ClientExbtn_Click(object sender, EventArgs e)
        {
            AjoutClient a = new AjoutClient(dataRechClient);
            a.Show();
        }

        private void AnnulerRechClientbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rechercheClient_Load(object sender, EventArgs e)
        {
            BALClient.loadClients(dataRechClient);
        }

        private void ClientTextBoxRechClient_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void RueTextBoxRechClient_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void VilleTextBoxRechClient_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void CodePostalTextBoxRechClient_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void telephoneTextBoxRechClient_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void ValiderRechClientbtn_Click(object sender, EventArgs e)
        {
            if (dataRechClient.SelectedRows.Count > 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    myClient[i].Text = dataRechClient.SelectedRows[0].Cells[i+1].Value.ToString();
                }
                myClient[5].Text = dataRechClient.SelectedRows[0].Cells[0].Value.ToString();
                this.Close();
                
            }
        }

    
    }


}
