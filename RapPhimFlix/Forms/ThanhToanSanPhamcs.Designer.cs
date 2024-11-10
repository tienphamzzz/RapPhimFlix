namespace RapPhimFlix.Forms
{
    partial class ThanhToanSanPhamcs
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
            labelTitle = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblGioiTinh = new Label();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            listView1 = new ListView();
            label1 = new Label();
            textBox1 = new TextBox();
            btnCancel = new Button();
            btnThanhToan = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(40, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 371);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTenKhach);
            groupBox2.Controls.Add(txtTenKhach);
            groupBox2.Controls.Add(lblSoDienThoai);
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(lblGioiTinh);
            groupBox2.Controls.Add(rbNam);
            groupBox2.Controls.Add(rbNu);
            groupBox2.Location = new Point(510, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 371);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // lblTenKhach
            // 
            lblTenKhach.Location = new Point(25, 37);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(100, 23);
            lblTenKhach.TabIndex = 7;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(135, 37);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(200, 27);
            txtTenKhach.TabIndex = 8;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Location = new Point(25, 77);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 23);
            lblSoDienThoai.TabIndex = 9;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(135, 77);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(200, 27);
            txtSoDienThoai.TabIndex = 10;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(25, 117);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 11;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // rbNam
            // 
            rbNam.Location = new Point(135, 117);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(71, 24);
            rbNam.TabIndex = 12;
            rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            rbNu.Location = new Point(231, 117);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(80, 24);
            rbNu.TabIndex = 13;
            rbNu.Text = "Nữ";
            // 
            // listView1
            // 
            listView1.Location = new Point(13, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(445, 332);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 468);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Tổng tiền :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 465);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(768, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 43);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(868, 468);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(106, 43);
            btnThanhToan.TabIndex = 7;
            btnThanhToan.Text = "Thanh toán";
            // 
            // ThanhToanSanPhamcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnThanhToan);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelTitle);
            Name = "ThanhToanSanPhamcs";
            Size = new Size(1015, 571);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblGioiTinh;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Label label1;
        private TextBox textBox1;
        private Button btnCancel;
        private Button btnThanhToan;
    }
}
