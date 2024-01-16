using ProjektParkplatzManagement.com;
using ProjektParkplatzManagement.com.dao;
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
            Benutzer? foundUser = controller.managementData.getUserByCredentials(input_name, input_password);
            if (foundUser == null)
            {
                displayUserNotFoundError();
                return;
            }
            controller.loginUser(foundUser);
            if (foundUser.getPermissions() > Permissions.DEFAULT)
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
        private void displayUserNotFoundError()
        {
            MessageBox.Show("Ungültiger Benutzername oder Passwort!", "Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}