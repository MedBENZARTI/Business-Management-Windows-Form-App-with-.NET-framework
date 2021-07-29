using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Produit
    {
        string _CodeProduit;
        string _Designation;
        int _CodeTProduit;
        float _Prix;

        public string CodeProduit { get { return _CodeProduit; } set { _CodeProduit = value; } }
        public string Designation { get { return _Designation; } set { _Designation = value; } }
        public int CodeTProduit { get { return _CodeTProduit; } set { _CodeTProduit = value; } }
        public float Prix { get { return _Prix; } set { _Prix = value; } }

        public Produit(string codeproduit, string designation, int codetproduit, float prix)
        {
            _CodeProduit = codeproduit;
            _Designation = designation;
            _CodeTProduit = codetproduit;
            _Prix = prix;
        }
    }
}
