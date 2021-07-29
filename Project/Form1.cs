using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BAL;
using DAL;

namespace Project
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void remplirListeCommandedgv()
        {
            BALCommande.remplirListeCommande(ListeCommandedgv);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirListeCommandedgv();
        }

        private void ListeCommandedgv_SelectionChanged(object sender, EventArgs e)
        {
            if (ListeCommandedgv.SelectedRows.Count > 0)
            {
                BALLignecmd.remplirListeLigneCmnd(ListeLigneCmddgv, ListeCommandedgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ListeCommandedgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] infoClient = { InfoClient, InfoAdrs, InfoVille, InfoCP, InfoTel };
            BALClient.remplirInfoClient(ListeCommandedgv,infoClient);
        }

        private void Quiterbtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
                
            
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            if (ListeCommandedgv.Rows.Count > 0)
            {
                for (int i = 0; i < ListeCommandedgv.Rows.Count; i++)
                {
                    BALLignecmd.deleteLigCmd(ListeCommandedgv.SelectedRows[0].Cells[0].Value.ToString());
                }
                BALCommande.deleteCmd(ListeCommandedgv.SelectedRows[0].Cells[0].Value.ToString());
                BALCommande.remplirListeCommande(ListeCommandedgv);
                ListeLigneCmddgv.Rows.Clear();
            }
            
        }

        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            AjoutCmd a = new AjoutCmd(ListeCommandedgv,ListeLigneCmddgv);
            a.Show();
        }

        private void Modifierbtn_Click(object sender, EventArgs e)
        {
            if(ListeCommandedgv.SelectedRows.Count > 0)
            {
                AjoutCmd a = new AjoutCmd(ListeCommandedgv,ListeLigneCmddgv);
                a.Show();
            }
        }

        private void find()
        {

            TextBox[] info =
            {
                RechercheRef,
                RechercheClientinput
            };

            DateTimePicker[] dates =
            {
                deb,
                fin
            };

            BALCommande.rechercheCmd(ListeCommandedgv, info, dates);
        }

        private void RechercheRef_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void RechercheClientinput_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void deb_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void fin_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
