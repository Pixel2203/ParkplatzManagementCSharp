namespace ProjektParkplatzManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 199);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Anmelden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 113);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 96);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Benutzer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 155);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Passwort";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(262, 172);
            maskedTextBox2.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.PasswordChar = '*';
            maskedTextBox2.Size = new Size(179, 23);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(302, 278);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Jetzt Registrieren!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 250);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 7;
            label3.Text = "Noch kein Konto?";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(maskedTextBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Anmelden";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}