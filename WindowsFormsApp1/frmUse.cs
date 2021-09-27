using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
namespace WindowsFormsApp1
{
    public partial class frmUse : Form
    {
       
            
            Person person;
            LichSuHocTap lichsu;

        public frmUse(string idPerson = "1")
            {
                InitializeComponent();
                person = Person.Get(idPerson);
                if (person != null)
                {
                    //cah1
                    //txtHoTen.Text = $"{person.LastName} {person.FirstName}";
                    //cach2
                    txtHoTen.Text = person.FullName;
                    dtpNgaySinh.Value = person.DOB;
                    if (person.Sex == Person.EGioiTinh.Nam)
                        rdNam.Checked = true;
                    else
                        rdNu.Checked = true;

                    txtQueQuan.Text = person.QueQuan;
                }
                var ls = LichSuHocTap.GetList();
                lichSuHocTapBindingSource.DataSource = ls;
                gridLichSu.DataSource = lichSuHocTapBindingSource.DataSource;
            }

        private void gridLichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File anh(*.png,*.jpg)|*.png;*.jpg";
            dialog.Title = "Chon anh dai dien";
            //var rs = dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                picAvatar.ImageLocation = fileName;
            }
        }
    }


    
}
