namespace ARGOPOS.Grn
{
    partial class GrnView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxGrnNum = new System.Windows.Forms.TextBox();
            this.dateTimePickerGrn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSuplier = new System.Windows.Forms.ComboBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewGrn = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInsertItem = new System.Windows.Forms.Button();
            this.buttonSaveItems = new System.Windows.Forms.Button();
            this.grnItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posgrnitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvidergrn = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnItemDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posgrnitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidergrn)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGrnNum
            // 
            this.textBoxGrnNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxGrnNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxGrnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrnNum.Location = new System.Drawing.Point(88, 21);
            this.textBoxGrnNum.Name = "textBoxGrnNum";
            this.textBoxGrnNum.Size = new System.Drawing.Size(115, 26);
            this.textBoxGrnNum.TabIndex = 0;
            this.textBoxGrnNum.TextChanged += new System.EventHandler(this.textBoxGrnNum_TextChanged);
            this.textBoxGrnNum.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxGrnNum_Validating);
            this.textBoxGrnNum.Validated += new System.EventHandler(this.textBoxGrnNum_Validated);
            // 
            // dateTimePickerGrn
            // 
            this.dateTimePickerGrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerGrn.Location = new System.Drawing.Point(88, 62);
            this.dateTimePickerGrn.Name = "dateTimePickerGrn";
            this.dateTimePickerGrn.Size = new System.Drawing.Size(231, 26);
            this.dateTimePickerGrn.TabIndex = 1;
            // 
            // comboBoxSuplier
            // 
            this.comboBoxSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSuplier.FormattingEnabled = true;
            this.comboBoxSuplier.Location = new System.Drawing.Point(503, 19);
            this.comboBoxSuplier.Name = "comboBoxSuplier";
            this.comboBoxSuplier.Size = new System.Drawing.Size(137, 28);
            this.comboBoxSuplier.TabIndex = 3;
            // 
            // textBoxQty
            // 
            this.textBoxQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQty.Location = new System.Drawing.Point(88, 177);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(231, 29);
            this.textBoxQty.TabIndex = 8;
            this.textBoxQty.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxQty_Validating);
            this.textBoxQty.Validated += new System.EventHandler(this.textBoxQty_Validated);
            // 
            // buttonsave
            // 
            this.buttonsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsave.Location = new System.Drawing.Point(519, 83);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(121, 43);
            this.buttonsave.TabIndex = 9;
            this.buttonsave.Text = "SaveGrn";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "GrnNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Supliyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(88, 117);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(121, 28);
            this.comboBoxItem.TabIndex = 13;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.Location = new System.Drawing.Point(88, 239);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(137, 29);
            this.textBoxCost.TabIndex = 14;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
            this.textBoxCost.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCost_Validating);
            this.textBoxCost.Validated += new System.EventHandler(this.textBoxCost_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cost";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridViewGrn
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewGrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnQty,
            this.ColumnCost});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGrn.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewGrn.Location = new System.Drawing.Point(88, 300);
            this.dataGridViewGrn.Name = "dataGridViewGrn";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrn.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewGrn.Size = new System.Drawing.Size(552, 232);
            this.dataGridViewGrn.TabIndex = 18;
            // 
            // ColumnId
            // 
            this.ColumnId.FillWeight = 150F;
            this.ColumnId.HeaderText = "ItemId";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 150;
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 150F;
            this.ColumnName.HeaderText = "Item";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnQty
            // 
            this.ColumnQty.FillWeight = 150F;
            this.ColumnQty.HeaderText = "Quantity";
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.Width = 150;
            // 
            // ColumnCost
            // 
            this.ColumnCost.FillWeight = 125F;
            this.ColumnCost.HeaderText = "Cost";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.Width = 125;
            // 
            // buttonInsertItem
            // 
            this.buttonInsertItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertItem.Location = new System.Drawing.Point(519, 191);
            this.buttonInsertItem.Name = "buttonInsertItem";
            this.buttonInsertItem.Size = new System.Drawing.Size(121, 43);
            this.buttonInsertItem.TabIndex = 20;
            this.buttonInsertItem.TabStop = false;
            this.buttonInsertItem.Text = "InsertItem";
            this.buttonInsertItem.UseVisualStyleBackColor = true;
            this.buttonInsertItem.Click += new System.EventHandler(this.buttonInsertItem_Click);
            // 
            // buttonSaveItems
            // 
            this.buttonSaveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveItems.Location = new System.Drawing.Point(519, 562);
            this.buttonSaveItems.Name = "buttonSaveItems";
            this.buttonSaveItems.Size = new System.Drawing.Size(121, 43);
            this.buttonSaveItems.TabIndex = 21;
            this.buttonSaveItems.TabStop = false;
            this.buttonSaveItems.Text = "SaveItems";
            this.buttonSaveItems.UseVisualStyleBackColor = true;
            this.buttonSaveItems.Click += new System.EventHandler(this.buttonSaveItems_Click);
            // 
            // grnItemDtoBindingSource
            // 
            this.grnItemDtoBindingSource.DataSource = typeof(ARGOPOS.Grn.Model.GrnItemDto);
            // 
            // posgrnitemBindingSource
            // 
            this.posgrnitemBindingSource.DataSource = typeof(ARGOPOS.pos_grnitem);
            // 
            // errorProvidergrn
            // 
            this.errorProvidergrn.ContainerControl = this;
            // 
            // GrnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 617);
            this.Controls.Add(this.buttonSaveItems);
            this.Controls.Add(this.buttonInsertItem);
            this.Controls.Add(this.dataGridViewGrn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.comboBoxSuplier);
            this.Controls.Add(this.dateTimePickerGrn);
            this.Controls.Add(this.textBoxGrnNum);
            this.Name = "GrnView";
            this.Text = "GrnView";
            this.Load += new System.EventHandler(this.GrnView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnItemDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posgrnitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidergrn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGrnNum;
        private System.Windows.Forms.DateTimePicker dateTimePickerGrn;
        private System.Windows.Forms.ComboBox comboBoxSuplier;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource posgrnitemBindingSource;
        private System.Windows.Forms.BindingSource grnItemDtoBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewGrn;
        private System.Windows.Forms.Button buttonInsertItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.Button buttonSaveItems;
        private System.Windows.Forms.ErrorProvider errorProvidergrn;
    }
}