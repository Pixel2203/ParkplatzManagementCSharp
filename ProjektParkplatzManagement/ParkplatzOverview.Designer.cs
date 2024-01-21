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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(274, 20);
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
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 63);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(694, 203);
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
            // ParkplatzOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 374);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ParkplatzOverview";
            Text = "ParkplatzOverview";
            Load += ParkplatzOverview_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem benutzerToolStripMenuItem;
        private ToolStripMenuItem abmeldenToolStripMenuItem;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}