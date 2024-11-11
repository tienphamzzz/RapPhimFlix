namespace RapPhimFlix.Forms.MenuNav.SuatChieu
{
    partial class Form_DanhSachSuatChieu
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
            grb_SuatChieu = new GroupBox();
            btn_SuatChieu_Them = new Button();
            btn_SuatChieu_Xoa = new Button();
            btn_SuatChieu_Sua = new Button();
            panel1 = new Panel();
            btn_SuatPhim_Phong3 = new Button();
            btn_SuatPhim_Phong2 = new Button();
            btn_SuatPhim_Phong1 = new Button();
            btn_SuatChieu_All = new Button();
            panel2 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            grb_SuatChieu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grb_SuatChieu
            // 
            grb_SuatChieu.Controls.Add(btn_SuatChieu_Them);
            grb_SuatChieu.Controls.Add(btn_SuatChieu_Xoa);
            grb_SuatChieu.Controls.Add(btn_SuatChieu_Sua);
            grb_SuatChieu.Dock = DockStyle.Bottom;
            grb_SuatChieu.Location = new Point(0, 370);
            grb_SuatChieu.Name = "grb_SuatChieu";
            grb_SuatChieu.Size = new Size(800, 80);
            grb_SuatChieu.TabIndex = 2;
            grb_SuatChieu.TabStop = false;
            // 
            // btn_SuatChieu_Them
            // 
            btn_SuatChieu_Them.Location = new Point(132, 22);
            btn_SuatChieu_Them.Name = "btn_SuatChieu_Them";
            btn_SuatChieu_Them.Size = new Size(95, 33);
            btn_SuatChieu_Them.TabIndex = 4;
            btn_SuatChieu_Them.Text = "Thêm";
            btn_SuatChieu_Them.UseVisualStyleBackColor = true;
            btn_SuatChieu_Them.Click += btn_SuatChieu_Them_Click;
            // 
            // btn_SuatChieu_Xoa
            // 
            btn_SuatChieu_Xoa.Location = new Point(443, 22);
            btn_SuatChieu_Xoa.Name = "btn_SuatChieu_Xoa";
            btn_SuatChieu_Xoa.Size = new Size(98, 33);
            btn_SuatChieu_Xoa.TabIndex = 3;
            btn_SuatChieu_Xoa.Text = "Xóa";
            btn_SuatChieu_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_SuatChieu_Sua
            // 
            btn_SuatChieu_Sua.Location = new Point(299, 22);
            btn_SuatChieu_Sua.Name = "btn_SuatChieu_Sua";
            btn_SuatChieu_Sua.Size = new Size(98, 33);
            btn_SuatChieu_Sua.TabIndex = 2;
            btn_SuatChieu_Sua.Text = "Sửa";
            btn_SuatChieu_Sua.UseVisualStyleBackColor = true;
            btn_SuatChieu_Sua.Click += btn_SuatChieu_Sua_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_SuatPhim_Phong3);
            panel1.Controls.Add(btn_SuatPhim_Phong2);
            panel1.Controls.Add(btn_SuatPhim_Phong1);
            panel1.Controls.Add(btn_SuatChieu_All);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 330);
            panel1.TabIndex = 3;
            // 
            // btn_SuatPhim_Phong3
            // 
            btn_SuatPhim_Phong3.Location = new Point(26, 229);
            btn_SuatPhim_Phong3.Name = "btn_SuatPhim_Phong3";
            btn_SuatPhim_Phong3.Size = new Size(117, 33);
            btn_SuatPhim_Phong3.TabIndex = 3;
            btn_SuatPhim_Phong3.Text = "Phòng 3";
            btn_SuatPhim_Phong3.UseVisualStyleBackColor = true;
            // 
            // btn_SuatPhim_Phong2
            // 
            btn_SuatPhim_Phong2.Location = new Point(26, 161);
            btn_SuatPhim_Phong2.Name = "btn_SuatPhim_Phong2";
            btn_SuatPhim_Phong2.Size = new Size(117, 33);
            btn_SuatPhim_Phong2.TabIndex = 2;
            btn_SuatPhim_Phong2.Text = "Phòng 2";
            btn_SuatPhim_Phong2.UseVisualStyleBackColor = true;
            // 
            // btn_SuatPhim_Phong1
            // 
            btn_SuatPhim_Phong1.Location = new Point(26, 91);
            btn_SuatPhim_Phong1.Name = "btn_SuatPhim_Phong1";
            btn_SuatPhim_Phong1.Size = new Size(117, 33);
            btn_SuatPhim_Phong1.TabIndex = 1;
            btn_SuatPhim_Phong1.Text = "Phòng 1";
            btn_SuatPhim_Phong1.UseVisualStyleBackColor = true;
            // 
            // btn_SuatChieu_All
            // 
            btn_SuatChieu_All.Location = new Point(26, 19);
            btn_SuatChieu_All.Name = "btn_SuatChieu_All";
            btn_SuatChieu_All.Size = new Size(117, 33);
            btn_SuatChieu_All.TabIndex = 0;
            btn_SuatChieu_All.Text = "Tất cả";
            btn_SuatChieu_All.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 6);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 1;
            label1.Text = "Chọn ngày";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(357, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(169, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(631, 330);
            dataGridView1.TabIndex = 5;
            // 
            // Form_DanhSachSuatChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(grb_SuatChieu);
            Controls.Add(panel2);
            Name = "Form_DanhSachSuatChieu";
            Text = "Form_DanhSachSuatChieu";
            grb_SuatChieu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_SuatChieu;
        private Button btn_SuatChieu_Them;
        private Button btn_SuatChieu_Xoa;
        private Button btn_SuatChieu_Sua;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btn_SuatPhim_Phong3;
        private Button btn_SuatPhim_Phong2;
        private Button btn_SuatPhim_Phong1;
        private Button btn_SuatChieu_All;
    }
}