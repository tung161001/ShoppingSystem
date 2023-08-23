using BusinessObject;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace SalesWinApp
{
    public partial class frmUpdateProduct : Form
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
        }
        public Product product { get; set; }
        IProductRepository repository = new ProductRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            tbProductID.Enabled = false;
            tbProductID.Text = product.ProductId.ToString();
            tbProductName.Text = product.ProductName.ToString();
            tbProductWeight.Text = product.Weight.ToString();
            tbUnitPrice.Text = product.UnitPrice.ToString();
            tbUnitsInStock.Text = product.UnitsInStock.ToString();
            LoadComboBoxCategory();
        }

        private void LoadComboBoxCategory()
        {
            int index = 0;
            bool flag = true;
            List<Category> categories = categoryRepository.GetCategories();
            Dictionary<int, string> categoryDic = new Dictionary<int, string>();
            foreach (Category category in categories)
            {
                categoryDic.Add(category.CategoryId, category.CategoryName);
                if (product.CategoryId != category.CategoryId && flag)
                {
                    index++;
                }
                else if (product.CategoryId == category.CategoryId)
                {
                    flag = false;
                }
            }
            cbCategory.DataSource = categoryDic.ToList();
            cbCategory.DisplayMember = "value";
            cbCategory.ValueMember = "key";
            cbCategory.SelectedIndex = index;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Save product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox && control.Text.Trim().Equals(string.Empty))
                        {
                            throw new Exception("Must fill all fields");
                        }
                    }
                    product = new Product()
                    {
                        ProductId = int.Parse(tbProductID.Text),
                        ProductName = tbProductName.Text,
                        Weight = tbProductWeight.Text,
                        UnitPrice = decimal.Parse(tbUnitPrice.Text),
                        UnitsInStock = int.Parse(tbUnitsInStock.Text),
                        CategoryId = int.Parse(cbCategory.SelectedValue.ToString()),
                    };
                    repository.UpdateProduct(product);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
