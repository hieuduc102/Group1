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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var SoThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai=0;
                if(double.TryParse(SoThuNhat,out temp))
                    nSoThuNhat = Convert.ToInt64(SoThuNhat);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu nhat:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                var SoThuHai = txtSoThuHai.Text;
                if (double.TryParse(SoThuHai, out temp))
                    nSoThuHai = long.Parse(SoThuHai);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu hai:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                

                var ketQua = nSoThuNhat + nSoThuHai;
                lblKetQua.Text
                    = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Loi tran so. Vui long nhap so ngan hon:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Da xay ra loi:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {

                var SoThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(SoThuNhat, out temp))
                    nSoThuNhat = Convert.ToInt64(SoThuNhat);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu nhat:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                var SoThuHai = txtSoThuHai.Text;
                if (double.TryParse(SoThuHai, out temp))
                    nSoThuHai = long.Parse(SoThuHai);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu hai:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }


                var ketQua = nSoThuNhat - nSoThuHai;
                lblKetQua.Text
                    = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Loi tran so. Vui long nhap so ngan hon:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Da xay ra loi:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {

                var SoThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(SoThuNhat, out temp))
                    nSoThuNhat = Convert.ToInt64(SoThuNhat);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu nhat:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                var SoThuHai = txtSoThuHai.Text;
                if (double.TryParse(SoThuHai, out temp))
                    nSoThuHai = long.Parse(SoThuHai);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu hai:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }


                var ketQua = nSoThuNhat * nSoThuHai;
                lblKetQua.Text
                    = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Loi tran so. Vui long nhap so ngan hon:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Da xay ra loi:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {

                var SoThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(SoThuNhat, out temp))
                    nSoThuNhat = Convert.ToInt64(SoThuNhat);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu nhat:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                var SoThuHai = txtSoThuHai.Text;
                if (double.TryParse(SoThuHai, out temp))
                    nSoThuHai = long.Parse(SoThuHai);
                else
                {
                    MessageBox.Show($"Vui long nhap lai so thu hai:", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                double ketQua=1.0*nSoThuNhat / 1.0*nSoThuHai;
                lblKetQua.Text
                    = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Loi tran so. Vui long nhap so ngan hon:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Da xay ra loi:{ex.Message}", "Thong bao loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
