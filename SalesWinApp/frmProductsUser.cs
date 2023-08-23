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
    public partial class frmProductsUser : Form
    {
        public frmProductsUser()
        {
            InitializeComponent();
        }
        IProductRepository repository = new ProductRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        Product Product { get; set; }
        public Member Member { get; set; }


        public static ShoppingCart Cart = new ShoppingCart();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            categoryRepository = new CategoryRepository();
            var source = new BindingSource();
            source.DataSource = repository.GetProducts();
            LoadProductList(source);
            LoadComboBoxSearch();
            lbEmail.Text = Member.Email.ToString();
        }

        private void LoadProductList(BindingSource source)
        {
            dgvProductManagement.DataSource = null;
            try
            {
                IQueryable<Product> products = ((List<Product>)source.DataSource).AsQueryable();
                IQueryable<Category> categories = categoryRepository.GetCategories().AsQueryable();
                var data = products.Join(
                    categories,
                    outer => outer.CategoryId,
                    inner => inner.CategoryId,
                    (product, category) => new
                    {
                        ID = product.ProductId,
                        Name = product.ProductName,
                        Category = category.CategoryName,
                        InStock = product.UnitsInStock,
                        Price = product.UnitPrice,
                    }).Where(pro => pro.InStock != 0).ToList();
                dgvProductManagement.DataSource = data;
                dgvProductManagement.Columns["InStock"].HeaderText = "In Stock";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadComboBoxSearch()
        {
            try
            {
                //List<string> searchFields = new List<string>
                //{
                //    "--Fields--","ID", "Name", "Unit Price", "Units In Stock"
                //};

                Dictionary<string, string> searchFields = new Dictionary<string, string>();
                searchFields.Add("ID", "ProductID");
                searchFields.Add("Name", "ProductName");
                searchFields.Add("Unit Price", "UnitPrice");
                searchFields.Add("Units In Stock", "UnitsInStock");

                cbSearchField.DataSource = null;
                cbSearchField.Items.Clear();
                cbSearchField.DataSource = searchFields.ToList();
                cbSearchField.DisplayMember = "key";
                cbSearchField.ValueMember = "value";
                cbSearchField.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            try
            {
                // if search box has word
                if (tbSearch.Text != string.Empty)
                {
                    int productID = -1;
                    string? productName = null;
                    decimal unitPrice = 0.0m;
                    int unitInStock = -1;
                    string search = tbSearch.Text;
                    switch (cbSearchField.Text)
                    {
                        case "ID":
                            productID = int.Parse(search);
                            break;
                        case "Name":
                            productName = search;
                            break;
                        case "Unit Price":
                            unitPrice = decimal.Parse(search);
                            break;
                        case "Units In Stock":
                            unitInStock = int.Parse(search);
                            break;
                    }
                    List<Product> products = repository.SearchProduct(productID, productName, unitPrice, unitInStock);
                    source.DataSource = products;
                }
                else
                {
                    // if search box is empty
                    source.DataSource = repository.GetProducts();
                }
                LoadProductList(source);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = (int)dgvProductManagement.SelectedRows[0].Cells[0].Value;
            Product product = repository.GetProductById(item);
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Product = product,
                Cart = Cart
            };
            frmProductDetail.ShowDialog();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmCart frmCart = new frmCart
            {
                Cart = Cart,
                Member = Member,
            };
            frmCart.ShowDialog();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmUserOrderView frmUserOrderView = new frmUserOrderView
            {
                Member = Member,
            };
            Hide();
            frmUserOrderView.ShowDialog();
            Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e) => Close();

        private bool exitConfirm()
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void frmProductsUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !exitConfirm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmUpdateMember frmUpdateMember = new frmUpdateMember()
            {
                Member = Member,
                isUser = true
            };

            //frmUpdateMember.MdiParent = frmMain.ActiveForm;
            frmUpdateMember.Show();
            //LoadMemberList();
        }

        private void dgvProductManagement_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
