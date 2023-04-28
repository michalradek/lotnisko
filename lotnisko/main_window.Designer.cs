namespace lotnisko
{
    partial class main_window
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
            components = new System.ComponentModel.Container();
            DataGrid = new DataGridView();
            admin_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = false;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(13, 20);
            DataGrid.Margin = new Padding(4, 5, 4, 5);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersWidth = 62;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.ScrollBars = ScrollBars.Horizontal;
            DataGrid.ShowCellErrors = false;
            DataGrid.ShowCellToolTips = false;
            DataGrid.ShowEditingIcon = false;
            DataGrid.ShowRowErrors = false;
            DataGrid.Size = new Size(876, 794);
            DataGrid.TabIndex = 0;
            DataGrid.VirtualMode = true;
            // 
            // admin_button
            // 
            admin_button.Location = new Point(896, 626);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(188, 188);
            admin_button.TabIndex = 1;
            admin_button.Text = "admin";
            admin_button.UseVisualStyleBackColor = true;
            admin_button.Click += admin_button_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(896, 20);
            button2.Name = "button2";
            button2.Size = new Size(188, 188);
            button2.TabIndex = 2;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // main_window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 828);
            Controls.Add(button2);
            Controls.Add(admin_button);
            Controls.Add(DataGrid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "main_window";
            Text = "main_window";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DataGrid;
        private Button admin_button;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
    }
}