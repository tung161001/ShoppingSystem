namespace SalesWinApp
{
    partial class frmCreateMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbMemberCountry = new System.Windows.Forms.TextBox();
            this.tbMemberCity = new System.Windows.Forms.TextBox();
            this.tbMemberPassword = new System.Windows.Forms.TextBox();
            this.tbMemberEmail = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lbMemberCountry = new System.Windows.Forms.Label();
            this.lbMemberCity = new System.Windows.Forms.Label();
            this.lbMemberPw = new System.Windows.Forms.Label();
            this.lbMemberEmail = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.EPCompanyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPCountry = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EPCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(128, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Create Member";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(224, 264);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(89, 264);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbMemberCountry
            // 
            this.tbMemberCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberCountry.Location = new System.Drawing.Point(128, 211);
            this.tbMemberCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberCountry.Name = "tbMemberCountry";
            this.tbMemberCountry.Size = new System.Drawing.Size(225, 23);
            this.tbMemberCountry.TabIndex = 26;
            this.tbMemberCountry.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberCountry_Validating);
            // 
            // tbMemberCity
            // 
            this.tbMemberCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberCity.Location = new System.Drawing.Point(128, 174);
            this.tbMemberCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberCity.Name = "tbMemberCity";
            this.tbMemberCity.Size = new System.Drawing.Size(225, 23);
            this.tbMemberCity.TabIndex = 25;
            this.tbMemberCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberCity_Validating);
            // 
            // tbMemberPassword
            // 
            this.tbMemberPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberPassword.Location = new System.Drawing.Point(128, 139);
            this.tbMemberPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberPassword.Name = "tbMemberPassword";
            this.tbMemberPassword.Size = new System.Drawing.Size(225, 23);
            this.tbMemberPassword.TabIndex = 24;
            this.tbMemberPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberPassword_Validating);
            // 
            // tbMemberEmail
            // 
            this.tbMemberEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberEmail.Location = new System.Drawing.Point(128, 103);
            this.tbMemberEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberEmail.Name = "tbMemberEmail";
            this.tbMemberEmail.Size = new System.Drawing.Size(225, 23);
            this.tbMemberEmail.TabIndex = 23;
            this.tbMemberEmail.TextChanged += new System.EventHandler(this.tbMemberEmail_TextChanged);
            this.tbMemberEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberEmail_Validating);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCompanyName.Location = new System.Drawing.Point(128, 70);
            this.tbCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(225, 23);
            this.tbCompanyName.TabIndex = 22;
            this.tbCompanyName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCompanyName_Validating);
            // 
            // lbMemberCountry
            // 
            this.lbMemberCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemberCountry.AutoSize = true;
            this.lbMemberCountry.Location = new System.Drawing.Point(48, 211);
            this.lbMemberCountry.Name = "lbMemberCountry";
            this.lbMemberCountry.Size = new System.Drawing.Size(50, 15);
            this.lbMemberCountry.TabIndex = 20;
            this.lbMemberCountry.Text = "Country";
            // 
            // lbMemberCity
            // 
            this.lbMemberCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemberCity.AutoSize = true;
            this.lbMemberCity.Location = new System.Drawing.Point(48, 174);
            this.lbMemberCity.Name = "lbMemberCity";
            this.lbMemberCity.Size = new System.Drawing.Size(28, 15);
            this.lbMemberCity.TabIndex = 19;
            this.lbMemberCity.Text = "City";
            // 
            // lbMemberPw
            // 
            this.lbMemberPw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemberPw.AutoSize = true;
            this.lbMemberPw.Location = new System.Drawing.Point(48, 139);
            this.lbMemberPw.Name = "lbMemberPw";
            this.lbMemberPw.Size = new System.Drawing.Size(57, 15);
            this.lbMemberPw.TabIndex = 18;
            this.lbMemberPw.Text = "Password";
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Location = new System.Drawing.Point(48, 103);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(36, 15);
            this.lbMemberEmail.TabIndex = 17;
            this.lbMemberEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(28, 70);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(94, 15);
            this.lbCompanyName.TabIndex = 16;
            this.lbCompanyName.Text = "Company Name";
            // 
            // EPCompanyName
            // 
            this.EPCompanyName.ContainerControl = this;
            // 
            // EPEmail
            // 
            this.EPEmail.ContainerControl = this;
            // 
            // EPPassword
            // 
            this.EPPassword.ContainerControl = this;
            // 
            // EPCity
            // 
            this.EPCity.ContainerControl = this;
            // 
            // EPCountry
            // 
            this.EPCountry.ContainerControl = this;
            // 
            // frmCreateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 315);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMemberCountry);
            this.Controls.Add(this.tbMemberCity);
            this.Controls.Add(this.tbMemberPassword);
            this.Controls.Add(this.tbMemberEmail);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.lbMemberCountry);
            this.Controls.Add(this.lbMemberCity);
            this.Controls.Add(this.lbMemberPw);
            this.Controls.Add(this.lbMemberEmail);
            this.Controls.Add(this.lbCompanyName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateMember";
            this.Load += new System.EventHandler(this.frmCreateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbMemberCountry;
        private TextBox tbMemberCity;
        private TextBox tbMemberPassword;
        private TextBox tbMemberEmail;
        private TextBox tbCompanyName;
        private Label lbMemberCountry;
        private Label lbMemberCity;
        private Label lbMemberPw;
        private Label lbMemberEmail;
        private Label lbCompanyName;
        private ErrorProvider EPCompanyName;
        private ErrorProvider EPEmail;
        private ErrorProvider EPPassword;
        private ErrorProvider EPCity;
        private ErrorProvider EPCountry;
    }
}