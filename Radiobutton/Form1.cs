using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox.Text = "Rezervacija za Avion.";
            }
            else if (radioButton2.Checked)
            {
                textBox.Text = "Rezervacija za Brod.";
            }
            else if (radioButton3.Checked)
            {
                textBox.Text = "Rezervacija za Auto.";
            }
            else
            {
                MessageBox.Show("Molimo odaberite rezervaciju.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
