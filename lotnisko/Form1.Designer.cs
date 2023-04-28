namespace lotnisko
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            password_textbox = new TextBox();
            login_textbox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(password_textbox);
            panel1.Controls.Add(login_textbox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 738);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 353);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 240);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 8;
            label2.Text = "Login";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(56, 512);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(371, 123);
            button1.TabIndex = 7;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password_textbox
            // 
            password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.Location = new Point(56, 383);
            password_textbox.Margin = new Padding(4, 5, 4, 5);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new Size(370, 39);
            password_textbox.TabIndex = 6;
            // 
            // login_textbox
            // 
            login_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_textbox.Location = new Point(56, 270);
            login_textbox.Margin = new Padding(4, 5, 4, 5);
            login_textbox.Name = "login_textbox";
            login_textbox.Size = new Size(370, 39);
            login_textbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 48);
            label1.TabIndex = 4;
            label1.Text = "Log in";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(517, 778);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "s";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox password_textbox;
        private TextBox login_textbox;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}