//using DevExpress.XtraCharts;
//using DevExpress.XtraEditors; // Thêm dòng này

namespace RapPhimFlix.Forms.QLyNhanVien
{
    partial class ThongKeDoanhThu
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
            //Series series9 = new Series();
            //PieSeriesView pieSeriesView3 = new PieSeriesView();
            //XYDiagram xyDiagram3 = new XYDiagram();
            //Series series10 = new Series();
            //SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView7 = new SideBySideStackedBarSeriesView();
            //Series series11 = new Series();
            //SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView8 = new SideBySideStackedBarSeriesView();
            //Series series12 = new Series();
            //SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView9 = new SideBySideStackedBarSeriesView();
            dtpNgayBatDau = new DateTimePicker();
            dtp_NgayKetThuc = new DateTimePicker();
            btn_ThongKeSP = new Button();
            //chart_ThongKeSP = new ChartControl();
            //chart_ThongKeVe = new ChartControl();
            btn_ThongKeVe = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btn_huy = new Button();
            //((System.ComponentModel.ISupportInitialize)chart_ThongKeSP).BeginInit();
            //((System.ComponentModel.ISupportInitialize)series9).BeginInit();
            //((System.ComponentModel.ISupportInitialize)pieSeriesView3).BeginInit();
            //((System.ComponentModel.ISupportInitialize)chart_ThongKeVe).BeginInit();
            //((System.ComponentModel.ISupportInitialize)xyDiagram3).BeginInit();
            //((System.ComponentModel.ISupportInitialize)series10).BeginInit();
            //((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView7).BeginInit();
            //((System.ComponentModel.ISupportInitialize)series11).BeginInit();
            //((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView8).BeginInit();
            //((System.ComponentModel.ISupportInitialize)series12).BeginInit();
            //((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView9).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(237, 347);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(188, 31);
            dtpNgayBatDau.TabIndex = 2;
            // 
            // dtp_NgayKetThuc
            // 
            dtp_NgayKetThuc.Location = new Point(237, 402);
            dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            dtp_NgayKetThuc.Size = new Size(188, 31);
            dtp_NgayKetThuc.TabIndex = 4;
            // 
            // btn_ThongKeSP
            // 
            btn_ThongKeSP.Location = new Point(28, 260);
            btn_ThongKeSP.Name = "btn_ThongKeSP";
            btn_ThongKeSP.Size = new Size(122, 32);
            btn_ThongKeSP.TabIndex = 5;
            btn_ThongKeSP.Text = "Thống Kê SP";
            btn_ThongKeSP.UseVisualStyleBackColor = true;
            //btn_ThongKeSP.Click += btn_ThongKeSP_Click;
            // 
            // chart_ThongKeSP
            // 
            //chart_ThongKeSP.Location = new Point(28, 30);
            //chart_ThongKeSP.Name = "chart_ThongKeSP";
            //series9.Name = "Series 1";
            //series9.SeriesID = 0;
            //series9.View = pieSeriesView3;
            //chart_ThongKeSP.SeriesSerializable = new Series[]
    {
    //series9
    };
            //chart_ThongKeSP.Size = new Size(371, 214);
            //chart_ThongKeSP.TabIndex = 0;
            // 
            // chart_ThongKeVe
            // 
            //xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            //xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            //chart_ThongKeVe.Diagram = xyDiagram3;
            //chart_ThongKeVe.Location = new Point(22, 30);
            //chart_ThongKeVe.Name = "chart_ThongKeVe";
            //series10.Name = "Series 1";
            //series10.SeriesID = 0;
            //series10.View = sideBySideStackedBarSeriesView7;
            //series10.Visible = false;
            //series11.Name = "Series 2";
            //series11.SeriesID = 1;
            //series11.View = sideBySideStackedBarSeriesView8;
            //series12.Name = "Series 3";
            //series12.SeriesID = 2;
            //series12.View = sideBySideStackedBarSeriesView9;
            //chart_ThongKeVe.SeriesSerializable = new Series[]
    {
    //series10,
    //series11,
    //series12
    };
            //chart_ThongKeVe.Size = new Size(370, 214);
            //chart_ThongKeVe.TabIndex = 6;
            // 
            // btn_ThongKeVe
            // 
            btn_ThongKeVe.Location = new Point(22, 257);
            btn_ThongKeVe.Name = "btn_ThongKeVe";
            btn_ThongKeVe.Size = new Size(123, 35);
            btn_ThongKeVe.TabIndex = 7;
            btn_ThongKeVe.Text = "thống kê vé";
            btn_ThongKeVe.UseVisualStyleBackColor = true;
            //btn_ThongKeVe.Click += btn_ThongKeVe_Click;
            // 
            // groupBox1
            // 
            //groupBox1.Controls.Add(chart_ThongKeSP);
            groupBox1.Controls.Add(btn_ThongKeSP);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 298);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê doanh thu sản phẩm";
            // 
            // groupBox2
            // 
            //groupBox2.Controls.Add(chart_ThongKeVe);
            groupBox2.Controls.Add(btn_ThongKeVe);
            groupBox2.Location = new Point(472, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 298);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê doanh thu vé";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 347);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 10;
            label1.Text = "Thời Gian Bắt Đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 402);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 11;
            label2.Text = "Thời Gian Kết Thúc";
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(751, 373);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(113, 52);
            btn_huy.TabIndex = 12;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            //btn_huy.Click += btn_huy_Click;
            // 
            // ThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(900, 437);
            Controls.Add(btn_huy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtp_NgayKetThuc);
            Controls.Add(dtpNgayBatDau);
            Name = "ThongKeDoanhThu";
            Text = "ThongKeDoanhThu";
            //Load += ThongKeDoanhThu_Load;
            //((System.ComponentModel.ISupportInitialize)pieSeriesView3).EndInit();
            //((System.ComponentModel.ISupportInitialize)series9).EndInit();
            //((System.ComponentModel.ISupportInitialize)chart_ThongKeSP).EndInit();
            //((System.ComponentModel.ISupportInitialize)xyDiagram3).EndInit();
            //((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView7).EndInit();
            //((System.ComponentModel.ISupportInitialize)series10).EndInit();
            //((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView8).EndInit();
            //((System.ComponentModel.ISupportInitialize)series11).EndInit();
            //((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView9).EndInit();
            //((System.ComponentModel.ISupportInitialize)series12).EndInit();
            //((System.ComponentModel.ISupportInitialize)chart_ThongKeVe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtp_NgayKetThuc;
        private Button btn_ThongKeSP;
        //private ChartControl chart_ThongKeSP;
        //private ChartControl chart_ThongKeVe;
        private Button btn_ThongKeVe;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Button btn_huy;
    }
}
