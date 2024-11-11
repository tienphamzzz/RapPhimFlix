namespace RapPhimFlix.Forms.QLyNhanVien
{
    partial class ChiTietNV
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_TaiAnh = new Button();
            pictureBox_anh = new PictureBox();
            txt_SDT = new TextBox();
            txt_Luong = new TextBox();
            txt_GioiTinh = new TextBox();
            txt_TenNV = new TextBox();
            txt_MaNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txt_ChucVu = new TextBox();
            txt_MatKhau = new TextBox();
            txt_TaiKhoan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btn_XacNhan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anh).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 30);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Thông Tin Nhân Viên";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_TaiAnh);
            groupBox1.Controls.Add(pictureBox_anh);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(txt_Luong);
            groupBox1.Controls.Add(txt_GioiTinh);
            groupBox1.Controls.Add(txt_TenNV);
            groupBox1.Controls.Add(txt_MaNV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 196);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // btn_TaiAnh
            // 
            btn_TaiAnh.Location = new Point(541, 72);
            btn_TaiAnh.Name = "btn_TaiAnh";
            btn_TaiAnh.Size = new Size(71, 70);
            btn_TaiAnh.TabIndex = 11;
            btn_TaiAnh.Text = "Tải ảnh";
            btn_TaiAnh.UseVisualStyleBackColor = true;
            // 
            // pictureBox_anh
            // 
            pictureBox_anh.Location = new Point(618, 19);
            pictureBox_anh.Name = "pictureBox_anh";
            pictureBox_anh.Size = new Size(132, 149);
            pictureBox_anh.TabIndex = 10;
            pictureBox_anh.TabStop = false;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(348, 85);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(158, 31);
            txt_SDT.TabIndex = 9;
            // 
            // txt_Luong
            // 
            txt_Luong.Location = new Point(348, 37);
            txt_Luong.Name = "txt_Luong";
            txt_Luong.Size = new Size(158, 31);
            txt_Luong.TabIndex = 8;
            // 
            // txt_GioiTinh
            // 
            txt_GioiTinh.Location = new Point(108, 137);
            txt_GioiTinh.Name = "txt_GioiTinh";
            txt_GioiTinh.Size = new Size(158, 31);
            txt_GioiTinh.TabIndex = 7;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(108, 85);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(158, 31);
            txt_TenNV.TabIndex = 6;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(108, 31);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(158, 31);
            txt_MaNV.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 91);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 4;
            label6.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 37);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 3;
            label5.Text = "Lương";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 143);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 1;
            label3.Text = "Tên NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã NV";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_ChucVu);
            groupBox2.Controls.Add(txt_MatKhau);
            groupBox2.Controls.Add(txt_TaiKhoan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 123);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(356, 38);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(158, 31);
            txt_ChucVu.TabIndex = 12;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(108, 77);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(158, 31);
            txt_MatKhau.TabIndex = 11;
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(108, 35);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(158, 31);
            txt_TaiKhoan.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 35);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 3;
            label9.Text = "Chức Vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 80);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 3;
            label8.Text = "Mật Khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 38);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 5;
            label7.Text = "Tài Khoản";
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new Point(623, 402);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(118, 53);
            btn_XacNhan.TabIndex = 4;
            btn_XacNhan.Text = "Xác Nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            // 
            // ChiTietNV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(btn_XacNhan);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ChiTietNV";
            Text = "ThemNV";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_Luong;
        private TextBox txt_GioiTinh;
        private TextBox txt_TenNV;
        private TextBox txt_MaNV;
        private TextBox txt_SDT;
        private TextBox txt_ChucVu;
        private TextBox txt_MatKhau;
        private TextBox txt_TaiKhoan;
        private Button btn_XacNhan;
        private Button btn_TaiAnh;
        private PictureBox pictureBox_anh;
    }
}