using ARGOPOS.Grn.DatabaseRepositery;
using ARGOPOS.Grn.Model;
using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARGOPOS.Grn
{
    public partial class GrnView : Form
    {
        GrnHeaderRepo grnHeaderRepo;
        GrnItemRepo grnItemRepo;
        int grnid;
        List<GrnItemDto> itemlist = new List<GrnItemDto>();
        public GrnView()
        {
            InitializeComponent();
            grnHeaderRepo = new GrnHeaderRepo();
            grnItemRepo = new GrnItemRepo();
            List<string> autocompleate = grnHeaderRepo.getGrnNumberList();
            var source = new AutoCompleteStringCollection();
            source.AddRange(autocompleate.ToArray());
            textBoxGrnNum.AutoCompleteCustomSource = source;
            loaditems();
            loadSuplliers();
        

        }

        private void buttonsave_Click(object sender, EventArgs e)
        { 
            string grnnumber = textBoxGrnNum.Text;
            int supplyier = (int)comboBoxSuplier.SelectedValue;
            DateTime dateTime = dateTimePickerGrn.Value;

            pos_grnheader grnheader = new pos_grnheader
            {
                number = grnnumber,
                suplier = supplyier,
                time = dateTime,
                total = 10,

            };

            RepositeryResponce repositeryResponce = grnHeaderRepo.saveGrn(grnheader);

            if (repositeryResponce.sucsess)
            {
                ShowMessageSucsess(repositeryResponce.message);
                textBoxGrnNum.Enabled = false;
                comboBoxSuplier.Enabled = false;
                dateTimePickerGrn.Enabled = false;
               var idobject = repositeryResponce.data;
               grnid  = int.Parse(idobject.GetType().GetProperty("id").GetValue(idobject).ToString());

            }
            else
            {
                ShowMessageError(repositeryResponce.message);
            }
                
                }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GrnView_Load(object sender, EventArgs e)
        {

        }

        private void loaditems()
        {
            comboBoxItem.DataSource = grnHeaderRepo.getItemlistFroGrn();

            comboBoxItem.ValueMember = "id";
            comboBoxItem.DisplayMember = "itemname";

        }

        private void loadSuplliers()
        {
            comboBoxSuplier.DataSource = grnHeaderRepo.GetSuppliersForGrn();
            comboBoxSuplier.ValueMember = "id";
            comboBoxSuplier.DisplayMember = "suppliernmae";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
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

        private void loadDatagrid()
        {

   
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

  



        private bool ContainSameItemTowise(string name)
        {
            foreach(DataGridViewRow row in dataGridViewGrn.Rows)
            {
               
                if(row.Cells[1].Value != null && row.Cells[1].Value.Equals(name))
                {
                    return true;
                }

            }

            return false;
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertItem_Click(object sender, EventArgs e)
        {
            if (grnid > 0)
            {
                string grn = textBoxGrnNum.Text;
                int supllier = (int)comboBoxSuplier.SelectedValue;
                int itemid = (int)comboBoxItem.SelectedValue;
                decimal cost = decimal.Parse(textBoxCost.Text);
                decimal qty = decimal.Parse(textBoxQty.Text);
                string name = grnItemRepo.GetItemNameFromid(itemid);
                if (!ContainSameItemTowise(name))
                {
                    dataGridViewGrn.Rows.Add(itemid, name, qty, cost);
                }
                else
                {
                    ShowMessageError("please edit on inserted item");
                }

            }
            else
            {
                ShowMessageError("SaveGrnFrist");

            }
        }

        private void buttonSaveItems_Click(object sender, EventArgs e)
        {
        

            List<pos_grnitem> grnitems = new List<pos_grnitem>();
            foreach (DataGridViewRow row in dataGridViewGrn.Rows)
            {
                pos_grnitem grnitem = new pos_grnitem();
                if (row.Cells[0].Value != null || row.Cells[2].Value != null || row.Cells[3].Value != null)
                {
                    grnitem.itemid = (int)row.Cells[0].Value;
                    grnitem.itemquntity = (decimal)row.Cells[2].Value;
                    grnitem.itemcost = (decimal)row.Cells[3].Value;
                    grnitem.grnid = grnid;

                    grnitems.Add(grnitem);
                }
                else
                {
                 
                }


                
              
            }

            if (grnitems.Count > 0)
            {
                
            RepositeryResponce  responce =    grnItemRepo.SaveGrnItems(grnitems);

                if (responce.sucsess)
                {
                    ShowMessageSucsess(responce.message);

                }
                else
                {
                    ShowMessageError(responce.message);
                }

            }


        }

        private void textBoxGrnNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrnNum_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxGrnNum.Text != null && !textBoxGrnNum.Text.Equals(""))
            {

                e.Cancel = false;
            }
            else
            {
                errorProvidergrn.SetError(textBoxGrnNum, "canot be empty");
                e.Cancel = true;

            }
        }

        private void textBoxGrnNum_Validated(object sender, EventArgs e)
        {
            errorProvidergrn.SetError(textBoxGrnNum, string.Empty);
        }

        private void textBoxQty_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxQty.Text != null && !textBoxGrnNum.Text.Equals(""))
            {

                e.Cancel = false;
            }
            else
            {
                errorProvidergrn.SetError(textBoxQty, " canot be empty");
                e.Cancel = true;

            }
        }

        private void textBoxQty_Validated(object sender, EventArgs e)
        {
            errorProvidergrn.SetError(textBoxQty, string.Empty);
        }

        private void textBoxCost_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCost.Text != null && !textBoxCost.Text.Equals(""))
            {

                e.Cancel = false;
            }
            else
            {
                errorProvidergrn.SetError(textBoxCost, " canot be empty");
                e.Cancel = true;

            }
        }

        private void textBoxCost_Validated(object sender, EventArgs e)
        {
            errorProvidergrn.SetError(textBoxCost, string.Empty);
        }
    }
}
