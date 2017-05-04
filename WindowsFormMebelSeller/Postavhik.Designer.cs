namespace WindowsFormMebelSeller
{
    partial class Postavhik
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
            this.mebelBDDataSet = new WindowsFormMebelSeller.MebelBDDataSet();
            this.postavhikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavhikiTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.PostavhikiTableAdapter();
            this.namePostavhikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavhikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namePostavhikDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavhikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // mebelBDDataSet
            // 
            this.mebelBDDataSet.DataSetName = "MebelBDDataSet";
            this.mebelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavhikiBindingSource
            // 
            this.postavhikiBindingSource.DataMember = "Postavhiki";
            this.postavhikiBindingSource.DataSource = this.mebelBDDataSet;
            // 
            // postavhikiTableAdapter
            // 
            this.postavhikiTableAdapter.ClearBeforeFill = true;
            // 
            // namePostavhikDataGridViewTextBoxColumn
            // 
            this.namePostavhikDataGridViewTextBoxColumn.DataPropertyName = "NamePostavhik";
            this.namePostavhikDataGridViewTextBoxColumn.HeaderText = "NamePostavhik";
            this.namePostavhikDataGridViewTextBoxColumn.Name = "namePostavhikDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // Postavhik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 360);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Postavhik";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Postavhik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavhikiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MebelBDDataSet mebelBDDataSet;
        private System.Windows.Forms.BindingSource postavhikiBindingSource;
        private MebelBDDataSetTableAdapters.PostavhikiTableAdapter postavhikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePostavhikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}