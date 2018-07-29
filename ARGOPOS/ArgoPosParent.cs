using ARGOPOS.Customer;
using ARGOPOS.Grn;
using ARGOPOS.Item;
using ARGOPOS.ItemCategories;
using ARGOPOS.Login;
using ARGOPOS.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARGOPOS
{
    public partial class ArgoPosParent : Form
    {
        private int childFormNumber = 0;

        public ArgoPosParent()
        {
            InitializeComponent();
           
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.MdiParent = this;
            customerView.Show();
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            ItemCategoryView itemCategoryView = new ItemCategoryView();
            itemCategoryView.MdiParent = this;
            itemCategoryView.Show();
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrnView itemView = new GrnView();
            itemView.MdiParent = this;
            itemView.Show();
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = saveFileDialog.FileName;
            //}
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report itemView = new Report();
            itemView.MdiParent = this;
            itemView.Show();
        }

        private void itemCatogoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemCategoryView itemCategoryView = new ItemCategoryView();
            itemCategoryView.MdiParent = this;
            itemCategoryView.Show();

        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemView itemView = new ItemView();
            itemView.MdiParent = this;
            itemView.Show();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void grnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrnView itemView = new GrnView();
            itemView.MdiParent = this;
            itemView.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.MdiParent = this;
            customerView.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemView unitView = new ItemView();
            unitView.MdiParent = this;
            unitView.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ArgoPosParent_Load(object sender, EventArgs e)
        {

        }
    }
}
