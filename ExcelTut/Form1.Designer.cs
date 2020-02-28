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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.TextBox_Path = new System.Windows.Forms.TextBox();
            this.TextBox_Sheet = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSheet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(25, 142);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(861, 458);
            this.dgvList.TabIndex = 0;
            // 
            // TextBox_Path
            // 
            this.TextBox_Path.Location = new System.Drawing.Point(119, 35);
            this.TextBox_Path.Name = "TextBox_Path";
            this.TextBox_Path.Size = new System.Drawing.Size(252, 20);
            this.TextBox_Path.TabIndex = 1;
            // 
            // TextBox_Sheet
            // 
            this.TextBox_Sheet.Location = new System.Drawing.Point(119, 81);
            this.TextBox_Sheet.Name = "TextBox_Sheet";
            this.TextBox_Sheet.Size = new System.Drawing.Size(252, 20);
            this.TextBox_Sheet.TabIndex = 2;
            this.TextBox_Sheet.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // btnSheet
            // 
            this.btnSheet.Location = new System.Drawing.Point(25, 78);
            this.btnSheet.Name = "btnSheet";
            this.btnSheet.Size = new System.Drawing.Size(75, 23);
            this.btnSheet.TabIndex = 4;
            this.btnSheet.Text = "Load Excel";
            this.btnSheet.UseVisualStyleBackColor = true;
            this.btnSheet.Click += new System.EventHandler(this.btnSheet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 603);
            this.Controls.Add(this.btnSheet);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.TextBox_Sheet);
            this.Controls.Add(this.TextBox_Path);
            this.Controls.Add(this.dgvList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView dgvList;
        private System.Windows.Forms.TextBox TextBox_Path;
        private System.Windows.Forms.TextBox TextBox_Sheet;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSheet;

        //#endregion
    }
}

