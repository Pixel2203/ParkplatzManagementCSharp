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

namespace ProjektParkplatzManagement
{
    public partial class ParkplatzView : Form
    {
        ParkingLotData parkingLotData;
        public ParkplatzView(ParkingLotData parkingLotData)
        {
            this.parkingLotData = parkingLotData;
            InitializeComponent();
        }

        private void ParkplatzView_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.label1.Text = parkingLotData.name;
            this.label2.Text = parkingLotData.type.ToString();
            this.label3.Text = parkingLotData.id.ToString();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = timepicker.Value;
            DateTime selectedDate = datepicker.Value;
            DateTime now = DateTime.Now;

            int durationInMinutes = trackBar1.Value * 30;

            bool isSameDay = selectedDate.Date == now.Date;
            bool isPastDay = selectedDate.Date < now.Date;

            if (isPastDay)
            {
                MessageBox.Show("Du darfst keinen Zeitpunkt in der Vergangenheit als Start festlegen!", "Falsche Eingabe!", MessageBoxButtons.OK);
                return;
            }

            if (isSameDay)
            {
                if (selectedTime < now)
                {
                    MessageBox.Show("Du darfst keinen Zeitpunkt in der Vergangenheit als Start festlegen!", "Falsche Eingabe!", MessageBoxButtons.OK);
                    return;
                }
            }
            DateTime combinedDateTime = new DateTime(
                selectedDate.Year,
                selectedDate.Month,
                selectedDate.Day,
                selectedTime.Hour,
                selectedTime.Minute,
                0);
            long startDateInMilliseconds = Utils.toMilliseconds(combinedDateTime);
            BookingRequest request = new BookingRequest(startDateInMilliseconds, startDateInMilliseconds + durationInMinutes * 60 * 1000, Form1.controller.getUser(), this.parkingLotData.id);

            
            FullBookingResponse response = Form1.controller.bucheParkplatz(request);
            string title = response.getWorked() ? "Erfolgreich gebucht!" : "Buchung Fehlgeschlagen!";
            MessageBox.Show(response.getMessage(), title, MessageBoxButtons.OK);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar1.Value * 30 + " Minuten";
        }
    }
}
