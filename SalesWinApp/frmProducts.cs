using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        BindingSource source;
        IProductRepository productRepository = new ProductRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();

        public Product product { get; set; }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
            LoadComboBoxSearch();
        }

        private void LoadProductList()
        {
            try
            {
                //List<Product> products = productRepository.GetProducts();
                source = new BindingSource();

                //IQueryable<Product> products = ((List<Product>)source.DataSource).AsQueryable();
                IQueryable<Product> products = productRepository.GetProducts().AsQueryable();
                IQueryable<Category> categories = categoryRepository.GetCategories().AsQueryable();
                var data = products.Join(
                    categories,
                    outer => outer.CategoryId,
                    inner => inner.CategoryId,
                    (product, category) => new
                    {
                        ProductID = product.ProductId,
                        ProductName = product.ProductName,
                        CategoryName = category.CategoryName,
                        CategoryID = category.CategoryId,
                        Weight = product.Weight,
                        UnitsInStock = product.UnitsInStock,
                        UnitPrice = product.UnitPrice,
                    }).ToList();


                source.DataSource = data;

                dgvProductManagement.DataSource = null;
                dgvProductManagement.DataSource = source;

                dgvProductManagement.Columns["CategoryID"].Visible = false;

                // Choose the first row by default
                DataGridViewRow row = dgvProductManagement.Rows[0];
                product = new Product()
                {
                    ProductId = int.Parse(row.Cells["ProductId"].Value.ToString()),
                    CategoryId = int.Parse(row.Cells["CategoryId"].Value.ToString()),
                    ProductName = row.Cells["ProductName"].Value.ToString(),
                    Weight = row.Cells["Weight"].Value.ToString(),
                    UnitPrice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
                    UnitsInStock = int.Parse(row.Cells["UnitsInStock"].Value.ToString()),
                };
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

                cbSearchField.Items.Clear();
                cbSearchField.DataSource = searchFields.ToList();
                cbSearchField.DisplayMember = "key";
                cbSearchField.ValueMember = "value";
                cbSearchField.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load ComboBoxSearch error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
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
                    List<Product> products = productRepository.SearchProduct(productID, productName, unitPrice, unitInStock);
                    source.DataSource = products;

                    dgvProductManagement.DataSource = null;
                    dgvProductManagement.DataSource = source;
                }
                else
                {
                    // if search box is empty
                    LoadProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // set the selected Row as Product object
                DataGridViewRow row = dgvProductManagement.Rows[e.RowIndex];
                product = new Product()
                {
                    ProductId = int.Parse(row.Cells["ProductId"].Value.ToString()),
                    CategoryId = int.Parse(row.Cells["CategoryId"].Value.ToString()),
                    ProductName = row.Cells["ProductName"].Value.ToString(),
                    Weight = row.Cells["Weight"].Value.ToString(),
                    UnitPrice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
                    UnitsInStock = int.Parse(row.Cells["UnitsInStock"].Value.ToString()),
                    Category = categoryRepository.GetCategoryByID(int.Parse(row.Cells["CategoryId"].Value.ToString()))
                };
            };
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            LoadProductList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateProduct frmCreateProduct = new frmCreateProduct();
                frmCreateProduct.MdiParent = frmMain.ActiveForm;
                frmCreateProduct.Show();
                LoadProductList();
                source.Position = source.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateProduct frmUpdateProduct = new frmUpdateProduct()
                {
                    product = product
                };
                frmUpdateProduct.MdiParent = frmMain.ActiveForm;
                frmUpdateProduct.Show();
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    int proID = product.ProductId;
                    productRepository.DeleteProduct(proID);
                    LoadProductList();
                    source.Position = source.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool exitConfirm()
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !exitConfirm();
        }
    }
}
