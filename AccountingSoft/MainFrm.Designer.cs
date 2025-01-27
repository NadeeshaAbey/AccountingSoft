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
            top_panel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            close_button = new Button();
            min_button = new Button();
            bottom_panel = new Panel();
            top_panel.SuspendLayout();
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
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Location = new Point(0, 614);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(955, 40);
            bottom_panel.TabIndex = 1;
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
    }
}