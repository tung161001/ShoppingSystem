using BusinessObject;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmMemberInfo : Form
    {
        public IMemberRepository Repository { get; set; }

        public Member Member { get; set; }

        public frmMemberInfo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            frmUpdateMember frmUpdateMember = new frmUpdateMember {
                MemberRepository = Repository,
                Member = Member,
            };
            Hide();
            frmUpdateMember.ShowDialog();
            this.Show();

        }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            txtID.Text = Member.MemberId.ToString();
            txtCompanyName.Text = Member.CompanyName.ToString();
            txtEmail.Text = Member.Email.ToString();
            txtPassword.Text = Member.Password.ToString();
            txtCity.Text = Member.City.ToString();
            txtCountry.Text = Member.Country.ToString();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmUserOrderView frmUserOrderView = new frmUserOrderView
            {
                Member = Member,
            };
            Hide();
            frmUserOrderView.ShowDialog();
            Show();
        }
    }
}
