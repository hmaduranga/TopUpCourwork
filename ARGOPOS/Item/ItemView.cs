using ARGOPOS.Unit.DatabaseRepositery;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using ARGOPOS.ItemCategories.DatabaseRepositery;
using ARGOPOS.Item.DatabaseRepositery;
using System.Linq;

namespace ARGOPOS.Item
{
    public partial class ItemView : Form , IDialogBox
    {
        ArgoPosEntities dbentities;
        ItemRepo itemRepo;
        int itemid = 0;

        public ItemView()
        {
            InitializeComponent();
            itemid = 0;
        }

        private void ItemView_Load(object sender, EventArgs e)
        {

            dbentities = new ArgoPosEntities();
            itemRepo = new ItemRepo();
            // dataGridViewItem.DataSource = itemRepo.GetDisplayList();
            loadGrid();
            loadItemCatogory();
            loadUnit();
            
        }

        private void comboBoxUnit_Validated(object sender, EventArgs e)
        {

        }

        private void comboBoxUnit_Validating(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadUnit()
        {

            UnitRepo unitrepo = new UnitRepo();
            comboBoxUnit.DataSource = unitrepo.GetList();
            comboBoxUnit.DisplayMember = "posunit";
            comboBoxUnit.ValueMember = "id";
        }

        private void loadItemCatogory()
        {
            ItemCategoryRepo itemCategoryRepo = new ItemCategoryRepo();
            comboBoxCatagory.DataSource = itemCategoryRepo.GetList();
            comboBoxCatagory.DisplayMember = "category";
            comboBoxCatagory.ValueMember = "id";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        #region Validating
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text != null && !textBoxName.Text.Equals(""))
            {

                e.Cancel = false;
            }
            else
            {
                errorProviderItemName.SetError(textBoxName, "item name name canot be empty");
                e.Cancel = true;

            }
        }

       

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProviderItemName.SetError(textBoxName, string.Empty);
        }
       

        private void textBoxDiscription_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDiscription.Text != null && !textBoxDiscription.Text.Equals(""))
            {

                e.Cancel = false;
            }
            else
            {
                errorProviderItemName.SetError(textBoxDiscription, "item discription canot be empty");
                e.Cancel = true;

            }
        }

       

        private void textBoxDiscription_Validated(object sender, EventArgs e)
        {
            errorProviderItemName.SetError(textBoxDiscription, string.Empty);
        }

        #endregion validating

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int itemunit = (int)comboBoxUnit.SelectedValue;
            int catogory = (int)comboBoxCatagory.SelectedValue;
            string name = textBoxName.Text;
            string discription = textBoxDiscription.Text;

            RepositeryResponce repositeryResponce = itemRepo.Save(new pos_item
            {
                id = itemid,
                itemcategory = catogory,
                itemname = name,
                unit = itemunit,
                discreption = discription,
            });

            if (repositeryResponce.sucsess)
            {
                loadGrid();
                ShowMessageSucsess(repositeryResponce.message);
            }
            else
            {
                ShowMessageError(repositeryResponce.message);
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridViewItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewItem.SelectedCells.Count > 0)
            {
                var result = dataGridViewItem.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewItem.Rows[result];

                 int value = (int)selectedRow.Cells[0].Value;
                fillData(value);

            }
        }


        private void  fillData(int id)
        {
           pos_item item = itemRepo.getByItemId(id);

            comboBoxCatagory.SelectedValue = item.itemcategory;
            comboBoxUnit.SelectedValue = item.unit;
            textBoxName.Text = item.itemname;
            textBoxDiscription.Text = item.discreption;
            itemid = item.id;
        }


        private void loadGrid()
        {

            dataGridViewItem.DataSource = itemRepo.GetDisplayList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (itemid > 0)
            {
                var result = MessageBox.Show("ARE YOU SURE", "Error", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == result)
                {
                   RepositeryResponce responce = itemRepo.Remove(itemid);
                    if(responce.sucsess){
                        ShowMessageSucsess(responce.message);
                        reset();
                        loadGrid();

                    }
                    else
                    {
                        ShowMessageError(responce.message);
                    }
                   
                }
                else if (DialogResult.No == result)
                {


                }
            }
        }


        private void reset()
        {

            comboBoxCatagory.SelectedIndex = 0;
            comboBoxUnit.SelectedIndex = 0;
            textBoxName.ResetText();
            textBoxName.Focus();
            textBoxDiscription.ResetText();
            itemid = 0;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string curent = textBoxSearch.Text;
            dataGridViewItem.DataSource = itemRepo.GetDisplayList().Where(
                item =>
                 item.itemcatogory.StartsWith(curent, StringComparison.OrdinalIgnoreCase) ||
                 item.positemname.StartsWith(curent, StringComparison.OrdinalIgnoreCase)
                ).ToList();
        }
    }
}
