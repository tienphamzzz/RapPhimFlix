namespace RapPhimFlix.Forms
{
    partial class frmChonSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonSanPham));
            gbOrder = new GroupBox();
            lvSelectedProducts = new ListView();
            columnHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel2 = new Panel();
            btnCancel = new Button();
            label1 = new Label();
            lblTotalPrice = new Label();
            lblTotal = new Label();
            btnConfirm = new Button();
            panel1 = new Panel();
            btnAddProduct = new Button();
            lblProductName = new Label();
            nudProductQuantity = new NumericUpDown();
            txtProductName = new TextBox();
            gbProductsList = new GroupBox();
            flpProducts = new FlowLayoutPanel();
            gbOrder.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).BeginInit();
            gbProductsList.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(lvSelectedProducts);
            gbOrder.Controls.Add(panel2);
            gbOrder.Controls.Add(panel1);
            gbOrder.Location = new Point(550, 12);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(397, 487);
            gbOrder.TabIndex = 1;
            gbOrder.TabStop = false;
            gbOrder.Text = "Thông tin đặt hàng";
            // 
            // lvSelectedProducts
            // 
            lvSelectedProducts.Columns.AddRange(new ColumnHeader[] { columnHeader, columnHeader1, columnHeader2, columnHeader3 });
            lvSelectedProducts.Location = new Point(6, 139);
            lvSelectedProducts.Name = "lvSelectedProducts";
            lvSelectedProducts.Size = new Size(382, 247);
            lvSelectedProducts.TabIndex = 21;
            lvSelectedProducts.UseCompatibleStateImageBehavior = false;
            lvSelectedProducts.View = View.Details;
            // 
            // columnHeader
            // 
            columnHeader.Text = "Tên SP";
            columnHeader.Width = 130;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Loại";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotalPrice);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnConfirm);
            panel2.Location = new Point(6, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 85);
            panel2.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 36);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 10);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 7;
            label1.Text = "vnđ";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(273, 10);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(13, 15);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(18, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền :";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(251, 36);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(118, 40);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(nudProductQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Location = new Point(6, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 108);
            panel1.TabIndex = 19;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(251, 51);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(118, 37);
            btnAddProduct.TabIndex = 20;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(14, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // nudProductQuantity
            // 
            nudProductQuantity.Location = new Point(320, 7);
            nudProductQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudProductQuantity.Name = "nudProductQuantity";
            nudProductQuantity.ReadOnly = true;
            nudProductQuantity.Size = new Size(49, 23);
            nudProductQuantity.TabIndex = 18;
            nudProductQuantity.TabStop = false;
            nudProductQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(120, 7);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(176, 23);
            txtProductName.TabIndex = 1;
            txtProductName.TabStop = false;
            // 
            // gbProductsList
            // 
            gbProductsList.Controls.Add(flpProducts);
            gbProductsList.Location = new Point(12, 12);
            gbProductsList.Name = "gbProductsList";
            gbProductsList.Size = new Size(532, 487);
            gbProductsList.TabIndex = 2;
            gbProductsList.TabStop = false;
            gbProductsList.Text = "Chọn sản phẩm";
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Location = new Point(6, 26);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(519, 451);
            flpProducts.TabIndex = 0;
            // 
            // frmChonSanPham
            // 
            ClientSize = new Size(954, 504);
            Controls.Add(gbProductsList);
            Controls.Add(gbOrder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChonSanPham";
            gbOrder.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).EndInit();
            gbProductsList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirm;
        private NumericUpDown nudProductQuantity;
        private Panel panel1;
        private Panel panel2;
        private Button btnAddProduct;
        private ListView lvSelectedProducts;
        private GroupBox gbProductsList;
        private FlowLayoutPanel flpProducts;
        private ColumnHeader columnHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblTotalPrice;
        private Label label1;
        private Button btnCancel;
    }
}