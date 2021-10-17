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
    public partial class frmkhoa : Form
    {

        public frmkhoa()
        {
            InitializeComponent();
            List<string> lskhoa = new List<string>();
            lskhoa.Add("Khoa CNTT");
            lskhoa.Add("Khoa hoa hoc");
            lskhoa.Add("Khoa vat ly");
            lskhoa.Add("Khoa toan");
            lskhoa.Add("Khoa van");
            lskhoa.Add("Khoa triet");

            cmbkhoa.DataSource = Faculty.GetList();
            cmbkhoa.DisplayMember = "Name";
            cmbkhoa.ValueMember = "Id";


        }

        private void cmbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbkhoa.SelectedIndex;
            var item = cmbkhoa.SelectedItem as Faculty;
            var lsPerson = Person.GetList(item.Id);
            gridPerson.DataSource = lsPerson;
            
        }
    }
}
