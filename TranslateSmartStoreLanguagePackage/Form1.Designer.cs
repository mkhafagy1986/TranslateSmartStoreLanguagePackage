﻿namespace TranslateSmartStoreLanguagePackage
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workingDataBaseDataSet = new TranslateSmartStoreLanguagePackage.WorkingDataBaseDataSet();
            this.englishLanguagePackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishLanguagePackageTableAdapter = new TranslateSmartStoreLanguagePackage.WorkingDataBaseDataSetTableAdapters.EnglishLanguagePackageTableAdapter();
            this.itemKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabicTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishLanguagePackageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemKeyDataGridViewTextBoxColumn,
            this.englishTextDataGridViewTextBoxColumn,
            this.arabicTextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.englishLanguagePackageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // workingDataBaseDataSet
            // 
            this.workingDataBaseDataSet.DataSetName = "WorkingDataBaseDataSet";
            this.workingDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // englishLanguagePackageBindingSource
            // 
            this.englishLanguagePackageBindingSource.DataMember = "EnglishLanguagePackage";
            this.englishLanguagePackageBindingSource.DataSource = this.workingDataBaseDataSet;
            // 
            // englishLanguagePackageTableAdapter
            // 
            this.englishLanguagePackageTableAdapter.ClearBeforeFill = true;
            // 
            // itemKeyDataGridViewTextBoxColumn
            // 
            this.itemKeyDataGridViewTextBoxColumn.DataPropertyName = "ItemKey";
            this.itemKeyDataGridViewTextBoxColumn.HeaderText = "ItemKey";
            this.itemKeyDataGridViewTextBoxColumn.Name = "itemKeyDataGridViewTextBoxColumn";
            // 
            // englishTextDataGridViewTextBoxColumn
            // 
            this.englishTextDataGridViewTextBoxColumn.DataPropertyName = "EnglishText";
            this.englishTextDataGridViewTextBoxColumn.HeaderText = "EnglishText";
            this.englishTextDataGridViewTextBoxColumn.Name = "englishTextDataGridViewTextBoxColumn";
            // 
            // arabicTextDataGridViewTextBoxColumn
            // 
            this.arabicTextDataGridViewTextBoxColumn.DataPropertyName = "ArabicText";
            this.arabicTextDataGridViewTextBoxColumn.HeaderText = "ArabicText";
            this.arabicTextDataGridViewTextBoxColumn.Name = "arabicTextDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "SmartStore Language Package";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishLanguagePackageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkingDataBaseDataSet workingDataBaseDataSet;
        private System.Windows.Forms.BindingSource englishLanguagePackageBindingSource;
        private WorkingDataBaseDataSetTableAdapters.EnglishLanguagePackageTableAdapter englishLanguagePackageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabicTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

