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
            gbTicketInfo = new GroupBox();
            lblTicketID = new Label();
            lblFilmName = new Label();
            lblShowDate = new Label();
            lblScreening = new Label();
            lblRoom = new Label();
            lblChair = new Label();
            lblTicketPrice = new Label();
            gbCustomerInfo = new GroupBox();
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            gbTicketInfo.SuspendLayout();
            gbCustomerInfo.SuspendLayout();
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
            // gbTicketInfo
            // 
            gbTicketInfo.Controls.Add(textBox8);
            gbTicketInfo.Controls.Add(textBox7);
            gbTicketInfo.Controls.Add(textBox6);
            gbTicketInfo.Controls.Add(textBox5);
            gbTicketInfo.Controls.Add(textBox4);
            gbTicketInfo.Controls.Add(textBox3);
            gbTicketInfo.Controls.Add(textBox2);
            gbTicketInfo.Controls.Add(lblTicketID);
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
            // lblTicketID
            // 
            lblTicketID.Location = new Point(10, 35);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(100, 23);
            lblTicketID.TabIndex = 0;
            lblTicketID.Text = "Mã vé:";
            // 
            // lblFilmName
            // 
            lblFilmName.Location = new Point(10, 75);
            lblFilmName.Name = "lblFilmName";
            lblFilmName.Size = new Size(100, 23);
            lblFilmName.TabIndex = 1;
            lblFilmName.Text = "Phim:";
            // 
            // lblShowDate
            // 
            lblShowDate.Location = new Point(10, 115);
            lblShowDate.Name = "lblShowDate";
            lblShowDate.Size = new Size(100, 23);
            lblShowDate.TabIndex = 2;
            lblShowDate.Text = "Ngày chiếu:";
            // 
            // lblScreening
            // 
            lblScreening.Location = new Point(10, 159);
            lblScreening.Name = "lblScreening";
            lblScreening.Size = new Size(100, 23);
            lblScreening.TabIndex = 3;
            lblScreening.Text = "Ca chiếu:";
            // 
            // lblRoom
            // 
            lblRoom.Location = new Point(10, 198);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(100, 23);
            lblRoom.TabIndex = 4;
            lblRoom.Text = "Phòng chiếu:";
            // 
            // lblChair
            // 
            lblChair.Location = new Point(10, 235);
            lblChair.Name = "lblChair";
            lblChair.Size = new Size(100, 23);
            lblChair.TabIndex = 5;
            lblChair.Text = "Ghế:";
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.Location = new Point(10, 277);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(100, 23);
            lblTicketPrice.TabIndex = 6;
            lblTicketPrice.Text = "Giá vé:";
            // 
            // gbCustomerInfo
            // 
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
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(10, 30);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(100, 23);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Tên khách:";
            lblCustomerName.Click += lblTenKhach_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(120, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(10, 70);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 23);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(120, 70);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblSex
            // 
            lblSex.Location = new Point(10, 110);
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
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(216, 110);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 24);
            rbFemale.TabIndex = 6;
            rbFemale.Text = "Nữ";
            rbFemale.CheckedChanged += rbNu_CheckedChanged;
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
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 6;
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
            Controls.Add(txtTotal);
            Controls.Add(labelTitle);
            Controls.Add(gbTicketInfo);
            Controls.Add(gbCustomerInfo);
            Controls.Add(lblTotal);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Name = "ThanhToanVePhim";
            Size = new Size(861, 476);
            gbTicketInfo.ResumeLayout(false);
            gbTicketInfo.PerformLayout();
            gbCustomerInfo.ResumeLayout(false);
            gbCustomerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private GroupBox gbTicketInfo;
        private Label lblTicketID;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
        }

        private TextBox textBox2;
        private TextBox txtTotal;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
