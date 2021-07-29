using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BAL
{
    public class BALPorduit
    {
        public static string findCodetypeByType(string type)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            string code;
            try
            {
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from tproduit where designation like '%" + type + "%'", cn);
                code = reader.GetValue(0).ToString();
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            Global.seDeconnecter(cn);
            return code;
        }

        public static string findTypeByCode(string code)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            string type = "";
            try
            {
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from tproduit where code =" + code, cn);
                if (reader.Read())
                {
                    type = reader.GetValue(1).ToString();
                }
                
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            Global.seDeconnecter(cn);
            return type;
        }
        public static void rechercheProduit(DataGridView dgv, TextBox[] infos)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            string min;
            string max;
            try
            {
                if (infos[1].Text.Length > 0)
                {
                    min = infos[1].Text;
                }
                else
                {
                    min = "0";
                }

                if (infos[2].Text.Length > 0)
                {
                    max = infos[2].Text;
                }
                else
                {
                    max = "99999999";
                }
                //     
                // string sql = "designation like '%" + infos[0].Text.ToString() + "%' and codetproduit = " + findCodetypeByType(infos[1].Text.ToString()) ;
                //string sql = "codetproduit = " + findCodetypeByType(infos[1].Text.ToString());
                string sql = "designation like '%" + infos[0].Text.ToString() + "%' and prix > " + min + " and prix < "+max;
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from produit where " + sql, cn);
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(3), findTypeByCode(reader.GetValue(2).ToString()));
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            Global.seDeconnecter(cn);
        }

        public static void remplirListClient(DataGridView dgv)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            try
            {
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from produit", cn);
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(3), findTypeByCode(reader.GetValue(2).ToString()));
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            Global.seDeconnecter(cn);
        }

        public static DAL.Produit findById(string id)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            try
            {
                OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from produit where code like '%"+ id +"%'", cn);
                if (reader.Read())
                {
                    DAL.Produit p = new DAL.Produit(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(),Int16.Parse(reader.GetValue(2).ToString()) , float.Parse(reader.GetValue(3).ToString()));
                    return p;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            Global.seDeconnecter(cn);
            return null ;
        }

        public static int addProduit(DAL.Produit p)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@Code",p.CodeProduit},
                {"@Designation", p.Designation},
                {"@CodeTProduit", p.CodeTProduit},
                {"@Prix",p.Prix}
           };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into produit (code,designation,CodeTProduit,Prix) values" +
                 " (@code,@designation,@CodeTProduit,@Prix)", cn, attr);
            Global.seDeconnecter(cn);
            return 0;
        }
    }
}
