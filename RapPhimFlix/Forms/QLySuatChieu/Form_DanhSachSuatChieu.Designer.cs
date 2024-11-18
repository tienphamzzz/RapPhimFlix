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
            flp_Phong = new FlowLayoutPanel();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dgv_SuatChieu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SuatChieu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flp_Phong);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 410);
            panel1.TabIndex = 3;
            // 
            // flp_Phong
            // 
            flp_Phong.AutoScroll = true;
            flp_Phong.Location = new Point(27, 22);
            flp_Phong.Name = "flp_Phong";
            flp_Phong.Size = new Size(129, 376);
            flp_Phong.TabIndex = 4;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(346, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
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
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel flp_Phong;
    }
}
