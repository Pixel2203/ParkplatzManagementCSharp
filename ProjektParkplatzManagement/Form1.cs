using ProjektParkplatzManagement.com;
using ProjektParkplatzManagement.com.dao;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
using System.Diagnostics;
using System.Drawing;
using Autofac.Features.GeneratedFactories;

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
            if (Form1.controller.isValidConnection() == true )6 {


                string input_name = textBox1.Text;
                string input_password = maskedTextBox2.Text;
                string hashed = Utils.erzeugeHashWert(input_password);
                if (hashed == null)
                {
                    return;
                }

                FullUserResponse foundUser = controller.loginUserByCredentials(input_name, hashed);
                if (!foundUser.getWorked())
                {
                    MessageBox.Show(foundUser.getMessage(), "Anmeldung fehlgeschlagen", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            else
            {
                showError();
            }
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
            maskedTextBox2.UseSystemPasswordChar = true;
            //pictureBox2.Controls.Add(pictureBox3);
            //pictureBox3.Location = new Point(0, 0);
            //pictureBox3.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
            linkLabel1.Parent = pictureBox2;
            linkLabel1.BackColor = Color.Transparent;
            label4.Parent = pictureBox2;
            label4.BackColor = Color.Transparent;
            label4.Visible = false;

        }
        private void showError()
        {
            label4.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*this.Hide();
            new SignUp().ShowDialog();
            this.Close();*/
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox2.UseSystemPasswordChar = !maskedTextBox2.UseSystemPasswordChar;
            //pictureBox1.BackgroundImage = maskedTextBox2.UseSystemPasswordChar ? eye_hidden : eye_shown;
            pictureBox1.BackgroundImage.Dispose();
            pictureBox1.BackgroundImage = maskedTextBox2.UseSystemPasswordChar ? Properties.Resources.eye_hidden : Properties.Resources.eye_shown;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUp().ShowDialog();
        }
    }
}