using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteck_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berechnenClick(object sender, MouseEventArgs e)
        {
            double höhe, breite, ausgabe;
            

            double.TryParse(textBoxHöhe.Text, out höhe);
            double.TryParse(textBoxBreite.Text, out breite);
            double.TryParse(textBoxAusgabe.Text, out ausgabe);

            ausgabe = höhe * breite;

            textBoxAusgabe.Text = ausgabe.ToString();


        }

        private void beendenClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
