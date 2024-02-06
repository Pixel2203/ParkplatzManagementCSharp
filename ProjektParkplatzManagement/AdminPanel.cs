using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektParkplatzManagement
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load_1(object sender, EventArgs e)
        {
            User? user = Form1.controller.getUser();
            if (user == null)
            {
                return;
            }
            label2.Text = user.name;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Manager().ShowDialog();
            this.Close();
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.controller.logoutUser(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new BuchungsManager().ShowDialog();
            this.Close();
        }

        private void abmeldenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1.controller.logoutUser(this);
        }
    }
}
