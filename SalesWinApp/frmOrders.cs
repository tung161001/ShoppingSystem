using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        BindingSource source;
        IOrderRepository orderRepository = new OrderRepository();
        Order Order { get; set; }
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            try
            {
                DateTime startDate = DateTime.Parse(dtpFrom.Value.ToString("MM/dd/yyyy"));
                DateTime endDate = DateTime.Parse(dtpTo.Value.ToString("MM/dd/yyyy"));

                if (startDate.CompareTo(endDate) <= 0)
                {
                    List<Order> listOrder = orderRepository.GetOrders(startDate, endDate);
                    source = new BindingSource();
                    source.DataSource = listOrder;
                    dgvOrders.DataSource = source;
                    dgvOrders.Columns["Member"].Visible = false;
                    dgvOrders.Columns["OrderDetails"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Start Date must be lower than End Date");
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];
                Order = new Order
                {
                    OrderId = int.Parse(row.Cells[0].Value.ToString()),
                    MemberId = int.Parse(row.Cells[1].Value.ToString()),
                    OrderDate = DateTime.Parse(row.Cells[2].Value.ToString()),
                    RequiredDate = row.Cells[3].Value == null ? null : DateTime.Parse(row.Cells[3].Value.ToString()),
                    ShipppedDate = row.Cells[4].Value == null ? null : DateTime.Parse(row.Cells[4].Value.ToString()),
                    Freight = row.Cells[5].Value == null ? null : decimal.Parse(row.Cells[5].Value.ToString())
                };

                frmOrderDetails frmOrderDetails = new frmOrderDetails { Order = Order, FrmOrders = this };
                frmOrderDetails.MdiParent = frmMain.ActiveForm;
                frmOrderDetails.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
