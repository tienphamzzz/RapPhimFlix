namespace RapPhimFlix.Forms
{
    partial class frmThanhToanVePhim
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
            gbTicketInfo = new GroupBox();
            txt_Ghes = new TextBox();
            txt_GiaVe = new TextBox();
            txt_PhongChieu = new TextBox();
            txt_CaChieu = new TextBox();
            txt_NgayChieu = new TextBox();
            txt_Phim = new TextBox();
            lblFilmName = new Label();
            lblShowDate = new Label();
            lblScreening = new Label();
            lblRoom = new Label();
            lblChair = new Label();
            lblTicketPrice = new Label();
            gbCustomerInfo = new GroupBox();
            txt_Discount = new TextBox();
            lbl_Discount = new Label();
            ptb_Image = new PictureBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblSex = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblTotal = new Label();
            btnCancel = new Button();
            btnPay = new Button();
            txtTotal = new TextBox();
            gbTicketInfo.SuspendLayout();
            gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(350, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(129, 26);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thanh toán";
            // 
            // gbTicketInfo
            // 
            gbTicketInfo.Controls.Add(txt_Ghes);
            gbTicketInfo.Controls.Add(txt_GiaVe);
            gbTicketInfo.Controls.Add(txt_PhongChieu);
            gbTicketInfo.Controls.Add(txt_CaChieu);
            gbTicketInfo.Controls.Add(txt_NgayChieu);
            gbTicketInfo.Controls.Add(txt_Phim);
            gbTicketInfo.Controls.Add(lblFilmName);
            gbTicketInfo.Controls.Add(lblShowDate);
            gbTicketInfo.Controls.Add(lblScreening);
            gbTicketInfo.Controls.Add(lblRoom);
            gbTicketInfo.Controls.Add(lblChair);
            gbTicketInfo.Controls.Add(lblTicketPrice);
            gbTicketInfo.Location = new Point(30, 55);
            gbTicketInfo.Name = "gbTicketInfo";
            gbTicketInfo.Size = new Size(350, 316);
            gbTicketInfo.TabIndex = 1;
            gbTicketInfo.TabStop = false;
            gbTicketInfo.Text = "Thông tin vé";
            // 
            // txt_Ghes
            // 
            txt_Ghes.Location = new Point(155, 214);
            txt_Ghes.Name = "txt_Ghes";
            txt_Ghes.ReadOnly = true;
            txt_Ghes.Size = new Size(184, 23);
            txt_Ghes.TabIndex = 8;
            // 
            // txt_GiaVe
            // 
            txt_GiaVe.Location = new Point(155, 252);
            txt_GiaVe.Name = "txt_GiaVe";
            txt_GiaVe.ReadOnly = true;
            txt_GiaVe.Size = new Size(184, 23);
            txt_GiaVe.TabIndex = 12;
            // 
            // txt_PhongChieu
            // 
            txt_PhongChieu.Location = new Point(155, 174);
            txt_PhongChieu.Name = "txt_PhongChieu";
            txt_PhongChieu.ReadOnly = true;
            txt_PhongChieu.Size = new Size(184, 23);
            txt_PhongChieu.TabIndex = 11;
            // 
            // txt_CaChieu
            // 
            txt_CaChieu.Location = new Point(155, 134);
            txt_CaChieu.Name = "txt_CaChieu";
            txt_CaChieu.ReadOnly = true;
            txt_CaChieu.Size = new Size(184, 23);
            txt_CaChieu.TabIndex = 10;
            // 
            // txt_NgayChieu
            // 
            txt_NgayChieu.Location = new Point(155, 91);
            txt_NgayChieu.Name = "txt_NgayChieu";
            txt_NgayChieu.ReadOnly = true;
            txt_NgayChieu.Size = new Size(184, 23);
            txt_NgayChieu.TabIndex = 9;
            // 
            // txt_Phim
            // 
            txt_Phim.Location = new Point(155, 51);
            txt_Phim.Name = "txt_Phim";
            txt_Phim.ReadOnly = true;
            txt_Phim.Size = new Size(184, 23);
            txt_Phim.TabIndex = 8;
            // 
            // lblFilmName
            // 
            lblFilmName.Location = new Point(10, 54);
            lblFilmName.Name = "lblFilmName";
            lblFilmName.Size = new Size(100, 23);
            lblFilmName.TabIndex = 1;
            lblFilmName.Text = "Phim:";
            // 
            // lblShowDate
            // 
            lblShowDate.Location = new Point(10, 94);
            lblShowDate.Name = "lblShowDate";
            lblShowDate.Size = new Size(100, 23);
            lblShowDate.TabIndex = 2;
            lblShowDate.Text = "Ngày chiếu:";
            // 
            // lblScreening
            // 
            lblScreening.Location = new Point(10, 138);
            lblScreening.Name = "lblScreening";
            lblScreening.Size = new Size(100, 23);
            lblScreening.TabIndex = 3;
            lblScreening.Text = "Ca chiếu:";
            // 
            // lblRoom
            // 
            lblRoom.Location = new Point(10, 177);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(100, 23);
            lblRoom.TabIndex = 4;
            lblRoom.Text = "Phòng chiếu:";
            // 
            // lblChair
            // 
            lblChair.Location = new Point(10, 214);
            lblChair.Name = "lblChair";
            lblChair.Size = new Size(100, 23);
            lblChair.TabIndex = 5;
            lblChair.Text = "Ghế:";
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.Location = new Point(10, 256);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(100, 23);
            lblTicketPrice.TabIndex = 6;
            lblTicketPrice.Text = "Giá vé:";
            // 
            // gbCustomerInfo
            // 
            gbCustomerInfo.Controls.Add(txt_Discount);
            gbCustomerInfo.Controls.Add(lbl_Discount);
            gbCustomerInfo.Controls.Add(ptb_Image);
            gbCustomerInfo.Controls.Add(lblCustomerName);
            gbCustomerInfo.Controls.Add(txtCustomerName);
            gbCustomerInfo.Controls.Add(lblPhoneNumber);
            gbCustomerInfo.Controls.Add(txtPhoneNumber);
            gbCustomerInfo.Controls.Add(lblSex);
            gbCustomerInfo.Controls.Add(rbMale);
            gbCustomerInfo.Controls.Add(rbFemale);
            gbCustomerInfo.Location = new Point(450, 60);
            gbCustomerInfo.Name = "gbCustomerInfo";
            gbCustomerInfo.Size = new Size(350, 311);
            gbCustomerInfo.TabIndex = 2;
            gbCustomerInfo.TabStop = false;
            gbCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(120, 146);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(200, 23);
            txt_Discount.TabIndex = 9;
            // 
            // lbl_Discount
            // 
            lbl_Discount.Location = new Point(10, 146);
            lbl_Discount.Name = "lbl_Discount";
            lbl_Discount.Size = new Size(100, 23);
            lbl_Discount.TabIndex = 8;
            lbl_Discount.Text = "Giảm giá:";
            // 
            // ptb_Image
            // 
            ptb_Image.Location = new Point(106, 209);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(137, 96);
            ptb_Image.TabIndex = 7;
            ptb_Image.TabStop = false;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(10, 33);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(100, 23);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Tên khách:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(120, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextChanged += txt_TextChanged;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(10, 73);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 23);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(120, 70);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 3;
            txtPhoneNumber.TextChanged += txt_TextChanged;
            // 
            // lblSex
            // 
            lblSex.Location = new Point(10, 111);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(100, 23);
            lblSex.TabIndex = 4;
            lblSex.Text = "Giới tính:";
            // 
            // rbMale
            // 
            rbMale.Location = new Point(120, 110);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(71, 24);
            rbMale.TabIndex = 5;
            rbMale.Text = "Nam";
            rbMale.Click += rbSex_Click;
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(216, 110);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 24);
            rbFemale.TabIndex = 6;
            rbFemale.Text = "Nữ";
            rbFemale.Click += rbSex_Click;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(30, 388);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Tổng tiền:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(546, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 43);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(653, 388);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(106, 43);
            btnPay.TabIndex = 5;
            btnPay.Text = "Thanh toán";
            btnPay.Click += btnThanhToan_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(244, 388);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 23);
            txtTotal.TabIndex = 6;
            // 
            // frmThanhToanVePhim
            // 
            ClientSize = new Size(843, 455);
            Controls.Add(txtTotal);
            Controls.Add(labelTitle);
            Controls.Add(gbTicketInfo);
            Controls.Add(gbCustomerInfo);
            Controls.Add(lblTotal);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Name = "frmThanhToanVePhim";
            gbTicketInfo.ResumeLayout(false);
            gbTicketInfo.PerformLayout();
            gbCustomerInfo.ResumeLayout(false);
            gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private GroupBox gbTicketInfo;
        private Label lblFilmName;
        private Label lblShowDate;
        private Label lblScreening;
        private Label lblRoom;
        private Label lblChair;
        private Label lblTicketPrice;
        private GroupBox gbCustomerInfo;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblSex;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label lblTotal;
        private Button btnCancel;
        private Button btnPay;

        

        
        private TextBox txtTotal;
        private TextBox txt_Ghes;
        private TextBox txt_GiaVe;
        private TextBox txt_PhongChieu;
        private TextBox txt_CaChieu;
        private TextBox txt_NgayChieu;
        private TextBox txt_Phim;
        private PictureBox ptb_Image;
        private TextBox txt_Discount;
        private Label lbl_Discount;
    }
}