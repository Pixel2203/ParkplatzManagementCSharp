using ProjektParkplatzManagement.com;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjektParkplatzManagement
{
    public partial class BuchungsManager : Form
    {
        public BuchungsManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Keinen Wert angegeben!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string column = "";
            bool isAnyFilterSet = false;
            foreach (Control control in groupBox1.Controls)
            {
                // Check if the control is a RadioButton
                if (control is RadioButton radioButton)
                {
                    // Check if the radio button is checked
                    if (radioButton.Checked)
                    {
                        isAnyFilterSet = true;

                        string selectedRadioButtonText = radioButton.Text;
                        switch (selectedRadioButtonText)
                        {
                            case "Kennzeichen":
                                column = "booking.plate";
                                break;
                            case "Email":
                                column = "user.email";
                                break;
                            case "Datum":
                                column = "booking.start";
                                break;
                            case "Buchungsnummer":
                                column = "booking.id";
                                break;
                            default:
                                column = "";
                                break;
                        }

                        if (string.IsNullOrEmpty(column))
                        {
                            MessageBox.Show("Keinen Filter spezifiziert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }
                        break;

                    }
                }
            }
            if (!isAnyFilterSet)
            {
                MessageBox.Show("Keinen Filter spezifiziert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            com.dto.response.FullAdvancedBookingListResponse response = Form1.controller.getAdvancedBookingsByFilter(column, value);
            if (!response.worked)
            {
                MessageBox.Show(response.message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (response.getValue().Count == 0)
            {
                MessageBox.Show(response.message, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listView1.Items.Clear();
            response.getValue().ForEach(abdo => addABDO(abdo));
        }
        private void addABDO(AdvancedBooking booking)
        {
            ListViewItem item = new ListViewItem(booking.id.ToString());
            item.SubItems.Add(Utils.fromMilliseconds(booking.startDate).ToString(Utils.formatDateWithYearMonthDayHoursMinutes));
            item.SubItems.Add(booking.plate);
            item.SubItems.Add(booking.parkinglotname);
            item.SubItems.Add(booking.email);
            listView1.Items.Add(item);
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.controller.logoutUser(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().ShowDialog();
            this.Close();
        }
    }
}
