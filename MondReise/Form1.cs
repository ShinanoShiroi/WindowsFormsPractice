using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MondReise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BerechnenClick(object sender, EventArgs e)
        {
            //distance earth-moon --> 384’400 Kilometers
            double d_velocity, ausgabe;

            double distance = 384400;

            double.TryParse(textBoxVelocity.Text, out d_velocity);

            if (radioButtonDays.Checked == true)
            {
                ausgabe = distance /24/ d_velocity;
                textBoxAusgabe.Text = ausgabe.ToString();

            }
            else if (radioButtonHours.Checked == true)
            {
                ausgabe = distance / d_velocity;
                textBoxAusgabe.Text = ausgabe.ToString();
            }
        }
    }
}
