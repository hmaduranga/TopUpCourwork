namespace ARGOPOS.Unit
{
    partial class UnitView
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
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnSaveUnit = new System.Windows.Forms.Button();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitnameErrorProvidor = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.unitDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitnameErrorProvidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(65, 36);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(46, 17);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "label1";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(65, 91);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(46, 17);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "label1";
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveUnit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveUnit.Location = new System.Drawing.Point(68, 204);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(82, 40);
            this.btnSaveUnit.TabIndex = 2;
            this.btnSaveUnit.Text = "button1";
            this.btnSaveUnit.UseVisualStyleBackColor = false;
            this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(186, 36);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(204, 20);
            this.txtUnitName.TabIndex = 3;
            this.txtUnitName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitName_Validating);
            this.txtUnitName.Validated += new System.EventHandler(this.txtUnitName_Validated);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(186, 88);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(204, 20);
            this.txtUnit.TabIndex = 4;
            this.txtUnit.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnit_Validating);
            this.txtUnit.Validated += new System.EventHandler(this.txtUnit_Validated);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.idDataGridViewTextBoxColumn,
            this.unit,
            this.name});
            this.dataGridView1.DataSource = this.posunitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(186, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 166);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "unit";
            this.unit.Name = "unit";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // posunitBindingSource
            // 
            this.posunitBindingSource.DataSource = typeof(ARGOPOS.pos_unit);
            // 
            // unitnameErrorProvidor
            // 
            this.unitnameErrorProvidor.ContainerControl = this;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(439, 233);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(197, 20);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // unitDtoBindingSource
            // 
            this.unitDtoBindingSource.DataSource = typeof(ARGOPOS.Unit.Model.UnitDto);
            // 
            // unitDtoBindingSource1
            // 
            this.unitDtoBindingSource1.DataSource = typeof(ARGOPOS.Unit.Model.UnitDto);
            // 
            // UnitView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 610);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.btnSaveUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblUnitName);
            this.Name = "UnitView";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnitView_FormClosing);
            this.Load += new System.EventHandler(this.Unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posunitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitnameErrorProvidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDtoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnSaveUnit;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource unitDtoBindingSource;
        private System.Windows.Forms.ErrorProvider unitnameErrorProvidor;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.BindingSource posunitBindingSource;
        private System.Windows.Forms.BindingSource unitDtoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

