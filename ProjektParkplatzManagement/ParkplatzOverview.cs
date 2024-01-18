﻿using ProjektParkplatzManagement.com;
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
        private void ParkplatzOverview_Load(object sender, EventArgs e)
        {
            /* dateTimePicker2.CustomFormat = "hh:mm";
             dateTimePicker2.Format = DateTimePickerFormat.Custom;
             dateTimePicker2.ShowUpDown = true;*/
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            UpdateSliderValue();
            label9.Text = translatedbookingduration.ToString() + " Minuten gebucht";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Stunden = 0;
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
                Stunden = int.Parse(ausgewaehlteZeit);
                Debug.WriteLine("Ausgewählter Inhalt: " + Stunden);
            }
            else
            {
                Debug.WriteLine("Es wurde nichts ausgewählt.");
            }
            Debug.WriteLine(translatedbookingduration);
            BookingRequest request = new BookingRequest(0,0, null, 0);
            Form1.controller.bucheParkplatz(request);
            
        }
        private void UpdateSliderValue()
        {
            translatedbookingduration = trackBar1.Value * 30;
        }
    }
}
