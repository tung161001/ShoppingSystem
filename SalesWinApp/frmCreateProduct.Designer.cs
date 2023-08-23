namespace SalesWinApp
{
    partial class frmCreateProduct
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
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.tbProductWeight = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbProductWeight = new System.Windows.Forms.Label();
            this.lbProductCategory = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.tbUnitsInStock = new System.Windows.Forms.TextBox();
            this.lbInStock = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.errorProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInStock = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(146, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "Create Product";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(256, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(102, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUnitPrice.Location = new System.Drawing.Point(146, 257);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(257, 27);
            this.tbUnitPrice.TabIndex = 39;
            this.tbUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbUnitPrice_Validating);
            // 
            // tbProductWeight
            // 
            this.tbProductWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductWeight.Location = new System.Drawing.Point(146, 208);
            this.tbProductWeight.Name = "tbProductWeight";
            this.tbProductWeight.Size = new System.Drawing.Size(257, 27);
            this.tbProductWeight.TabIndex = 38;
            this.tbProductWeight.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductWeight_Validating);
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductName.Location = new System.Drawing.Point(146, 113);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(257, 27);
            this.tbProductName.TabIndex = 36;
            this.tbProductName.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductName_Validating);
            // 
            // tbProductID
            // 
            this.tbProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductID.Location = new System.Drawing.Point(146, 69);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(257, 27);
            this.tbProductID.TabIndex = 35;
            this.tbProductID.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductID_Validating);
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(39, 260);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 34;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbProductWeight
            // 
            this.lbProductWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductWeight.AutoSize = true;
            this.lbProductWeight.Location = new System.Drawing.Point(39, 211);
            this.lbProductWeight.Name = "lbProductWeight";
            this.lbProductWeight.Size = new System.Drawing.Size(56, 20);
            this.lbProductWeight.TabIndex = 33;
            this.lbProductWeight.Text = "Weight";
            // 
            // lbProductCategory
            // 
            this.lbProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductCategory.AutoSize = true;
            this.lbProductCategory.Location = new System.Drawing.Point(39, 164);
            this.lbProductCategory.Name = "lbProductCategory";
            this.lbProductCategory.Size = new System.Drawing.Size(69, 20);
            this.lbProductCategory.TabIndex = 32;
            this.lbProductCategory.Text = "Category";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(39, 116);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 20);
            this.labelProductName.TabIndex = 31;
            this.labelProductName.Text = "Name";
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(39, 72);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(24, 20);
            this.lbProductName.TabIndex = 30;
            this.lbProductName.Text = "ID";
            // 
            // tbUnitsInStock
            // 
            this.tbUnitsInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUnitsInStock.Location = new System.Drawing.Point(146, 307);
            this.tbUnitsInStock.Name = "tbUnitsInStock";
            this.tbUnitsInStock.Size = new System.Drawing.Size(257, 27);
            this.tbUnitsInStock.TabIndex = 40;
            this.tbUnitsInStock.Validating += new System.ComponentModel.CancelEventHandler(this.tbUnitsInStock_Validating);
            // 
            // lbInStock
            // 
            this.lbInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInStock.AutoSize = true;
            this.lbInStock.Location = new System.Drawing.Point(39, 310);
            this.lbInStock.Name = "lbInStock";
            this.lbInStock.Size = new System.Drawing.Size(92, 20);
            this.lbInStock.TabIndex = 43;
            this.lbInStock.Text = "Unit In Stock";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(146, 161);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(257, 28);
            this.cbCategory.TabIndex = 37;
            // 
            // errorProviderID
            // 
            this.errorProviderID.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderWeight
            // 
            this.errorProviderWeight.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // errorProviderInStock
            // 
            this.errorProviderInStock.ContainerControl = this;
            // 
            // frmCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 412);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbUnitsInStock);
            this.Controls.Add(this.lbInStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.tbProductWeight);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbProductWeight);
            this.Controls.Add(this.lbProductCategory);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.lbProductName);
            this.Name = "frmCreateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateProduct";
            this.Load += new System.EventHandler(this.frmCreateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbUnitPrice;
        private TextBox tbProductWeight;
        private TextBox tbProductName;
        private TextBox tbProductID;
        private Label lbUnitPrice;
        private Label lbProductWeight;
        private Label lbProductCategory;
        private Label labelProductName;
        private Label lbProductName;
        private TextBox tbUnitsInStock;
        private Label lbInStock;
        private ComboBox cbCategory;
        private ErrorProvider errorProviderID;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderWeight;
        private ErrorProvider errorProviderPrice;
        private ErrorProvider errorProviderInStock;
    }
}