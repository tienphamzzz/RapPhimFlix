namespace RapPhimFlix.Forms.DangNhap
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            panel1 = new Panel();
            lbHienMK = new Label();
            btnThoat = new Button();
            btn_DangNhap_DangNhap = new Button();
            txt_DangNhap_MatKhau = new TextBox();
            ptb_DangNhap_MatKhau = new PictureBox();
            txt_DangNhap_TaiKhoan = new TextBox();
            ptb_DangNhap_TaiKhoan = new PictureBox();
            label1 = new Label();
            timerHienMK = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_MatKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_TaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbHienMK);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btn_DangNhap_DangNhap);
            panel1.Controls.Add(txt_DangNhap_MatKhau);
            panel1.Controls.Add(ptb_DangNhap_MatKhau);
            panel1.Controls.Add(txt_DangNhap_TaiKhoan);
            panel1.Controls.Add(ptb_DangNhap_TaiKhoan);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 423);
            panel1.TabIndex = 0;
            // 
            // lbHienMK
            // 
            lbHienMK.AutoSize = true;
            lbHienMK.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbHienMK.ForeColor = Color.Blue;
            lbHienMK.Location = new Point(444, 236);
            lbHienMK.Name = "lbHienMK";
            lbHienMK.Size = new Size(87, 15);
            lbHienMK.TabIndex = 5;
            lbHienMK.Text = "Hiện mât khẩu";
            lbHienMK.Click += lbHienMK_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(424, 280);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 32);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btn_DangNhap_DangNhap
            // 
            btn_DangNhap_DangNhap.Location = new Point(293, 280);
            btn_DangNhap_DangNhap.Margin = new Padding(4);
            btn_DangNhap_DangNhap.Name = "btn_DangNhap_DangNhap";
            btn_DangNhap_DangNhap.Size = new Size(107, 32);
            btn_DangNhap_DangNhap.TabIndex = 3;
            btn_DangNhap_DangNhap.Text = "Đăng nhập";
            btn_DangNhap_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap_DangNhap.Click += btn_DangNhap_DangNhap_Click;
            // 
            // txt_DangNhap_MatKhau
            // 
            txt_DangNhap_MatKhau.Location = new Point(150, 203);
            txt_DangNhap_MatKhau.Margin = new Padding(4);
            txt_DangNhap_MatKhau.Name = "txt_DangNhap_MatKhau";
            txt_DangNhap_MatKhau.Size = new Size(381, 29);
            txt_DangNhap_MatKhau.TabIndex = 2;
            txt_DangNhap_MatKhau.TextChanged += txt_DangNhap_MatKhau_TextChanged;
            txt_DangNhap_MatKhau.KeyDown += txt_DangNhap_MatKhau_KeyDown;
            // 
            // ptb_DangNhap_MatKhau
            // 
            ptb_DangNhap_MatKhau.Image = (Image)resources.GetObject("ptb_DangNhap_MatKhau.Image");
            ptb_DangNhap_MatKhau.Location = new Point(74, 190);
            ptb_DangNhap_MatKhau.Margin = new Padding(4);
            ptb_DangNhap_MatKhau.Name = "ptb_DangNhap_MatKhau";
            ptb_DangNhap_MatKhau.Size = new Size(43, 42);
            ptb_DangNhap_MatKhau.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_DangNhap_MatKhau.TabIndex = 3;
            ptb_DangNhap_MatKhau.TabStop = false;
            // 
            // txt_DangNhap_TaiKhoan
            // 
            txt_DangNhap_TaiKhoan.Location = new Point(150, 146);
            txt_DangNhap_TaiKhoan.Margin = new Padding(4);
            txt_DangNhap_TaiKhoan.Name = "txt_DangNhap_TaiKhoan";
            txt_DangNhap_TaiKhoan.Size = new Size(381, 29);
            txt_DangNhap_TaiKhoan.TabIndex = 1;
            txt_DangNhap_TaiKhoan.KeyDown += txt_DangNhap_TaiKhoan_KeyDown;
            // 
            // ptb_DangNhap_TaiKhoan
            // 
            ptb_DangNhap_TaiKhoan.Image = (Image)resources.GetObject("ptb_DangNhap_TaiKhoan.Image");
            ptb_DangNhap_TaiKhoan.Location = new Point(74, 133);
            ptb_DangNhap_TaiKhoan.Margin = new Padding(4);
            ptb_DangNhap_TaiKhoan.Name = "ptb_DangNhap_TaiKhoan";
            ptb_DangNhap_TaiKhoan.Size = new Size(43, 42);
            ptb_DangNhap_TaiKhoan.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_DangNhap_TaiKhoan.TabIndex = 1;
            ptb_DangNhap_TaiKhoan.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // timerHienMK
            // 
            timerHienMK.Tick += timerHienMK_Tick;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 423);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            FormClosing += FormDangNhap_FormClosing;
            Load += FormDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_MatKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_TaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_DangNhap_DangNhap;
        private TextBox txt_DangNhap_MatKhau;
        private PictureBox ptb_DangNhap_MatKhau;
        private TextBox txt_DangNhap_TaiKhoan;
        private PictureBox ptb_DangNhap_TaiKhoan;
        private Label label1;
        private Button btnThoat;
        private Label lbHienMK;
        private System.Windows.Forms.Timer timerHienMK;
    }
}