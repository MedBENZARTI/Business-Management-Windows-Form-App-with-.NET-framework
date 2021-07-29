using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DAL
{
    public class Commande
    {
        string _NumCmd;
        string _DateCmd;
        int _NumClient;

        public string NumCmd { get { return _NumCmd; } set { _NumCmd = value; } }

        public string DateCmd { get => _DateCmd; set => _DateCmd = value; }
        public int NumClient { get { return _NumClient; } set { _NumClient = value; } }



        public Commande(string numCmd, int numclient, string time)
        {
            _NumCmd = numCmd;
            _NumClient = numclient;
            _DateCmd = time;

        }

        public Commande(string numCmd, int numclient)
        {
            _NumCmd = numCmd;
            _NumClient = numclient;
        }
    }
}
