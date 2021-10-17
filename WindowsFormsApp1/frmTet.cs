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
    public partial class frmTet : Form
    {
        public frmTet()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"F:\music\HappyNewYearNhacChuong-ABBA-2929458.mp3";
            pictureBox1.Image = Image.FromFile("C:/testImage.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
