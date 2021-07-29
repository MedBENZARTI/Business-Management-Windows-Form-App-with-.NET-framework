using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace BAL
{
    public class BALLignecmd
    {
        public static void remplirListeLigneCmnd(DataGridView dgv, string idCmd)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;

            reader = Global.ExecuterOleDBSelect(@"select * from ligcmd where numcmd like '%" + idCmd + "%'", cn);
            while (reader.Read())
            {

                dgv.Rows.Add(reader.GetValue(0), getProduitByCodeProduit(reader.GetValue(0)), reader.GetValue(2), reader.GetValue(3));
            }
            Global.seDeconnecter(cn);
            reader.Close();
        }

        public static string getProduitByCodeProduit(Object codeProduit)
        {

            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            string produit = "";

            reader = Global.ExecuterOleDBSelect(@"select * from produit where code ='" + codeProduit.ToString() + "'", cn);
            while (reader.Read())
            {
                produit = reader.GetValue(1).ToString();
            }
            reader.Close();
            Global.seDeconnecter(cn);
            return produit;
        }

        public static void addOrReplaceItem(DataGridView dgv, TextBox[] info)
        {
            int nbr = Int16.Parse(info[3].Text);
            int price = Int16.Parse(info[4].Text);
            if (Global.idInDgv(dgv, info[0].Text))
            {
                dgv.Rows.Remove(dgv.SelectedRows[0]);
                dgv.Rows.Add(info[0].Text, info[2].Text, nbr, nbr * price);

            }
            else
            {
                dgv.Rows.Add(info[0].Text, info[2].Text, nbr, nbr * price);
            }
        }

        public static int addLigneCmd(DAL.Lignecmd lc)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@CodeProduit",lc.CodeProduit},
                {"@NumcCmd", lc.NumCmd},
                {"@Qte", lc.Qte},
                {"@Prix" , lc.Prix}
            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into ligcmd (CodeProduit,NumCmd,Qte,Prix) values "+" (@CodeProduit, @NumCmd,@Qte,@Prix)", cn,attr);
            Global.seDeconnecter(cn);
            return 0;
        }

        public static void deleteLigCmd(string refCmd)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@NumCmd",refCmd}
            };

            int res = Global.ExecuterOleDBActionNomsParams(@"delete from ligcmd where numcmd like @NumCmd", cn, attr);

            Global.seDeconnecter(cn);

        }

    }
}
