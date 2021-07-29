using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Lignecmd
    {
        string _CodeProduit;
        string _NumCmd;
        int _Qte;
        float _Prix;

        public string CodeProduit { get { return _CodeProduit; } set { _CodeProduit = value; } }
        public string NumCmd { get { return _NumCmd; } set { _NumCmd = value; } }

        public int Qte { get { return _Qte; } set { _Qte = value; } }
        public float Prix { get { return _Prix; } set { _Prix = value; } }

        public Lignecmd(string CodeProduit, string NumCmd, int Qte, float Prix)
        {
            _CodeProduit = CodeProduit;
            _NumCmd = NumCmd;
            _Qte = Qte;
            _Prix = Prix;
        }

        public Lignecmd(string CodeProduit, int Qte, float Prix)
        {
            _CodeProduit = CodeProduit;
            _Qte = Qte;
            _Prix = Prix;
        }
    }
}
