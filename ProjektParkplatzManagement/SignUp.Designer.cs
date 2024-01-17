namespace ProjektParkplatzManagement
{
    partial class SignUp
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(490, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(49, 359);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(51, 296);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(187, 23);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 213);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 94);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 7;
            label2.Text = "Nummernschild";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 278);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Passwort";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 341);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 9;
            label4.Text = "Passwort wiederholen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 30);
            label5.Name = "label5";
            label5.Size = new Size(189, 30);
            label5.TabIndex = 10;
            label5.Text = "Persönliche Daten";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(490, 30);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 11;
            label6.Text = "Fahrzeug Daten";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 94);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 12;
            label7.Text = "Vorname";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 151);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 14;
            label8.Text = "Nachname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Abbrechen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(600, 415);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 16;
            button2.Text = "Registrieren";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}