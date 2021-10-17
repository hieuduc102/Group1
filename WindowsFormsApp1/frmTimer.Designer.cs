
namespace WindowsFormsApp1
{
    partial class frmTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.NumericUpDown();
            this.btBatdau = new System.Windows.Forms.Button();
            this.btDung = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian(m):";
            // 
            // Timer
            // 
            this.Timer.Location = new System.Drawing.Point(109, 36);
            this.Timer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(73, 20);
            this.Timer.TabIndex = 1;
            this.Timer.ThousandsSeparator = true;
            this.Timer.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btBatdau
            // 
            this.btBatdau.Location = new System.Drawing.Point(40, 75);
            this.btBatdau.Name = "btBatdau";
            this.btBatdau.Size = new System.Drawing.Size(75, 23);
            this.btBatdau.TabIndex = 2;
            this.btBatdau.Text = "Bắt đầu";
            this.btBatdau.UseVisualStyleBackColor = true;
            this.btBatdau.Click += new System.EventHandler(this.btBatdau_Click);
            // 
            // btDung
            // 
            this.btDung.Location = new System.Drawing.Point(40, 116);
            this.btDung.Name = "btDung";
            this.btDung.Size = new System.Drawing.Size(75, 23);
            this.btDung.TabIndex = 3;
            this.btDung.Text = "Dừng";
            this.btDung.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(20, 162);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(95, 42);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "1:30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(507, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Còn";
            // 
            // lblTet
            // 
            this.lblTet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTet.Location = new System.Drawing.Point(272, 116);
            this.lblTet.Name = "lblTet";
            this.lblTet.Size = new System.Drawing.Size(607, 48);
            this.lblTet.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(367, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "là đến tết âm lịch 2022";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 174);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btDung);
            this.Controls.Add(this.btBatdau);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.label1);
            this.Name = "frmTimer";
            this.Text = "frmTimer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Timer;
        private System.Windows.Forms.Button btBatdau;
        private System.Windows.Forms.Button btDung;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}