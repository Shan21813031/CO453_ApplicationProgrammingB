using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Greetings
{
    /// <summary>
    /// 1.1 to 1.3
    /// In the class below, the buttons are assigned with code to provide output to the screen when the user
    /// makes use of them
    /// Author: Shan Ahmed
    /// </summary>
    /// 
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            lblBrag.Text = "Supa Dupa Computer\n Selling for £339";
            lblBrag.BackColor = Color.BlueViolet;
            lblBrag.ForeColor = Color.AntiqueWhite;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            lblBrag.Text = "C# .NET for Dumbos\n A real bargain at £29.99";
            lblBrag.BackColor = Color.DeepSkyBlue;
            lblBrag.ForeColor = Color.GhostWhite;
        }
    }
}
