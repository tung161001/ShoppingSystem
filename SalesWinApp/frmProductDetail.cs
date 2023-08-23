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
    public partial class frmProductDetail : Form
    {

        IProductRepository repository = new ProductRepository();
        public ShoppingCart Cart { get; set; }
        public Product Product { get; set; }

        private Boolean isNewItem = true;

        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductName.Text = Product.ProductName.ToString();
            txtCategory.Text = Product.CategoryId.ToString();
            txtWeight.Text = Product.Weight.ToString();
            txtUnitsInStock.Text = Product.UnitsInStock.ToString();
            txtPrice.Text = Product.UnitPrice.ToString();
            txtDiscount.Text = '0'.ToString();
            CartItem? found = Cart.Cart.FirstOrDefault(cartItem => cartItem.ProductID == Product.ProductId);
            if (found == null)
            {
                txtQuantity.Text = "1";
            }
            else
            {
                txtQuantity.Text = found.Quantity.ToString();
                this.Text = "Update Item";
                btnAddToCart.Text = "Update";
                isNewItem = false;
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(txtQuantity.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be positive");
                }
                else
                {
                    if (quantity > Product.UnitsInStock)
                    {
                        MessageBox.Show("Quantity must be lower than unit in stock");
                    }
                    else
                    {
                        if (isNewItem)
                        {
                            Cart.AddToCart(Product, quantity);
                        }
                        else
                        {
                            Cart.UpdateCart(Product, quantity);
                        }
                        Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Close();
    }
}
