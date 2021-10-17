using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
            Load += frmTimer_Load;
        }

        Timer t;
        DateTime endTime = new DateTime(2022, 03, 01, 00, 00, 00);

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (totalSecond == 0)
            {
                //pictureBox1.Image = Image.FromFile("c:/testImage.gif");
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                timer1.Stop();
                var f = new frmTet();
                f.Show();
            }
            else
            {
                totalSecond--;
                lblTimer.Text = $"{totalSecond/60:0#}:{totalSecond%60:0#}";
            }
        }
        int totalSecond = 0;
        private void btBatdau_Click(object sender, EventArgs e)
        {
            var minute = (int)Timer.Value;
            totalSecond = minute * 60;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now); //Lấy ngày Tết trừ thời gian hiện tại
            lblTet.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'"); //Format thời gian
            if (ts.TotalSeconds <= 0)
                t.Stop();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 500;
            t.Tick += timer2_Tick;

            TimeSpan ts = endTime.Subtract(DateTime.Now); //Lấy ngày Tết trừ thời gian hiện tại
            lblTet.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'"); //Format thời gian

            t.Start();
        }
    }
}
