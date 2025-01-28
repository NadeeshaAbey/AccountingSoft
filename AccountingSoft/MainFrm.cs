using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoft
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void user_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bottom_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.date_time_label.Text = DateTime.Now.Date.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void background_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fn;
                fn = Application.StartupPath+ "Data\\Pics\\" + background_comboBox.SelectedIndex.ToString() + ".jpg";
                this.BackgroundImage = Image.FromFile(fn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----------
            AccountingSoft.Properties.Settings.Default.select_img_index = background_comboBox.SelectedIndex;
            AccountingSoft.Properties.Settings.Default.Save();
            //-----------
            this.Close();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            int index = AccountingSoft.Properties.Settings.Default.select_img_index;
            background_comboBox.SelectedIndex = index;
        }
    }
}
