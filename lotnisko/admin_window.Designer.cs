﻿namespace lotnisko
{
    partial class admin_window
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
            add_button = new Button();
            delete_button = new Button();
            SuspendLayout();
            // 
            // add_button
            // 
            add_button.Location = new Point(12, 12);
            add_button.Name = "add_button";
            add_button.Size = new Size(371, 113);
            add_button.TabIndex = 0;
            add_button.Text = "Add flight";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(12, 131);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(371, 113);
            delete_button.TabIndex = 0;
            delete_button.Text = "Delete flight";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // admin_window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 258);
            Controls.Add(delete_button);
            Controls.Add(add_button);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "admin_window";
            Text = "admin_window";
            ResumeLayout(false);
        }

        #endregion

        private Button add_button;
        private Button delete_button;
    }
}