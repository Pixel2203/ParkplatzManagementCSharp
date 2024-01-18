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
            this.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //To-Do:

            //Authorized Key > Datenbank
            //> Anfrage zur Nutzung bereits verwendetem Kennzeichen > Ehefrau...

            string prename = textBox3.Text;
            string name = textBox2.Text;
            string email = textBox1.Text;
            string password = Utils.erzeugeHashWert(textBox6.Text);
            string passwordRepeated = Utils.erzeugeHashWert(textBox5.Text);
            string plate = textBox4.Text;
            if (ValidateFormData(prename, name, email, plate, password, passwordRepeated))
            {
                Debug.WriteLine("HASHED PASSWORD: " + password);
                User user = new User(0, prename, name, plate, email, 0, Permissions.DEFAULT, password);
                ResponseObject response = Form1.controller.registerUser(user);

                string title = response.getWorked() ? "Erfolgreich Registriert!" : "Registrierung Fehlgeschlagen!";
                label9.Text = title;
                MessageBox.Show(response.getMessage(), title, MessageBoxButtons.OK, response.getWorked() ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("Daten ungültig oder unvollständig!", "Ungültige Angaben", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIsNum(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }
            if (int.TryParse(number, out int parsedNumber) && !double.IsNaN(parsedNumber))
            {
                return true;
            }
            return false;
        }

        private bool ValidateFormData(string prename, string name, string email, string plate, string password, string passwordRepeated)
        {
            string[] requiredFields = { prename, name, email, plate };

            foreach (string item in requiredFields)
            {
                if (string.IsNullOrEmpty(item))
                {
                    return false;
                }
            }

            if (plate.Length > 8)
            {
                return false;
            }

            // Validate Kennzeichen
            if (!ValidatePlate(plate))
            {
                return false;
            }

            // Validate Email
            if (!ValidateEmail(email))
            {
                return false;
            }

            // Validate Password
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordRepeated) || !string.Equals(password, passwordRepeated))
            {
                return false;
            }

            return true;
        }

        private bool ValidatePlate(string plate)
        {
            bool allowed = true;

            for (int i = 0; i < plate.Length; i++)
            {
                if (CheckIsNum(plate[i].ToString()))
                {
                    for (int t = i; t < plate.Length; t++)
                    {
                        if (!CheckIsNum(plate[t].ToString()))
                        {
                            allowed = false;
                            break;
                        }
                    }
                    if (!allowed)
                    {
                        break;
                    }
                }
            }

            return allowed;
        }

        private bool ValidateEmail(string email)
        {
            return !string.IsNullOrEmpty(email);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = true;
            textBox6.UseSystemPasswordChar = true;
        }
    }
}
