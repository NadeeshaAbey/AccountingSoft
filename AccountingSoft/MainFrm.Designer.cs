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
            TreeNode treeNode1 = new TreeNode("Customers");
            TreeNode treeNode2 = new TreeNode("Sales Invoice");
            TreeNode treeNode3 = new TreeNode("Purchase Bill");
            TreeNode treeNode4 = new TreeNode("Invoices", new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Spend Money");
            TreeNode treeNode6 = new TreeNode("Receive Money");
            TreeNode treeNode7 = new TreeNode("Payments", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Expense");
            TreeNode treeNode9 = new TreeNode("All Tools", new TreeNode[] { treeNode1, treeNode4, treeNode7, treeNode8 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            top_panel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            accounting_button = new Button();
            close_button = new Button();
            min_button = new Button();
            bottom_panel = new Panel();
            date_time_label = new Label();
            label2 = new Label();
            user_label = new Label();
            user_pictureBox = new PictureBox();
            background_comboBox = new ComboBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tree_panel = new Panel();
            collapse_button = new Button();
            expand_button = new Button();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            top_panel.SuspendLayout();
            bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox).BeginInit();
            tree_panel.SuspendLayout();
            SuspendLayout();
            // 
            // top_panel
            // 
            top_panel.BackgroundImage = Properties.Resources.butt_background;
            top_panel.BackgroundImageLayout = ImageLayout.Stretch;
            top_panel.BorderStyle = BorderStyle.FixedSingle;
            top_panel.Controls.Add(button4);
            top_panel.Controls.Add(button3);
            top_panel.Controls.Add(button2);
            top_panel.Controls.Add(accounting_button);
            top_panel.Controls.Add(close_button);
            top_panel.Controls.Add(min_button);
            top_panel.Dock = DockStyle.Top;
            top_panel.Location = new Point(0, 0);
            top_panel.Name = "top_panel";
            top_panel.Size = new Size(955, 99);
            top_panel.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.butt_background;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources.top_Help_butt;
            button4.Location = new Point(401, 11);
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
            // accounting_button
            // 
            accounting_button.BackgroundImage = Properties.Resources.butt_background;
            accounting_button.BackgroundImageLayout = ImageLayout.Stretch;
            accounting_button.Cursor = Cursors.Hand;
            accounting_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accounting_button.Image = Properties.Resources.top_input_butt;
            accounting_button.Location = new Point(11, 11);
            accounting_button.Name = "accounting_button";
            accounting_button.Size = new Size(145, 72);
            accounting_button.TabIndex = 2;
            accounting_button.Text = "Accounting F2";
            accounting_button.TextImageRelation = TextImageRelation.ImageAboveText;
            accounting_button.UseVisualStyleBackColor = true;
            accounting_button.Click += accounting_button_Click;
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
            bottom_panel.Controls.Add(background_comboBox);
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
            // background_comboBox
            // 
            background_comboBox.Cursor = Cursors.Hand;
            background_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            background_comboBox.FormattingEnabled = true;
            background_comboBox.Items.AddRange(new object[] { "Image 1", "Image 2", "Image 3", "Image 4", "Image 5", "Image 6" });
            background_comboBox.Location = new Point(100, 7);
            background_comboBox.Name = "background_comboBox";
            background_comboBox.Size = new Size(151, 28);
            background_comboBox.TabIndex = 3;
            background_comboBox.SelectedIndexChanged += background_comboBox_SelectedIndexChanged;
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
            // tree_panel
            // 
            tree_panel.BorderStyle = BorderStyle.FixedSingle;
            tree_panel.Controls.Add(collapse_button);
            tree_panel.Controls.Add(expand_button);
            tree_panel.Controls.Add(treeView1);
            tree_panel.Location = new Point(20, 99);
            tree_panel.Name = "tree_panel";
            tree_panel.Size = new Size(310, 414);
            tree_panel.TabIndex = 2;
            tree_panel.Visible = false;
            // 
            // collapse_button
            // 
            collapse_button.BackgroundImage = Properties.Resources.collapse;
            collapse_button.BackgroundImageLayout = ImageLayout.Stretch;
            collapse_button.Location = new Point(271, 2);
            collapse_button.Name = "collapse_button";
            collapse_button.Size = new Size(32, 32);
            collapse_button.TabIndex = 4;
            collapse_button.Text = "button5";
            collapse_button.UseVisualStyleBackColor = true;
            collapse_button.Click += collapse_button_Click;
            // 
            // expand_button
            // 
            expand_button.BackgroundImage = Properties.Resources.expand;
            expand_button.BackgroundImageLayout = ImageLayout.Stretch;
            expand_button.Location = new Point(239, 2);
            expand_button.Name = "expand_button";
            expand_button.Size = new Size(32, 32);
            expand_button.TabIndex = 3;
            expand_button.Text = "button5";
            expand_button.UseVisualStyleBackColor = true;
            expand_button.Click += expand_button_Click;
            // 
            // treeView1
            // 
            treeView1.Cursor = Cursors.Hand;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Indent = 40;
            treeView1.ItemHeight = 40;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.ImageKey = "tree_customers.png";
            treeNode1.Name = "Customers";
            treeNode1.SelectedImageKey = "tree_customers.png";
            treeNode1.Text = "Customers";
            treeNode2.ImageKey = "tree_sale_invoice.png";
            treeNode2.Name = "Sales_Invoice";
            treeNode2.SelectedImageKey = "tree_sale_invoice.png";
            treeNode2.Text = "Sales Invoice";
            treeNode3.ImageKey = "tree_purchase_bill.png";
            treeNode3.Name = "Purchase_Bill";
            treeNode3.SelectedImageKey = "tree_purchase_bill.png";
            treeNode3.Text = "Purchase Bill";
            treeNode4.ImageKey = "tree_invoice.png";
            treeNode4.Name = "Invoices";
            treeNode4.SelectedImageKey = "tree_invoice.png";
            treeNode4.Text = "Invoices";
            treeNode5.ImageKey = "tree_spend.png";
            treeNode5.Name = "Spend_Money";
            treeNode5.SelectedImageKey = "tree_spend.png";
            treeNode5.Text = "Spend Money";
            treeNode6.ImageKey = "tree_receive.png";
            treeNode6.Name = "Receive_Money";
            treeNode6.SelectedImageKey = "tree_receive.png";
            treeNode6.Text = "Receive Money";
            treeNode7.ImageKey = "tree_payment.png";
            treeNode7.Name = "Payments";
            treeNode7.SelectedImageKey = "tree_payment.png";
            treeNode7.Text = "Payments";
            treeNode8.ImageKey = "tree_expense.png";
            treeNode8.Name = "Expense";
            treeNode8.SelectedImageKey = "tree_expense.png";
            treeNode8.Text = "Expense";
            treeNode9.ImageKey = "tree_root.png";
            treeNode9.Name = "Root";
            treeNode9.SelectedImageKey = "tree_root.png";
            treeNode9.Text = "All Tools";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(308, 412);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "products.png");
            imageList1.Images.SetKeyName(1, "tree_reports.png");
            imageList1.Images.SetKeyName(2, "tree_expense.png");
            imageList1.Images.SetKeyName(3, "tree_invoice.png");
            imageList1.Images.SetKeyName(4, "tree_payment.png");
            imageList1.Images.SetKeyName(5, "tree_customers.png");
            imageList1.Images.SetKeyName(6, "tree_root.png");
            imageList1.Images.SetKeyName(7, "tree_receive.png");
            imageList1.Images.SetKeyName(8, "tree_spend.png");
            imageList1.Images.SetKeyName(9, "expand.png");
            imageList1.Images.SetKeyName(10, "collapse.png");
            imageList1.Images.SetKeyName(11, "tree_sale_invoice.png");
            imageList1.Images.SetKeyName(12, "tree_purchase_bill.png");
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(955, 654);
            Controls.Add(tree_panel);
            Controls.Add(bottom_panel);
            Controls.Add(top_panel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounting Software";
            WindowState = FormWindowState.Maximized;
            Load += MainFrm_Load;
            top_panel.ResumeLayout(false);
            bottom_panel.ResumeLayout(false);
            bottom_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_pictureBox).EndInit();
            tree_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel top_panel;
        private Panel bottom_panel;
        private Button min_button;
        private Button close_button;
        private Button accounting_button;
        private Button button4;
        private Button button2;
        private Button button3;
        private ComboBox background_comboBox;
        private Label label1;
        private PictureBox user_pictureBox;
        private Label date_time_label;
        private Label label2;
        private Label user_label;
        private System.Windows.Forms.Timer timer1;
        private Panel tree_panel;
        private TreeView treeView1;
        private ImageList imageList1;
        private Button expand_button;
        private Button collapse_button;
    }
}