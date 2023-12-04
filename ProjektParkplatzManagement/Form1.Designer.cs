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
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(300, 230);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(204, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(357, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Anmelden";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 128);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Benutzer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 207);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Passwort";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Anmelden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}