using ARGOPOS.Customer.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARGOPOS.Customer
{
    public partial class Report : Form
    {
        CustomerRepo repo;
        public Report()
        {
            InitializeComponent();
            repo = new CustomerRepo();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pos_customerBindingSource.DataSource = repo.getList();
            this.reportViewer1.RefreshReport();
        }
    }
}
