namespace RapPhimFlix.Forms
{
    partial class frmSuatChieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb_ThongTinPhim = new RichTextBox();
            cbo_CacCaChieuKhac = new ComboBox();
            btn_QuayLai = new Button();
            grb_Anh = new GroupBox();
            ptb_Anh = new PictureBox();
            lbl_TenPhim = new Label();
            btn_Them = new Button();
            lbl_SuatChieu = new Label();
            btn_Chon = new Button();
            flp_CaChieu = new FlowLayoutPanel();
            grb_Anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).BeginInit();
            SuspendLayout();
            // 
            // rtb_ThongTinPhim
            // 
            rtb_ThongTinPhim.Location = new Point(290, 112);
            rtb_ThongTinPhim.Name = "rtb_ThongTinPhim";
            rtb_ThongTinPhim.ReadOnly = true;
            rtb_ThongTinPhim.Size = new Size(592, 221);
            rtb_ThongTinPhim.TabIndex = 26;
            rtb_ThongTinPhim.Text = "";
            // 
            // cbo_CacCaChieuKhac
            // 
            cbo_CacCaChieuKhac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_CacCaChieuKhac.FormattingEnabled = true;
            cbo_CacCaChieuKhac.Location = new Point(326, 439);
            cbo_CacCaChieuKhac.Name = "cbo_CacCaChieuKhac";
            cbo_CacCaChieuKhac.Size = new Size(331, 23);
            cbo_CacCaChieuKhac.TabIndex = 25;
            cbo_CacCaChieuKhac.Visible = false;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Location = new Point(3, 2);
            btn_QuayLai.Margin = new Padding(3, 2, 3, 2);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(58, 27);
            btn_QuayLai.TabIndex = 24;
            btn_QuayLai.Text = "Quay lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // grb_Anh
            // 
            grb_Anh.Controls.Add(ptb_Anh);
            grb_Anh.Location = new Point(32, 56);
            grb_Anh.Margin = new Padding(3, 2, 3, 2);
            grb_Anh.Name = "grb_Anh";
            grb_Anh.Padding = new Padding(3, 2, 3, 2);
            grb_Anh.Size = new Size(221, 281);
            grb_Anh.TabIndex = 23;
            grb_Anh.TabStop = false;
            // 
            // ptb_Anh
            // 
            ptb_Anh.Location = new Point(5, 13);
            ptb_Anh.Margin = new Padding(3, 2, 3, 2);
            ptb_Anh.Name = "ptb_Anh";
            ptb_Anh.Size = new Size(210, 264);
            ptb_Anh.TabIndex = 0;
            ptb_Anh.TabStop = false;
            // 
            // lbl_TenPhim
            // 
            lbl_TenPhim.AutoSize = true;
            lbl_TenPhim.Location = new Point(290, 69);
            lbl_TenPhim.Name = "lbl_TenPhim";
            lbl_TenPhim.Size = new Size(0, 15);
            lbl_TenPhim.TabIndex = 22;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(663, 371);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(78, 51);
            btn_Them.TabIndex = 21;
            btn_Them.Text = "Tất cả";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // lbl_SuatChieu
            // 
            lbl_SuatChieu.AutoSize = true;
            lbl_SuatChieu.Font = new Font("Segoe UI", 15F);
            lbl_SuatChieu.Location = new Point(95, 378);
            lbl_SuatChieu.Name = "lbl_SuatChieu";
            lbl_SuatChieu.Size = new Size(106, 28);
            lbl_SuatChieu.TabIndex = 16;
            lbl_SuatChieu.Text = "Suất chiếu:";
            // 
            // btn_Chon
            // 
            btn_Chon.Location = new Point(242, 439);
            btn_Chon.Name = "btn_Chon";
            btn_Chon.Size = new Size(75, 23);
            btn_Chon.TabIndex = 28;
            btn_Chon.Text = "Chọn";
            btn_Chon.UseVisualStyleBackColor = true;
            btn_Chon.Visible = false;
            btn_Chon.Click += btn_Chon_Click;
            // 
            // flp_CaChieu
            // 
            flp_CaChieu.AutoScroll = true;
            flp_CaChieu.Location = new Point(242, 371);
            flp_CaChieu.Name = "flp_CaChieu";
            flp_CaChieu.Size = new Size(415, 66);
            flp_CaChieu.TabIndex = 29;
            flp_CaChieu.WrapContents = false;
            // 
            // frmSuatChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 474);
            Controls.Add(flp_CaChieu);
            Controls.Add(btn_Chon);
            Controls.Add(rtb_ThongTinPhim);
            Controls.Add(cbo_CacCaChieuKhac);
            Controls.Add(btn_QuayLai);
            Controls.Add(grb_Anh);
            Controls.Add(lbl_TenPhim);
            Controls.Add(btn_Them);
            Controls.Add(lbl_SuatChieu);
            Name = "frmSuatChieu";
            grb_Anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_ThongTinPhim;
        private ComboBox cbo_CacCaChieuKhac;
        private Button btn_QuayLai;
        private GroupBox grb_Anh;
        private PictureBox ptb_Anh;
        private Label lbl_TenPhim;
        private Button btn_Them;
        private Label lbl_SuatChieu;
        private Button btn_Chon;
        private FlowLayoutPanel flp_CaChieu;
    }
}