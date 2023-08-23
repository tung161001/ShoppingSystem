using BusinessObject;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace SalesWinApp
{
    public partial class frmCreateProduct : Form
    {
        public frmCreateProduct()
        {
            InitializeComponent();
        }
        public Product product { get; set; }
        IProductRepository productRepository = new ProductRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();

        private void frmCreateProduct_Load(object sender, EventArgs e)
        {
            // auto increase the next id
            int productID = productRepository.GetMaxProductID() + 1;
            tbProductID.Text = productID.ToString();
            LoadComboBoxCategory();
            btnSave.Enabled = false;
        }

        private void LoadComboBoxCategory()
        {
            List<Category> categories = categoryRepository.GetCategories();
            Dictionary<int, string> categoryDic = new Dictionary<int, string>();
            foreach (Category category in categories)
            {
                categoryDic.Add(category.CategoryId, category.CategoryName);
            }
            cbCategory.DataSource = categoryDic.ToList();
            cbCategory.DisplayMember = "value";
            cbCategory.ValueMember = "key";
            cbCategory.SelectedIndex = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Save confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    product = new Product()
                    {
                        ProductId = int.Parse(tbProductID.Text),
                        ProductName = tbProductName.Text,
                        CategoryId = int.Parse(cbCategory.SelectedValue.ToString()),
                        Weight = tbProductWeight.Text,
                        UnitPrice = decimal.Parse(tbUnitPrice.Text),
                        UnitsInStock = int.Parse(tbUnitsInStock.Text)
                    };
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                        {
                            throw new Exception("Must fill all fields");
                        }
                    }
                    productRepository.CreateProduct(product);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Close();
            }
        }

        private void tbProductID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductID.Text) || !Regex.IsMatch(tbProductID.Text, @"^\d+$"))
            {
                errorProviderID.SetError(tbProductID, "Please enter ID as number");
                btnSave.Enabled = false;
            }
            else
            {
                errorProviderID.Clear();
                btnSave.Enabled = true;
            }
        }

        private void tbProductName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductName.Text))
            {
                errorProviderName.SetError(tbProductName, "Please enter Name");
                btnSave.Enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(tbProductName.Text) || !Regex.IsMatch(tbProductName.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                errorProviderName.SetError(tbProductName, "Name can't have special character");
                btnSave.Enabled = false;
            }
            else
            {
                errorProviderName.Clear();
                btnSave.Enabled = true;
            }
        }

        private void tbProductWeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductWeight.Text))
            {
                errorProviderWeight.SetError(tbProductWeight, "Please enter Weight");
                btnSave.Enabled = false;
            }
            else if (!Regex.IsMatch(tbProductWeight.Text, @"^[0-9]+[.]?[0-9a-zA-Z]*$"))
            {
                errorProviderWeight.SetError(tbProductWeight, "Can't have special character");
                btnSave.Enabled = false;
            }
            else
            {
                errorProviderWeight.Clear();
                btnSave.Enabled = true;
            }
        }

        private void tbUnitPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUnitPrice.Text))
            {
                errorProviderPrice.SetError(tbUnitPrice, "Please enter Unit Price");
                btnSave.Enabled = false;
            }
            else if (!Regex.IsMatch(tbUnitPrice.Text, @"^[\d]+[.]?[\d]*$"))
            {
                errorProviderPrice.SetError(tbUnitPrice, "Please enter Number");
                btnSave.Enabled = false;
            }
            else
            {
                errorProviderPrice.Clear();
                btnSave.Enabled = true;
            }
        }

        private void tbUnitsInStock_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUnitsInStock.Text))
            {
                errorProviderInStock.SetError(tbUnitsInStock, "Please enter Units In Stock");
                btnSave.Enabled = false;
            }
            else if (!Regex.IsMatch(tbUnitsInStock.Text, @"^[\d]+$"))
            {
                errorProviderInStock.SetError(tbUnitsInStock, "Please enter Number");
                btnSave.Enabled = false;
            }
            else
            {
                errorProviderInStock.Clear();
                btnSave.Enabled = true;
            }
        }
    }
}
