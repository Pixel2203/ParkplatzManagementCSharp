using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjektParkplatzManagement
{

    public partial class ParkplatzOverview : Form
    {
        int translatedbookingduration = 0;

        public ParkplatzOverview()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.trackBar1.Value = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // if (status = booked)
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ParkplatzOverview_Load(object sender, EventArgs e)
        {
            /* dateTimePicker2.CustomFormat = "hh:mm";
             dateTimePicker2.Format = DateTimePickerFormat.Custom;
             dateTimePicker2.ShowUpDown = true;*/
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            UpdateSliderValue();
            label9.Text = translatedbookingduration.ToString() + " Minuten gebucht";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            deselectRadiobutton("radioButton3");
        }

        private void deselectRadiobutton(string Input)
        {
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSliderValue();
            if (comboBox1.SelectedItem != null)
            {
                // Abrufen und Anzeigen des ausgewählten Inhalts
                string ausgewaehlterParkplatz = comboBox1.SelectedItem.ToString();
                Debug.WriteLine("Ausgewählter Inhalt: " + ausgewaehlterParkplatz);
            }
            else
            {
                Debug.WriteLine("Es wurde nichts ausgewählt.");
            }
            if (comboBox1.SelectedItem != null)
            {
                // Abrufen und Anzeigen des ausgewählten Inhalts
                string ausgewaehlteZeit = comboBox2.SelectedItem.ToString();
                int Stunden = int.Parse(ausgewaehlteZeit);
                Debug.WriteLine("Ausgewählter Inhalt: " + Stunden);
            }
            else
            {
                Debug.WriteLine("Es wurde nichts ausgewählt.");
            }
            Debug.WriteLine(translatedbookingduration);

            //Funktion get Status(ausgewaelterparkplatz)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateSliderValue()
        {
            translatedbookingduration = trackBar1.Value * 30;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
