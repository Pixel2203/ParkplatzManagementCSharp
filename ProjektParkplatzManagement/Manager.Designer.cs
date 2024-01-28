namespace ProjektParkplatzManagement
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            benutzerToolStripMenuItem = new ToolStripMenuItem();
            abmeldenToolStripMenuItem = new ToolStripMenuItem();
            blockUser = new CheckBox();
            changePassword = new Button();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            saveChanges = new Button();
            discardChanges = new Button();
            deleteBooking = new Button();
            loadBookings = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            selectedUserLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { benutzerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // benutzerToolStripMenuItem
            // 
            benutzerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abmeldenToolStripMenuItem });
            benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            benutzerToolStripMenuItem.Size = new Size(65, 20);
            benutzerToolStripMenuItem.Text = "Benutzer";
            // 
            // abmeldenToolStripMenuItem
            // 
            abmeldenToolStripMenuItem.Name = "abmeldenToolStripMenuItem";
            abmeldenToolStripMenuItem.Size = new Size(129, 22);
            abmeldenToolStripMenuItem.Text = "Abmelden";
            abmeldenToolStripMenuItem.Click += abmeldenToolStripMenuItem_Click;
            // 
            // blockUser
            // 
            blockUser.AutoSize = true;
            blockUser.Enabled = false;
            blockUser.Location = new Point(545, 191);
            blockUser.Name = "blockUser";
            blockUser.Size = new Size(70, 19);
            blockUser.TabIndex = 2;
            blockUser.Text = "Gesperrt";
            blockUser.UseVisualStyleBackColor = true;
            // 
            // changePassword
            // 
            changePassword.Enabled = false;
            changePassword.Location = new Point(545, 216);
            changePassword.Name = "changePassword";
            changePassword.Size = new Size(104, 23);
            changePassword.TabIndex = 36;
            changePassword.Text = "Passwort ändern";
            changePassword.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(255, 240, 230);
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader6 });
            listView2.Enabled = false;
            listView2.Location = new Point(236, 31);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(275, 208);
            listView2.TabIndex = 37;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum";
            columnHeader7.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Buchungsnummer";
            columnHeader6.Width = 120;
            // 
            // saveChanges
            // 
            saveChanges.BackColor = Color.FromArgb(128, 255, 128);
            saveChanges.Enabled = false;
            saveChanges.Location = new Point(408, 297);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(140, 34);
            saveChanges.TabIndex = 38;
            saveChanges.Text = "Änderungen Speichern";
            saveChanges.UseVisualStyleBackColor = false;
            // 
            // discardChanges
            // 
            discardChanges.BackColor = Color.Red;
            discardChanges.Location = new Point(554, 297);
            discardChanges.Name = "discardChanges";
            discardChanges.Size = new Size(140, 34);
            discardChanges.TabIndex = 39;
            discardChanges.Text = "Änderungen verwerfen";
            discardChanges.UseVisualStyleBackColor = false;
            // 
            // deleteBooking
            // 
            deleteBooking.Enabled = false;
            deleteBooking.Location = new Point(545, 84);
            deleteBooking.Name = "deleteBooking";
            deleteBooking.Size = new Size(142, 23);
            deleteBooking.TabIndex = 40;
            deleteBooking.Text = "Buchung löschen";
            deleteBooking.UseVisualStyleBackColor = true;
            deleteBooking.Click += button4_Click;
            // 
            // loadBookings
            // 
            loadBookings.Enabled = false;
            loadBookings.Location = new Point(545, 35);
            loadBookings.Name = "loadBookings";
            loadBookings.Size = new Size(142, 23);
            loadBookings.TabIndex = 41;
            loadBookings.Text = "Buchungen laden";
            loadBookings.UseVisualStyleBackColor = true;
            loadBookings.Click += loadBookings_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(202, 199);
            listBox1.TabIndex = 42;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 256);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 43;
            label1.Text = "Benutzer:";
            // 
            // selectedUserLabel
            // 
            selectedUserLabel.AutoSize = true;
            selectedUserLabel.Location = new Point(83, 258);
            selectedUserLabel.Name = "selectedUserLabel";
            selectedUserLabel.Size = new Size(145, 15);
            selectedUserLabel.TabIndex = 44;
            selectedUserLabel.Text = "Kein Benutzer ausgewählt!";
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(selectedUserLabel);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(loadBookings);
            Controls.Add(deleteBooking);
            Controls.Add(discardChanges);
            Controls.Add(saveChanges);
            Controls.Add(listView2);
            Controls.Add(changePassword);
            Controls.Add(blockUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Manager";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verwaltung";
            Load += Manager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem benutzerToolStripMenuItem;
        private ToolStripMenuItem abmeldenToolStripMenuItem;
        private CheckBox blockUser;
        private Button changePassword;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader6;
        private Button saveChanges;
        private Button discardChanges;
        private Button deleteBooking;
        private Button loadBookings;
        private ListBox listBox1;
        private Label label1;
        private Label selectedUserLabel;
    }
}