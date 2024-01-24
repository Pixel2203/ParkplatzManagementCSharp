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
            bookButton = new Button();
            datepicker = new DateTimePicker();
            trackBar1 = new TrackBar();
            label9 = new Label();
            timepicker = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 240, 230);
            label1.Location = new Point(255, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "PARKPLATZ_NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "TYPE_NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "PARKPLATZ_ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 240, 230);
            label4.Location = new Point(48, 37);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 9);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Typ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 9);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 5;
            label6.Text = "Parkplatznummer:";
            // 
            // bookButton
            // 
            bookButton.BackColor = Color.FromArgb(255, 240, 230);
            bookButton.Location = new Point(233, 410);
            bookButton.Margin = new Padding(3, 2, 3, 2);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(142, 34);
            bookButton.TabIndex = 30;
            bookButton.Text = "Buchen";
            bookButton.UseVisualStyleBackColor = false;
            bookButton.Click += bookButton_Click;
            // 
            // datepicker
            // 
            datepicker.CalendarMonthBackground = Color.FromArgb(255, 240, 230);
            datepicker.Format = DateTimePickerFormat.Custom;
            datepicker.Location = new Point(222, 5);
            datepicker.Margin = new Padding(3, 2, 3, 2);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(100, 23);
            datepicker.TabIndex = 31;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(255, 240, 230);
            trackBar1.Location = new Point(114, 5);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(228, 45);
            trackBar1.TabIndex = 32;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 316);
            label9.Name = "label9";
            label9.Size = new Size(112, 15);
            label9.TabIndex = 33;
            label9.Text = "30 Minuten gewählt";
            // 
            // timepicker
            // 
            timepicker.CalendarMonthBackground = Color.FromArgb(255, 240, 230);
            timepicker.CustomFormat = "HH:mm";
            timepicker.Format = DateTimePickerFormat.Custom;
            timepicker.Location = new Point(222, 5);
            timepicker.Margin = new Padding(3, 2, 3, 2);
            timepicker.Name = "timepicker";
            timepicker.Size = new Size(100, 23);
            timepicker.TabIndex = 36;
            timepicker.Value = new DateTime(2024, 1, 21, 22, 29, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 8);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 37;
            label7.Text = "Buchungsdatum";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 8);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 38;
            label8.Text = "Beginn";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 9);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 39;
            label10.Text = "Dauer";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 240, 230);
            panel1.Location = new Point(33, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 33);
            panel1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 240, 230);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(33, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 33);
            panel2.TabIndex = 41;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 240, 230);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(33, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(342, 33);
            panel4.TabIndex = 43;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 240, 230);
            panel5.Controls.Add(datepicker);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(33, 214);
            panel5.Name = "panel5";
            panel5.Size = new Size(342, 33);
            panel5.TabIndex = 43;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 240, 230);
            panel6.Controls.Add(timepicker);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(33, 271);
            panel6.Name = "panel6";
            panel6.Size = new Size(342, 33);
            panel6.TabIndex = 43;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 240, 230);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(trackBar1);
            panel7.Location = new Point(33, 334);
            panel7.Name = "panel7";
            panel7.Size = new Size(342, 37);
            panel7.TabIndex = 43;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 240, 230);
            button1.Location = new Point(33, 410);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 44;
            button1.Text = "Zurück";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ParkplatzView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(411, 455);
            Controls.Add(button1);
            Controls.Add(bookButton);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ParkplatzView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkplatzView";
            Load += ParkplatzView_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Button bookButton;
        private DateTimePicker datepicker;
        private TrackBar trackBar1;
        private Label label9;
        private DateTimePicker timepicker;
        private Label label7;
        private Label label8;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button button1;
    }
}