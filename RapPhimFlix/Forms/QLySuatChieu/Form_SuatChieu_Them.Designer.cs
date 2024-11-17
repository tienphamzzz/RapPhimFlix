namespace RapPhimFlix.Forms.MenuNav.SuatChieu
{
    partial class Form_SuatChieu_Them
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
            btn_ThemSuatChieu_quaylai = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_SuatChieu_XacNhan = new Button();
            tb_SuatChieu_GiaVe = new TextBox();
            cbb_SuatChieu_dsPhim = new ComboBox();
            cbb_SuatChieu_dsPhongChieu = new ComboBox();
            label7 = new Label();
            tb_SuatChieu_Them_MaSC = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cbb_Ca_begin = new ComboBox();
            cbb_Ca_end = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 19);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "Thêm Suất Chiếu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ThemSuatChieu_quaylai);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 67);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btn_ThemSuatChieu_quaylai
            // 
            btn_ThemSuatChieu_quaylai.Location = new Point(32, 22);
            btn_ThemSuatChieu_quaylai.Name = "btn_ThemSuatChieu_quaylai";
            btn_ThemSuatChieu_quaylai.Size = new Size(75, 23);
            btn_ThemSuatChieu_quaylai.TabIndex = 70;
            btn_ThemSuatChieu_quaylai.Text = "← Quay lại danh sách";
            btn_ThemSuatChieu_quaylai.UseVisualStyleBackColor = true;
            btn_ThemSuatChieu_quaylai.Click += btn_ThemSuatChieu_quaylai_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 163);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(346, 91);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "Ngày Chiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 291);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 4;
            label4.Text = "Ca chiếu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(346, 159);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 5;
            label5.Text = "Phòng Chiếu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 228);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 6;
            label6.Text = "Giá vé";
            // 
            // btn_SuatChieu_XacNhan
            // 
            btn_SuatChieu_XacNhan.Location = new Point(454, 340);
            btn_SuatChieu_XacNhan.Name = "btn_SuatChieu_XacNhan";
            btn_SuatChieu_XacNhan.Size = new Size(120, 38);
            btn_SuatChieu_XacNhan.TabIndex = 7;
            btn_SuatChieu_XacNhan.Text = "Xác nhận";
            btn_SuatChieu_XacNhan.UseVisualStyleBackColor = true;
            btn_SuatChieu_XacNhan.Click += btn_SuatChieu_XacNhan_Click;
            // 
            // tb_SuatChieu_GiaVe
            // 
            tb_SuatChieu_GiaVe.Location = new Point(156, 226);
            tb_SuatChieu_GiaVe.Name = "tb_SuatChieu_GiaVe";
            tb_SuatChieu_GiaVe.Size = new Size(154, 23);
            tb_SuatChieu_GiaVe.TabIndex = 12;
            // 
            // cbb_SuatChieu_dsPhim
            // 
            cbb_SuatChieu_dsPhim.FormattingEnabled = true;
            cbb_SuatChieu_dsPhim.Location = new Point(156, 161);
            cbb_SuatChieu_dsPhim.Name = "cbb_SuatChieu_dsPhim";
            cbb_SuatChieu_dsPhim.Size = new Size(154, 23);
            cbb_SuatChieu_dsPhim.TabIndex = 13;
            // 
            // cbb_SuatChieu_dsPhongChieu
            // 
            cbb_SuatChieu_dsPhongChieu.FormattingEnabled = true;
            cbb_SuatChieu_dsPhongChieu.Location = new Point(454, 159);
            cbb_SuatChieu_dsPhongChieu.Name = "cbb_SuatChieu_dsPhongChieu";
            cbb_SuatChieu_dsPhongChieu.Size = new Size(154, 23);
            cbb_SuatChieu_dsPhongChieu.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(32, 91);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 15;
            label7.Text = "Mã Suất Chiếu";
            // 
            // tb_SuatChieu_Them_MaSC
            // 
            tb_SuatChieu_Them_MaSC.Location = new Point(157, 97);
            tb_SuatChieu_Them_MaSC.Name = "tb_SuatChieu_Them_MaSC";
            tb_SuatChieu_Them_MaSC.Size = new Size(153, 23);
            tb_SuatChieu_Them_MaSC.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(156, 291);
            label8.Name = "label8";
            label8.Size = new Size(29, 21);
            label8.TabIndex = 17;
            label8.Text = "Từ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(258, 293);
            label9.Name = "label9";
            label9.Size = new Size(39, 21);
            label9.TabIndex = 18;
            label9.Text = "Đến";
            // 
            // cbb_Ca_begin
            // 
            cbb_Ca_begin.FormattingEnabled = true;
            cbb_Ca_begin.Location = new Point(191, 293);
            cbb_Ca_begin.Name = "cbb_Ca_begin";
            cbb_Ca_begin.Size = new Size(41, 23);
            cbb_Ca_begin.TabIndex = 19;
            // 
            // cbb_Ca_end
            // 
            cbb_Ca_end.FormattingEnabled = true;
            cbb_Ca_end.Location = new Point(303, 293);
            cbb_Ca_end.Name = "cbb_Ca_end";
            cbb_Ca_end.Size = new Size(43, 23);
            cbb_Ca_end.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(454, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // Form_SuatChieu_Them
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(754, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbb_Ca_end);
            Controls.Add(cbb_Ca_begin);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tb_SuatChieu_Them_MaSC);
            Controls.Add(label7);
            Controls.Add(cbb_SuatChieu_dsPhongChieu);
            Controls.Add(cbb_SuatChieu_dsPhim);
            Controls.Add(tb_SuatChieu_GiaVe);
            Controls.Add(btn_SuatChieu_XacNhan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "Form_SuatChieu_Them";
            Text = "Form_SuatChieu_Them";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_SuatChieu_XacNhan;
        private TextBox tb_SuatChieu_GiaVe;
        private ComboBox cbb_SuatChieu_dsPhim;
        private ComboBox cbb_SuatChieu_dsPhongChieu;
        private Button btn_ThemSuatChieu_quaylai;
        private Label label7;
        private TextBox tb_SuatChieu_Them_MaSC;
        private Label label8;
        private Label label9;
        private ComboBox cbb_Ca_begin;
        private ComboBox cbb_Ca_end;
        private DateTimePicker dateTimePicker1;
    }
}