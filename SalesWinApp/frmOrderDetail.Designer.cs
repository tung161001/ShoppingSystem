namespace SalesWinApp
{
    partial class frmOrderDetail
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
            this.lbOrderDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderedDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbMemberEmail = new System.Windows.Forms.Label();
            this.lbOrdDateText = new System.Windows.Forms.Label();
            this.lbReqDateText = new System.Windows.Forms.Label();
            this.lbShipDateText = new System.Windows.Forms.Label();
            this.dgvDetailsList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderDetail
            // 
            this.lbOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOrderDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderDetail.Location = new System.Drawing.Point(158, 12);
            this.lbOrderDetail.Name = "lbOrderDetail";
            this.lbOrderDetail.Size = new System.Drawing.Size(598, 40);
            this.lbOrderDetail.TabIndex = 0;
            this.lbOrderDetail.Text = "Order Detail";
            this.lbOrderDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordered by: ";
            // 
            // lbOrderedDate
            // 
            this.lbOrderedDate.AutoSize = true;
            this.lbOrderedDate.Location = new System.Drawing.Point(224, 115);
            this.lbOrderedDate.Name = "lbOrderedDate";
            this.lbOrderedDate.Size = new System.Drawing.Size(101, 20);
            this.lbOrderedDate.TabIndex = 2;
            this.lbOrderedDate.Text = "Ordered date:";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(489, 73);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(106, 20);
            this.lbRequiredDate.TabIndex = 3;
            this.lbRequiredDate.Text = "Required date:";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(489, 115);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(101, 20);
            this.lbShippedDate.TabIndex = 3;
            this.lbShippedDate.Text = "Shipped date:";
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Location = new System.Drawing.Point(321, 73);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(105, 20);
            this.lbMemberEmail.TabIndex = 4;
            this.lbMemberEmail.Text = "memberName";
            // 
            // lbOrdDateText
            // 
            this.lbOrdDateText.AutoSize = true;
            this.lbOrdDateText.Location = new System.Drawing.Point(321, 115);
            this.lbOrdDateText.Name = "lbOrdDateText";
            this.lbOrdDateText.Size = new System.Drawing.Size(97, 20);
            this.lbOrdDateText.TabIndex = 5;
            this.lbOrdDateText.Text = "dd/MM/YYYY";
            // 
            // lbReqDateText
            // 
            this.lbReqDateText.AutoSize = true;
            this.lbReqDateText.Location = new System.Drawing.Point(591, 73);
            this.lbReqDateText.Name = "lbReqDateText";
            this.lbReqDateText.Size = new System.Drawing.Size(97, 20);
            this.lbReqDateText.TabIndex = 5;
            this.lbReqDateText.Text = "dd/MM/YYYY";
            // 
            // lbShipDateText
            // 
            this.lbShipDateText.AutoSize = true;
            this.lbShipDateText.Location = new System.Drawing.Point(591, 115);
            this.lbShipDateText.Name = "lbShipDateText";
            this.lbShipDateText.Size = new System.Drawing.Size(97, 20);
            this.lbShipDateText.TabIndex = 5;
            this.lbShipDateText.Text = "dd/MM/YYYY";
            // 
            // dgvDetailsList
            // 
            this.dgvDetailsList.AllowUserToAddRows = false;
            this.dgvDetailsList.AllowUserToDeleteRows = false;
            this.dgvDetailsList.AllowUserToOrderColumns = true;
            this.dgvDetailsList.AllowUserToResizeColumns = false;
            this.dgvDetailsList.AllowUserToResizeRows = false;
            this.dgvDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetailsList.Enabled = false;
            this.dgvDetailsList.Location = new System.Drawing.Point(14, 155);
            this.dgvDetailsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetailsList.MultiSelect = false;
            this.dgvDetailsList.Name = "dgvDetailsList";
            this.dgvDetailsList.ReadOnly = true;
            this.dgvDetailsList.RowHeadersVisible = false;
            this.dgvDetailsList.RowHeadersWidth = 51;
            this.dgvDetailsList.RowTemplate.Height = 25;
            this.dgvDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsList.Size = new System.Drawing.Size(886, 355);
            this.dgvDetailsList.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(806, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 525);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDetailsList);
            this.Controls.Add(this.lbShipDateText);
            this.Controls.Add(this.lbReqDateText);
            this.Controls.Add(this.lbOrdDateText);
            this.Controls.Add(this.lbMemberEmail);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOrderDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderDetail;
        private Label label1;
        private Label lbOrderedDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private Label lbMemberEmail;
        private Label lbOrdDateText;
        private Label lbReqDateText;
        private Label lbShipDateText;
        private DataGridView dgvDetailsList;
        private Button btnClose;
    }
}