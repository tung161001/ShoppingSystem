using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        Member member { get; set; }

        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            LoadFilterComboBox();
        }
        private void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                dgvMemberManagement.DataSource = null;
                dgvMemberManagement.DataSource = source;

                DataGridViewRow row = this.dgvMemberManagement.Rows[0];
                member = new Member
                {
                    MemberId = int.Parse(row.Cells[0].Value.ToString()),
                    Email = row.Cells[1].Value.ToString(),
                    CompanyName = row.Cells[2].Value.ToString(),
                    City = row.Cells[3].Value.ToString(),
                    Country = row.Cells[4].Value.ToString(),
                    Password = row.Cells[5].Value.ToString(),

                };
                dgvMemberManagement.Columns["Orders"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void LoadFilterComboBox()
        {
            cbFilterCity.SelectedIndex = 0;
            cbFilterCountry.SelectedIndex = 0;
            var listMember = memberRepository.GetMembers();
            var listCity = from a in listMember
                           group a by a.City into g
                           select g.Key;
            var listCountry = from member in listMember
                              group member by member.Country into g
                              select g.Key;
            cbFilterCity.Items.AddRange(listCity.ToArray());
            cbFilterCountry.Items.AddRange(listCountry.ToArray());
        }

        private void dgvMemberManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMemberManagement.Rows[e.RowIndex];
                member = new Member
                {
                    MemberId = int.Parse(row.Cells[0].Value.ToString()),
                    Email = row.Cells[1].Value.ToString(),
                    CompanyName = row.Cells[2].Value.ToString(),
                    City = row.Cells[3].Value.ToString(),
                    Country = row.Cells[4].Value.ToString(),
                    Password = row.Cells[5].Value.ToString()
                };
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateMember frmCreate = new frmCreateMember
            {
                Text = "Add member",
                InsertorUpdate = false,
                memberRepository = memberRepository
            };
            frmCreate.MdiParent = frmMain.ActiveForm;
            frmCreate.Show();
            LoadMemberList();
            source.Position = source.Count - 1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbFilterCity.SelectedIndex = 0;
            cbFilterCountry.SelectedIndex = 0;
            tbSearch.Text = string.Empty;
            LoadMemberList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateMember frmUpdateMember = new frmUpdateMember()
            {
                Member = member,
                isAdmin = true
            };
            frmUpdateMember.MdiParent = frmMain.ActiveForm;
            frmUpdateMember.Show();
            LoadMemberList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?",
                "Delete confirmation", MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    memberRepository.DeleteMember(member.MemberId);
                    LoadMemberList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a member");
                }
            }
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbSearch.Text == String.Empty)
                {
                    LoadMemberList();
                }
                else
                {
                    int id = 0;
                    string name = tbSearch.Text;
                    if (int.TryParse(tbSearch.Text, out _))
                    {
                        id = int.Parse(tbSearch.Text);
                    }
                    List<Member> members = memberRepository.SearchMembers(id, name)
                        .ToList();
                    source.DataSource = members;
                    dgvMemberManagement.DataSource = null;
                    dgvMemberManagement.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search");

            }
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if value != defalt value then execute search 
                if (cbFilterCity.SelectedIndex != 0 && cbFilterCountry.SelectedIndex != 0)
                {
                    string city = cbFilterCity.Text;
                    string country = cbFilterCountry.Text;
                    List<Member> members = memberRepository
                        .FilterMember(city, country).ToList();
                    source.DataSource = members;
                    dgvMemberManagement.DataSource = null;
                    dgvMemberManagement.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e) => Close();

        private bool exitConfirm()
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void frmMemberManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !exitConfirm();
        }
    }

}