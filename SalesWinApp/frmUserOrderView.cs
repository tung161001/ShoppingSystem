using BusinessObject;
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
    public partial class frmUserOrderView : Form
    {
        public Member Member { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public List<Order> list { get; set; }

        public frmUserOrderView()
        {
            OrderRepository = new OrderRepository();
            InitializeComponent();
        }

        private void frmUserOrderView_Load(object sender, EventArgs e)
        {
            cbxType.SelectedIndex = 0;
            list = OrderRepository.GetOrdersByMemberID(Member.MemberId);

            BindingSource source = new BindingSource();

            source.DataSource = list;

            LoadOrders(source);
        }

        private void LoadOrders(BindingSource source)
        {
            dgvOrders.DataSource = source;
            dgvOrders.Columns["OrderID"].HeaderText = "ID";
            dgvOrders.Columns["OrderDate"].HeaderText = "Ordered Date";
            dgvOrders.Columns["RequiredDate"].HeaderText = "Required Date";
            dgvOrders.Columns["ShipppedDate"].HeaderText = "Shipped Date";
            dgvOrders.Columns["Member"].Visible = false;
            dgvOrders.Columns["MemberID"].Visible = false;
            dgvOrders.Columns["OrderDetails"].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Order selectedOrder = (Order)dgvOrders.SelectedRows[0].DataBoundItem;
            frmOrderDetail detail = new frmOrderDetail
            {
                Member = Member,
                Order = selectedOrder,
            };
            detail.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //flooring start date to dd/MM/YYYY 00:00:00
            var fromDate = Floor(dpkFrom.Value, new TimeSpan(1, 0, 0, 0));
            //ceiling end date to dd/MM/YYYY 23:59:59 
            var toDate = Ceil(dpkTo.Value, new TimeSpan(1, 0, 0, 0)).AddSeconds(-1);
            try
            {
                if (fromDate.CompareTo(toDate) > 0)
                {
                    throw new Exception("Start date cannot after end date");
                }
                string type = cbxType.Text;
                BindingSource source;
                switch (type)
                {
                    case "Ordered date":
                        source = filter(arg =>
                        {
                            return arg.OrderDate.CompareTo(fromDate) >= 0
                                   && arg.OrderDate.CompareTo(toDate) <= 0;
                        });
                        break;
                    case "Required date":
                        source = filter(arg =>
                        {
                            DateTime argDate = (DateTime)(arg.RequiredDate == null ? new DateTime(5000, 12, 31) : arg.RequiredDate);
                            return argDate.CompareTo(fromDate) >= 0
                                   && argDate.CompareTo(toDate) <= 0;
                        });
                        break;
                    default:
                        source = filter(arg =>
                        {
                            DateTime argDate = (DateTime)(arg.ShipppedDate == null ? new DateTime(5000, 12, 31) : arg.ShipppedDate);
                            return argDate.CompareTo(fromDate) >= 0
                                   && argDate.CompareTo(toDate) <= 0;
                        });
                        break;
                }
                LoadOrders(source);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BindingSource FilterByRequiredDate()
        {
            throw new NotImplementedException();
        }

        private DateTime Floor(DateTime date, TimeSpan span)
        {
            long ticks = (date.Ticks / span.Ticks);
            return new DateTime(ticks * span.Ticks);
        }
        private DateTime Ceil(DateTime date, TimeSpan span)
        {
            long ticks = (date.Ticks + span.Ticks - 1) / span.Ticks;
            return new DateTime(ticks * span.Ticks);
        }

        private BindingSource filter(Func<Order, bool> predicate)
        {
            List<Order> foundList = list.Where(order => predicate(order)).ToList();
            BindingSource source = new BindingSource();
            source.DataSource = foundList;
            return source;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;
            LoadOrders(source);
        }

        private void tbxOrderID_TextChanged(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            List<Order> foundList = list.Where(order =>
            {
                return order.OrderId.ToString().StartsWith(tbxOrderID.Text);
            }).ToList();
            source.DataSource = foundList;
            LoadOrders(source);
        }
    }
}
