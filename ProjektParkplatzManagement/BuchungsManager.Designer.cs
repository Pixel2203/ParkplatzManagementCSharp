namespace ProjektParkplatzManagement
{
    partial class BuchungsManager
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
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            menuStrip1 = new MenuStrip();
            benutzerToolStripMenuItem = new ToolStripMenuItem();
            abmeldenToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 83);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 12;
            label2.Text = "Filter:";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 240, 230);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(11, 165);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 239);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Buchungsnummer";
            columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kennzeichen";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Parkplatz";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            columnHeader6.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 10;
            label1.Text = "Suchen nach:";
            // 
            // button1
            // 
            button1.Location = new Point(219, 48);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Suchen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 240, 230);
            textBox1.Location = new Point(11, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(9, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 58);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(381, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(54, 19);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "Email";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(302, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(73, 19);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "Parkplatz";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(204, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(92, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Kennzeichen";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(137, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Datum";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(124, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Buchungsnummer";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { benutzerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
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
            // button2
            // 
            button2.Location = new Point(11, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Zurück";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BuchungsManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "BuchungsManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuchungsManager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem benutzerToolStripMenuItem;
        private ToolStripMenuItem abmeldenToolStripMenuItem;
        private Button button2;
    }
}