namespace lotnisko
{
    partial class search_window
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
            search_textbox = new TextBox();
            search_data_grid_view = new DataGridView();
            search_button = new Button();
            monthCalendar1 = new MonthCalendar();
            to_radio = new CheckBox();
            from_radio = new CheckBox();
            time_radio = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)search_data_grid_view).BeginInit();
            SuspendLayout();
            // 
            // search_textbox
            // 
            search_textbox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            search_textbox.Location = new Point(12, 12);
            search_textbox.Name = "search_textbox";
            search_textbox.Size = new Size(375, 61);
            search_textbox.TabIndex = 0;
            // 
            // search_data_grid_view
            // 
            search_data_grid_view.AllowUserToAddRows = false;
            search_data_grid_view.AllowUserToDeleteRows = false;
            search_data_grid_view.AllowUserToOrderColumns = true;
            search_data_grid_view.AllowUserToResizeColumns = false;
            search_data_grid_view.AllowUserToResizeRows = false;
            search_data_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_data_grid_view.Location = new Point(12, 385);
            search_data_grid_view.Name = "search_data_grid_view";
            search_data_grid_view.ReadOnly = true;
            search_data_grid_view.RowHeadersWidth = 62;
            search_data_grid_view.RowTemplate.Height = 33;
            search_data_grid_view.Size = new Size(870, 206);
            search_data_grid_view.TabIndex = 2;
            search_data_grid_view.VirtualMode = true;
            // 
            // search_button
            // 
            search_button.Location = new Point(664, 12);
            search_button.Name = "search_button";
            search_button.Size = new Size(218, 200);
            search_button.TabIndex = 3;
            search_button.Text = "search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 120);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // to_radio
            // 
            to_radio.AutoSize = true;
            to_radio.Location = new Point(12, 80);
            to_radio.Name = "to_radio";
            to_radio.Size = new Size(55, 29);
            to_radio.TabIndex = 6;
            to_radio.Text = "to";
            to_radio.UseVisualStyleBackColor = true;
            // 
            // from_radio
            // 
            from_radio.AutoSize = true;
            from_radio.Location = new Point(71, 80);
            from_radio.Name = "from_radio";
            from_radio.Size = new Size(77, 29);
            from_radio.TabIndex = 7;
            from_radio.Text = "from";
            from_radio.UseVisualStyleBackColor = true;
            // 
            // time_radio
            // 
            time_radio.AutoSize = true;
            time_radio.Location = new Point(154, 80);
            time_radio.Name = "time_radio";
            time_radio.Size = new Size(73, 29);
            time_radio.TabIndex = 8;
            time_radio.Text = "time";
            time_radio.UseVisualStyleBackColor = true;
            // 
            // search_window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 603);
            Controls.Add(time_radio);
            Controls.Add(from_radio);
            Controls.Add(to_radio);
            Controls.Add(monthCalendar1);
            Controls.Add(search_button);
            Controls.Add(search_data_grid_view);
            Controls.Add(search_textbox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "search_window";
            Text = "search_window";
            ((System.ComponentModel.ISupportInitialize)search_data_grid_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search_textbox;
        private DataGridView search_data_grid_view;
        private Button search_button;
        private MonthCalendar monthCalendar1;
        private CheckBox to_radio;
        private CheckBox from_radio;
        private CheckBox time_radio;
    }
}