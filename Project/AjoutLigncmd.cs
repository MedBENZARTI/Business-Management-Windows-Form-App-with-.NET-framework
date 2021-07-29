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
    public partial class AjoutLigncmd : Form
    {
        private DataGridView ligneCmddgv;
        private DAL.Lignecmd lignecmd;
        /*public AjoutLigncmd(DataGridView dgv)
        {
            InitializeComponent();
            QuantiteTextBoxAjoutLigcmd.Text = "1";
            this.ligneCmddgv = dgv;
        }*/
        public AjoutLigncmd(DataGridView dgv)
        {
            InitializeComponent();
            QuantiteTextBoxAjoutLigcmd.Text = "1";
            this.ligneCmddgv = dgv;
            if (this.ligneCmddgv.SelectedRows.Count>0)
            {
              
                    //DAL.Produit p = new DAL.Produit("aaa","eee", 12, float.Parse("12"));
                    DAL.Produit p = BALPorduit.findById(this.ligneCmddgv.SelectedRows[0].Cells[0].Value.ToString());
                    produitInput.Text = p.CodeProduit;
                    TypeTextBoxAjoutLigCmd.Text = BALTypeproduit.findTypeById(p.CodeTProduit.ToString());
                    DesTextBoxAjoutLig.Text = p.Designation;
                    QuantiteTextBoxAjoutLigcmd.Text = this.ligneCmddgv.SelectedRows[0].Cells[2].Value.ToString();
                    PrixTextBoxAjoutLigCmd.Text = p.Prix.ToString();
                }
            
           
        }

        private void AnnulerAjoutLigCmdbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produitInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox[] data = { produitInput, TypeTextBoxAjoutLigCmd, DesTextBoxAjoutLig, PrixTextBoxAjoutLigCmd };
            ListeProduit l = new ListeProduit(data);
            l.Show();
        }

        private void QuantiteTextBoxAjoutLigcmd_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ValiderAjoutLigCmdbtn_Click(object sender, EventArgs e)
        {
            TextBox[] info =
            {
                produitInput,
                TypeTextBoxAjoutLigCmd,
                DesTextBoxAjoutLig,
                QuantiteTextBoxAjoutLigcmd,
                PrixTextBoxAjoutLigCmd
            };
            BALLignecmd.addOrReplaceItem(ligneCmddgv, info);
            this.Close();
        }
    }
}
