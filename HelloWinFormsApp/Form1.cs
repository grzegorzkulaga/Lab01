using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsApp
{
    public partial class Witaj : Form
    {
        public Witaj()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelKomunikat.Text = "Witaj, " + textBoxImie.Text + " " + textBoxNazwisko.Text;

            int wiek = Convert.ToInt32(textBoxWiek.Text);

            if( wiek < 67 )
            {
                labelKomunikat2.Text = string.Format(" do emerytury zostało Ci {0} lat", 67 - wiek);
            }
            else
            {
                labelKomunikat2.Text = " jesteś emerytem ";
            }
        }

        private void Witaj_Load(object sender, EventArgs e)
        {

        }
    }
}
