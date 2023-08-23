using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmCartUpdate : Form
    {
        IProductRepository repository = new ProductRepository();
        public CartItem CartItem { get; set; }
        public ShoppingCart Cart { get; set; }
        public frmCart FrmCart { get; set; }

        private Product product = null;

        public frmCartUpdate()
        {
            InitializeComponent();
        }

        private void frmCartUpdate_Load(object sender, EventArgs e)
        {
            product = repository.GetProductById(CartItem.ProductID);
            txtInStock.Text = product.UnitsInStock.ToString();
            txtProductName.Text = product.ProductName;
            txtQuantity.Text = CartItem.Quantity.ToString();
            txtDiscount.Text = CartItem.Discount.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                int quantity = int.Parse(txtQuantity.Text);
                if (quantity <= 0) throw new Exception("Quantity must be positive");
                if (quantity > product.UnitsInStock)
                    throw new Exception("Quantity must be lower than unit in stock");
                Cart.UpdateCart(product, quantity);
                //FrmCart.Refresh();
                Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
