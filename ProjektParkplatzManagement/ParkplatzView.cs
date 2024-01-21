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
            this.label2.Text = parkingLotData.GetType().Name;
            this.label3.Text = parkingLotData.id.ToString();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
