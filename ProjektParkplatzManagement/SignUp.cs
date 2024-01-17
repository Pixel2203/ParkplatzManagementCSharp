using ProjektParkplatzManagement.com;
using ProjektParkplatzManagement.com.dto;
using ProjektParkplatzManagement.com.dto.response;
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

namespace ProjektParkplatzManagement
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string prename = textBox3.Text;
            string name = textBox2.Text;
            string email = textBox1.Text;
            string password = textBox6.Text;
            string passwordRepeated = textBox5.Text;
            string plate = textBox4.Text;
            if (validData(prename,name,email,password,passwordRepeated,plate))
            {
                Debug.WriteLine("HASHED PASSWORD: " + Utils.erzeugeHashWert(password));
                User user = new User(0, prename, name, plate, email, 0, com.Permissions.DEFAULT, Utils.erzeugeHashWert(password));
                ResponseObject response = Form1.controller.registerUser(user);

                string title = response.getWorked() ? "Erfolgreich Registriert!" : "Registrierung Fehlgeschlagen!";

                MessageBox.Show(response.getMessage(), title, MessageBoxButtons.OK, response.getWorked() ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
        }
        private bool validData(string prename, string name, string email, string password, string passwordRepeated, string plate)
        {
            if(password.Equals(passwordRepeated))
            {
                return true;
            }
            return false;
        }
    }
}
