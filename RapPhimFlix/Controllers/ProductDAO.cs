using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RapPhimFlix.Controllers;

namespace RapPhimFlix.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance;

        internal static ProductDAO Instance 
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }
        private ProductDAO() { }

        public List<Product> LoadProductList()
        {
            List<Product> products = new List<Product>();
            
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM tblSanPham");

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                products.Add(product);
            }

            return products;
        }

        public Product GetProductByName(string name) 
        {
            Product product = null;

            string query = "SELECT * FROM tblSanPham WHERE TenSanPham = @name";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { name });

            foreach (DataRow item in data.Rows)
            {
                product = new Product(item);
            }

            return product;
        }
    }
}
