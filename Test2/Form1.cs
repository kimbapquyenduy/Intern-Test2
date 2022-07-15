using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.Controls;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            private void addUserControl(UserControl user)
        {
            
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(user);
            user.BringToFront();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_DashBoard uc = new UC_DashBoard();
            addUserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Bookie uc = new UC_Bookie();
            addUserControl(uc);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Channel uc = new UC_Channel();
            addUserControl(uc);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UC_Rule uc = new UC_Rule();
            addUserControl(uc);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            UC_Account uc = new UC_Account();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Company uc = new UC_Company();
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Bot uc = new Bot();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_DashBoard uc = new UC_DashBoard();
            addUserControl(uc);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {


            
                Application.Exit();
            


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to close the app ", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
