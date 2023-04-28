namespace lotnisko
{
    partial class delete_flight_panel
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
            numeric_pick = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numeric_pick).BeginInit();
            SuspendLayout();
            // 
            // numeric_pick
            // 
            numeric_pick.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_pick.Location = new Point(76, 15);
            numeric_pick.Name = "numeric_pick";
            numeric_pick.Size = new Size(180, 50);
            numeric_pick.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(262, 17);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(58, 45);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // delete_flight_panel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 74);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numeric_pick);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "delete_flight_panel";
            Text = "delete_flight_panel";
            ((System.ComponentModel.ISupportInitialize)numeric_pick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numeric_pick;
        private Button button1;
        private Label label1;
    }
}