
namespace WindowsFormsApp1
{
    partial class frmUse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUse));
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.gridLichSu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhKiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichSuHocTapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuHocTapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(28, 81);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(194, 209);
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(410, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lý lịch trích ngang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(347, 105);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(406, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(347, 152);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(406, 20);
            this.txtQueQuan.TabIndex = 3;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(347, 129);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(455, 130);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 4;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(347, 179);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // gridLichSu
            // 
            this.gridLichSu.AutoGenerateColumns = false;
            this.gridLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.hanhKiemDataGridViewTextBoxColumn});
            this.gridLichSu.DataSource = this.lichSuHocTapBindingSource;
            this.gridLichSu.Location = new System.Drawing.Point(288, 247);
            this.gridLichSu.Name = "gridLichSu";
            this.gridLichSu.Size = new System.Drawing.Size(443, 150);
            this.gridLichSu.TabIndex = 7;
            this.gridLichSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLichSu_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Cấp";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "Trường";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.Width = 200;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.Width = 50;
            // 
            // hanhKiemDataGridViewTextBoxColumn
            // 
            this.hanhKiemDataGridViewTextBoxColumn.DataPropertyName = "HanhKiem";
            this.hanhKiemDataGridViewTextBoxColumn.HeaderText = "Hạnh kiểm";
            this.hanhKiemDataGridViewTextBoxColumn.Name = "hanhKiemDataGridViewTextBoxColumn";
            // 
            // lichSuHocTapBindingSource
            // 
            this.lichSuHocTapBindingSource.DataSource = typeof(WindowsFormsApp1.Entities.LichSuHocTap);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lịch sử học tập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quê quán";
            // 
            // frmUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridLichSu);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAvatar);
            this.Name = "frmUse";
            this.Text = "Thông tin cá nhân cơ bản";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuHocTapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView gridLichSu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhKiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lichSuHocTapBindingSource;
    }
}