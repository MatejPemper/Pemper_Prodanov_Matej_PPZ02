using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemper_Prodanov_Matej_PPZ02
{
    public partial class Form1 : Form
    {
        List<Alkohol> listaAlkohol = new List<Alkohol>();
        List<Gazirano> listaGazirano = new List<Gazirano>();
        List<Negazirano> listaNegazirano = new List<Negazirano>();

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (radioButtonAlkohol.Checked)
            {
                labelPostotak.Text = Convert.ToString(trackBarPostotak.Value);
            }
            else
            {
                trackBarPostotak.Value = 0;
            }
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            if (radioButtonAlkohol.Checked)
            {
                Alkohol alkohol = new Alkohol(textBoxNaziv.Text, comboBoxKolicina.Text, comboBoxPakiranje.Text, textBoxCijena.Text, trackBarPostotak.Value);

                listaAlkohol.Add(alkohol);

            }
            if (radioButtonGazirano.Checked)
            {
                Gazirano gazirano = new Gazirano(textBoxNaziv.Text, comboBoxKolicina.Text, comboBoxPakiranje.Text, textBoxCijena.Text);

                listaGazirano.Add(gazirano);
            }
            else
            {
                Negazirano negazirano = new Negazirano(textBoxNaziv.Text, comboBoxKolicina.Text, comboBoxPakiranje.Text, textBoxCijena.Text);

                listaNegazirano.Add(negazirano);
            }

            MessageBox.Show("Unos je usješan", "uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonIspis_Click(object sender, EventArgs e)
        {
            richTextBoxIspis.Clear();

            if (radioButtonAlkohol.Checked)
            {

                foreach (Alkohol alkohol in listaAlkohol)
                {
                    richTextBoxIspis.AppendText(alkohol.ToString());
                }
            }
            if (radioButtonGazirano.Checked)
            {
                foreach (Gazirano gazirano in listaGazirano)
                {
                    richTextBoxIspis.AppendText(gazirano.ToString());
                }
            }
            if (radioButtonNegazirano.Checked) { 
               foreach(Negazirano negazirano in listaNegazirano)
                {
                    richTextBoxIspis.AppendText(negazirano.ToString());
                }
            }
        }
    }
}
