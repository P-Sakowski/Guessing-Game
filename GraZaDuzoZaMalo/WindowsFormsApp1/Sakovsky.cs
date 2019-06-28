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
            this.Icon = new Icon("Resources/Icon.ico");
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
            string a = textBoxOd.Text;
            string b = textBoxDo.Text;

            while (true)
            {
                try
                {
                    int a2 = Convert.ToInt32(a);
                    int b2 = Convert.ToInt32(a);
                    gra = new Gra(a2, b2);
                    textBoxOd.Enabled = false;
                    textBoxDo.Enabled = false;
                    buttonLosuj.Enabled = false;
                    groupBoxGra.Visible = true;
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }

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

        public void buttonCheck_Click(object sender, EventArgs e)
        {
            string c = textBoxCheck.Text;
            while (true)
            {
                try
                {
                    int c2 = Convert.ToInt32(c);
                    if (gra.Ocena(c2).ToString() == "Trafiono")
                    {
                        labelCounter.Visible = true;
                        buttonGiveUp.Enabled = false;
                        buttonNewGame.Visible = true;
                        buttonMenu.Visible = true;
                        buttonExit.Visible = true;
                        labelCounter.Text = "Zanim odgadłeś odpowiedź, próbowałeś: " + (gra.LicznikRuchow + 1) / 2 + " razy";
                        labelScore.Text = "Brawo, trafiłeś! " + textBoxCheck.Text + " to prawidłowa odpowiedź";
                    }
                    else if (gra.Ocena(c2).ToString() == "ZaDuzo")
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
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Sakovsky sakovsky = new Sakovsky();
            sakovsky.Show();
            this.Dispose(false);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}