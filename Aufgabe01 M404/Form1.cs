using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe01_M404
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VerdoppleEvent(object sender, EventArgs e)
        {
            int iEingabe, iAusgabe;

            int.TryParse(textBoxEingabe.Text, out iEingabe);
            int.TryParse(textBoxAusgabe.Text, out iAusgabe);

            iAusgabe = iEingabe * 2;

            textBoxAusgabe.Text = Convert.ToString(iAusgabe);
        }
    }
}
