using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BAL
{
    public class BALCommande
    {
        public static void remplirListeCommande(DataGridView dgv)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader readerCmd;

            readerCmd = Global.ExecuterOleDBSelect(@"select * from [commande] ;", cn);

            while (readerCmd.Read())
            {
                
                dgv.Rows.Add(readerCmd.GetValue(0), readerCmd.GetValue(1),getClientById(readerCmd.GetValue(2).ToString()), readerCmd.GetValue(2));
               
            }
            Global.seDeconnecter(cn);
            readerCmd.Close();

        }
        private static string getClientById(string id)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            string name = "";
            try
            {
                reader = Global.ExecuterOleDBSelect(@"select * from client where id = " + id, cn);
                while (reader.Read())
                {
                    name = reader.GetValue(1).ToString();
                }

                reader.Close();
                Global.seDeconnecter(cn);
            }
            catch (Exception)
            {

            }
           
            return name;

        }


        private static string getIdClientByName(string name)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            string id = "";

            reader = Global.ExecuterOleDBSelect(@"select * from client where nom = " + name, cn);
            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }

            reader.Close();
            Global.seDeconnecter(cn);
            return id;

        }

        public static int addCommande(DAL.Commande c)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@NumCmd",c.NumCmd},
                {"@DateCmd", c.DateCmd},
                {"@NumClient", c.NumClient},
            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into commande values" +
                 " (@NumCmd,@DateCmd,@NumClient)", cn, attr);
            Global.seDeconnecter(cn);
             return 0;
        }


        public static bool checkCmd(string refCmd)
        {
            bool exist = false;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            try
            {
                reader = Global.ExecuterOleDBSelect(@"select numcmd from commande where numcmd like '%" + refCmd +"%'", cn);
      
                if (reader.Read())
                {
                    exist = true;
                }

            }
            catch (Exception)
            {
            }
            Global.seDeconnecter(cn);
            return exist;
        }

        public static void deleteCmd(string refCmd)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@NumCmd",refCmd}
            };

            int res = Global.ExecuterOleDBActionNomsParams(@"delete from commande where numcmd like @NumCmd", cn, attr);

            Global.seDeconnecter(cn);

        }
        public static void rechercheCmd(DataGridView dgv, TextBox[] infos, DateTimePicker[] dates)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            try
            {
                string sql = "numcmd like '%" + infos[0].Text + "%' and numclient = " + BALClient.getIDByNom(infos[1].Text);
                //+ " and datecmd between '" + dates[0].Value.ToString() +"' and '" + dates[0].Value.ToString()+"'"
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from commande where " + sql, cn);
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), getClientById(reader.GetValue(2).ToString()), reader.GetValue(2));
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            Global.seDeconnecter(cn);

        }

    }
}
