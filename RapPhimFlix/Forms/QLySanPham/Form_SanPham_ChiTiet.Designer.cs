namespace RapPhimFlix.Forms.MenuNav.SanPham
{
    partial class Form_SanPham_ChiTiet
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
            groupBox2 = new GroupBox();
            btn_SanPham_ChiTiet_XacNhan = new Button();
            ptb_SanPham_ChiTiet = new PictureBox();
            tb_SanPham_ChiTiet_MaSP = new TextBox();
            tb_SanPham_ChiTiet_Gia = new TextBox();
            tb_SanPham_ChiTiet_TenSanPham = new TextBox();
            tb_SanPham_ChiTiet_Loai = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btn_ThemPhim_quaylai = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham_ChiTiet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Sản Phẩm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ThemPhim_quaylai);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 74);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_SanPham_ChiTiet_XacNhan);
            groupBox2.Controls.Add(ptb_SanPham_ChiTiet);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_MaSP);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_Gia);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenSanPham);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_Loai);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(0, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 376);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btn_SanPham_ChiTiet_XacNhan
            // 
            btn_SanPham_ChiTiet_XacNhan.Location = new Point(439, 259);
            btn_SanPham_ChiTiet_XacNhan.Name = "btn_SanPham_ChiTiet_XacNhan";
            btn_SanPham_ChiTiet_XacNhan.Size = new Size(150, 58);
            btn_SanPham_ChiTiet_XacNhan.TabIndex = 0;
            btn_SanPham_ChiTiet_XacNhan.Text = "Xác Nhận";
            btn_SanPham_ChiTiet_XacNhan.UseVisualStyleBackColor = true;
            btn_SanPham_ChiTiet_XacNhan.Click += btn_SanPham_ChiTiet_XacNhan_Click;
            // 
            // ptb_SanPham_ChiTiet
            // 
            ptb_SanPham_ChiTiet.BackColor = SystemColors.ControlLightLight;
            ptb_SanPham_ChiTiet.Location = new Point(439, 22);
            ptb_SanPham_ChiTiet.Name = "ptb_SanPham_ChiTiet";
            ptb_SanPham_ChiTiet.Size = new Size(154, 154);
            ptb_SanPham_ChiTiet.TabIndex = 12;
            ptb_SanPham_ChiTiet.TabStop = false;
            // 
            // tb_SanPham_ChiTiet_MaSP
            // 
            tb_SanPham_ChiTiet_MaSP.Location = new Point(144, 177);
            tb_SanPham_ChiTiet_MaSP.Name = "tb_SanPham_ChiTiet_MaSP";
            tb_SanPham_ChiTiet_MaSP.Size = new Size(152, 23);
            tb_SanPham_ChiTiet_MaSP.TabIndex = 11;
            tb_SanPham_ChiTiet_MaSP.TextChanged += tb_SanPham_ChiTiet_MaSP_TextChanged;
            // 
            // tb_SanPham_ChiTiet_Gia
            // 
            tb_SanPham_ChiTiet_Gia.Location = new Point(144, 257);
            tb_SanPham_ChiTiet_Gia.Name = "tb_SanPham_ChiTiet_Gia";
            tb_SanPham_ChiTiet_Gia.Size = new Size(152, 23);
            tb_SanPham_ChiTiet_Gia.TabIndex = 10;
            // 
            // tb_SanPham_ChiTiet_TenSanPham
            // 
            tb_SanPham_ChiTiet_TenSanPham.Location = new Point(144, 29);
            tb_SanPham_ChiTiet_TenSanPham.Name = "tb_SanPham_ChiTiet_TenSanPham";
            tb_SanPham_ChiTiet_TenSanPham.Size = new Size(152, 23);
            tb_SanPham_ChiTiet_TenSanPham.TabIndex = 8;
            // 
            // tb_SanPham_ChiTiet_Loai
            // 
            tb_SanPham_ChiTiet_Loai.Location = new Point(144, 106);
            tb_SanPham_ChiTiet_Loai.Name = "tb_SanPham_ChiTiet_Loai";
            tb_SanPham_ChiTiet_Loai.Size = new Size(152, 23);
            tb_SanPham_ChiTiet_Loai.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(353, 27);
            label8.Name = "label8";
            label8.Size = new Size(39, 21);
            label8.TabIndex = 7;
            label8.Text = "Ảnh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 259);
            label7.Name = "label7";
            label7.Size = new Size(33, 21);
            label7.TabIndex = 6;
            label7.Text = "Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 175);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 5;
            label6.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 27);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 3;
            label4.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 104);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "Loại";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ThemPhim_quaylai
            // 
            btn_ThemPhim_quaylai.Location = new Point(28, 22);
            btn_ThemPhim_quaylai.Name = "btn_ThemPhim_quaylai";
            btn_ThemPhim_quaylai.Size = new Size(75, 28);
            btn_ThemPhim_quaylai.TabIndex = 70;
            btn_ThemPhim_quaylai.Text = "← Quay lại danh sách";
            btn_ThemPhim_quaylai.UseVisualStyleBackColor = true;
            btn_ThemPhim_quaylai.Click += btn_ThemPhim_quaylai_Click;
            // 
            // Form_SanPham_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_SanPham_ChiTiet";
            Text = "Form_SanPham_ChiTiet";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham_ChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button btn_SanPham_ChiTiet_XacNhan;
        private PictureBox ptb_SanPham_ChiTiet;
        private TextBox tb_SanPham_ChiTiet_MaSP;
        private TextBox tb_SanPham_ChiTiet_Gia;
        private TextBox tb_SanPham_ChiTiet_TenSanPham;
        private TextBox tb_SanPham_ChiTiet_Loai;
        private OpenFileDialog openFileDialog1;
        private Button btn_ThemPhim_quaylai;
    }
}