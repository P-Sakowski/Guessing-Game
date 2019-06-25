using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra gra;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            int a = int.Parse(textBoxOd.Text);
            int b = int.Parse(textBoxDo.Text);

            // utwórz grę
            gra = new Gra(a, b);

            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            buttonLosuj.Enabled = false;
            groupBoxGra.Visible = true;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void groupBoxGra_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            gra.Poddaj();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBoxCheck.Text);
            labelScore.Text = "Wynik: " + gra.Ocena(c).ToString();
            if(gra.Ocena(c).ToString() == "Trafiono")
            {
                labelCounter.Visible = true;
                labelCounter.Text = labelCounter.Text + gra.LicznikRuchow/2 + " razy";
            }
        }
    }
}