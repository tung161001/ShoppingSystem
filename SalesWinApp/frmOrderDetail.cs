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
    public partial class frmOrderDetail : Form
    {
        public Member Member { get; set; }
        public Order Order { get; set; }
        private IOrderDetailRepository Repository { get; set; }

        public frmOrderDetail()
        {
            Repository = new OrderDetailRepository();
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            lbOrderDetail.Text += " #" + Order.OrderId;
            lbMemberEmail.Text = Member.Email;
            lbOrdDateText.Text = Order.OrderDate.ToString();
            lbReqDateText.Text = (Order.RequiredDate == null) ? "Not yet" : Order.RequiredDate.ToString();
            lbShipDateText.Text = (Order.ShipppedDate == null) ? "Not yet" : Order.RequiredDate.ToString();

            IQueryable<OrderDetail> orderDetails = Repository.getOrderDetailsByOrderID(Order.OrderId).AsQueryable();

            var source = new BindingSource();
            source.DataSource = orderDetails;
            loadData(source);
        }

        private void loadData(BindingSource source)
        {
            var proRepo = new ProductRepository();
            var allProduct = proRepo.GetProducts().AsQueryable();
            IQueryable<OrderDetail> orderDetails = (IQueryable<OrderDetail>) source.DataSource;

            var data = orderDetails.Join(allProduct,
                outer => outer.ProductId,
                inner => inner.ProductId,
                (detail, product) => new {
                    ProductName = product.ProductName,
                    detail.UnitPrice,
                    Amount = detail.Quantity * detail.UnitPrice,
                    detail.Quantity,
                    detail.Discount,
                }).ToList();
            dgvDetailsList.DataSource = data;
            dgvDetailsList.Columns["ProductName"].HeaderText = "Product";
            dgvDetailsList.Columns["UnitPrice"].HeaderText = "Unit Price";
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
