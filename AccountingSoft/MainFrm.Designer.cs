namespace AccountingSoft
{
    partial class MainFrm
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
            top_panel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            close_button = new Button();
            min_button = new Button();
            bottom_panel = new Panel();
            date_time_label = new Label();
            label2 = new Label();
            user_label = new Label();
            user_pictureBox = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            top_panel.SuspendLayout();
            bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // top_panel
            // 
            top_panel.BorderStyle = BorderStyle.FixedSingle;
            top_panel.Controls.Add(button4);
            top_panel.Controls.Add(button3);
            top_panel.Controls.Add(button2);
            top_panel.Controls.Add(button1);
            top_panel.Controls.Add(close_button);
            top_panel.Controls.Add(min_button);
            top_panel.Dock = DockStyle.Top;
            top_panel.Location = new Point(0, 0);
            top_panel.Name = "top_panel";
            top_panel.Size = new Size(955, 93);
            top_panel.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.butt_background;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources.top_Help_butt;
            button4.Location = new Point(390, 11);
            button4.Name = "button4";
            button4.Size = new Size(97, 72);
            button4.TabIndex = 5;
            button4.Text = "Help F5";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.butt_background;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.top_Tools_butt;
            button3.Location = new Point(281, 11);
            button3.Name = "button3";
            button3.Size = new Size(103, 72);
            button3.TabIndex = 4;
            button3.Text = "Tools F4";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.butt_background;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.top_report_butt;
            button2.Location = new Point(162, 11);
            button2.Name = "button2";
            button2.Size = new Size(113, 72);
            button2.TabIndex = 3;
            button2.Text = "Reports F3";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.butt_background;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.top_input_butt;
            button1.Location = new Point(11, 11);
            button1.Name = "button1";
            button1.Size = new Size(145, 72);
            button1.TabIndex = 2;
            button1.Text = "Accounting F2";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // close_button
            // 
            close_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_button.Cursor = Cursors.Hand;
            close_button.Image = Properties.Resources.Close_butt;
            close_button.Location = new Point(927, 3);
            close_button.Name = "close_button";
            close_button.Size = new Size(24, 24);
            close_button.TabIndex = 1;
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += button1_Click;
            // 
            // min_button
            // 
            min_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min_button.Cursor = Cursors.Hand;
            min_button.Image = Properties.Resources.min_butt;
            min_button.Location = new Point(906, 3);
            min_button.Name = "min_button";
            min_button.Size = new Size(24, 24);
            min_button.TabIndex = 0;
            min_button.UseVisualStyleBackColor = true;
            min_button.Click += min_button_Click;
            // 
            // bottom_panel
            // 
            bottom_panel.BorderStyle = BorderStyle.FixedSingle;
            bottom_panel.Controls.Add(date_time_label);
            bottom_panel.Controls.Add(label2);
            bottom_panel.Controls.Add(user_label);
            bottom_panel.Controls.Add(user_pictureBox);
            bottom_panel.Controls.Add(comboBox1);
            bottom_panel.Controls.Add(label1);
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Location = new Point(0, 614);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(955, 40);
            bottom_panel.TabIndex = 1;
            bottom_panel.Paint += bottom_panel_Paint;
            // 
            // date_time_label
            // 
            date_time_label.AutoSize = true;
            date_time_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_time_label.Location = new Point(586, 4);
            date_time_label.Name = "date_time_label";
            date_time_label.Size = new Size(23, 31);
            date_time_label.TabIndex = 7;
            date_time_label.Text = "-";
            date_time_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 4);
            label2.Name = "label2";
            label2.Size = new Size(23, 31);
            label2.TabIndex = 6;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_label.Location = new Point(332, 4);
            user_label.Name = "user_label";
            user_label.Size = new Size(23, 31);
            user_label.TabIndex = 5;
            user_label.Text = "-";
            user_label.TextAlign = ContentAlignment.MiddleLeft;
            user_label.Click += user_label_Click;
            // 
            // user_pictureBox
            // 
            user_pictureBox.BorderStyle = BorderStyle.FixedSingle;
            user_pictureBox.Location = new Point(281, -1);
            user_pictureBox.Name = "user_pictureBox";
            user_pictureBox.Size = new Size(45, 40);
            user_pictureBox.TabIndex = 4;
            user_pictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Image 1", "Image 2", "Image 3", "Image 4", "Image 5", "Image 6" });
            comboBox1.Location = new Point(100, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Background :";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 654);
            Controls.Add(bottom_panel);
            Controls.Add(top_panel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounting Software";
            WindowState = FormWindowState.Maximized;
            top_panel.ResumeLayout(false);
            bottom_panel.ResumeLayout(false);
            bottom_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel top_panel;
        private Panel bottom_panel;
        private Button min_button;
        private Button close_button;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox user_pictureBox;
        private Label date_time_label;
        private Label label2;
        private Label user_label;
        private System.Windows.Forms.Timer timer1;
    }
}