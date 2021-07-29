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
    public partial class AjoutCmd : Form
    {

        private DataGridView cmddgv;
        private DataGridView ligcmddgv;
        int nbrLigCmd;


        public AjoutCmd(DataGridView dgv, DataGridView dgvlig)
        {
            InitializeComponent();
            this.cmddgv = dgv;
            this.ligcmddgv = dgvlig;
            nbrLigCmd = this.ligcmddgv.Rows.Count;
            if (this.cmddgv.SelectedRows.Count > 0)
            {
                RefCmdTextBoxAjoutCmd.Text = this.cmddgv.SelectedRows[0].Cells[0].Value.ToString();
                //DateAjoutCmd.Value = this.cmddgv.SelectedRows[0].Cells[0].Value;
                DAL.Client c = BALClient.findById(this.cmddgv.SelectedRows[0].Cells[3].Value.ToString());
                idclient.Text = c.id.ToString();
                clientInput.Text = c.nom;
                RueTextBoxAjoutCmd.Text = c.rue;
                VilleTextBoxAjoutCmd.Text = c.ville;
                CodePostalTextBoxAjoutCmd.Text = c.cp.ToString();
                TelTextBoxAjoutCmd.Text = c.tel.ToString();
                for (int i = 0; i < dgvlig.Rows.Count; i++)
                {
                    LignesCmdGrid.Rows.Add(
                        this.ligcmddgv.Rows[i].Cells[0].Value,
                        this.ligcmddgv.Rows[i].Cells[1].Value,
                        this.ligcmddgv.Rows[i].Cells[2].Value,
                        this.ligcmddgv.Rows[i].Cells[3].Value
                        ) ;
                }


            }
            else
            {
                RefCmdTextBoxAjoutCmd.Text = BAL.Global.newGGID();
            }
        }
        


        private void AjouterLigneCmd_Click(object sender, EventArgs e)
        {
            AjoutLigncmd a = new AjoutLigncmd(LignesCmdGrid);
            a.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox[] infoClient = { clientInput, RueTextBoxAjoutCmd, VilleTextBoxAjoutCmd, CodePostalTextBoxAjoutCmd, TelTextBoxAjoutCmd, idclient };
            rechercheClient r = new rechercheClient(infoClient);
            r.Show();
        }

        private void AnnulerLigneCmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutCmd_Load(object sender, EventArgs e)
        {
            
            

        }

       

        private void clientInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifierLigneCmd_Click(object sender, EventArgs e)
        {
            if (LignesCmdGrid.SelectedRows.Count > 0)
            {
                AjoutLigncmd popup = new AjoutLigncmd(LignesCmdGrid);
                popup.Show();
            }
        }

        private void SupprimerLigneCmd_Click(object sender, EventArgs e)
        {
            if (LignesCmdGrid.SelectedRows.Count > 0)
            {
                LignesCmdGrid.Rows.Remove(LignesCmdGrid.SelectedRows[0]);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ValiderLigneCmd_Click(object sender, EventArgs e)
        {
            DAL.Commande cmd = new DAL.Commande(RefCmdTextBoxAjoutCmd.Text,Int32.Parse(idclient.Text),DateAjoutCmd.Value.ToString());
            if (BALCommande.checkCmd(cmd.NumCmd))
            {
                for (int i = 0; i < nbrLigCmd; i++)
                {
                    BALLignecmd.deleteLigCmd(cmd.NumCmd);
                }
                BALCommande.deleteCmd(cmd.NumCmd);
            }
                
            
            BALCommande.addCommande(cmd);

            if (LignesCmdGrid.Rows.Count > 0)
            {
                for (int i = 0; i < LignesCmdGrid.Rows.Count; i++)
                {
                    DAL.Lignecmd l = new DAL.Lignecmd(
                        LignesCmdGrid.Rows[i].Cells[0].Value.ToString(),
                        RefCmdTextBoxAjoutCmd.Text,
                        Int32.Parse(LignesCmdGrid.Rows[i].Cells[2].Value.ToString()),
                        float.Parse(LignesCmdGrid.Rows[i].Cells[3].Value.ToString())
                        );
                    BALLignecmd.addLigneCmd(l);
                }
                BALCommande.remplirListeCommande(cmddgv);
                this.Close();
            }
        }
    }
}
