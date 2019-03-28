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

            string age = textBoxWiek.Text;

            try
            {
                int wiek = Int32.Parse(age);
                if (wiek < 67)
                {
                    labelKomunikat2.Text = string.Format(" do emerytury zostało Ci {0} lat", 67 - wiek);
                }
                else
                {
                    labelKomunikat2.Text = " jesteś emerytem ";
                }
            }
            catch(FormatException)
            {
                labelKomunikat2.Text = "Błędne dane ";
            }
            catch (OverflowException)
            {
                labelKomunikat2.Text = "Błędne dane ";
            }
        }

        private void Witaj_Load(object sender, EventArgs e)
        {

        }
    }
}
