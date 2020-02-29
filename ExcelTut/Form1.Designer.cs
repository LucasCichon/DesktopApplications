using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTut
{

    public partial class Form1
    {
        // <summary>
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.TextBox_Path = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            //this.identityUserDataSet = new ExcelTut.IdentityUserDataSet();
            this.identityUserDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identityUserDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.excelApplicationDataSet = new ExcelTut.ExcelApplicationDataSet();
            this.excelApplicationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excelApplicationDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.excelApplicationDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.excelApplicationDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.excelDataSet = new ExcelTut.ExcelDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new ExcelTut.ExcelDataSetTableAdapters.CustomersTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExportSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.identityUserDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identityUserDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identityUserDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.customersBindingSource;
            this.dgvList.Location = new System.Drawing.Point(25, 142);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(861, 458);
            this.dgvList.TabIndex = 0;
            // 
            // TextBox_Path
            // 
            this.TextBox_Path.Location = new System.Drawing.Point(119, 35);
            this.TextBox_Path.Name = "TextBox_Path";
            this.TextBox_Path.Size = new System.Drawing.Size(177, 20);
            this.TextBox_Path.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(25, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Chose File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(119, 73);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.Size = new System.Drawing.Size(177, 21);
            this.comboBoxSheet.TabIndex = 5;
            this.comboBoxSheet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sheet";
            // 
            // identityUserDataSet
            // 
            //this.identityUserDataSet.DataSetName = "IdentityUserDataSet";
            //this.identityUserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // identityUserDataSetBindingSource
            // 
            //this.identityUserDataSetBindingSource.DataSource = this.identityUserDataSet;
            //this.identityUserDataSetBindingSource.Position = 0;
            // 
            // identityUserDataSetBindingSource1
            // 
            //this.identityUserDataSetBindingSource1.DataSource = this.identityUserDataSet;
            //this.identityUserDataSetBindingSource1.Position = 0;
            // 
            // excelApplicationDataSet
            // 
            this.excelApplicationDataSet.DataSetName = "ExcelApplicationDataSet";
            this.excelApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excelApplicationDataSetBindingSource
            // 
            this.excelApplicationDataSetBindingSource.DataSource = this.excelApplicationDataSet;
            this.excelApplicationDataSetBindingSource.Position = 0;
            // 
            // excelApplicationDataSetBindingSource1
            // 
            this.excelApplicationDataSetBindingSource1.DataSource = this.excelApplicationDataSet;
            this.excelApplicationDataSetBindingSource1.Position = 0;
            // 
            // excelApplicationDataSetBindingSource2
            // 
            this.excelApplicationDataSetBindingSource2.DataSource = this.excelApplicationDataSet;
            this.excelApplicationDataSetBindingSource2.Position = 0;
            // 
            // excelApplicationDataSetBindingSource3
            // 
            this.excelApplicationDataSetBindingSource3.DataSource = this.excelApplicationDataSet;
            this.excelApplicationDataSetBindingSource3.Position = 0;
            // 
            // excelDataSet
            // 
            this.excelDataSet.DataSetName = "ExcelDataSet";
            this.excelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.excelDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // buttonExportSQL
            // 
            this.buttonExportSQL.Location = new System.Drawing.Point(754, 35);
            this.buttonExportSQL.Name = "buttonExportSQL";
            this.buttonExportSQL.Size = new System.Drawing.Size(132, 23);
            this.buttonExportSQL.TabIndex = 7;
            this.buttonExportSQL.Text = "Export to SQL";
            this.buttonExportSQL.UseVisualStyleBackColor = true;
            this.buttonExportSQL.Click += new System.EventHandler(this.buttonExportSQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(898, 603);
            this.Controls.Add(this.buttonExportSQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.TextBox_Path);
            this.Controls.Add(this.dgvList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From Exel To Sql";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.identityUserDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identityUserDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identityUserDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelApplicationDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView dgvList;
        private System.Windows.Forms.TextBox TextBox_Path;
        private System.Windows.Forms.Button btnOpen;
        private ComboBox comboBoxSheet;
        private System.Windows.Forms.Label label1;
        private BindingSource identityUserDataSetBindingSource;
       // private IdentityUserDataSet identityUserDataSet;
        private BindingSource excelApplicationDataSetBindingSource;
        private ExcelApplicationDataSet excelApplicationDataSet;
        private BindingSource identityUserDataSetBindingSource1;
        private BindingSource excelApplicationDataSetBindingSource2;
        private BindingSource excelApplicationDataSetBindingSource1;
        private BindingSource excelApplicationDataSetBindingSource3;
        private ExcelDataSet excelDataSet;
        private BindingSource customersBindingSource;
        private ExcelDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonExportSQL;

        //#endregion
    }
}

