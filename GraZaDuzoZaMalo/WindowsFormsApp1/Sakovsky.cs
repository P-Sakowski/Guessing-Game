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
    public partial class Sakovsky : Form
    {
        private Gra gra;

        public Sakovsky()
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


        private void Sakovsky_Load(object sender, EventArgs e)
        {

        }


        private void groupBoxGra_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            gra.Poddaj();
            buttonGiveUp.Enabled = false;
            labelGiveUp.Text = "Zanim się poddałeś, próbowałeś: " + (gra.LicznikRuchow + 1) / 2 + " razy";
            labelGiveUp.Visible = true;
            buttonNewGame.Visible = true;
            buttonMenu.Visible = true;
            buttonExit.Visible = true;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBoxCheck.Text);
            if (gra.Ocena(c).ToString() == "Trafiono")
            {
                labelCounter.Visible = true;
                buttonGiveUp.Enabled = false;
                buttonNewGame.Visible = true;
                buttonMenu.Visible = true;
                buttonExit.Visible = true;
                labelCounter.Text = "Zanim odgadłeś odpowiedź, próbowałeś: " + (gra.LicznikRuchow+1)/2 + " razy";
                labelScore.Text = "Brawo, trafiłeś! " + textBoxCheck.Text + " to prawidłowa odpowiedź";
            }
            else if (gra.Ocena(c).ToString() == "ZaDuzo")
            {
                labelScore.Text = "Twoja propozycja: " + textBoxCheck.Text + " jest zbyt dużą liczbą";
                textBoxCheck.Text = "";
                textBoxCheck.Focus();
            }
            else 
            {
                labelScore.Text = "Twoja propozycja: " + textBoxCheck.Text + " jest zbyt małą liczbą";
                textBoxCheck.Text = "";
                textBoxCheck.Focus();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}