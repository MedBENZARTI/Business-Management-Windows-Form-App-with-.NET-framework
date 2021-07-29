using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Typeproduit
    {
        int _CodeTProduit;
        string _Designation;

        public int CodeTProduit { get { return _CodeTProduit; } set { _CodeTProduit = value; } }

        public string Designation { get { return _Designation; } set { _Designation = value; } }

        public Typeproduit(int codeTProduit, string designation)
        {
            _CodeTProduit = codeTProduit;
            _Designation = designation;
        }
        public Typeproduit(string designation)
        {
            _Designation = designation;
        }
    }
}
