namespace lotnisko
{
    partial class add_flight_panel
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
            from_textbox = new TextBox();
            to_textbox = new TextBox();
            date_textbox = new TextBox();
            time_textbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(60, 45);
            label1.TabIndex = 0;
            label1.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(101, 45);
            label2.TabIndex = 0;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(93, 45);
            label3.TabIndex = 0;
            label3.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 247);
            label4.Name = "label4";
            label4.Size = new Size(97, 45);
            label4.TabIndex = 0;
            label4.Text = "Time:";
            // 
            // from_textbox
            // 
            from_textbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            from_textbox.Location = new Point(119, 32);
            from_textbox.Name = "from_textbox";
            from_textbox.Size = new Size(312, 50);
            from_textbox.TabIndex = 1;
            // 
            // to_textbox
            // 
            to_textbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            to_textbox.Location = new Point(119, 106);
            to_textbox.Name = "to_textbox";
            to_textbox.Size = new Size(312, 50);
            to_textbox.TabIndex = 2;
            // 
            // date_textbox
            // 
            date_textbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            date_textbox.Location = new Point(119, 178);
            date_textbox.Name = "date_textbox";
            date_textbox.Size = new Size(312, 50);
            date_textbox.TabIndex = 3;
            // 
            // time_textbox
            // 
            time_textbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            time_textbox.Location = new Point(119, 247);
            time_textbox.Name = "time_textbox";
            time_textbox.Size = new Size(312, 50);
            time_textbox.TabIndex = 4;
            time_textbox.Text = "hh:mm:ss";
            // 
            // button1
            // 
            button1.Location = new Point(506, 68);
            button1.Name = "button1";
            button1.Size = new Size(136, 139);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // add_flight_panel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 312);
            Controls.Add(button1);
            Controls.Add(time_textbox);
            Controls.Add(date_textbox);
            Controls.Add(to_textbox);
            Controls.Add(from_textbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "add_flight_panel";
            Text = "add_flight_panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox from_textbox;
        private TextBox to_textbox;
        private TextBox date_textbox;
        private TextBox time_textbox;
        private Button button1;
    }
}