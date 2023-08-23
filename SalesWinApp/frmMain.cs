namespace SalesWinApp
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            member.MdiParent = this;
            member.Show();

        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            member.MdiParent = this;
            member.Show();
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders order = new frmOrders();
            order.MdiParent = this;
            order.Show();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window ";
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                Form frm = ActiveMdiChild;
                TextBox textBox = frm.ActiveControl as TextBox;
                if (textBox.SelectedText != string.Empty)
                {
                    Clipboard.SetData(DataFormats.Text, textBox.SelectedText);
                }
                textBox.SelectedText = String.Empty;
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                Form frm = ActiveMdiChild;
                TextBox textBox = frm.ActiveControl as TextBox;
                if (textBox.SelectedText != string.Empty)
                {
                    Clipboard.SetData(DataFormats.Text, textBox.SelectedText);
                }
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                Form frm = ActiveMdiChild;
                int position = ((TextBox)frm.ActiveControl).SelectionStart;
                frm.ActiveControl.Text = frm.ActiveControl.Text.Insert(position, Clipboard.GetText());
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                Form frm = ActiveMdiChild;
                TextBox textBox = frm.ActiveControl as TextBox;
                if (textBox.Text != string.Empty)
                {
                    textBox.SelectAll();
                    Clipboard.SetData(DataFormats.Text, textBox.Text);
                }
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private bool exitConfirm()
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !exitConfirm();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();

        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();
        }

        private void memberManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            member.MdiParent = this;
            member.Show();

        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders order = new frmOrders();
            order.MdiParent = this;
            order.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exitConfirm())
            {
                this.Close();
            }
        }

    }
}
