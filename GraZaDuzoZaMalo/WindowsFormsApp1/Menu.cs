using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraGUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            try
            {
                this.Icon = new Icon("Resources/Icon.ico");
            }
            catch (Exception dirEx)
            {
            }
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRunGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sakovsky sakovsky = new Sakovsky();
            sakovsky.ShowDialog();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAboutMe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/P-Sakowski");
        }
    }
}
