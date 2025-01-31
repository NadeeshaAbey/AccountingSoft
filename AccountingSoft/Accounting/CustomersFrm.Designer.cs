namespace AccountingSoft.Accounting
{
    partial class CustomersFrm
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
            toolStrip1 = new ToolStrip();
            new_butt = new ToolStripButton();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            toolStripSeparator1 = new ToolStripSeparator();
            edit_butt = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            delete_butt = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            save_butt = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            cancel_butt = new ToolStripButton();
            label1 = new Label();
            id_textBox = new TextBox();
            fname_trxtBox = new TextBox();
            label2 = new Label();
            lname_textBox = new TextBox();
            label3 = new Label();
            gender_textBox = new TextBox();
            label4 = new Label();
            landLine_textBox = new TextBox();
            label5 = new Label();
            cell_no_textBox = new TextBox();
            label6 = new Label();
            email_textBox = new TextBox();
            label7 = new Label();
            address_textBox = new TextBox();
            label8 = new Label();
            comment_textBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            reg_user_label = new Label();
            reg_date_label = new Label();
            label13 = new Label();
            reg_time_label = new Label();
            label15 = new Label();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_butt, toolStripSeparator1, edit_butt, toolStripSeparator2, delete_butt, toolStripSeparator4, save_butt, toolStripSeparator3, cancel_butt });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(734, 56);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_butt
            // 
            new_butt.AutoSize = false;
            new_butt.Image = Properties.Resources.new_butt;
            new_butt.ImageScaling = ToolStripItemImageScaling.None;
            new_butt.ImageTransparentColor = Color.Magenta;
            new_butt.Name = "new_butt";
            new_butt.Size = new Size(90, 53);
            new_butt.Text = "New";
            new_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comment_textBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(address_textBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(email_textBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cell_no_textBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(landLine_textBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(gender_textBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lname_textBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(fname_trxtBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id_textBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 360);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 425);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(711, 139);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(reg_time_label);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(reg_date_label);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(reg_user_label);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 586);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 34);
            panel1.TabIndex = 3;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 56);
            // 
            // edit_butt
            // 
            edit_butt.AutoSize = false;
            edit_butt.Image = Properties.Resources.edit_butt;
            edit_butt.ImageScaling = ToolStripItemImageScaling.None;
            edit_butt.ImageTransparentColor = Color.Magenta;
            edit_butt.Name = "edit_butt";
            edit_butt.Size = new Size(90, 53);
            edit_butt.Text = "Edit";
            edit_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 56);
            // 
            // delete_butt
            // 
            delete_butt.AutoSize = false;
            delete_butt.Image = Properties.Resources.del_butt;
            delete_butt.ImageScaling = ToolStripItemImageScaling.None;
            delete_butt.ImageTransparentColor = Color.Magenta;
            delete_butt.Name = "delete_butt";
            delete_butt.Size = new Size(90, 53);
            delete_butt.Text = "Delete";
            delete_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 56);
            // 
            // save_butt
            // 
            save_butt.AutoSize = false;
            save_butt.Enabled = false;
            save_butt.Image = Properties.Resources.save_utt;
            save_butt.ImageScaling = ToolStripItemImageScaling.None;
            save_butt.ImageTransparentColor = Color.Magenta;
            save_butt.Name = "save_butt";
            save_butt.Size = new Size(90, 53);
            save_butt.Text = "Save";
            save_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 56);
            // 
            // cancel_butt
            // 
            cancel_butt.AutoSize = false;
            cancel_butt.Enabled = false;
            cancel_butt.Image = Properties.Resources.canecl_butt;
            cancel_butt.ImageScaling = ToolStripItemImageScaling.None;
            cancel_butt.ImageTransparentColor = Color.Magenta;
            cancel_butt.Name = "cancel_butt";
            cancel_butt.Size = new Size(90, 53);
            cancel_butt.Text = "Cancel";
            cancel_butt.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 29);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            label1.Click += label1_Click;
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(235, 26);
            id_textBox.Name = "id_textBox";
            id_textBox.ReadOnly = true;
            id_textBox.Size = new Size(278, 27);
            id_textBox.TabIndex = 1;
            // 
            // fname_trxtBox
            // 
            fname_trxtBox.Location = new Point(235, 59);
            fname_trxtBox.Name = "fname_trxtBox";
            fname_trxtBox.Size = new Size(278, 27);
            fname_trxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name :";
            // 
            // lname_textBox
            // 
            lname_textBox.Location = new Point(235, 92);
            lname_textBox.Name = "lname_textBox";
            lname_textBox.Size = new Size(278, 27);
            lname_textBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 95);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name :";
            // 
            // gender_textBox
            // 
            gender_textBox.Location = new Point(235, 125);
            gender_textBox.Name = "gender_textBox";
            gender_textBox.Size = new Size(278, 27);
            gender_textBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 128);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "Gender :";
            // 
            // landLine_textBox
            // 
            landLine_textBox.Location = new Point(235, 158);
            landLine_textBox.Name = "landLine_textBox";
            landLine_textBox.Size = new Size(278, 27);
            landLine_textBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 161);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 8;
            label5.Text = "Land Line :";
            // 
            // cell_no_textBox
            // 
            cell_no_textBox.Location = new Point(235, 191);
            cell_no_textBox.Name = "cell_no_textBox";
            cell_no_textBox.Size = new Size(278, 27);
            cell_no_textBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 194);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 10;
            label6.Text = "Cell Number :";
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(235, 224);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(278, 27);
            email_textBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 227);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 12;
            label7.Text = "Email :";
            // 
            // address_textBox
            // 
            address_textBox.Location = new Point(235, 257);
            address_textBox.Name = "address_textBox";
            address_textBox.Size = new Size(278, 27);
            address_textBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(122, 260);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 14;
            label8.Text = "Address :";
            // 
            // comment_textBox
            // 
            comment_textBox.Location = new Point(235, 290);
            comment_textBox.Name = "comment_textBox";
            comment_textBox.Size = new Size(278, 27);
            comment_textBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(122, 293);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 16;
            label9.Text = "Comment :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 4);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 1;
            label10.Text = "Reg User : ";
            // 
            // reg_user_label
            // 
            reg_user_label.Location = new Point(74, 4);
            reg_user_label.Name = "reg_user_label";
            reg_user_label.Size = new Size(169, 20);
            reg_user_label.TabIndex = 2;
            reg_user_label.Text = "-";
            // 
            // reg_date_label
            // 
            reg_date_label.Location = new Point(320, 4);
            reg_date_label.Name = "reg_date_label";
            reg_date_label.Size = new Size(190, 20);
            reg_date_label.TabIndex = 4;
            reg_date_label.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(249, 4);
            label13.Name = "label13";
            label13.Size = new Size(82, 20);
            label13.TabIndex = 3;
            label13.Text = "Reg Date : ";
            // 
            // reg_time_label
            // 
            reg_time_label.Location = new Point(587, 4);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(134, 20);
            reg_time_label.TabIndex = 6;
            reg_time_label.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(516, 4);
            label15.Name = "label15";
            label15.Size = new Size(83, 20);
            label15.TabIndex = 5;
            label15.Text = "Reg Time : ";
            // 
            // CustomersFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 620);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomersFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers Form";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private ToolStripButton new_butt;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton edit_butt;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton delete_butt;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton save_butt;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton cancel_butt;
        private TextBox id_textBox;
        private Label label1;
        private TextBox landLine_textBox;
        private Label label5;
        private TextBox gender_textBox;
        private Label label4;
        private TextBox lname_textBox;
        private Label label3;
        private TextBox fname_trxtBox;
        private Label label2;
        private TextBox comment_textBox;
        private Label label9;
        private TextBox address_textBox;
        private Label label8;
        private TextBox email_textBox;
        private Label label7;
        private TextBox cell_no_textBox;
        private Label label6;
        private Label label10;
        private Label reg_time_label;
        private Label label15;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
    }
}