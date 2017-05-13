namespace WindowsFormMebelSeller
{
    partial class Postavka
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
            this.datePostavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePostavhik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavkaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mebelBDDataSet = new WindowsFormMebelSeller.MebelBDDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tovariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mebelBDDataSet1 = new WindowsFormMebelSeller.MebelBDDataSet();
            this.tovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.postavhikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.postavkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.PostavkaTableAdapter();
            this.tovariTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.TovariTableAdapter();
            this.tovariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postavhikiTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.PostavhikiTableAdapter();
            this.postavhikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavhikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavhikiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datePostavkaDataGridViewTextBoxColumn,
            this.NameTovar,
            this.NamePostavhik,
            this.kolvoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavkaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datePostavkaDataGridViewTextBoxColumn
            // 
            this.datePostavkaDataGridViewTextBoxColumn.DataPropertyName = "DatePostavka";
            this.datePostavkaDataGridViewTextBoxColumn.HeaderText = "DatePostavka";
            this.datePostavkaDataGridViewTextBoxColumn.Name = "datePostavkaDataGridViewTextBoxColumn";
            // 
            // NameTovar
            // 
            this.NameTovar.DataPropertyName = "NameTovar";
            this.NameTovar.HeaderText = "NameTovar";
            this.NameTovar.Name = "NameTovar";
            // 
            // NamePostavhik
            // 
            this.NamePostavhik.DataPropertyName = "NamePostavhik";
            this.NamePostavhik.HeaderText = "NamePostavhik";
            this.NamePostavhik.Name = "NamePostavhik";
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kolvo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kolvo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            // 
            // postavkaBindingSource2
            // 
            this.postavkaBindingSource2.DataMember = "Postavka";
            this.postavkaBindingSource2.DataSource = this.mebelBDDataSet;
            // 
            // mebelBDDataSet
            // 
            this.mebelBDDataSet.DataSetName = "MebelBDDataSet";
            this.mebelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tovariBindingSource2, "NameKategori", true));
            this.comboBox1.DataSource = this.tovariBindingSource;
            this.comboBox1.DisplayMember = "NameTovar";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "IdTovar";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tovariBindingSource2
            // 
            this.tovariBindingSource2.DataMember = "Tovari";
            this.tovariBindingSource2.DataSource = this.mebelBDDataSet1;
            // 
            // mebelBDDataSet1
            // 
            this.mebelBDDataSet1.DataSetName = "MebelBDDataSet";
            this.mebelBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovariBindingSource
            // 
            this.tovariBindingSource.DataMember = "Tovari";
            this.tovariBindingSource.DataSource = this.mebelBDDataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postavhikiBindingSource, "NamePostavhik", true));
            this.comboBox2.DataSource = this.postavhikiBindingSource;
            this.comboBox2.DisplayMember = "NamePostavhik";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "IdPostavhik";
            // 
            // postavhikiBindingSource
            // 
            this.postavhikiBindingSource.DataMember = "Postavhiki";
            this.postavhikiBindingSource.DataSource = this.mebelBDDataSet1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата Поставки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поставщик";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // postavkaBindingSource1
            // 
            this.postavkaBindingSource1.DataMember = "Postavka";
            this.postavkaBindingSource1.DataSource = this.mebelBDDataSet;
            // 
            // postavkaBindingSource
            // 
            this.postavkaBindingSource.DataMember = "Postavka";
            this.postavkaBindingSource.DataSource = this.mebelBDDataSet;
            // 
            // postavkaTableAdapter
            // 
            this.postavkaTableAdapter.ClearBeforeFill = true;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // tovariBindingSource1
            // 
            this.tovariBindingSource1.DataMember = "Tovari";
            this.tovariBindingSource1.DataSource = this.mebelBDDataSet1;
            // 
            // postavhikiTableAdapter
            // 
            this.postavhikiTableAdapter.ClearBeforeFill = true;
            // 
            // postavhikiBindingSource1
            // 
            this.postavhikiBindingSource1.DataMember = "Postavhiki";
            this.postavhikiBindingSource1.DataSource = this.mebelBDDataSet1;
            // 
            // Postavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Postavka";
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.Postavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavhikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavhikiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MebelBDDataSet mebelBDDataSet;
        private System.Windows.Forms.BindingSource postavkaBindingSource;
        private MebelBDDataSetTableAdapters.PostavkaTableAdapter postavkaTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource postavkaBindingSource1;
        private System.Windows.Forms.BindingSource postavkaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePostavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePostavhik;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private MebelBDDataSet mebelBDDataSet1;
        private System.Windows.Forms.BindingSource tovariBindingSource;
        private MebelBDDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.BindingSource tovariBindingSource1;
        private System.Windows.Forms.BindingSource tovariBindingSource2;
        private System.Windows.Forms.BindingSource postavhikiBindingSource;
        private MebelBDDataSetTableAdapters.PostavhikiTableAdapter postavhikiTableAdapter;
        private System.Windows.Forms.BindingSource postavhikiBindingSource1;
    }
}