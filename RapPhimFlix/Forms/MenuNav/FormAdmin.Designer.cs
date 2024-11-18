namespace RapPhimFlix.Forms.MenuNav
{
    partial class FormAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            btn_Admin_DoanhSo = new Button();
            pictureBox1 = new PictureBox();
            btn_Admin_NhanVien = new Button();
            label2 = new Label();
            btn_Admin_DangXuat = new Button();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            ptb_QuanLy_DangXuat = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txt_Admin_Ten = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel_Body = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QuanLy_DangXuat).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Admin_DoanhSo
            // 
            btn_Admin_DoanhSo.Location = new Point(43, 134);
            btn_Admin_DoanhSo.Name = "btn_Admin_DoanhSo";
            btn_Admin_DoanhSo.Size = new Size(166, 25);
            btn_Admin_DoanhSo.TabIndex = 12;
            btn_Admin_DoanhSo.Text = "Quản lý doanh số";
            btn_Admin_DoanhSo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btn_Admin_NhanVien
            // 
            btn_Admin_NhanVien.Location = new Point(43, 74);
            btn_Admin_NhanVien.Name = "btn_Admin_NhanVien";
            btn_Admin_NhanVien.Size = new Size(166, 25);
            btn_Admin_NhanVien.TabIndex = 10;
            btn_Admin_NhanVien.Text = "Quản lý nhân viên";
            btn_Admin_NhanVien.UseVisualStyleBackColor = true;
            btn_Admin_NhanVien.Click += btn_Admin_NhanVien_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 11;
            label2.Text = "Flix Cinema";
            // 
            // btn_Admin_DangXuat
            // 
            btn_Admin_DangXuat.Location = new Point(433, 10);
            btn_Admin_DangXuat.Name = "btn_Admin_DangXuat";
            btn_Admin_DangXuat.Size = new Size(92, 23);
            btn_Admin_DangXuat.TabIndex = 10;
            btn_Admin_DangXuat.Text = "Đăng xuất";
            btn_Admin_DangXuat.UseVisualStyleBackColor = true;
            btn_Admin_DangXuat.Click += btn_Admin_DangXuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 9;
            label1.Text = "hiện ngày giờ ở đây";
            label1.Click += label1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 74);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // ptb_QuanLy_DangXuat
            // 
            ptb_QuanLy_DangXuat.Image = (Image)resources.GetObject("ptb_QuanLy_DangXuat.Image");
            ptb_QuanLy_DangXuat.Location = new Point(402, 9);
            ptb_QuanLy_DangXuat.Name = "ptb_QuanLy_DangXuat";
            ptb_QuanLy_DangXuat.Size = new Size(25, 25);
            ptb_QuanLy_DangXuat.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_QuanLy_DangXuat.TabIndex = 8;
            ptb_QuanLy_DangXuat.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btn_Admin_DangXuat);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ptb_QuanLy_DangXuat);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 45);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(53, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(221, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 48);
            panel2.TabIndex = 3;
            // 
            // txt_Admin_Ten
            // 
            txt_Admin_Ten.Location = new Point(43, 12);
            txt_Admin_Ten.Name = "txt_Admin_Ten";
            txt_Admin_Ten.Size = new Size(166, 23);
            txt_Admin_Ten.TabIndex = 5;
            txt_Admin_Ten.TextChanged += txt_Admin_Ten_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(btn_Admin_DoanhSo);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btn_Admin_NhanVien);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(txt_Admin_Ten);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 465);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 465);
            panel1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel_Body
            // 
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(221, 48);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(730, 417);
            panel_Body.TabIndex = 4;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 465);
            Controls.Add(panel_Body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            FormClosing += FormAdmin_FormClosing;
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QuanLy_DangXuat).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Admin_DoanhSo;
        private PictureBox pictureBox1;
        private Button btn_Admin_NhanVien;
        private Label label2;
        private Button btn_Admin_DangXuat;
        private Label label1;
        private PictureBox pictureBox6;
        private PictureBox ptb_QuanLy_DangXuat;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox txt_Admin_Ten;
        private GroupBox groupBox1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Panel panel_Body;
    }
}