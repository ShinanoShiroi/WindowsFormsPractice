using System;
using System.Windows.Forms;

namespace TextBox_und_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            int i = 1;

            while (i <= myListBox.Items.Count)
            {
                i++;
            }

            string item = i + ": " + textBoxEingabe.Text;
            myListBox.Items.Add(item);
            textBoxEingabe.Clear();
            textBoxEingabe.Select();
        }

        private void myListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                myListBox.Items.Remove(myListBox.SelectedItem);
            }

        }
    }
}