using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BAL
{
    static public class Global
    {
        static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= |DataDirectory|DBProject.accdb";
        static public OleDbConnection seConnecter(String strCN)
        {
            // on va creer un objet de connexopn objCN
            OleDbConnection objCN = new OleDbConnection();
            try
            {
                // Definir la chaine de connexion
                objCN.ConnectionString = strCN;
                // Si la connexion est fermee on l'ouvre avec la methode open
                if (objCN.State == System.Data.ConnectionState.Closed)
                    objCN.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return objCN;
        }

        static public void seDeconnecter(OleDbConnection objCN)
        {
            try
            {
                if (objCN.State == System.Data.ConnectionState.Open)
                    objCN.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        static public Object ExecuterOleDBScalaire(String strSQL, OleDbConnection objCN)
        {
            Object obj = new Object();
            OleDbCommand objCom = new OleDbCommand(strSQL, objCN);
            try
            {
                obj = objCom.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        static public OleDbDataReader ExecuterOleDBSelect(String strSQL, OleDbConnection objCN)
        {
            OleDbDataReader objRD = null;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {
                objRD = objCOM.ExecuteReader();
            }
            catch (Exception e)
            {

                System.Console.Write(e.Message);
            }
            return objRD;
        }

        static public int ExecuteOleDBAction(String strSQL, OleDbConnection objCN, params Object[] objPM)
        {
            int nb = -1;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {
                foreach (Object obj in objPM)
                {
                    OleDbParameter param = new OleDbParameter();
                    param.Value = obj;
                    objCOM.Parameters.Add(param);
                }
                nb = objCOM.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

            return nb;
        }

        static public int ExecuterOleDBActionNomsParams(string strSQL, OleDbConnection objCN, Object[,] objPM)
        {
            int nb = -1;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {
                for (int i = 0; i < objPM.GetLength(0); i++)
                {
                    objCOM.Parameters.AddWithValue((String)objPM[i, 0], objPM[i, 1]);
                }

                nb = objCOM.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return nb;
        }

        static public bool ExecuterTransaction(string strCN, params string[] tabSQL)
        {
            bool ok;
            OleDbCommand objCOM = new OleDbCommand();
            OleDbTransaction transact;
            try
            {
                OleDbConnection objCN = seConnecter(strCN);
                objCOM.Connection = objCN;
                transact = objCN.BeginTransaction();
                objCOM.Transaction = transact;
                try
                {
                    foreach (String strSQL in tabSQL)
                    {
                        objCOM.CommandText = strSQL;
                        int i = objCOM.ExecuteNonQuery();
                    }
                    transact.Commit();
                    ok = true;
                }
                catch (Exception)
                {
                    transact.Rollback();
                    ok = false;
                }
                finally
                {
                    seDeconnecter(objCN);
                }
            }
            catch (System.Exception)
            {
                ok = false;
            }


            return ok;
        }

        public static string newGGID()
        {
            Guid g = Guid.NewGuid();
            String[] gguids = { g.ToString().Split('-')[0], g.ToString().Split('-')[1] };
            return String.Join("", gguids);
        }
        public static bool idInDgv(DataGridView dgv, string id)
        {
            bool exist = false;
            if (dgv.Rows.Count > 0)
            {
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString().Equals(id))
                    {
                        exist = true;
                    }
                }

            } 
            return exist;
        } 

        
    }
}

