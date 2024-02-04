using ProjektParkplatzManagement.com;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;

namespace ProjektParkplatzManagement
{

    public partial class ParkplatzOverview : Form
    {
        List<ParkingLotData> parkingLotDatas = new List<ParkingLotData>();
        List<ParkingTicket> recentBookings = new List<ParkingTicket>();
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
            item.SubItems.Add(lotData.bookable ? "Frei" : "Gebucht");
            item.SubItems.Add(lotData.id.ToString());
            listView1.Items.Add(item);

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (selectedItem.SubItems.Count == 4)
                {
                    int id = int.Parse(selectedItem.SubItems[3].Text);
                    foreach (ParkingLotData parkingLotData in parkingLotDatas)
                    {
                        if (parkingLotData.id == id)
                        {
                            new ParkplatzView(parkingLotData).ShowDialog();
                            break;
                        }
                    }
                }
            }
        }
        private void addBookingItemToListView(ParkingTicket ticket)
        {
            ListViewItem item = new ListViewItem(Utils.fromMilliseconds(ticket.startDate).ToString(Utils.formatDateWithYearMonthDay));
            Parkplatz parkplatz;
            float parkzeit = ticket.getParkingDuration() / 1000 / 60;
            if (ticket.type == ParkingLotType.DEFAULT)
            {
                parkplatz = new StandartParkplatz(parkzeit);
            }else
            {
                parkplatz = new EParkplatz(parkzeit);
            }
            item.SubItems.Add((ticket.getParkingDuration() / 1000 / 60).ToString() + " Minuten");
            item.SubItems.Add(ticket.name);
            item.SubItems.Add(Enum.GetName(ticket.type));
            item.SubItems.Add(ticket.plate);
            item.SubItems.Add(parkplatz.berechneKosten()+" EUR");
            listView2.Items.Add(item);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isAnyFilterSet = false;
            FullParkingTicketListResponse response = null;
            foreach (Control control in panel1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    // Check if the radio button is checked
                    if (radioButton.Checked)
                    {
                        isAnyFilterSet = true;
                        switch (radioButton.Text)
                        {
                            case "Vergangene Buchungen":
                                response = Form1.controller.getRecentBookingsByLoggedInUser();
                                break;
                            case "Bevorstehende Buchungen":
                                response = Form1.controller.getFutureParkingTicketsByLoggedInUser();
                                break;
                            default:
                                response = Form1.controller.getAllParkingTicketsByLoggedInUser();
                                break;
                        }
                        break;


                    }
                }
            }
            if (!isAnyFilterSet || response == null)
            {
                MessageBox.Show("Keinen Filter spezifiziert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }





            if (!response.worked)
            {
                MessageBox.Show(response.message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView2.Items.Clear();
            response.getValue().ForEach(booking => addBookingItemToListView(booking));

        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.controller.logoutUser(this);
        }
    }
}
