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
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listBox1 = new ListBox();
            label1 = new Label();
            selectedUserLabel = new Label();
            button3 = new Button();
            loadBookings = new Button();
            deleteBooking = new Button();
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
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(255, 240, 230);
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader6 });
            listView2.Enabled = false;
            listView2.Location = new Point(268, 31);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(419, 214);
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
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 240, 230);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 214);
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
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 240, 230);
            button3.Location = new Point(12, 297);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(142, 34);
            button3.TabIndex = 46;
            button3.Text = "Zurück";
            button3.UseVisualStyleBackColor = false;
            // 
            // loadBookings
            // 
            loadBookings.BackColor = Color.FromArgb(255, 240, 230);
            loadBookings.Location = new Point(492, 293);
            loadBookings.Margin = new Padding(3, 2, 3, 2);
            loadBookings.Name = "loadBookings";
            loadBookings.Size = new Size(142, 34);
            loadBookings.TabIndex = 47;
            loadBookings.Text = "Buchungen laden";
            loadBookings.UseVisualStyleBackColor = false;
            // 
            // deleteBooking
            // 
            deleteBooking.BackColor = Color.FromArgb(255, 240, 230);
            deleteBooking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBooking.Location = new Point(640, 293);
            deleteBooking.Margin = new Padding(3, 2, 3, 2);
            deleteBooking.Name = "deleteBooking";
            deleteBooking.Size = new Size(47, 34);
            deleteBooking.TabIndex = 48;
            deleteBooking.Text = "🗑";
            deleteBooking.UseVisualStyleBackColor = false;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(deleteBooking);
            Controls.Add(loadBookings);
            Controls.Add(button3);
            Controls.Add(selectedUserLabel);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(listView2);
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
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader6;
        private ListBox listBox1;
        private Label label1;
        private Label selectedUserLabel;
        private Button button3;
        private Button loadBookings;
        private Button deleteBooking;
    }
}