using BusinessObject;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace SalesWinApp
{
    public partial class frmUpdateMember : Form
    {
        public IMemberRepository MemberRepository = new MemberRepository();

        public Member Member { get; set; }

        public bool isAdmin { get; set; }
        public bool isUser { get; set; }


        //public bool CompanyNameCheck = false;
        //public bool EmailCheck = false;
        //public bool PassCheck = false;
        //public bool CityCheck = false;
        //public bool CountryCheck = false;


        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            tbMemberID.Text = Member.MemberId.ToString();
            tbCompanyName.Text = Member.CompanyName.ToString();
            tbMemberEmail.Text = Member.Email.ToString();
            tbMemberPassword.Text = Member.Password.ToString();
            tbMemberCity.Text = Member.City.ToString();
            tbMemberCountry.Text = Member.Country.ToString();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save?", "Update confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9]+@gmail\.com$");
                try
                {
                    if (regex.IsMatch(tbMemberEmail.Text) &&
                            !tbCompanyName.Text.Equals("") &&
                            !tbMemberEmail.Text.Equals("") &&
                            !tbMemberPassword.Text.Equals("") &&
                            !tbMemberCity.Text.Equals("") &&
                            !tbMemberCountry.Text.Equals(""))
                    {
                        Member = new Member()
                        {
                            MemberId = int.Parse(tbMemberID.Text),
                            CompanyName = tbCompanyName.Text,
                            Email = tbMemberEmail.Text,
                            Password = tbMemberPassword.Text,
                            City = tbMemberCity.Text,
                            Country = tbMemberCountry.Text
                        };
                        MemberRepository.UpdateMember(Member);
                        if (isUser)
                        {
                            // is user then open user info
                            frmMemberInfo frmMemberInfo = new frmMemberInfo()
                            {
                                Member = Member
                            };
                            Hide();
                            frmMemberInfo.ShowDialog();
                            Close();
                        }
                        else if (isAdmin)
                        {
                            // is admin then open member management
                            Close();
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Wrong email format", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (dialogResult == DialogResult.Cancel)
                        {
                            Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update a member");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void tbCompanyName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrWhiteSpace(tbCompanyName.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPCompanyName.
                    SetError(tbCompanyName, "Can not null or front blank");
                //CompanyNameCheck = false;
            }
            //@"^[a-zA-Z\s]*$"
            else if (!Regex.IsMatch(tbCompanyName.Text,
                @"^[0-9a-zA-Z\s]*$"))
            {
                EPCompanyName.
                    SetError(tbCompanyName, "Wrong format");
                //CompanyNameCheck = false;
            }
            else
            {
                EPCompanyName.Clear();
                //CompanyNameCheck = true;
                btnSave.Enabled = true;
                //if (CompanyNameCheck && EmailCheck && PassCheck
                //    && CityCheck && CountryCheck)
                //{
                //    btnSave.Enabled = true;
                //}
                //else
                //{
                //    btnSave.Enabled = false;
                //}
            }
        }

        private void tbMemberEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrWhiteSpace(tbMemberEmail.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPEmail.
                    SetError(tbMemberEmail, "Can not null or front blank");
                //EmailCheck = false;

            }
            else if (!Regex.IsMatch(tbMemberEmail.Text,
                @"^[\w.+\-]+@gmail\.com$"))
            {
                EPEmail.
                    SetError(tbMemberEmail, "Wrong email format");
                //EmailCheck=false;
            }
            else
            {
                EPEmail.Clear();
                //EmailCheck = true;
                btnSave.Enabled = true;
                //if (CompanyNameCheck && EmailCheck && PassCheck
                //    && CityCheck && CountryCheck)
                //{
                //    btnSave.Enabled = true;
                //}
                //else
                //{
                //    btnSave.Enabled = false;
                //}
            }
        }

        private void tbMemberPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrWhiteSpace(tbMemberPassword.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPPassword.
                    SetError(tbMemberPassword, "Can not null or front blank");
                //PassCheck = false;
            }
            else if (!Regex.IsMatch(tbMemberPassword.Text,
                @"^[0-9a-zA-Z]*$"))
            {
                EPPassword.
                    SetError(tbMemberPassword, "Can not contain number");
                //PassCheck = false;
            }
            else
            {
                EPPassword.Clear();
                //PassCheck = true;
                btnSave.Enabled = true;
                //if (CompanyNameCheck && EmailCheck && PassCheck
                //    && CityCheck && CountryCheck)
                //{
                //    btnSave.Enabled = true;
                //}
                //else
                //{
                //    btnSave.Enabled = false;
                //}
            }
        }

        private void tbMemberCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrWhiteSpace(tbMemberCity.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPCity.
                    SetError(tbMemberCity, "Can not null or front blank");
                //CityCheck = false;

            }
            else if (!Regex.IsMatch(tbMemberCity.Text, @"^[a-zA-Z\s]*$"))
            {
                EPCity.
                    SetError(tbMemberCity, "Can not contain number");
                //CityCheck = false;

            }
            else
            {
                EPCity.Clear();
                //CityCheck = true;
                btnSave.Enabled = true;
                //if (CompanyNameCheck && EmailCheck && PassCheck
                //    && CityCheck && CountryCheck)
                //{
                //    btnSave.Enabled = true;
                //}
                //else
                //{
                //    btnSave.Enabled = false;
                //}
            }
        }

        private void tbMemberCountry_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrWhiteSpace(tbMemberCountry.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPCountry.
                    SetError(tbMemberCountry, "Can not null or front blank");
                //CountryCheck = false;
            }
            else if (!Regex.IsMatch(tbMemberCountry.Text, @"^[a-zA-Z\s]*$"))
            {
                EPCountry.
                    SetError(tbMemberCountry, "Can not contain number");
                //CountryCheck = false;
            }
            else
            {
                EPCountry.Clear();
                //CountryCheck = true;
                btnSave.Enabled = true;
                //if (CompanyNameCheck && EmailCheck && PassCheck
                //    && CityCheck && CountryCheck)
                //{
                //    btnSave.Enabled = true;
                //}
                //else
                //{
                //    btnSave.Enabled = false;
                //}
            }
        }
    }
}
