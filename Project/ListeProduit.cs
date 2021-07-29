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
    public partial class ListeProduit : Form
    {
        private TextBox[] data;
        public ListeProduit(TextBox[] d)
        {
            InitializeComponent();
            this.data = d;
        }

        private void find()
        {

            TextBox[] info =
           {
                RechProduitTextBox,
                minInput,
                maxInput
            };
            BALPorduit.rechercheProduit(listeProduitdgv, info);
        }

        private void AnnulerProduitsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeProduit_Load(object sender, EventArgs e)
        {
            BALPorduit.remplirListClient(listeProduitdgv);    
        }

        private void RechProduitTextBox_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void typeProduitInput_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void minInput_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void maxInput_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void ValiderProduitsbtn_Click(object sender, EventArgs e)
        {
            if (listeProduitdgv.SelectedRows.Count > 0)
            {
                this.data[0].Text = listeProduitdgv.SelectedRows[0].Cells[0].Value.ToString();
                this.data[1].Text = listeProduitdgv.SelectedRows[0].Cells[3].Value.ToString();
                this.data[2].Text = listeProduitdgv.SelectedRows[0].Cells[1].Value.ToString();
                this.data[3].Text = listeProduitdgv.SelectedRows[0].Cells[2].Value.ToString();
            }
            this.Close();
        }

        private void ProduitInexbtn_Click(object sender, EventArgs e)
        {

            
            AjoutProduit prod = new AjoutProduit(listeProduitdgv);
            prod.Show();
        }
    }
}
