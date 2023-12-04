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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton6 = new RadioButton();
            label9 = new Label();
            trackBar1 = new TrackBar();
            dateTimePicker2 = new DateTimePicker();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label5 = new Label();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // groupBox7
            // 
<<<<<<< HEAD
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(label1);
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(radioButton6);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(trackBar1);
            groupBox7.Controls.Add(dateTimePicker2);
            groupBox7.Controls.Add(radioButton4);
            groupBox7.Controls.Add(radioButton5);
            groupBox7.Controls.Add(radioButton2);
            groupBox7.Controls.Add(radioButton3);
            groupBox7.Controls.Add(radioButton1);
            groupBox7.Controls.Add(dateTimePicker1);
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(label5);
            groupBox7.Location = new Point(12, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(787, 435);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "groupBox7";
            groupBox7.Enter += groupBox7_Enter;
=======
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(22, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 103);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 3;
            label1.Text = "Parkplatz 1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 73);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(143, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Parkplatz Wählen";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(48, 83);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(218, 143);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CardGroup";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BookingLength
            // 
            BookingLength.LargeChange = 2;
            BookingLength.Location = new Point(70, 499);
            BookingLength.Margin = new Padding(3, 4, 3, 4);
            BookingLength.Maximum = 8;
            BookingLength.Minimum = 1;
            BookingLength.Name = "BookingLength";
            BookingLength.Size = new Size(473, 56);
            BookingLength.TabIndex = 3;
            BookingLength.Value = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(623, 83);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(218, 143);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "CardGroup";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(22, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 103);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 12);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 3;
            label2.Text = "Parkplatz 3";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 73);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Parkplatz Wählen";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Location = new Point(336, 83);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(218, 143);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "CardGroup";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(radioButton3);
            panel3.Location = new Point(22, 28);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 103);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 12);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 3;
            label3.Text = "Parkplatz 2";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 73);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(143, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Parkplatz Wählen";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(349, 12);
            label5.Name = "label5";
            label5.Size = new Size(227, 35);
            label5.TabIndex = 6;
            label5.Text = "Parkplatz Übersicht";
            label5.Click += label5_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel4);
            groupBox4.Location = new Point(48, 275);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(218, 143);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "CardGroup";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(radioButton4);
            panel4.Location = new Point(22, 28);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 103);
            panel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 12);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 3;
            label6.Text = "Parkplatz 4";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 73);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(143, 24);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Parkplatz Wählen";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(panel5);
            groupBox5.Location = new Point(336, 275);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(218, 143);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "CardGroup";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(radioButton5);
            panel5.Location = new Point(22, 28);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(185, 103);
            panel5.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 12);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 3;
            label7.Text = "Parkplatz 5";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 73);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(143, 24);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Parkplatz Wählen";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel6);
            groupBox6.Location = new Point(623, 275);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(218, 143);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "CardGroup";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(radioButton6);
            panel6.Location = new Point(22, 28);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(185, 103);
            panel6.TabIndex = 1;
>>>>>>> 5a95dcce324566ff0fc88936f1f552a5703a39dd
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            label8.Location = new Point(641, 223);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 21;
            label8.Text = "E-Parkplatz 1";
=======
            label8.Location = new Point(48, 12);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 3;
            label8.Text = "Parkplatz 6";
>>>>>>> 5a95dcce324566ff0fc88936f1f552a5703a39dd
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(369, 223);
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
            label6.Location = new Point(57, 223);
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
            label1.Location = new Point(57, 95);
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
            label3.Location = new Point(369, 95);
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
            label4.Location = new Point(654, 95);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 16;
            label4.Text = "Parkplatz 3";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
<<<<<<< HEAD
            radioButton6.Location = new Point(356, 135);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(116, 19);
            radioButton6.TabIndex = 22;
=======
            radioButton6.Location = new Point(3, 73);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(143, 24);
            radioButton6.TabIndex = 4;
>>>>>>> 5a95dcce324566ff0fc88936f1f552a5703a39dd
            radioButton6.TabStop = true;
            radioButton6.Text = "Parkplatz Wählen";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(364, 366);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 27;
            label9.Text = "30 Minuten gebucht";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(295, 384);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(260, 45);
            trackBar1.TabIndex = 26;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(174, 384);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(74, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(42, 135);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(116, 19);
            radioButton4.TabIndex = 25;
            radioButton4.TabStop = true;
            radioButton4.Text = "Parkplatz Wählen";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(635, 259);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(116, 19);
            radioButton5.TabIndex = 26;
            radioButton5.TabStop = true;
            radioButton5.Text = "Parkplatz Wählen";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(635, 135);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 19);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "Parkplatz Wählen";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(356, 259);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(116, 19);
            radioButton3.TabIndex = 23;
            radioButton3.TabStop = true;
            radioButton3.Text = "Parkplatz Wählen";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(42, 259);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Parkplatz Wählen";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(86, 384);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(82, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // button1
            // 
<<<<<<< HEAD
            button1.Location = new Point(589, 375);
            button1.Name = "button1";
            button1.Size = new Size(162, 45);
            button1.TabIndex = 23;
=======
            button1.Location = new Point(645, 499);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(185, 60);
            button1.TabIndex = 10;
>>>>>>> 5a95dcce324566ff0fc88936f1f552a5703a39dd
            button1.Text = "Parkplatz + ID + buchen";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(330, 19);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 19;
            label5.Text = "Parkplatz Übersicht";
            // 
            // ParkplatzOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox7);
=======
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(BookingLength);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
>>>>>>> 5a95dcce324566ff0fc88936f1f552a5703a39dd
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
        private RadioButton radioButton6;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}