using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntry
{
    /// <summary>
    /// Task 1.4
    /// This is a simple Data Entry form which displays a message
    /// which can also be altered through the use of the buttons
    /// Author: Shan Ahmed
    /// </summary>

    public partial class frmDataEntry : Form
    {
        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        public void btnMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hi " + txtFname.Text + " " + txtSname.Text + " from " + txtTown.Text + "\nHappy Programming";
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            lblMessage.Text = lblMessage.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            lblMessage.Text = lblMessage.Text.ToLower();
        }

        private void lblSname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            txtFname.BackColor = Color.LightBlue;
            txtSname.BackColor = Color.LightBlue;
            txtTown.BackColor = Color.LightBlue;
            lblMessage.Text = "Get on with it " + txtFname.Text;
        }

        private void frmDataEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
