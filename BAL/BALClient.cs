using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using DAL;

namespace BAL
{
    public class BALClient
    {
        public static void remplirInfoClient(DataGridView dgv, TextBox[] info)
        {
            if (dgv.SelectedCells.Count > 0 )
            {
                OleDbConnection cn = new OleDbConnection();
                cn = Global.seConnecter(Global.cs);
                OleDbDataReader reader;

                string nomClient = dgv.SelectedCells[0].Value.ToString();
                reader = Global.ExecuterOleDBSelect(@"select * from client where nom = '"+ nomClient +"'",cn);
                while (reader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        info[i].Text = reader.GetValue(i + 1).ToString();
                    }
                }
                reader.Close();
                Global.seDeconnecter(cn);
            }
        }

        public static void loadClients(DataGridView dgv)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from client", cn);
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
            }
            reader.Close();
            Global.seDeconnecter(cn);
        }

        public static void rechercheClient(DataGridView dgv, TextBox[] infos)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            try
            {
                string sql = "nom like '%" + infos[0].Text.ToString() + "%' and rue like '%" + infos[1].Text.ToString() + "%' and ville like '%" + infos[2].Text.ToString() + "%' and cp like '%" + infos[3].Text.ToString() + "%' and tel like '%"+ infos[4].Text.ToString() + "%'";
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from client where " + sql, cn);
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
                }
                reader.Close();
            }
            catch (Exception)
            {
                
            }
            Global.seDeconnecter(cn);

        }

        public static void affecterClient(DataGridView dgv, DAL.Client client)
        {
            client.id = 0;
            client.nom = "";
            client.rue = "";
            client.ville = "";
            client.cp = 0;
            client.tel = 0;

            if (dgv.SelectedRows.Count > 0)
            {
                client.id = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                client.nom = dgv.SelectedRows[0].Cells[1].Value.ToString();
                client.rue = dgv.SelectedRows[0].Cells[2].Value.ToString();
                client.ville = dgv.SelectedRows[0].Cells[3].Value.ToString();
                client.cp = int.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
                client.tel = int.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            }
        }





        public static int addClient(DAL.Client c)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@nom",c.nom},
                {"@rue", c.rue },
                {"@ville",c.ville },
                {"@cp",c.cp },
                {"@tel",c.tel }
            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into client (nom, rue, ville, cp, tel) values" +
                 " (@nom,@rue,@ville,@cp,@tel)", cn, attr);
            Global.seDeconnecter(cn);


            return 0;
        }

        public static DAL.Client findById(string id)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from client where id = "+id, cn);
            while (reader.Read())
            {
                DAL.Client c = new Client(
                    Int16.Parse(reader.GetValue(0).ToString()),
                    reader.GetValue(1).ToString(),
                    reader.GetValue(2).ToString(),
                    reader.GetValue(3).ToString(),
                    Int16.Parse(reader.GetValue(4).ToString()),
                    Int32.Parse(reader.GetValue(5).ToString())
                    );
                return c;
            }
            reader.Close();
            Global.seDeconnecter(cn);
            return null;
        }

        public static string getIDByNom(string nom)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            string id = "";
            try
            {
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from client where nom like '%" + nom + "%'", cn);
                if (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                    reader.Close();
                }
               
            }
            catch (Exception)
            {
            }
            Global.seDeconnecter(cn);
            return id;
        }
    }
}
