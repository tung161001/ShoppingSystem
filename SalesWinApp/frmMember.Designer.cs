namespace SalesWinApp
{
    partial class frmMember
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
            this.dgvMemberManagement = new System.Windows.Forms.DataGridView();
            this.lbMemberManagement = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilterCity = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterCountry = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberManagement)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemberManagement
            // 
            this.dgvMemberManagement.AllowUserToAddRows = false;
            this.dgvMemberManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemberManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberManagement.Location = new System.Drawing.Point(11, 125);
            this.dgvMemberManagement.MultiSelect = false;
            this.dgvMemberManagement.Name = "dgvMemberManagement";
            this.dgvMemberManagement.ReadOnly = true;
            this.dgvMemberManagement.RowHeadersWidth = 51;
            this.dgvMemberManagement.RowTemplate.Height = 29;
            this.dgvMemberManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberManagement.Size = new System.Drawing.Size(776, 201);
            this.dgvMemberManagement.TabIndex = 0;
            this.dgvMemberManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberManagement_CellClick);
            // 
            // lbMemberManagement
            // 
            this.lbMemberManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemberManagement.AutoSize = true;
            this.lbMemberManagement.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMemberManagement.Location = new System.Drawing.Point(260, 20);
            this.lbMemberManagement.Name = "lbMemberManagement";
            this.lbMemberManagement.Size = new System.Drawing.Size(283, 31);
            this.lbMemberManagement.TabIndex = 1;
            this.lbMemberManagement.Text = "MEMBER MANAGEMENT";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.Location = new System.Drawing.Point(279, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(540, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogOut.Location = new System.Drawing.Point(359, 56);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoad.Location = new System.Drawing.Point(152, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Location = new System.Drawing.Point(575, 80);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(182, 27);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Search:";
            // 
            // cbFilterCity
            // 
            this.cbFilterCity.AllowDrop = true;
            this.cbFilterCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFilterCity.FormattingEnabled = true;
            this.cbFilterCity.Items.AddRange(new object[] {
            "--City--"});
            this.cbFilterCity.Location = new System.Drawing.Point(96, 77);
            this.cbFilterCity.Name = "cbFilterCity";
            this.cbFilterCity.Size = new System.Drawing.Size(115, 28);
            this.cbFilterCity.TabIndex = 9;
            this.cbFilterCity.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Location = new System.Drawing.Point(416, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter:";
            // 
            // cbFilterCountry
            // 
            this.cbFilterCountry.AllowDrop = true;
            this.cbFilterCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFilterCountry.FormattingEnabled = true;
            this.cbFilterCountry.Items.AddRange(new object[] {
            "--Country--"});
            this.cbFilterCountry.Location = new System.Drawing.Point(217, 77);
            this.cbFilterCountry.Name = "cbFilterCountry";
            this.cbFilterCountry.Size = new System.Drawing.Size(123, 28);
            this.cbFilterCountry.TabIndex = 13;
            this.cbFilterCountry.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 15;
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbFilterCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbMemberManagement);
            this.Controls.Add(this.dgvMemberManagement);
            this.Name = "frmMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMemberManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberManagement)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMemberManagement;
        private Label lbMemberManagement;
        private Button btnNew;
        private Button btnDelete;
        private Button btnLogOut;
        private Button btnLoad;
        private TextBox tbSearch;
        private Label label7;
        private ComboBox cbFilterCity;
        private Button btnUpdate;
        private Label label1;
        private ComboBox cbFilterCountry;
        private Panel panel1;
    }
}