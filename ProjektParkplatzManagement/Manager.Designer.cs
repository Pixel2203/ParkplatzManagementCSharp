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
            checkBox1 = new CheckBox();
            button1 = new Button();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            deleteBooking = new Button();
            loadBookings = new Button();
            listBox1 = new ListBox();
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(565, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Gesperrt";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(565, 216);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 36;
            button1.Text = "Passwort ändern";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(255, 240, 230);
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader6 });
            listView2.Location = new Point(236, 31);
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
            columnHeader6.Text = "Kennzeichen";
            columnHeader6.Width = 120;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(408, 297);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 38;
            button2.Text = "Änderungen Speichern";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(554, 297);
            button3.Name = "button3";
            button3.Size = new Size(140, 34);
            button3.TabIndex = 39;
            button3.Text = "Änderungen verwerfen";
            button3.UseVisualStyleBackColor = false;
            // 
            // deleteBooking
            // 
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
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(listBox1);
            Controls.Add(loadBookings);
            Controls.Add(deleteBooking);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private Button button1;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader6;
        private Button button2;
        private Button button3;
        private Button deleteBooking;
        private Button loadBookings;
        private ListBox listBox1;
    }
}