using DevExpress.XtraCharts;
using DevExpress.XtraEditors; // Thêm dòng này

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
            Series series1 = new Series();
            PieSeriesView pieSeriesView1 = new PieSeriesView();
            XYDiagram xyDiagram1 = new XYDiagram();
            Series series2 = new Series();
            SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView1 = new SideBySideStackedBarSeriesView();
            Series series3 = new Series();
            SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView2 = new SideBySideStackedBarSeriesView();
            Series series4 = new Series();
            SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView3 = new SideBySideStackedBarSeriesView();
            dtpNgayBatDau = new DateTimePicker();
            dtp_NgayKetThuc = new DateTimePicker();
            btn_ThongKeSP = new Button();
            chart_ThongKeSP = new ChartControl();
            chart_ThongKeVe = new ChartControl();
            btn_ThongKeVe = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_ThongKeSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_ThongKeVe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView3).BeginInit();
            SuspendLayout();
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(177, 351);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(188, 31);
            dtpNgayBatDau.TabIndex = 2;
            // 
            // dtp_NgayKetThuc
            // 
            dtp_NgayKetThuc.Location = new Point(434, 351);
            dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            dtp_NgayKetThuc.Size = new Size(188, 31);
            dtp_NgayKetThuc.TabIndex = 4;
            // 
            // btn_ThongKeSP
            // 
            btn_ThongKeSP.Location = new Point(127, 257);
            btn_ThongKeSP.Name = "btn_ThongKeSP";
            btn_ThongKeSP.Size = new Size(122, 32);
            btn_ThongKeSP.TabIndex = 5;
            btn_ThongKeSP.Text = "Thống Kê SP";
            btn_ThongKeSP.UseVisualStyleBackColor = true;
            btn_ThongKeSP.Click += btn_ThongKeSP_Click;
            // 
            // chart_ThongKeSP
            // 
            chart_ThongKeSP.Location = new Point(12, 17);
            chart_ThongKeSP.Name = "chart_ThongKeSP";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = pieSeriesView1;
            chart_ThongKeSP.SeriesSerializable = new Series[]
    {
    series1
    };
            chart_ThongKeSP.Size = new Size(371, 214);
            chart_ThongKeSP.TabIndex = 0;
            // 
            // chart_ThongKeVe
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chart_ThongKeVe.Diagram = xyDiagram1;
            chart_ThongKeVe.Location = new Point(404, 17);
            chart_ThongKeVe.Name = "chart_ThongKeVe";
            series2.Name = "Series 1";
            series2.SeriesID = 0;
            series2.View = sideBySideStackedBarSeriesView1;
            series2.Visible = false;
            series3.Name = "Series 2";
            series3.SeriesID = 1;
            series3.View = sideBySideStackedBarSeriesView2;
            series4.Name = "Series 3";
            series4.SeriesID = 2;
            series4.View = sideBySideStackedBarSeriesView3;
            chart_ThongKeVe.SeriesSerializable = new Series[]
    {
    series2,
    series3,
    series4
    };
            chart_ThongKeVe.Size = new Size(355, 214);
            chart_ThongKeVe.TabIndex = 6;
            // 
            // btn_ThongKeVe
            // 
            btn_ThongKeVe.Location = new Point(541, 257);
            btn_ThongKeVe.Name = "btn_ThongKeVe";
            btn_ThongKeVe.Size = new Size(123, 35);
            btn_ThongKeVe.TabIndex = 7;
            btn_ThongKeVe.Text = "thống kê vé";
            btn_ThongKeVe.UseVisualStyleBackColor = true;
            btn_ThongKeVe.Click += btn_ThongKeVe_Click;
            // 
            // ThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(766, 432);
            Controls.Add(btn_ThongKeVe);
            Controls.Add(chart_ThongKeVe);
            Controls.Add(chart_ThongKeSP);
            Controls.Add(btn_ThongKeSP);
            Controls.Add(dtp_NgayKetThuc);
            Controls.Add(dtpNgayBatDau);
            Name = "ThongKeDoanhThu";
            Text = "ThongKeDoanhThu";
            Load += ThongKeDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_ThongKeSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)series3).EndInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideStackedBarSeriesView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)series4).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_ThongKeVe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtp_NgayKetThuc;
        private Button btn_ThongKeSP;
        private ChartControl chart_ThongKeSP;
        private ChartControl chart_ThongKeVe;
        private Button btn_ThongKeVe;
    }
}
