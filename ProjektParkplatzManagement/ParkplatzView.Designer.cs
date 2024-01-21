namespace ProjektParkplatzManagement
{
    partial class ParkplatzView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            bookButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            trackBar1 = new TrackBar();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "PARKPLATZ_NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "TYPE_NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 172);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "PARKPLATZ_ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 37);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 104);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Typ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 172);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 5;
            label6.Text = "Parkplatznummer:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            comboBox2.Location = new Point(227, 283);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 35;
            comboBox2.Text = "Uhrzeit";
            // 
            // bookButton
            // 
            bookButton.Location = new Point(134, 410);
            bookButton.Margin = new Padding(3, 2, 3, 2);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(142, 34);
            bookButton.TabIndex = 30;
            bookButton.Text = "Buchen";
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(99, 283);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 31;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(99, 351);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(228, 45);
            trackBar1.TabIndex = 32;
            trackBar1.Value = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 334);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 33;
            label9.Text = "30 Minuten gebucht";
            // 
            // ParkplatzView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 455);
            Controls.Add(comboBox2);
            Controls.Add(bookButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(trackBar1);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ParkplatzView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkplatzView";
            Load += ParkplatzView_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private Button bookButton;
        private DateTimePicker dateTimePicker1;
        private TrackBar trackBar1;
        private Label label9;
    }
}