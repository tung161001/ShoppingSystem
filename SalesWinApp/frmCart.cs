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
    public partial class frmCart : Form
    {
        IProductRepository productRepository = new ProductRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public ShoppingCart Cart { get; set; }
        BindingSource source;
        public Member Member { get; set; }
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void LoadCart()
        {
            ////get cart items
            //IQueryable<CartItem> items = Cart.GetCart().AsQueryable();
            //IQueryable<Category> categories = new CategoryRepository().getAll().AsQueryable();
            var cart = Cart.GetCart();
            try
            {
                source = new BindingSource();
                source.DataSource = cart;
                dgvCart.DataSource = source;
                dgvCart.Columns["ProductID"].HeaderText = "ID";
                dgvCart.Columns["ProductName"].HeaderText = "Product";
                UpdateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load cart error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateForm()
        {
            lbTotal.Text = Cart.GetTotal().ToString();
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                frmCartUpdate frmCartUpdate = new frmCartUpdate
                {
                    CartItem = (CartItem)dgvCart.SelectedRows[0].DataBoundItem,
                    Cart = Cart
                };
                frmCartUpdate.ShowDialog();
                this.Refresh();
                UpdateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No item was selected", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CartItem item = (CartItem)dgvCart.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.
                Show("Do you want to remove this item?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Cart.RemoveToCart(productRepository.GetProductById(item.ProductID));
                }
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No item seltected", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            var cart = Cart.GetCart();
            if (cart == null || cart.Count() == 0)
            {
                MessageBox.Show("Empty Cart", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                orderRepository.SaveOrder(Cart, Member.MemberId);
                productRepository.UpdateQuantity(Cart);
                Cart.EmptyCart();
                MessageBox.Show("Pay success", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var cart = Cart.GetCart();
            if (cart == null || cart.Count() == 0) // If cart has 0 items, automatically close without asking
            {
                Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save the cart?", "Confirm", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    orderRepository.SaveOrder(Cart, Member.MemberId);
                    productRepository.UpdateQuantity(Cart);
                    Cart.EmptyCart();
                    MessageBox.Show("Pay success", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                } else
                {
                    Close();
                }
            }
        }
    }
}
