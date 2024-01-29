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
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektParkplatzManagement
{
    public partial class SignUp : Form
    {
        private bool isAdminMode;
        private User? userInfoOptional;
        public SignUp(bool isAdminMode, User? userInfoOptional)
        {
            InitializeComponent();
            this.Focus();

            this.isAdminMode = isAdminMode;
            this.userInfoOptional = userInfoOptional;
        }

        private void button1_Click_2(object sender, EventArgs e)
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
                int uid = userInfoOptional == null ? 0 : userInfoOptional.id;
                int penalties = blockUser.Checked ? 1 : 0;
                Permissions uPermission = isAdminMode ? (Permissions) Enum.Parse(typeof(Permissions),comboBox1.Text) : Permissions.DEFAULT;

                User user = new User(uid, prename, name, plate, email, penalties, uPermission, password);

                if (isAdminMode)
                {
                    ResponseObject response = Form1.controller.updateUser(user);
                    string title = response.worked ? "Erfolgreich Registriert!" : "Registrierung Fehlgeschlagen!";
                    label9.Text = title;
                    MessageBox.Show(response.message, title, MessageBoxButtons.OK, response.worked ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                }
                else
                {
                    ResponseObject response = Form1.controller.registerUser(user);
                    string title = response.worked ? "Erfolgreich Registriert!" : "Registrierung Fehlgeschlagen!";
                    label9.Text = title;
                    MessageBox.Show(response.message, title, MessageBoxButtons.OK, response.worked ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }
            }
            else
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
            if (isAdminMode)
            {
                label10.Visible = true;
                comboBox1.Visible = true;
                blockUser.Visible = true;
                label3.Text = "Neues Password";
                label4.Text = "Neues Password wiederholen";
                button1.Text = "Speichern";
                if (userInfoOptional == null)
                {
                    MessageBox.Show("Konnte Benutzerdaten nicht laden!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                textBox1.Text = userInfoOptional.email;
                textBox3.Text = userInfoOptional.prename;
                textBox2.Text = userInfoOptional.name;
                textBox4.Text = userInfoOptional.plate;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
