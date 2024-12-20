﻿namespace RapPhimFlix.Forms
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
            labelTitle.Location = new Point(411, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(164, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Thanh toán";
            // 
            // gbProductsInfor
            // 
            gbProductsInfor.Controls.Add(lvProductsInfomations);
            gbProductsInfor.Location = new Point(40, 78);
            gbProductsInfor.Name = "gbProductsInfor";
            gbProductsInfor.Size = new Size(464, 371);
            gbProductsInfor.TabIndex = 2;
            gbProductsInfor.TabStop = false;
            gbProductsInfor.Text = "Thông tin sản phẩm";
            // 
            // lvProductsInfomations
            // 
            lvProductsInfomations.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvProductsInfomations.Location = new Point(13, 33);
            lvProductsInfomations.Name = "lvProductsInfomations";
            lvProductsInfomations.Size = new Size(445, 332);
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
            gbCustomerInfor.Location = new Point(510, 78);
            gbCustomerInfor.Name = "gbCustomerInfor";
            gbCustomerInfor.Size = new Size(464, 371);
            gbCustomerInfor.TabIndex = 3;
            gbCustomerInfor.TabStop = false;
            gbCustomerInfor.Text = "Thông tin khách hàng";
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(25, 37);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(100, 23);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(135, 37);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(200, 27);
            txtTenKhach.TabIndex = 8;
            txtTenKhach.TextChanged += txtTenKhach_TextChanged;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(25, 77);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 23);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(135, 77);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(200, 27);
            txtSoDienThoai.TabIndex = 10;
            // 
            // lblSex
            // 
            lblSex.Location = new Point(25, 117);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(100, 23);
            lblSex.TabIndex = 11;
            lblSex.Text = "Giới tính:";
            // 
            // rbMale
            // 
            rbMale.Location = new Point(135, 117);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(71, 24);
            rbMale.TabIndex = 12;
            rbMale.Text = "Nam";
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(231, 117);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 24);
            rbFemale.TabIndex = 13;
            rbFemale.Text = "Nữ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(53, 468);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(79, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền :";
            lblTotal.Click += label1_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(373, 465);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 5;
            txtTotal.TabStop = false;
            txtTotal.Text = "0";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(768, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 43);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(868, 468);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(106, 43);
            btnPay.TabIndex = 7;
            btnPay.Text = "Thanh toán";
            btnPay.Click += btnPay_Click;
            // 
            // frmThanhToanSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 524);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(gbCustomerInfor);
            Controls.Add(gbProductsInfor);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
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