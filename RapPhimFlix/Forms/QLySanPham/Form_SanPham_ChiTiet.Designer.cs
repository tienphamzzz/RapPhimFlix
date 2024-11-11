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
            groupBox3 = new GroupBox();
            btn_SanPham_ChiTiet_XacNhan = new Button();
            btn_SanPham_ChiTiet_Huy = new Button();
            label2 = new Label();
            tb_SanPham_ChiTiet_TenQuanLy = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_SanPham_ChiTiet_TenQuanLy_Loai = new TextBox();
            tb_SanPham_ChiTiet_TenQuanLy_TenSanPham = new TextBox();
            tb_SanPham_ChiTiet_TenQuanLy_MoTa = new TextBox();
            tb_SanPham_ChiTiet_TenQuanLy_Gia = new TextBox();
            tb_SanPham_ChiTiet_TenQuanLy_MaSP = new TextBox();
            ptb_SanPham_ChiTiet = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btn_SanPham_ChonTep = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham_ChiTiet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Sản Phẩm";
            // 
            // groupBox1
            // 
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
            groupBox2.Controls.Add(btn_SanPham_ChonTep);
            groupBox2.Controls.Add(ptb_SanPham_ChiTiet);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenQuanLy_MaSP);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenQuanLy_Gia);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenQuanLy_MoTa);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenQuanLy_TenSanPham);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenQuanLy_Loai);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tb_SanPham_ChiTiet_TenQuanLy);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(0, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 296);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_SanPham_ChiTiet_Huy);
            groupBox3.Controls.Add(btn_SanPham_ChiTiet_XacNhan);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 80);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // btn_SanPham_ChiTiet_XacNhan
            // 
            btn_SanPham_ChiTiet_XacNhan.Location = new Point(560, 28);
            btn_SanPham_ChiTiet_XacNhan.Name = "btn_SanPham_ChiTiet_XacNhan";
            btn_SanPham_ChiTiet_XacNhan.Size = new Size(105, 35);
            btn_SanPham_ChiTiet_XacNhan.TabIndex = 0;
            btn_SanPham_ChiTiet_XacNhan.Text = "Xác Nhận";
            btn_SanPham_ChiTiet_XacNhan.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham_ChiTiet_Huy
            // 
            btn_SanPham_ChiTiet_Huy.Location = new Point(430, 28);
            btn_SanPham_ChiTiet_Huy.Name = "btn_SanPham_ChiTiet_Huy";
            btn_SanPham_ChiTiet_Huy.Size = new Size(97, 35);
            btn_SanPham_ChiTiet_Huy.TabIndex = 1;
            btn_SanPham_ChiTiet_Huy.Text = "Hủy";
            btn_SanPham_ChiTiet_Huy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 25);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên Quản lý ";
            // 
            // tb_SanPham_ChiTiet_TenQuanLy
            // 
            tb_SanPham_ChiTiet_TenQuanLy.Location = new Point(144, 25);
            tb_SanPham_ChiTiet_TenQuanLy.Name = "tb_SanPham_ChiTiet_TenQuanLy";
            tb_SanPham_ChiTiet_TenQuanLy.Size = new Size(174, 23);
            tb_SanPham_ChiTiet_TenQuanLy.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 159);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 93);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 3;
            label4.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 222);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 4;
            label5.Text = "Mô tả sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(324, 25);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 5;
            label6.Text = "Mã sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(324, 93);
            label7.Name = "label7";
            label7.Size = new Size(33, 21);
            label7.TabIndex = 6;
            label7.Text = "Giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(536, 163);
            label8.Name = "label8";
            label8.Size = new Size(39, 21);
            label8.TabIndex = 7;
            label8.Text = "Ảnh";
            // 
            // tb_SanPham_ChiTiet_TenQuanLy_Loai
            // 
            tb_SanPham_ChiTiet_TenQuanLy_Loai.Location = new Point(144, 161);
            tb_SanPham_ChiTiet_TenQuanLy_Loai.Name = "tb_SanPham_ChiTiet_TenQuanLy_Loai";
            tb_SanPham_ChiTiet_TenQuanLy_Loai.Size = new Size(174, 23);
            tb_SanPham_ChiTiet_TenQuanLy_Loai.TabIndex = 8;
            // 
            // tb_SanPham_ChiTiet_TenQuanLy_TenSanPham
            // 
            tb_SanPham_ChiTiet_TenQuanLy_TenSanPham.Location = new Point(144, 95);
            tb_SanPham_ChiTiet_TenQuanLy_TenSanPham.Name = "tb_SanPham_ChiTiet_TenQuanLy_TenSanPham";
            tb_SanPham_ChiTiet_TenQuanLy_TenSanPham.Size = new Size(174, 23);
            tb_SanPham_ChiTiet_TenQuanLy_TenSanPham.TabIndex = 8;
            // 
            // tb_SanPham_ChiTiet_TenQuanLy_MoTa
            // 
            tb_SanPham_ChiTiet_TenQuanLy_MoTa.Location = new Point(160, 224);
            tb_SanPham_ChiTiet_TenQuanLy_MoTa.Multiline = true;
            tb_SanPham_ChiTiet_TenQuanLy_MoTa.Name = "tb_SanPham_ChiTiet_TenQuanLy_MoTa";
            tb_SanPham_ChiTiet_TenQuanLy_MoTa.Size = new Size(415, 58);
            tb_SanPham_ChiTiet_TenQuanLy_MoTa.TabIndex = 9;
            // 
            // tb_SanPham_ChiTiet_TenQuanLy_Gia
            // 
            tb_SanPham_ChiTiet_TenQuanLy_Gia.Location = new Point(430, 95);
            tb_SanPham_ChiTiet_TenQuanLy_Gia.Name = "tb_SanPham_ChiTiet_TenQuanLy_Gia";
            tb_SanPham_ChiTiet_TenQuanLy_Gia.Size = new Size(145, 23);
            tb_SanPham_ChiTiet_TenQuanLy_Gia.TabIndex = 10;
            // 
            // tb_SanPham_ChiTiet_TenQuanLy_MaSP
            // 
            tb_SanPham_ChiTiet_TenQuanLy_MaSP.Location = new Point(430, 27);
            tb_SanPham_ChiTiet_TenQuanLy_MaSP.Name = "tb_SanPham_ChiTiet_TenQuanLy_MaSP";
            tb_SanPham_ChiTiet_TenQuanLy_MaSP.Size = new Size(145, 23);
            tb_SanPham_ChiTiet_TenQuanLy_MaSP.TabIndex = 11;
            // 
            // ptb_SanPham_ChiTiet
            // 
            ptb_SanPham_ChiTiet.BackColor = SystemColors.ControlLightLight;
            ptb_SanPham_ChiTiet.Location = new Point(616, 26);
            ptb_SanPham_ChiTiet.Name = "ptb_SanPham_ChiTiet";
            ptb_SanPham_ChiTiet.Size = new Size(154, 154);
            ptb_SanPham_ChiTiet.TabIndex = 12;
            ptb_SanPham_ChiTiet.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_SanPham_ChonTep
            // 
            btn_SanPham_ChonTep.Location = new Point(695, 206);
            btn_SanPham_ChonTep.Name = "btn_SanPham_ChonTep";
            btn_SanPham_ChonTep.Size = new Size(75, 23);
            btn_SanPham_ChonTep.TabIndex = 13;
            btn_SanPham_ChonTep.Text = "Chọn tệp";
            btn_SanPham_ChonTep.UseVisualStyleBackColor = true;
            // 
            // Form_SanPham_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form_SanPham_ChiTiet";
            Text = "Form_SanPham_ChiTiet";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tb_SanPham_ChiTiet_TenQuanLy;
        private Label label2;
        private GroupBox groupBox3;
        private Button btn_SanPham_ChiTiet_Huy;
        private Button btn_SanPham_ChiTiet_XacNhan;
        private Button btn_SanPham_ChonTep;
        private PictureBox ptb_SanPham_ChiTiet;
        private TextBox tb_SanPham_ChiTiet_TenQuanLy_MaSP;
        private TextBox tb_SanPham_ChiTiet_TenQuanLy_Gia;
        private TextBox tb_SanPham_ChiTiet_TenQuanLy_MoTa;
        private TextBox tb_SanPham_ChiTiet_TenQuanLy_TenSanPham;
        private TextBox tb_SanPham_ChiTiet_TenQuanLy_Loai;
        private OpenFileDialog openFileDialog1;
    }
}