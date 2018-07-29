using ARGOPOS.Unit.DatabaseRepositery;
using ARGOPOS.Unit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARGOPOS.Unit
{
    public partial class UnitView : Form , IDialogBox
    {
        private UnitRepo unitRepo = new UnitRepo();
        private Control control;
        private List<UnitDto> unitDtosList = new List<UnitDto>();
        public UnitView()
        {
            ResXResourceSet resxSet = new ResXResourceSet(@".\Localisation\Eng.resx");
            InitializeComponent();
            this.Text = resxSet.GetString("Unit");
            this.lblUnit.Text = resxSet.GetString("Unit");
            this.lblUnitName.Text = resxSet.GetString("UnitName");
            this.btnSaveUnit.Text = resxSet.GetString("Save");
            unitDtosList = unitRepo.GetList();

        }

        private void Unit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = unitDtosList;
            ArgoPosEntities dbentities = new ArgoPosEntities();
            dataGridView1.DataSource = dbentities.pos_unit.ToList();
        }



        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            UnitDto unitdto = new UnitDto();
            unitdto.posunitname = txtUnitName.Text;
            unitdto.posunit = txtUnit.Text;
            string message =  unitRepo.SaveUnit(unitdto);
            this.ShowMessageSucsess(message);
        }

      

        #region validation

        private void txtUnitName_Validated(object sender, EventArgs e)
        {
            this.unitnameErrorProvidor.SetError(txtUnitName, string.Empty);
        }

        private void txtUnitName_Validating(object sender, CancelEventArgs e)
        {
            // chaeack wether valid or invalida name 
            if (CustomeValidator.IsvalidName(txtUnitName.Text))
            {
                e.Cancel = false;
            }
            else
            {
                this.unitnameErrorProvidor.SetError(txtUnitName, "Enter valida name");
                e.Cancel = true;
                control = txtUnitName;
            }

        }

        private void txtUnit_Validated(object sender, EventArgs e)
        {
            this.unitnameErrorProvidor.SetError(txtUnit, string.Empty);
        }

        private void txtUnit_Validating(object sender, CancelEventArgs e)
        {
            // chaeack wether valid or invalida name 
            if (CustomeValidator.IsvalidName(txtUnit.Text))
            {
                e.Cancel = false;
            }
            else
            {
                this.unitnameErrorProvidor.SetError(txtUnit, "Enter valida Unit");
                e.Cancel = true;
                control = txtUnitName;
            }
        }

        #endregion



        private void UnitView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                var result = MessageBox.Show("ARE YOU SURE", "Error", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == result)
                {
                   
                }
                else if (DialogResult.No == result)
                {
                    e.Cancel = true;

                }
            }
            else
            {

                control.CausesValidation = false;
                this.Dispose();
               
            }
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var result = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[result];

                var value = selectedRow.Cells[0].Value;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = unitDtosList.Where(unit =>

                unit.posunit.StartsWith(txtsearch.Text, StringComparison.OrdinalIgnoreCase) ||
                unit.posunitname.StartsWith(txtsearch.Text, StringComparison.OrdinalIgnoreCase)

            ).ToList();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];

            dataGridView1.Sort(column, ListSortDirection.Ascending);
        }
    }
    
}

