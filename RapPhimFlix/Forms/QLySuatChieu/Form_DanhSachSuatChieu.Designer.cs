namespace RapPhimFlix.Forms.MenuNav.SuatChieu
{
    partial class Form_DanhSachSuatChieu
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
            panel1 = new Panel();
            btn_SuatPhim_Phong3 = new Button();
            btn_SuatPhim_Phong2 = new Button();
            btn_SuatPhim_Phong1 = new Button();
            btn_SuatChieu_All = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dgv_SuatChieu = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SuatChieu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_SuatPhim_Phong3);
            panel1.Controls.Add(btn_SuatPhim_Phong2);
            panel1.Controls.Add(btn_SuatPhim_Phong1);
            panel1.Controls.Add(btn_SuatChieu_All);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 410);
            panel1.TabIndex = 3;
            // 
            // btn_SuatPhim_Phong3
            // 
            btn_SuatPhim_Phong3.Location = new Point(26, 229);
            btn_SuatPhim_Phong3.Name = "btn_SuatPhim_Phong3";
            btn_SuatPhim_Phong3.Size = new Size(117, 33);
            btn_SuatPhim_Phong3.TabIndex = 3;
            btn_SuatPhim_Phong3.Text = "Phòng 3";
            btn_SuatPhim_Phong3.UseVisualStyleBackColor = true;
            btn_SuatPhim_Phong3.Click += btn_SuatPhim_Phong3_Click;
            // 
            // btn_SuatPhim_Phong2
            // 
            btn_SuatPhim_Phong2.Location = new Point(26, 161);
            btn_SuatPhim_Phong2.Name = "btn_SuatPhim_Phong2";
            btn_SuatPhim_Phong2.Size = new Size(117, 33);
            btn_SuatPhim_Phong2.TabIndex = 2;
            btn_SuatPhim_Phong2.Text = "Phòng 2";
            btn_SuatPhim_Phong2.UseVisualStyleBackColor = true;
            btn_SuatPhim_Phong2.Click += btn_SuatPhim_Phong2_Click;
            // 
            // btn_SuatPhim_Phong1
            // 
            btn_SuatPhim_Phong1.Location = new Point(26, 91);
            btn_SuatPhim_Phong1.Name = "btn_SuatPhim_Phong1";
            btn_SuatPhim_Phong1.Size = new Size(117, 33);
            btn_SuatPhim_Phong1.TabIndex = 1;
            btn_SuatPhim_Phong1.Text = "Phòng 1";
            btn_SuatPhim_Phong1.UseVisualStyleBackColor = true;
            btn_SuatPhim_Phong1.Click += btn_SuatPhim_Phong1_Click;
            // 
            // btn_SuatChieu_All
            // 
            btn_SuatChieu_All.Location = new Point(26, 19);
            btn_SuatChieu_All.Name = "btn_SuatChieu_All";
            btn_SuatChieu_All.Size = new Size(117, 33);
            btn_SuatChieu_All.TabIndex = 0;
            btn_SuatChieu_All.Text = "Tất cả";
            btn_SuatChieu_All.UseVisualStyleBackColor = true;
            btn_SuatChieu_All.Click += btn_SuatChieu_All_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 6);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 1;
            label1.Text = "Chọn ngày";
            // 
            // dgv_SuatChieu
            // 
            dgv_SuatChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SuatChieu.Dock = DockStyle.Fill;
            dgv_SuatChieu.EnableHeadersVisualStyles = false;
            dgv_SuatChieu.Location = new Point(169, 40);
            dgv_SuatChieu.Name = "dgv_SuatChieu";
            dgv_SuatChieu.Size = new Size(631, 410);
            dgv_SuatChieu.TabIndex = 5;
            dgv_SuatChieu.CellClick += dgv_SuatChieu_CellClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(346, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // Form_DanhSachSuatChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_SuatChieu);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form_DanhSachSuatChieu";
            Text = "Form_DanhSachSuatChieu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SuatChieu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dgv_SuatChieu;
        private Button btn_SuatPhim_Phong3;
        private Button btn_SuatPhim_Phong2;
        private Button btn_SuatPhim_Phong1;
        private Button btn_SuatChieu_All;
        private DateTimePicker dateTimePicker1;
    }
}
