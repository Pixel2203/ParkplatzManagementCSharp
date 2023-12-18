using ProjektParkplatzManagement.com;
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
            string input_password = maskedTextBox1.Text;
            Benutzer? foundUser = controller.managementData.getUserByCredentials(input_name, input_password);
            if (foundUser == null)
            {
                displayUserNotFoundError();
                return;
            }
            controller.managementData.setLoggedInUser(foundUser);

            if (foundUser.getPermissions() > Permissions.DEFAULT)
            {
                openAdminPanel();
            }else
            {
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
            label3.Text = "Konnte Benutzer nicht finden!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParkplatzOverview().ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}