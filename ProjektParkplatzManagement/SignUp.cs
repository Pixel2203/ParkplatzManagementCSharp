﻿using ProjektParkplatzManagement.com;
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

            string prename = textBox3.Text;
            string name = textBox2.Text;
            string email = textBox1.Text;
            string password = Utils.erzeugeHashWert(textBox6.Text);
            string passwordRepeated = Utils.erzeugeHashWert(textBox5.Text);
            string plate = textBox4.Text;
            int uid = userInfoOptional == null ? 0 : userInfoOptional.id;
            int penalties = blockUser.Checked ? 1 : 0;
            Permissions uPermission = isAdminMode ? (Permissions)Enum.Parse(typeof(Permissions), comboBox1.Text) : Permissions.DEFAULT;
            User user;


            if (isAdminMode)
            {
                string fallback = string.IsNullOrEmpty(password) ? userInfoOptional.password : password;
                user = new User(uid, prename, name, plate, email, penalties, uPermission, fallback);
            }
            else
            {
                user = new User(0, prename, name, plate, email, 0, Permissions.DEFAULT, password);
            }

            if (isAdminMode)
            {
                bool fullyValidated = ValidateFormData(prename, name, email, plate, password, passwordRepeated);
                if (fullyValidated)
                {
                    ResponseObject response = Form1.controller.updateUser(user);
                    string title = response.worked ? "Erfolgreich geändert!" : "Änderung fehlgeschlagen!";
                    label9.Text = title;
                    MessageBox.Show(response.message, title, MessageBoxButtons.OK, response.worked ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool partlyValidated = ValidateFormData(prename, name, email, plate);
                    if (textBox5.Text == textBox6.Text && textBox6.Text == string.Empty && partlyValidated)
                    {
                        ResponseObject response = Form1.controller.updateUser(user);
                        string title = response.worked ? "Erfolgreich geändert!" : "Änderung fehlgeschlagen!";
                        label9.Text = title;
                        MessageBox.Show(response.message, title, MessageBoxButtons.OK, response.worked ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Daten ungültig oder unvollständig!", "Ungültige Angaben", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                bool fullyValidated = ValidateFormData(prename, name, email, plate, password, passwordRepeated);
                if (fullyValidated)
                {

                    ResponseObject response = Form1.controller.registerUser(user);
                    string title = response.worked ? "Erfolgreich Registriert!" : "Registrierung Fehlgeschlagen!";
                    label9.Text = title;
                    MessageBox.Show(response.message, title, MessageBoxButtons.OK, response.worked ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Daten ungültig oder unvollständig!", "Ungültige Angaben", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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


        private bool ValidateFormData(string prename, string name, string email, string plate)
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

        private void SignUp_Load_1(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = true;
            textBox6.UseSystemPasswordChar = true;
            if (isAdminMode)
            {
                label10.Visible = true;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = userInfoOptional.permission == Permissions.ADMIN ? 1 : 0;
                blockUser.Visible = true;
                button2.Visible = true;
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



        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(string.Format("Benutzer {0} wirklich löschen?", userInfoOptional.name), "Sicher?" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                ResponseObject result = Form1.controller.deleteUserById(userInfoOptional.id);
                MessageBox.Show(result.message, result.worked ? "Erfolgreich gelöscht!" : "Fehler!", MessageBoxButtons.OK, result.worked ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if(result.worked)
                {
                    this.Close();
                }
            }
        }
    }
}
