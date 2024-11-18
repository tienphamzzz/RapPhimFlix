namespace RapPhimFlix.Forms.QLyNhanVien
{
    partial class ThemNV
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
            panel1 = new Panel();
            rdo_GioiTinh_Nam = new RadioButton();
            rdo_GioiTinh_Nu = new RadioButton();
            btn_TaiAnh = new Button();
            pictureBox_anh = new PictureBox();
            txt_SDT = new TextBox();
            txt_Luong = new TextBox();
            txt_TenNV = new TextBox();
            txt_MaNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            rdo_ChucVuNhanVien = new RadioButton();
            rdo_ChucVu_QuanLy = new RadioButton();
            txt_MatKhau = new TextBox();
            txt_TaiKhoan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btn_Huy = new Button();
            btn_XacNhan = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anh).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Thêm Nhân Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btn_TaiAnh);
            groupBox1.Controls.Add(pictureBox_anh);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(txt_Luong);
            groupBox1.Controls.Add(txt_TenNV);
            groupBox1.Controls.Add(txt_MaNV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 34);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(529, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdo_GioiTinh_Nam);
            panel1.Controls.Add(rdo_GioiTinh_Nu);
            panel1.Location = new Point(68, 84);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 21);
            panel1.TabIndex = 14;
            // 
            // rdo_GioiTinh_Nam
            // 
            rdo_GioiTinh_Nam.AutoSize = true;
            rdo_GioiTinh_Nam.Location = new Point(8, 2);
            rdo_GioiTinh_Nam.Margin = new Padding(2);
            rdo_GioiTinh_Nam.Name = "rdo_GioiTinh_Nam";
            rdo_GioiTinh_Nam.Size = new Size(51, 19);
            rdo_GioiTinh_Nam.TabIndex = 14;
            rdo_GioiTinh_Nam.TabStop = true;
            rdo_GioiTinh_Nam.Text = "Nam";
            rdo_GioiTinh_Nam.UseVisualStyleBackColor = true;
            // 
            // rdo_GioiTinh_Nu
            // 
            rdo_GioiTinh_Nu.AutoSize = true;
            rdo_GioiTinh_Nu.Location = new Point(76, 2);
            rdo_GioiTinh_Nu.Margin = new Padding(2);
            rdo_GioiTinh_Nu.Name = "rdo_GioiTinh_Nu";
            rdo_GioiTinh_Nu.Size = new Size(41, 19);
            rdo_GioiTinh_Nu.TabIndex = 13;
            rdo_GioiTinh_Nu.TabStop = true;
            rdo_GioiTinh_Nu.Text = "Nữ";
            rdo_GioiTinh_Nu.UseVisualStyleBackColor = true;
            // 
            // btn_TaiAnh
            // 
            btn_TaiAnh.Location = new Point(368, 40);
            btn_TaiAnh.Margin = new Padding(2);
            btn_TaiAnh.Name = "btn_TaiAnh";
            btn_TaiAnh.Size = new Size(60, 30);
            btn_TaiAnh.TabIndex = 11;
            btn_TaiAnh.Text = "Tải ảnh";
            btn_TaiAnh.UseVisualStyleBackColor = true;
            btn_TaiAnh.Click += btn_TaiAnh_Click;
            // 
            // pictureBox_anh
            // 
            pictureBox_anh.Location = new Point(433, 11);
            pictureBox_anh.Margin = new Padding(2);
            pictureBox_anh.Name = "pictureBox_anh";
            pictureBox_anh.Size = new Size(92, 89);
            pictureBox_anh.TabIndex = 10;
            pictureBox_anh.TabStop = false;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(244, 51);
            txt_SDT.Margin = new Padding(2);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(112, 23);
            txt_SDT.TabIndex = 9;
            txt_SDT.TextChanged += txt_SDT_TextChanged;
            txt_SDT.KeyPress += txt_Luong_KeyPress;
            // 
            // txt_Luong
            // 
            txt_Luong.Location = new Point(244, 22);
            txt_Luong.Margin = new Padding(2);
            txt_Luong.Name = "txt_Luong";
            txt_Luong.Size = new Size(112, 23);
            txt_Luong.TabIndex = 8;
            txt_Luong.KeyPress += txt_Luong_KeyPress;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(76, 51);
            txt_TenNV.Margin = new Padding(2);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(112, 23);
            txt_TenNV.TabIndex = 6;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(76, 19);
            txt_MaNV.Margin = new Padding(2);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(112, 23);
            txt_MaNV.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 55);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 4;
            label6.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 22);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 3;
            label5.Text = "Lương";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã NV";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(txt_MatKhau);
            groupBox2.Controls.Add(txt_TaiKhoan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(8, 155);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(529, 74);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // panel2
            // 
            panel2.Controls.Add(rdo_ChucVuNhanVien);
            panel2.Controls.Add(rdo_ChucVu_QuanLy);
            panel2.Location = new Point(257, 17);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 26);
            panel2.TabIndex = 14;
            // 
            // rdo_ChucVuNhanVien
            // 
            rdo_ChucVuNhanVien.AutoSize = true;
            rdo_ChucVuNhanVien.Location = new Point(89, 2);
            rdo_ChucVuNhanVien.Margin = new Padding(2);
            rdo_ChucVuNhanVien.Name = "rdo_ChucVuNhanVien";
            rdo_ChucVuNhanVien.Size = new Size(80, 19);
            rdo_ChucVuNhanVien.TabIndex = 13;
            rdo_ChucVuNhanVien.TabStop = true;
            rdo_ChucVuNhanVien.Text = "Nhân Viên";
            rdo_ChucVuNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdo_ChucVu_QuanLy
            // 
            rdo_ChucVu_QuanLy.AutoSize = true;
            rdo_ChucVu_QuanLy.Location = new Point(6, 4);
            rdo_ChucVu_QuanLy.Margin = new Padding(2);
            rdo_ChucVu_QuanLy.Name = "rdo_ChucVu_QuanLy";
            rdo_ChucVu_QuanLy.Size = new Size(68, 19);
            rdo_ChucVu_QuanLy.TabIndex = 12;
            rdo_ChucVu_QuanLy.TabStop = true;
            rdo_ChucVu_QuanLy.Text = "Quản Lý";
            rdo_ChucVu_QuanLy.UseVisualStyleBackColor = true;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(76, 46);
            txt_MatKhau.Margin = new Padding(2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(112, 23);
            txt_MatKhau.TabIndex = 11;
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(76, 21);
            txt_TaiKhoan.Margin = new Padding(2);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.ReadOnly = true;
            txt_TaiKhoan.Size = new Size(112, 23);
            txt_TaiKhoan.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 21);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 3;
            label9.Text = "Chức Vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 48);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 3;
            label8.Text = "Mật Khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 23);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 5;
            label7.Text = "Tài Khoản";
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(328, 241);
            btn_Huy.Margin = new Padding(2);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(83, 32);
            btn_Huy.TabIndex = 3;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new Point(436, 241);
            btn_XacNhan.Margin = new Padding(2);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(83, 32);
            btn_XacNhan.TabIndex = 4;
            btn_XacNhan.Text = "Xác Nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // ThemNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 280);
            Controls.Add(btn_XacNhan);
            Controls.Add(btn_Huy);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ThemNV";
            Text = "ThemNV";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_anh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox txt_TenNV;
        private TextBox txt_MaNV;
        private TextBox txt_SDT;
        private TextBox txt_MatKhau;
        private TextBox txt_TaiKhoan;
        private Button btn_Huy;
        private Button btn_XacNhan;
        private Button btn_TaiAnh;
        private PictureBox pictureBox_anh;
        private RadioButton rdo_GioiTinh_Nu;
        private RadioButton rdo_ChucVuNhanVien;
        private RadioButton rdo_ChucVu_QuanLy;
        private Panel panel1;
        private Panel panel2;
        private RadioButton rdo_GioiTinh_Nam;
    }
}