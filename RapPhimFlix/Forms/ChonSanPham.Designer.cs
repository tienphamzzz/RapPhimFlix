namespace RapPhimFlix.Forms
{
    partial class ChonSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            groupBoxOrder = new GroupBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblTotal = new Label();
            btnConfirm = new Button();
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOrder
            // 
            groupBoxOrder.Controls.Add(listView1);
            groupBoxOrder.Controls.Add(panel2);
            groupBoxOrder.Controls.Add(panel1);
            groupBoxOrder.Location = new Point(585, 20);
            groupBoxOrder.Name = "groupBoxOrder";
            groupBoxOrder.Size = new Size(407, 545);
            groupBoxOrder.TabIndex = 1;
            groupBoxOrder.TabStop = false;
            groupBoxOrder.Text = "Thông tin đặt hàng";
            groupBoxOrder.Enter += groupBoxOrder_Enter;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(14, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(120, 7);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(180, 27);
            txtProductName.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(18, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(261, 34);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(118, 40);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(330, 6);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 27);
            numericUpDown1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(txtProductName);
            panel1.Location = new Point(6, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 108);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(261, 50);
            button1.Name = "button1";
            button1.Size = new Size(118, 40);
            button1.TabIndex = 20;
            button1.Text = "Thêm";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnConfirm);
            panel2.Location = new Point(6, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 88);
            panel2.TabIndex = 20;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 139);
            listView1.Name = "listView1";
            listView1.Size = new Size(395, 306);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 545);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn sản phẩm";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(6, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(555, 513);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ChonSanPham
            // 
            Controls.Add(groupBox1);
            Controls.Add(groupBoxOrder);
            Name = "ChonSanPham";
            Size = new Size(1024, 586);
            groupBoxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirm;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private ListView listView1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
