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
    public partial class AjoutProduit : Form
    {
        DataGridView listprod;
        public AjoutProduit(DataGridView dgv)
        {
            InitializeComponent();
            listprod = dgv;
        }

        private void AnnuleRAjoutProduitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AjoutProduit_Load(object sender, EventArgs e)
        {
            typeCombo.DisplayMember = "designation";
            typeCombo.ValueMember = "code";
            BALTypeproduit.getAll(typeCombo);
        }

        private void addTypebtn_Click(object sender, EventArgs e)
        {
            addTypeProduit addType = new addTypeProduit(typeCombo);
            addType.Show();
        }

        private void ValiderAjoutProduittbn_Click(object sender, EventArgs e)
        {

            DAL.Typeproduit t = (DAL.Typeproduit)typeCombo.SelectedItem;
            DAL.Produit prod = new DAL.Produit(codeProdBox.Text, desigBox.Text, t.CodeTProduit, float.Parse(priceBox.Text));
            BALPorduit.addProduit(prod);
            BALPorduit.remplirListClient(listprod);
            this.Close();
        }
    }
}
