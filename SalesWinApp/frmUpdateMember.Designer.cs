namespace SalesWinApp
{
    partial class frmUpdateMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbComanyName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbMemberEmail = new System.Windows.Forms.TextBox();
            this.tbMemberPassword = new System.Windows.Forms.TextBox();
            this.tbMemberCity = new System.Windows.Forms.TextBox();
            this.tbMemberCountry = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lbComanyName
            // 
            this.lbComanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbComanyName.AutoSize = true;
            this.lbComanyName.Location = new System.Drawing.Point(21, 112);
            this.lbComanyName.Name = "lbComanyName";
            this.lbComanyName.Size = new System.Drawing.Size(116, 20);
            this.lbComanyName.TabIndex = 1;
            this.lbComanyName.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberID.Location = new System.Drawing.Point(143, 69);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.ReadOnly = true;
            this.tbMemberID.Size = new System.Drawing.Size(257, 27);
            this.tbMemberID.TabIndex = 6;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCompanyName.Location = new System.Drawing.Point(143, 109);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(257, 27);
            this.tbCompanyName.TabIndex = 7;
            this.tbCompanyName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCompanyName_Validating);
            // 
            // tbMemberEmail
            // 
            this.tbMemberEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberEmail.Location = new System.Drawing.Point(143, 155);
            this.tbMemberEmail.Name = "tbMemberEmail";
            this.tbMemberEmail.Size = new System.Drawing.Size(257, 27);
            this.tbMemberEmail.TabIndex = 8;
            this.tbMemberEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberEmail_Validating);
            // 
            // tbMemberPassword
            // 
            this.tbMemberPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberPassword.Location = new System.Drawing.Point(143, 203);
            this.tbMemberPassword.Name = "tbMemberPassword";
            this.tbMemberPassword.Size = new System.Drawing.Size(257, 27);
            this.tbMemberPassword.TabIndex = 9;
            this.tbMemberPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberPassword_Validating);
            // 
            // tbMemberCity
            // 
            this.tbMemberCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberCity.Location = new System.Drawing.Point(143, 249);
            this.tbMemberCity.Name = "tbMemberCity";
            this.tbMemberCity.Size = new System.Drawing.Size(257, 27);
            this.tbMemberCity.TabIndex = 10;
            this.tbMemberCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberCity_Validating);
            // 
            // tbMemberCountry
            // 
            this.tbMemberCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberCountry.Location = new System.Drawing.Point(143, 299);
            this.tbMemberCountry.Name = "tbMemberCountry";
            this.tbMemberCountry.Size = new System.Drawing.Size(257, 27);
            this.tbMemberCountry.TabIndex = 11;
            this.tbMemberCountry.Validating += new System.ComponentModel.CancelEventHandler(this.tbMemberCountry_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(106, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(261, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(143, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Update Member";
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
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 416);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMemberCountry);
            this.Controls.Add(this.tbMemberCity);
            this.Controls.Add(this.tbMemberPassword);
            this.Controls.Add(this.tbMemberEmail);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbComanyName);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateMember";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.Click += new System.EventHandler(this.frmUpdateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbComanyName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbMemberID;
        private TextBox tbCompanyName;
        private TextBox tbMemberEmail;
        private TextBox tbMemberPassword;
        private TextBox tbMemberCity;
        private TextBox tbMemberCountry;
        private Button btnSave;
        private Button btnCancel;
        private Label label7;
        private ErrorProvider EPCompanyName;
        private ErrorProvider EPEmail;
        private ErrorProvider EPPassword;
        private ErrorProvider EPCity;
        private ErrorProvider EPCountry;
    }
}