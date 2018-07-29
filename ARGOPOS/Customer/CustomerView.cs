using ARGOPOS.Customer.DatabaseRepositery;
using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ARGOPOS.Customer
{
    public partial class CustomerView : Form
    {
        int customerid = 0;
        CustomerRepo customerRepo;
        bool cusoder = true;

        public CustomerView()
        {
            InitializeComponent();
            customerRepo = new CustomerRepo();
            loadDatagrid();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string address = textBoxAddres.Text;
            int contact =int.Parse(textBoxContact.Text);
            decimal cusloyltypoint = decimal.Parse(textBoxLoyalty.Text);

            pos_customer customer = new pos_customer
            {
                id = customerid,
                customeraddrees = address,
                customername = name,
                customercontact = contact,
                loyaltypoint = cusloyltypoint,

            };

            RepositeryResponce repositeryResponce = customerRepo.Save(customer);
         if (repositeryResponce.sucsess)
            {
                loadDatagrid();
                Reset();
                ShowMessageSucsess(repositeryResponce.message);
            }
            else
            {
                ShowMessageError(repositeryResponce.message);

            }



        }

        private void loadDatagrid()
        {
            dataGridViewCustomer.DataSource = customerRepo.getList();
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

        public void Reset()
        {
            textBoxName.Clear();
            textBoxAddres.Clear();
            textBoxContact.Clear();
            textBoxLoyalty.Clear();
            customerid = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RepositeryResponce repositeryResponce = customerRepo.Remove(customerid);
            if (repositeryResponce.sucsess)
            {
                loadDatagrid();
                Reset();
                ShowMessageSucsess(repositeryResponce.message);
            }
            else
            {
                ShowMessageError(repositeryResponce.message);

            }
        }

        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.SelectedCells.Count > 0)
            {
                var result = dataGridViewCustomer.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewCustomer.Rows[result];

                int value = (int)selectedRow.Cells[0].Value;
                fillData(value);

            }
        }

        private void fillData(int value)
        {
             pos_customer customer = customerRepo.findbyId(value);

            textBoxName.Text = customer.customername;
            textBoxAddres.Text = customer.customeraddrees;
            textBoxContact.Text = customer.customercontact.ToString();
            textBoxLoyalty.Text = customer.loyaltypoint.ToString();
            customerid = customer.id;
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewCustomer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           int index = e.ColumnIndex;

            if (index == 4)
            {
                dataGridViewCustomer.DataSource = customerRepo.getSourtby(cusoder);
                cusoder = !cusoder;
            }
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            var text = textBoxsearch.Text;
            dataGridViewCustomer.DataSource = customerRepo.getList().Where(customer =>
            customer.customername.StartsWith(text, StringComparison.OrdinalIgnoreCase)
            || customer.customeraddrees.StartsWith(text, StringComparison.OrdinalIgnoreCase)
            || customer.customercontact.ToString().StartsWith(text, StringComparison.OrdinalIgnoreCase)
            || customer.loyaltypoint.ToString().StartsWith(text, StringComparison.OrdinalIgnoreCase)
            ).ToList(); 
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxAddres_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxAddres_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxContact_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxContact_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxLoyalty_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxLoyalty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
