namespace RapPhimFlix.Forms
{
    partial class ThanhToanVePhim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            groupBoxTicketInfo = new GroupBox();
            lblMaVe = new Label();
            lblPhim = new Label();
            lblNgayChieu = new Label();
            lblCaChieu = new Label();
            lblPhongChieu = new Label();
            lblGhe = new Label();
            lblGiaVe = new Label();
            groupBoxCustomerInfo = new GroupBox();
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblGioiTinh = new Label();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            lblTongTien = new Label();
            btnCancel = new Button();
            btnThanhToan = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            groupBoxTicketInfo.SuspendLayout();
            groupBoxCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(350, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(164, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thanh toán";
            // 
            // groupBoxTicketInfo
            // 
            groupBoxTicketInfo.Controls.Add(textBox8);
            groupBoxTicketInfo.Controls.Add(textBox7);
            groupBoxTicketInfo.Controls.Add(textBox6);
            groupBoxTicketInfo.Controls.Add(textBox5);
            groupBoxTicketInfo.Controls.Add(textBox4);
            groupBoxTicketInfo.Controls.Add(textBox3);
            groupBoxTicketInfo.Controls.Add(textBox2);
            groupBoxTicketInfo.Controls.Add(lblMaVe);
            groupBoxTicketInfo.Controls.Add(lblPhim);
            groupBoxTicketInfo.Controls.Add(lblNgayChieu);
            groupBoxTicketInfo.Controls.Add(lblCaChieu);
            groupBoxTicketInfo.Controls.Add(lblPhongChieu);
            groupBoxTicketInfo.Controls.Add(lblGhe);
            groupBoxTicketInfo.Controls.Add(lblGiaVe);
            groupBoxTicketInfo.Location = new Point(30, 55);
            groupBoxTicketInfo.Name = "groupBoxTicketInfo";
            groupBoxTicketInfo.Size = new Size(350, 316);
            groupBoxTicketInfo.TabIndex = 1;
            groupBoxTicketInfo.TabStop = false;
            groupBoxTicketInfo.Text = "Thông tin vé";
            // 
            // lblMaVe
            // 
            lblMaVe.Location = new Point(10, 35);
            lblMaVe.Name = "lblMaVe";
            lblMaVe.Size = new Size(100, 23);
            lblMaVe.TabIndex = 0;
            lblMaVe.Text = "Mã vé:";
            // 
            // lblPhim
            // 
            lblPhim.Location = new Point(10, 75);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(100, 23);
            lblPhim.TabIndex = 1;
            lblPhim.Text = "Phim:";
            // 
            // lblNgayChieu
            // 
            lblNgayChieu.Location = new Point(10, 115);
            lblNgayChieu.Name = "lblNgayChieu";
            lblNgayChieu.Size = new Size(100, 23);
            lblNgayChieu.TabIndex = 2;
            lblNgayChieu.Text = "Ngày chiếu:";
            // 
            // lblCaChieu
            // 
            lblCaChieu.Location = new Point(10, 159);
            lblCaChieu.Name = "lblCaChieu";
            lblCaChieu.Size = new Size(100, 23);
            lblCaChieu.TabIndex = 3;
            lblCaChieu.Text = "Ca chiếu:";
            // 
            // lblPhongChieu
            // 
            lblPhongChieu.Location = new Point(10, 198);
            lblPhongChieu.Name = "lblPhongChieu";
            lblPhongChieu.Size = new Size(100, 23);
            lblPhongChieu.TabIndex = 4;
            lblPhongChieu.Text = "Phòng chiếu:";
            // 
            // lblGhe
            // 
            lblGhe.Location = new Point(10, 235);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(100, 23);
            lblGhe.TabIndex = 5;
            lblGhe.Text = "Ghế:";
            // 
            // lblGiaVe
            // 
            lblGiaVe.Location = new Point(10, 277);
            lblGiaVe.Name = "lblGiaVe";
            lblGiaVe.Size = new Size(100, 23);
            lblGiaVe.TabIndex = 6;
            lblGiaVe.Text = "Giá vé:";
            // 
            // groupBoxCustomerInfo
            // 
            groupBoxCustomerInfo.Controls.Add(lblTenKhach);
            groupBoxCustomerInfo.Controls.Add(txtTenKhach);
            groupBoxCustomerInfo.Controls.Add(lblSoDienThoai);
            groupBoxCustomerInfo.Controls.Add(txtSoDienThoai);
            groupBoxCustomerInfo.Controls.Add(lblGioiTinh);
            groupBoxCustomerInfo.Controls.Add(rbNam);
            groupBoxCustomerInfo.Controls.Add(rbNu);
            groupBoxCustomerInfo.Location = new Point(450, 60);
            groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            groupBoxCustomerInfo.Size = new Size(350, 311);
            groupBoxCustomerInfo.TabIndex = 2;
            groupBoxCustomerInfo.TabStop = false;
            groupBoxCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // lblTenKhach
            // 
            lblTenKhach.Location = new Point(10, 30);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(100, 23);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            lblTenKhach.Click += lblTenKhach_Click;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(120, 30);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(200, 27);
            txtTenKhach.TabIndex = 1;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Location = new Point(10, 70);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 23);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(120, 70);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(200, 27);
            txtSoDienThoai.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(10, 110);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // rbNam
            // 
            rbNam.Location = new Point(120, 110);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(71, 24);
            rbNam.TabIndex = 5;
            rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            rbNu.Location = new Point(216, 110);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(80, 24);
            rbNu.TabIndex = 6;
            rbNu.Text = "Nữ";
            rbNu.CheckedChanged += rbNu_CheckedChanged;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(30, 388);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(100, 23);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(546, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 43);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(653, 388);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(106, 43);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 388);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(155, 195);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 27);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(155, 273);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(184, 27);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(155, 235);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(184, 27);
            textBox8.TabIndex = 8;
            // 
            // ThanhToanVePhim
            // 
            Controls.Add(textBox1);
            Controls.Add(labelTitle);
            Controls.Add(groupBoxTicketInfo);
            Controls.Add(groupBoxCustomerInfo);
            Controls.Add(lblTongTien);
            Controls.Add(btnCancel);
            Controls.Add(btnThanhToan);
            Name = "ThanhToanVePhim";
            Size = new Size(861, 476);
            groupBoxTicketInfo.ResumeLayout(false);
            groupBoxTicketInfo.PerformLayout();
            groupBoxCustomerInfo.ResumeLayout(false);
            groupBoxCustomerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private GroupBox groupBoxTicketInfo;
        private Label lblMaVe;
        private Label lblPhim;
        private Label lblNgayChieu;
        private Label lblCaChieu;
        private Label lblPhongChieu;
        private Label lblGhe;
        private Label lblGiaVe;
        private GroupBox groupBoxCustomerInfo;
        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblGioiTinh;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Label lblTongTien;
        private Button btnCancel;
        private Button btnThanhToan;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
        }

        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
