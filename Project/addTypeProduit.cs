using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace Project
{
    public partial class addTypeProduit : Form
    {
        ComboBox typeCombo;
        public addTypeProduit(ComboBox combo)
        {
            InitializeComponent();
            typeCombo = combo;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            DAL.Typeproduit type = new DAL.Typeproduit(typename.Text);
            int res = BALTypeproduit.addTypeproduit(type);
            BALTypeproduit.getAll(typeCombo);
            this.Close();
        }
    }
}
