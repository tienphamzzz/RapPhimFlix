using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapPhimFlix.Controllers;

namespace RapPhimFlix.Forms
{
    public partial class frmChonSanPham : Form
    {

        #region Methods
        public frmChonSanPham()
        {
            InitializeComponent();

            LoadProduct();
        }

        public void LoadProduct()
        {
            List<Product> products = DAO.ProductDAO.Instance.LoadProductList();

            foreach (Product product in products)
            {
                uclProduct ucl = new uclProduct(product);

                flpProducts.Controls.Add(ucl);

                ucl.ProductClick += Ucl_ProductClick;
            }
        }
        #endregion

        #region Events
        private void Ucl_ProductClick(object sender, EventArgs e)
        {
            uclProduct ucl = sender as uclProduct;
            txtProductName.Text = ucl.getProductName();
        }
        #endregion

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int quantity = (int)nudProductQuantity.Value;

            Product product = DAO.ProductDAO.Instance.GetProductByName(productName);

            string type = product.Type;
            float price = (float)product.Price;
            float totalPrice = price * quantity;

            bool isExist = false;

            foreach (ListViewItem item in lvSelectedProducts.Items)
            {
                if (item.SubItems[0].Text == productName)
                {
                    item.SubItems[2].Text = (int.Parse(item.SubItems[2].Text) + quantity).ToString();
                    item.SubItems[3].Text = (float.Parse(item.SubItems[3].Text) + totalPrice).ToString();
                    isExist = true;
                    lblTotalPrice.Text = (float.Parse(lblTotalPrice.Text) + totalPrice).ToString();
                    break;
                }
            }
            if (!isExist)
            {
                ListViewItem item = new ListViewItem(productName);
                item.SubItems.Add(type);
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add(totalPrice.ToString());
                lblTotalPrice.Text = (float.Parse(lblTotalPrice.Text) + totalPrice).ToString();

                lvSelectedProducts.Items.Add(item);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lvSelectedProducts.Items.Clear();
            lblTotalPrice.Text = "0";
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
