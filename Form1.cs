using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bruh
{
    public partial class FRM : Form
    {
        public FRM()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Shown(object sender, EventArgs e)
        {
            lbkiiratas.Text = "";
        }

        private void btgomb_Click(object sender, EventArgs e)
        {
            /*string nev = txnev.Text 
            lbkiiratas.Text = "Üdvözöllek " + nev+"!"; */

            lbkiiratas.Text = "Üdvözöllek " + txnev.Text + "!";
            lb2.Text = "A kedvenc ételed a: "+ txkaja.Text;
        }
    }
}
