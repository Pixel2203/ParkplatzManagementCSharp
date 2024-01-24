using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
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
    public partial class Manager : Form
    {
        private List<User>? users;
        public Manager()
        {
            InitializeComponent();
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.controller.logoutUser(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Es muss eine Buchung ausgewählt werden", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = listView2.SelectedItems[0];


        }

        private void loadBookings_Click(object sender, EventArgs e)
        {
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            FullUserListResponse response = Form1.controller.getAllUsers();
            if (response.worked)
            {
                this.users = response.getValue();
                updateUserList();
                return;
            }
            MessageBox.Show(response.message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateUserList()
        {
            if(this.users == null)
            {
                return;
            }
            this.users.ForEach(user => listBox1.Items.Add(user));
        }
    }
}
