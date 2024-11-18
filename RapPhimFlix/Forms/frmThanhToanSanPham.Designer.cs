namespace RapPhimFlix.Forms
{
    partial class frmThanhToanSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToanSanPham));
            labelTitle = new Label();
            gbProductsInfor = new GroupBox();
            lvProductsInfomations = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            gbCustomerInfor = new GroupBox();
            lblCustomerName = new Label();
            txtTenKhach = new TextBox();
            lblPhoneNumber = new Label();
            txtSoDienThoai = new TextBox();
            lblSex = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCancel = new Button();
            btnPay = new Button();
            gbProductsInfor.SuspendLayout();
            gbCustomerInfor.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(389, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(129, 26);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Thanh toán";
            // 
            // gbProductsInfor
            // 
            gbProductsInfor.Controls.Add(lvProductsInfomations);
            gbProductsInfor.Location = new Point(64, 78);
            gbProductsInfor.Margin = new Padding(3, 2, 3, 2);
            gbProductsInfor.Name = "gbProductsInfor";
            gbProductsInfor.Padding = new Padding(3, 2, 3, 2);
            gbProductsInfor.Size = new Size(406, 278);
            gbProductsInfor.TabIndex = 2;
            gbProductsInfor.TabStop = false;
            gbProductsInfor.Text = "Thông tin sản phẩm";
            // 
            // lvProductsInfomations
            // 
            lvProductsInfomations.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvProductsInfomations.Location = new Point(11, 25);
            lvProductsInfomations.Margin = new Padding(3, 2, 3, 2);
            lvProductsInfomations.Name = "lvProductsInfomations";
            lvProductsInfomations.Size = new Size(390, 250);
            lvProductsInfomations.TabIndex = 0;
            lvProductsInfomations.UseCompatibleStateImageBehavior = false;
            lvProductsInfomations.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên sản phẩm";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Loại";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 110;
            // 
            // gbCustomerInfor
            // 
            gbCustomerInfor.Controls.Add(lblCustomerName);
            gbCustomerInfor.Controls.Add(txtTenKhach);
            gbCustomerInfor.Controls.Add(lblPhoneNumber);
            gbCustomerInfor.Controls.Add(txtSoDienThoai);
            gbCustomerInfor.Controls.Add(lblSex);
            gbCustomerInfor.Controls.Add(rbMale);
            gbCustomerInfor.Controls.Add(rbFemale);
            gbCustomerInfor.Location = new Point(475, 78);
            gbCustomerInfor.Margin = new Padding(3, 2, 3, 2);
            gbCustomerInfor.Name = "gbCustomerInfor";
            gbCustomerInfor.Padding = new Padding(3, 2, 3, 2);
            gbCustomerInfor.Size = new Size(406, 278);
            gbCustomerInfor.TabIndex = 3;
            gbCustomerInfor.TabStop = false;
            gbCustomerInfor.Text = "Thông tin khách hàng";
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(22, 28);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(88, 17);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(118, 28);
            txtTenKhach.Margin = new Padding(3, 2, 3, 2);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(176, 23);
            txtTenKhach.TabIndex = 8;
            txtTenKhach.TextChanged += txt_TextChanged;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(22, 58);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 17);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(118, 58);
            txtSoDienThoai.Margin = new Padding(3, 2, 3, 2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(176, 23);
            txtSoDienThoai.TabIndex = 10;
            txtSoDienThoai.TextChanged += txt_TextChanged;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // lblSex
            // 
            lblSex.Location = new Point(22, 88);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(88, 17);
            lblSex.TabIndex = 11;
            lblSex.Text = "Giới tính:";
            // 
            // rbMale
            // 
            rbMale.Location = new Point(118, 88);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 18);
            rbMale.TabIndex = 12;
            rbMale.Text = "Nam";
            rbMale.Click += rbSex_Click;
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(202, 88);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(70, 18);
            rbFemale.TabIndex = 13;
            rbFemale.Text = "Nữ";
            rbFemale.Click += rbSex_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(75, 371);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(63, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền :";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(355, 369);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TabStop = false;
            txtTotal.Text = "0";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(701, 371);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(66, 32);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(789, 371);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(93, 32);
            btnPay.TabIndex = 7;
            btnPay.Text = "Thanh toán";
            btnPay.Click += btnPay_Click;
            // 
            // frmThanhToanSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 458);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(gbCustomerInfor);
            Controls.Add(gbProductsInfor);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmThanhToanSanPham";
            gbProductsInfor.ResumeLayout(false);
            gbCustomerInfor.ResumeLayout(false);
            gbCustomerInfor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private GroupBox gbProductsInfor;
        private GroupBox gbCustomerInfor;
        private ListView lvProductsInfomations;
        private Label lblCustomerName;
        private TextBox txtTenKhach;
        private Label lblPhoneNumber;
        private TextBox txtSoDienThoai;
        private Label lblSex;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCancel;
        private Button btnPay;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}