using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    IMemberRepository Repository { get; set; }
    public frmLogin()
    {
        InitializeComponent();
    }

    private class AdminAccount : Member
    {
        public new string ToString => Email + " " + Password;

        public override bool Equals(object? obj)
        {
            return obj is AdminAccount account &&
                   Email == account.Email &&
                   Password == account.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Email, Password);
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        Repository = new MemberRepository();
    }

    private Boolean isAdminAccount(AdminAccount admin)
    {
        IConfiguration configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json").Build();
        IConfigurationSection jsonObject = configuration.GetSection("admin");

        AdminAccount admin1 = new AdminAccount
        {
            Email = jsonObject["email"],
            Password = jsonObject["password"]
        };

        return admin1.Equals(admin);
    }


    private void btnSignIn_Click(object sender, EventArgs e)
    {
        try
        {
            AdminAccount account = new AdminAccount
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };
            if (isAdminAccount(account))
            {
                //admin account
                frmMain frmMain = new frmMain();
                this.Hide();
                DialogResult result = frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                // user account
                Member member = Repository.SignIn(txtEmail.Text, txtPassword.Text);
                if (member == null) throw new Exception("Member not found");
                frmProductsUser frmProductsUser = new frmProductsUser
                {
                    Member = member,
                };
                Hide();
                frmProductsUser.ShowDialog();
                Show();
            }
            txtEmail.Text = string.Empty;
            errorMessage.Text = string.Empty;
            errorMessage.Visible = false;
        }
        catch (Exception ex)
        {
            //errorMessage.Visible = true;
            //errorMessage.Text = ex.Message;
            MessageBox.Show(ex.Message);
            txtPassword.Focus();
        }
        finally
        {
            txtPassword.Text = string.Empty;
            if (errorMessage.Text == string.Empty)
                txtEmail.Focus();
            else txtPassword.Focus();
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

    private void txtEmail_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSignIn_Click(sender, e);
        }
    }
    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSignIn_Click(sender, e);
        }
    }
}


