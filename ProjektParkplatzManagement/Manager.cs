using ProjektParkplatzManagement.com;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjektParkplatzManagement
{
    public partial class Manager : Form
    {
        private List<User>? users;
        private List<Booking>? recentBookings;
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
            int bookingId = int.Parse(item.SubItems[1].Text);
            ResponseObject response = Form1.controller.deleteBookingById(bookingId);
        }

        private void loadBookings_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (users == null)
            {
                return;
            }
            foreach (User user in users)
            {
                if (user.email == listBox1.Text)
                {
                    FullBookingListResponse response = Form1.controller.getAllBookingsByUserId(user.id);
                    if (!response.worked)
                    {
                        MessageBox.Show(response.message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.recentBookings = response.getValue();
                    break;
                }
            }

            if (recentBookings == null)
            {
                return;
            }
            if (recentBookings.Count > 0)
            {
                deleteBooking.Enabled = true;
                listView2.Enabled = true;
            }
            recentBookings.ForEach(booking => addBookingItemToListView(booking));
            // 
        }
        private void addBookingItemToListView(Booking booking)
        {
            ListViewItem item = new ListViewItem(Utils.fromMilliseconds(booking.startDate).ToString(Utils.formatDateWithYearMonthDayHoursMinutes));
            item.SubItems.Add(booking.id.ToString());
            listView2.Items.Add(item);

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
            if (this.users == null)
            {
                return;
            }
            this.users.ForEach(user => listBox1.Items.Add(user.email));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUserLabel.Text = listBox1.Text;
            loadBookings.Enabled = true;
            deleteBooking.Enabled = false;
            changePassword.Enabled = false;
            blockUser.Enabled = false;
            discardChanges.Enabled = false;
            listView2.Enabled = false;
        }
    }
}
