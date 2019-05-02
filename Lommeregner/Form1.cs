using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string resultat = "0";
        double sidsteVærdi = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TalTrykket(object sender, EventArgs e)
        {
            int tal =  int.Parse(((TextBox)sender).Tag.ToString());
            if (operation != "" && sidsteVærdi == 0)
            {
                sidsteVærdi = double.Parse(resultat);
                resultat = "";
            }
            else if (resultat == "0")
            {
                resultat = "";
            }
            resultat += tal.ToString();
            OpdaterResultat(resultat);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            resultat = "0";
            operation = "";
            OpdaterResultat(resultat);
        }

        private void OpdaterResultat(string værdi)
        {
            labelResultat.Text = værdi;
        }

        private void OperationsEvent(object sender, EventArgs e)
        {
            operation = ((Button)sender).Tag.ToString();
        }
    }
}
