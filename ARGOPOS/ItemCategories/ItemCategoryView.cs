using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;

using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ARGOPOS.ItemCategories
{
    public partial class ItemCategoryView : Form , IDialogBox
    {
        ItemCategoryRepo itemCategoryRepo;
        int catogoryid = 0;
        public ItemCategoryView()
        {
            InitializeComponent();
            catogoryid = 0;
        }

        private void ItemCategoryView_Load(object sender, EventArgs e)
        {
            itemCategoryRepo = new ItemCategoryRepo();
            loadDatagrid();
        }

        private void loadDatagrid()
        {

            dataGridViewItemcat.DataSource = itemCategoryRepo.GetList();
        }









#region vlidating
private void textBoxitemCatogory_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxitemCatogory.Text != null && !textBoxitemCatogory.Text.Equals(""))
            {

                e.Cancel = false;
            }
            else
            {
                errorProviderItemCatogory.SetError(textBoxitemCatogory, "catogory name canot be empty");
                e.Cancel = true;
              
            }
        }

        private void textBoxitemCatogory_Validated(object sender, EventArgs e)
        {
            this.errorProviderItemCatogory.SetError(textBoxitemCatogory,string.Empty);
        }

        #endregion  validating 

        #region message box
        public void ShowMessageSucsess(string message)
        {
            MessageBox.Show(message, "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowMessageError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string catogoryname = textBoxitemCatogory.Text;
            RepositeryResponce responce = itemCategoryRepo.Save(new pos_itemcategory {id= catogoryid, category = catogoryname });

            if (responce.sucsess)
            {
                loadDatagrid();
                ShowMessageSucsess(responce.message);
            }
            else
            {
                ShowMessageError(responce.message);

            }
        }

        private void dataGridViewItemcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewItemcat_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewItemcat.SelectedCells.Count > 0)
            {
                var result = dataGridViewItemcat.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewItemcat.Rows[result];

                int value = (int)selectedRow.Cells[0].Value;
                string catogrory = (string)selectedRow.Cells[1].Value;

                catogoryid = value;
                textBoxitemCatogory.Text = catogrory;


            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            catogoryid = 0;
            textBoxitemCatogory.Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text;
            dataGridViewItemcat.DataSource = itemCategoryRepo.GetList().Where(
                catogary => catogary.category.StartsWith(text, StringComparison.OrdinalIgnoreCase)
                ).ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
          RepositeryResponce responce =  itemCategoryRepo.remove(catogoryid);

            if (responce.sucsess)
            {
                textBoxitemCatogory.Clear();
                loadDatagrid();
                ShowMessageSucsess(responce.message);
            }
            else
            {

                ShowMessageError(responce.message);
            }
        }
    }
}
