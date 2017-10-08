namespace TranslateSmartStoreLanguagePackage
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
            this.englishLanguagePackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workingDataBaseDataSet = new TranslateSmartStoreLanguagePackage.WorkingDataBaseDataSet();
            this.englishLanguagePackageTableAdapter = new TranslateSmartStoreLanguagePackage.WorkingDataBaseDataSetTableAdapters.EnglishLanguagePackageTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.workingDataBaseDataSet1 = new TranslateSmartStoreLanguagePackage.WorkingDataBaseDataSet1();
            this.englishLanguagePackageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.englishLanguagePackageTableAdapter1 = new TranslateSmartStoreLanguagePackage.WorkingDataBaseDataSet1TableAdapters.EnglishLanguagePackageTableAdapter();
            this.itemKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishLanguagePackageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishLanguagePackageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemKeyDataGridViewTextBoxColumn,
            this.englishTextDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.englishLanguagePackageBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(55, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // englishLanguagePackageBindingSource
            // 
            this.englishLanguagePackageBindingSource.DataMember = "EnglishLanguagePackage";
            this.englishLanguagePackageBindingSource.DataSource = this.workingDataBaseDataSet;
            // 
            // workingDataBaseDataSet
            // 
            this.workingDataBaseDataSet.DataSetName = "WorkingDataBaseDataSet";
            this.workingDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // englishLanguagePackageTableAdapter
            // 
            this.englishLanguagePackageTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // workingDataBaseDataSet1
            // 
            this.workingDataBaseDataSet1.DataSetName = "WorkingDataBaseDataSet1";
            this.workingDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // englishLanguagePackageBindingSource1
            // 
            this.englishLanguagePackageBindingSource1.DataMember = "EnglishLanguagePackage";
            this.englishLanguagePackageBindingSource1.DataSource = this.workingDataBaseDataSet1;
            // 
            // englishLanguagePackageTableAdapter1
            // 
            this.englishLanguagePackageTableAdapter1.ClearBeforeFill = true;
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
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "SmartStore Language Package";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishLanguagePackageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishLanguagePackageBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkingDataBaseDataSet workingDataBaseDataSet;
        private System.Windows.Forms.BindingSource englishLanguagePackageBindingSource;
        private WorkingDataBaseDataSetTableAdapters.EnglishLanguagePackageTableAdapter englishLanguagePackageTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private WorkingDataBaseDataSet1 workingDataBaseDataSet1;
        private System.Windows.Forms.BindingSource englishLanguagePackageBindingSource1;
        private WorkingDataBaseDataSet1TableAdapters.EnglishLanguagePackageTableAdapter englishLanguagePackageTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}

