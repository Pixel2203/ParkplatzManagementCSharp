using ProjektParkplatzManagement.com;
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

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Benutzer? user = Form1.controller.managementData.getCurrentUser();
            if (user == null)
            {
                return;
            }
            label2.Text = user.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.controller.logoutUser();
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }
    }
}
