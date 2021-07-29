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
    public class BALTypeproduit
    {

        public static string findTypeById(string id)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from tproduit where code = "+id, cn);
            string name = "";
            if (reader.Read())
            {
                name = reader.GetValue(1).ToString();
            }
            reader.Close();
            Global.seDeconnecter(cn);
            return name;

        }
        public static void getAll(ComboBox categs)
        {
            categs.Items.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from tproduit", cn);
            while (reader.Read())
            {
                DAL.Typeproduit typeproduit = new DAL.Typeproduit(reader.GetInt32(0), reader.GetValue(1).ToString());
                categs.Items.Add(typeproduit);
            }
            reader.Close();
            Global.seDeconnecter(cn);

        }

        public static int addTypeproduit(DAL.Typeproduit tp)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"Designation", tp.Designation},
            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into Tproduit (Designation ) values" +
                 " (@Designation)", cn, attr);
            Global.seDeconnecter(cn);

            return 0;
        }

    }
}
