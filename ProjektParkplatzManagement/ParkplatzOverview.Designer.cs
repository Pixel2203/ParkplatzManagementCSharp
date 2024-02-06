namespace ProjektParkplatzManagement
{
    partial class ParkplatzOverview
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
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            benutzerToolStripMenuItem = new ToolStripMenuItem();
            abmeldenToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(274, 3);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 19;
            label5.Text = "Parkplatz Übersicht";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { benutzerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(718, 24);
            menuStrip1.TabIndex = 33;
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
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 240, 230);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(8, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(694, 208);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Typ";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 100;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(718, 351);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 224, 192);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(710, 323);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parkplätze";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 224, 192);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(710, 323);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Konto";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 240, 230);
            button2.Location = new Point(8, 265);
            button2.Name = "button2";
            button2.Size = new Size(142, 23);
            button2.TabIndex = 36;
            button2.Text = "Buchungen Laden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(255, 240, 230);
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader4, columnHeader5, columnHeader6, columnHeader9 });
            listView2.Location = new Point(8, 51);
            listView2.Name = "listView2";
            listView2.Size = new Size(694, 208);
            listView2.TabIndex = 35;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Dauer";
            columnHeader8.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Parkplatz";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Typ";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Kennzeichen";
            columnHeader6.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Kosten";
            columnHeader9.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Dein Konto";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(144, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(151, 19);
            radioButton1.TabIndex = 37;
            radioButton1.TabStop = true;
            radioButton1.Text = "Vergangene Buchungen";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(316, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(167, 19);
            radioButton2.TabIndex = 38;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bevorstehende Buchungen";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(8, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 23);
            panel1.TabIndex = 39;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(109, 19);
            radioButton3.TabIndex = 39;
            radioButton3.TabStop = true;
            radioButton3.Text = "Alle Buchungen";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // ParkplatzOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(718, 374);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ParkplatzOverview";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parkplatz Übersicht";
            Load += ParkplatzOverview_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private TrackBar trackBar1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem benutzerToolStripMenuItem;
        private ToolStripMenuItem abmeldenToolStripMenuItem;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private Label label1;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader4;
        private Button button2;
        private ColumnHeader columnHeader6;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}