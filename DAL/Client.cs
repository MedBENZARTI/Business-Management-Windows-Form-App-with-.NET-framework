using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace DAL
{
    public class Client
    {
        int _id;
        string _nom;
        string _rue;
        string _ville;
        int _cp;
        int _tel;
        public int id { get { return _id; } set { _id = value; } }
        public string nom { get { return _nom; } set { _nom = value; } }
        public string rue { get { return _rue; } set { _rue = value; } }
        public string ville { get { return _ville; } set { _ville = value; } }
        public int cp { get { return _cp; } set { _cp = value; } }
        public int tel { get { return _tel; } set { _tel = value; } }
        public Client(string nom, string rue, string ville, int cp, int tel)
        {
            _nom = nom;
            _rue = rue;
            _ville = ville;
            _cp = cp;
            _tel = tel;
        }
        public Client(int id, string nom, string rue, string ville, int cp, int tel)
        {
            _id = id;
            _nom = nom;
            _rue = rue;
            _ville = ville;
            _cp = cp;
            _tel = tel;
        }
    }
}
