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
    public partial class FrmManageUser : Form
    {
        public FrmManageUser()
        {
            InitializeComponent();
            var ls = Person.GetList();
            personBindingSource.DataSource = ls;
            gridSinhVien.DataSource = personBindingSource.DataSource;

        }
        public Person selectedPerson
        {
            get
            {
                var p = personBindingSource.Current as Person;
                return p;
            }
        }

        private void gridSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedPerson != null)
            {
                var f = new frmUse(selectedPerson.Id);
                f.Show();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null)
            {
                var result = MessageBox.Show(
                    "Ban co chac xoa sinh vien nay ko?", "Chu y",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    personBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
