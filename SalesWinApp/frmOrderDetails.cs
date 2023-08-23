using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrders FrmOrders { get; set; }
        public Order Order { get; set; }
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            LoadOrder();
            LoadOrderDetails();
            LoadTextBoxTotal();
        }

        private void LoadOrder()
        {
            Order order = orderRepository.GetOrderByID(Order.OrderId);
            txtMember.Text = memberRepository.GetMemberbyID(Order.MemberId).Email;
            dtpOrderDate.Value = Order.OrderDate;
            if (Order.RequiredDate == null)
            {
                dtpRequiredDate.CustomFormat = " ";
                dtpRequiredDate.Format = DateTimePickerFormat.Custom;
                dtpRequiredDate.Enabled = true;
                dtpRequiredDate.Checked = false;
            }
            if (Order.ShipppedDate == null)
            {
                dtpShippedDate.CustomFormat = " ";
                dtpShippedDate.Format = DateTimePickerFormat.Custom;
                dtpShippedDate.Enabled = true;
                dtpShippedDate.Checked = false;
            }
            if (Order.Freight == null)
            {
                txtFreight.Text = "";
                txtFreight.ReadOnly = false;
            }
            else
            {
                dtpRequiredDate.Value = Order.RequiredDate.Value;
                dtpShippedDate.Value = Order.ShipppedDate.Value;
                txtFreight.Text = Order.Freight.ToString();
            }
        }
        private void dtpRequiredDate_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTimePicker)sender).ShowCheckBox == true)
            {
                if (((DateTimePicker)sender).Checked == false)
                {
                    ((DateTimePicker)sender).CustomFormat = " ";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;

                }
                else
                {
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                }
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;

            }
        }

        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTimePicker)sender).ShowCheckBox == true)
            {
                if (((DateTimePicker)sender).Checked == false)
                {
                    ((DateTimePicker)sender).CustomFormat = " ";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                }
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
            }
        }

        private void LoadTextBoxTotal()
        {
            Order order = orderRepository.GetOrderByID(Order.OrderId);
            txtSubTotal.Text = detailRepository.GetTotal(Order.OrderId).ToString();
            txtTotal.Text = (detailRepository.GetTotal(Order.OrderId) + Order.Freight).ToString();
        }

        private void LoadOrderDetails()
        {
            try
            {
                List<OrderDetail> list = detailRepository.getOrderDetailsByOrderID(Order.OrderId);
                source = new BindingSource();
                source.DataSource = list;
                dgvOrderDetails.DataSource = source;
                dgvOrderDetails.Columns["Order"].Visible = false;
                dgvOrderDetails.Columns["Product"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpRequiredDate.Format == DateTimePickerFormat.Custom || dtpShippedDate.Format == DateTimePickerFormat.Custom || txtFreight.Text == null)
                {
                    MessageBox.Show("Please enter all field");
                }
                else
                {
                    DateTime orderDate = DateTime.Parse(dtpOrderDate.Value.ToString("dd/MM/yyyy"));
                    DateTime shippedDate = DateTime.Parse(dtpShippedDate.Value.ToString("dd/MM/yyyy"));
                    DateTime requiredDate = DateTime.Parse(dtpRequiredDate.Value.ToString("dd/MM/yyyy"));
                    decimal freight = decimal.Parse(txtFreight.Text);
                    if (orderDate.CompareTo(shippedDate) > 0)
                    {
                        MessageBox.Show("Shipped Date must be after Order Date");
                    }
                    if (orderDate.CompareTo(requiredDate) > 0)
                    {
                        MessageBox.Show("Required Date must be after Order Date");
                    }
                    else
                    {
                        orderRepository.UpdateOrder(requiredDate, shippedDate, freight, Order.OrderId);
                        Order = new Order
                        {
                            OrderId = Order.OrderId,
                            MemberId = Order.MemberId,
                            RequiredDate = requiredDate,
                            ShipppedDate = shippedDate,
                            OrderDate = orderDate,
                            Freight = freight
                        };
                        LoadOrder();
                        LoadTextBoxTotal();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close?","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
