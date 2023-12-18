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
            groupBox7 = new GroupBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            trackBar1 = new TrackBar();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label5 = new Label();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(comboBox1);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(label1);
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(trackBar1);
            groupBox7.Controls.Add(dateTimePicker2);
            groupBox7.Controls.Add(dateTimePicker1);
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(label5);
            groupBox7.Location = new Point(12, 1);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(676, 326);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "groupBox7";
            groupBox7.Enter += groupBox7_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PP 1", "PP 2", "PP 3", "PP 4", "PP 5", "E-PP 1 " });
            comboBox1.Location = new Point(75, 260);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(567, 167);
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
            label7.Location = new Point(323, 167);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 20;
            label7.Text = "Parkplatz 5";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(70, 167);
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
            label1.Location = new Point(70, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 18;
            label1.Text = "Parkplatz 1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 71);
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
            label4.Location = new Point(573, 71);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 16;
            label4.Text = "Parkplatz 3";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 274);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 27;
            label9.Text = "30 Minuten gebucht";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(258, 288);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(228, 45);
            trackBar1.TabIndex = 26;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(152, 288);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(65, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(75, 288);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(72, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(515, 281);
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
            label5.Location = new Point(277, 18);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 19;
            label5.Text = "Parkplatz Übersicht";
            // 
            // ParkplatzOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 338);
            Controls.Add(groupBox7);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ParkplatzOverview";
            Text = "ParkplatzOverview";
            Load += ParkplatzOverview_Load;
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox7;
        private Label label9;
        private TrackBar trackBar1;
        private DateTimePicker dateTimePicker2;
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
    }
}