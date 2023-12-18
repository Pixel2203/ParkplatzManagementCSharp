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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            trackBar1 = new TrackBar();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            comboBox2.Location = new Point(146, 300);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(64, 23);
            comboBox2.TabIndex = 29;
            comboBox2.Text = "Uhrzeit";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PP 1", "PP 2", "PP 3", "PP 4", "PP 5", "E-PP 1 " });
            comboBox1.Location = new Point(68, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 28;
            comboBox1.Text = "Parkplatz Wählen";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(37, 17);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 21;
            label8.Text = "E-Parkplatz 1";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(316, 179);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 20;
            label7.Text = "Parkplatz 5";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(95, 179);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 19;
            label6.Text = "Parkplatz 4";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 83);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 18;
            label1.Text = "Parkplatz 1";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(316, 83);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 17;
            label3.Text = "Parkplatz 2";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 15);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 16;
            label4.Text = "Parkplatz 3";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 275);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 27;
            label9.Text = "30 Minuten gebucht";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(253, 300);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(228, 45);
            trackBar1.TabIndex = 26;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(68, 300);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(72, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(521, 289);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 23;
            button1.Text = "Buchen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // panel1
            // 
            panel1.Location = new Point(51, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 56);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel2
            // 
            panel2.Location = new Point(51, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 56);
            panel2.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.Location = new Point(277, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(173, 56);
            panel3.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.Location = new Point(277, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(173, 56);
            panel4.TabIndex = 32;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Location = new Point(508, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(173, 56);
            panel5.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.Controls.Add(label8);
            panel6.Location = new Point(508, 162);
            panel6.Name = "panel6";
            panel6.Size = new Size(173, 56);
            panel6.TabIndex = 32;
            // 
            // ParkplatzOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 374);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(trackBar1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ParkplatzOverview";
            Text = "ParkplatzOverview";
            Load += ParkplatzOverview_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private TrackBar trackBar1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}