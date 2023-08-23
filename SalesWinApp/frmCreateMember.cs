using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace SalesWinApp
{
    public partial class frmCreateMember : Form
    {
        public IMemberRepository memberRepository { get; set; }
        public bool InsertorUpdate { get; set; }
        public Member memberInfo { get; set; }
        public MemberDAO memberDAO { get; set; }
        public bool CompanyNameCheck = false;
        public bool EmailCheck = false;
        public bool PassCheck = false;
        public bool CityCheck = false;
        public bool CountryCheck = false;
        public frmCreateMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[\w.+\-]+@gmail\.com$");
            DialogResult result = MessageBox.Show("Do you want to save?", "Create confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (InsertorUpdate == false)
                    {
                        if (regex.IsMatch(tbMemberEmail.Text) &&
                            !tbCompanyName.Text.Equals("") &&
                            !tbMemberEmail.Text.Equals("") &&
                            !tbMemberPassword.Text.Equals("") &&
                            !tbMemberCity.Text.Equals("") &&
                            !tbMemberCountry.Text.Equals(""))
                        {
                            memberInfo = new Member()
                            {
                                MemberId = memberRepository.GetLast().MemberId + 1,
                                Email = tbMemberEmail.Text,
                                CompanyName = tbCompanyName.Text,
                                City = tbMemberCity.Text,
                                Country = tbMemberCountry.Text,
                                Password = tbMemberPassword.Text

                            };
                            Member m = memberRepository.GetMemberbyEmail(tbMemberEmail.Text);
                            if (m != null)
                            {
                                MessageBox.Show("Email is already exist");
                            }
                            else
                            {
                                memberRepository.AddMember(memberInfo);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertorUpdate == false ? "Add new member" :
                        "Update member");

                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCreateMember_Load(object sender, EventArgs e)
        {
            //tbMemberID.Enabled = !InsertorUpdate;
            if (InsertorUpdate == true)
            {
                //tbMemberID.Text = memberInfo.MemberID.ToString();
                tbCompanyName.Text = memberInfo.CompanyName; //.Trim()
                tbMemberEmail.Text = memberInfo.Email;
                tbMemberPassword.Text = memberInfo.Password;
                tbMemberCity.Text = memberInfo.City;
                tbMemberCountry.Text = memberInfo.Country;
            }
        }
        private void tbCompanyName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrWhiteSpace(tbCompanyName.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPCompanyName.
                    SetError(tbCompanyName, "Can not null or front blank");
                //btnSave.Enabled = false;
                CompanyNameCheck = false;

            }
            else if (!Regex.IsMatch(tbCompanyName.Text,
                @"^[0-9a-zA-Z\s]*$"))
            {
                EPCompanyName.
                    SetError(tbCompanyName, "Wrong format");
                //btnSave.Enabled = false;
                CompanyNameCheck = false;
            }
            else
            {
                EPCompanyName.Clear();
                CompanyNameCheck = true;
                if (CompanyNameCheck && EmailCheck && PassCheck
                    && CityCheck && CountryCheck)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }
        }

        private void tbMemberEmail_TextChanged(object sender, EventArgs e)
        {
            //Do not write here
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
                //btnSave.Enabled = false;
                EmailCheck = false;
            }
            else if (!Regex.IsMatch(tbMemberEmail.Text,
                @"^[\w.+\-]+@gmail\.com$"))
            {
                EPEmail.
                    SetError(tbMemberEmail, "Wrong email format");
                //btnSave.Enabled = false;
                EmailCheck = false;
            }
            else
            {
                EPEmail.Clear();
                EmailCheck = true;
                if (CompanyNameCheck && EmailCheck && PassCheck
                    && CityCheck && CountryCheck)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }
        }

        private void tbMemberPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnSave.Enabled = false;
            //Minimum eight characters, at least one letter and one number
            //"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
            if (string.IsNullOrWhiteSpace(tbMemberPassword.Text))
            {
                //e.Cancel = true;
                //tbMemberName.Focus();
                EPPassword.
                    SetError(tbMemberPassword, "Can not null or front blank");
                //btnSave.Enabled = false;
                PassCheck = false;
            }
            else if (!Regex.IsMatch(tbMemberPassword.Text,
                @"^[0-9a-zA-Z]*$"))
            {
                EPPassword.
                    SetError(tbMemberPassword, "Can not contain number");
                //btnSave.Enabled = false;
                PassCheck = false;
            }
            else
            {
                EPPassword.Clear();
                PassCheck = true;
                if (CompanyNameCheck && EmailCheck && PassCheck
                    && CityCheck && CountryCheck)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
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
                //btnSave.Enabled = false;
                CityCheck = false;
            }
            else if (!Regex.IsMatch(tbMemberCity.Text, @"^[a-zA-Z\s]*$"))
            {
                EPCity.
                    SetError(tbMemberCity, "Can not contain number");
                //btnSave.Enabled = false;
                CityCheck = false;
            }
            else
            {
                EPCity.Clear();
                CityCheck = true;
                if (CompanyNameCheck && EmailCheck && PassCheck
                    && CityCheck && CountryCheck)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
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
                //btnSave.Enabled = false;
                CountryCheck = false;
            }
            else if (!Regex.IsMatch(tbMemberCountry.Text, @"^[a-zA-Z\s]*$"))
            {
                EPCountry.
                    SetError(tbMemberCountry, "Can not contain number");
                //btnSave.Enabled = false;
                CountryCheck = false;
            }
            else
            {
                EPCountry.Clear();
                CountryCheck = true;
                if (CompanyNameCheck && EmailCheck && PassCheck
                    && CityCheck && CountryCheck)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }

        }
    }
}
