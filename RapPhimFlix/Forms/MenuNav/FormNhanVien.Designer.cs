namespace RapPhimFlix.Forms.MenuNav
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            groupBox2 = new GroupBox();
            button2 = new Button();
            btn_DanhSachPhim = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            txt_NhanVien_Ten = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel_Display = new Panel();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btn_DanhSachPhim);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(959, 45);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(447, 3);
            button2.Name = "button2";
            button2.Size = new Size(463, 42);
            button2.TabIndex = 1;
            button2.Text = "Đồ ăn vặt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_DanhSachPhim
            // 
            btn_DanhSachPhim.Location = new Point(0, 3);
            btn_DanhSachPhim.Name = "btn_DanhSachPhim";
            btn_DanhSachPhim.Size = new Size(450, 42);
            btn_DanhSachPhim.TabIndex = 0;
            btn_DanhSachPhim.Text = "Phim đang chiếu";
            btn_DanhSachPhim.UseVisualStyleBackColor = true;
            btn_DanhSachPhim.Click += btn_DanhSachPhim_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 551);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 45);
            panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_NhanVien_Ten);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 54);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(690, 20);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Flix Cinema";
            // 
            // button3
            // 
            button3.Location = new Point(800, 16);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 5;
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 20);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 4;
            label1.Text = "hiện ngày giờ ở đây";
            // 
            // txt_NhanVien_Ten
            // 
            txt_NhanVien_Ten.Location = new Point(43, 18);
            txt_NhanVien_Ten.Name = "txt_NhanVien_Ten";
            txt_NhanVien_Ten.Size = new Size(188, 22);
            txt_NhanVien_Ten.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(646, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(297, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 54);
            panel1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel_Display
            // 
            panel_Display.Dock = DockStyle.Fill;
            panel_Display.Location = new Point(0, 54);
            panel_Display.Name = "panel_Display";
            panel_Display.Size = new Size(959, 497);
            panel_Display.TabIndex = 4;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 596);
            Controls.Add(panel_Display);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            FormClosing += FormNhanVien_FormClosing;
            Load += FormNhanVien_Load;
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button2;
        private Button btn_DanhSachPhim;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button button3;
        private Label label1;
        private TextBox txt_NhanVien_Ten;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel_Display;
    }
}