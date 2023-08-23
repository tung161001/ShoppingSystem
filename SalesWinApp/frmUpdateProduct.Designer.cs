namespace SalesWinApp
{
    partial class frmUpdateProduct
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbUnitsInStock = new System.Windows.Forms.TextBox();
            this.lbInStock = new System.Windows.Forms.Label();
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
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(150, 160);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(257, 28);
            this.cbCategory.TabIndex = 60;
            // 
            // tbUnitsInStock
            // 
            this.tbUnitsInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUnitsInStock.Location = new System.Drawing.Point(150, 306);
            this.tbUnitsInStock.Name = "tbUnitsInStock";
            this.tbUnitsInStock.Size = new System.Drawing.Size(257, 27);
            this.tbUnitsInStock.TabIndex = 55;
            this.tbUnitsInStock.Validating += new System.ComponentModel.CancelEventHandler(this.tbUnitsInStock_Validating);
            // 
            // lbInStock
            // 
            this.lbInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInStock.AutoSize = true;
            this.lbInStock.Location = new System.Drawing.Point(43, 309);
            this.lbInStock.Name = "lbInStock";
            this.lbInStock.Size = new System.Drawing.Size(92, 20);
            this.lbInStock.TabIndex = 58;
            this.lbInStock.Text = "Unit In Stock";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(150, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "Update Product";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(260, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(106, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUnitPrice.Location = new System.Drawing.Point(150, 256);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(257, 27);
            this.tbUnitPrice.TabIndex = 54;
            this.tbUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbUnitPrice_Validating);
            // 
            // tbProductWeight
            // 
            this.tbProductWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductWeight.Location = new System.Drawing.Point(150, 207);
            this.tbProductWeight.Name = "tbProductWeight";
            this.tbProductWeight.Size = new System.Drawing.Size(257, 27);
            this.tbProductWeight.TabIndex = 53;
            this.tbProductWeight.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductWeight_Validating);
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductName.Location = new System.Drawing.Point(150, 112);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(257, 27);
            this.tbProductName.TabIndex = 52;
            this.tbProductName.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductName_Validating);
            // 
            // tbProductID
            // 
            this.tbProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductID.Location = new System.Drawing.Point(150, 68);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(257, 27);
            this.tbProductID.TabIndex = 51;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(43, 259);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 50;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbProductWeight
            // 
            this.lbProductWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductWeight.AutoSize = true;
            this.lbProductWeight.Location = new System.Drawing.Point(43, 210);
            this.lbProductWeight.Name = "lbProductWeight";
            this.lbProductWeight.Size = new System.Drawing.Size(56, 20);
            this.lbProductWeight.TabIndex = 49;
            this.lbProductWeight.Text = "Weight";
            // 
            // lbProductCategory
            // 
            this.lbProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductCategory.AutoSize = true;
            this.lbProductCategory.Location = new System.Drawing.Point(43, 163);
            this.lbProductCategory.Name = "lbProductCategory";
            this.lbProductCategory.Size = new System.Drawing.Size(69, 20);
            this.lbProductCategory.TabIndex = 48;
            this.lbProductCategory.Text = "Category";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(43, 115);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 20);
            this.labelProductName.TabIndex = 47;
            this.labelProductName.Text = "Name";
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(43, 71);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(24, 20);
            this.lbProductName.TabIndex = 46;
            this.lbProductName.Text = "ID";
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
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 410);
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
            this.MaximizeBox = false;
            this.Name = "frmUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateProduct";
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCategory;
        private TextBox tbUnitsInStock;
        private Label lbInStock;
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
        private ErrorProvider errorProviderID;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderWeight;
        private ErrorProvider errorProviderPrice;
        private ErrorProvider errorProviderInStock;
    }
}