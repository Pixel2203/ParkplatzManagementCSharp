using ProjektParkplatzManagement.com;
using ProjektParkplatzManagement.com.dto;
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
        List<ParkingLotData> parkingLotDatas = new List<ParkingLotData>();
        public ParkplatzOverview()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void ParkplatzOverview_Load(object sender, EventArgs e)
        {
            parkingLotDatas = Form1.controller.getParkingLotData();
            parkingLotDatas.ForEach(parkdata => addParkingLotItemToListView(parkdata));

        }
        private void addParkingLotItemToListView(ParkingLotData lotData)
        {
            ListViewItem item = new ListViewItem(lotData.name);
            item.SubItems.Add(Enum.GetName(lotData.type));
            item.SubItems.Add(lotData.bookable.ToString());
            item.SubItems.Add(lotData.id.ToString());
            listView1.Items.Add(item);
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
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
            */
            //FullBookingResponse res = Form1.controller.bucheParkplatz(new BookingRequest(Utils.toMilliseconds(DateTime.Now), Utils.toMilliseconds(DateTime.Now) + 1000*60*60, Form1.controller.getUser(), 1));
            //Debug.WriteLine(res);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if(selectedItem.SubItems.Count == 4)
                {
                    int id = int.Parse(selectedItem.SubItems[3].Text);
                    foreach (ParkingLotData parkingLotData in parkingLotDatas)
                    {
                        if(parkingLotData.id == id)
                        {
                            new ParkplatzView(parkingLotData).ShowDialog();
                            break;
                        }
                    }
                }
            }
        }
    }
}
