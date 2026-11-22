namespace DBCourseWork
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(66, 334);
            button1.Name = "button1";
            button1.Size = new Size(257, 34);
            button1.TabIndex = 3;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 31);
            textBox1.TabIndex = 1;
            textBox1.MaxLength = 128;
            textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 31);
            textBox2.TabIndex = 0;
            textBox2.MaxLength = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 180);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // hScrollBar1
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(165, 259);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Text = "ФИО";
            fullNameLabel.Visible = false;
            fullNameTextBox.Location = new Point(66, 286);
            fullNameTextBox.MaxLength = 120;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(257, 31);
            fullNameTextBox.TabIndex = 2;
            fullNameTextBox.Visible = false;
            registerButton.Location = new Point(66, 376);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(257, 34);
            registerButton.TabIndex = 4;
            registerButton.Text = "Создать учётную запись";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AcceptButton = button1;
            ClientSize = new Size(388, 432);
            Controls.Add(registerButton);
            Controls.Add(fullNameTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход на склад";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Button registerButton;
    }
}
