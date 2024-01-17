using ProjektParkplatzManagement.com;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
using System.Diagnostics;

namespace ProjektParkplatzManagement
{
    public partial class Form1 : Form
    {
        public static Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = textBox1.Text;
            string input_password = maskedTextBox2.Text;
            string hashed = Utils.erzeugeHashWert(input_password);
            if (hashed == null)
            {
                return;
            }
            FullUserResponse foundUser = controller.loginUserByCredentials(input_name, hashed.ToString());
            if (!foundUser.getWorked())
            {
                MessageBox.Show(foundUser.getMessage(), "Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (foundUser.getValue().permission > Permissions.DEFAULT)
            {
                openAdminPanel();
            }
            else
            {
                openOverview();
                Debug.WriteLine("Unzureichende Rechtegruppe, um das Adminpanel zu öffnen!");
            }
            // Open Admin Panel
        }
        private void openAdminPanel()
        {
            this.Hide();
            new AdminPanel().ShowDialog();
            this.Close();
        }
        private void openOverview()
        {
            this.Hide();
            new ParkplatzOverview().ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUp().ShowDialog();
            this.Close();
        }
    }
}