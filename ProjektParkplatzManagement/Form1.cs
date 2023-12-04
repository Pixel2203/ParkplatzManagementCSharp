using ProjektParkplatzManagement.com;
using System.Diagnostics;

namespace ProjektParkplatzManagement
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = controller.isValidUser(textBox1.Text, maskedTextBox1.Text);
            Debug.WriteLine("HELLO valid:" + valid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParkplatzOverview().ShowDialog();
            this.Close();
        }
    }
}