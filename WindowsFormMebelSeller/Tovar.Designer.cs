namespace WindowsFormMebelSeller
{
    partial class Tovar
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
            this.nameTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mebelBDDataSet = new WindowsFormMebelSeller.MebelBDDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovariTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.TovariTableAdapter();
            this.kategoriTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.KategoriTableAdapter();
            this.kategoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameTovarDataGridViewTextBoxColumn,
            this.nameKategoriDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovariBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameTovarDataGridViewTextBoxColumn
            // 
            this.nameTovarDataGridViewTextBoxColumn.DataPropertyName = "NameTovar";
            this.nameTovarDataGridViewTextBoxColumn.HeaderText = "NameTovar";
            this.nameTovarDataGridViewTextBoxColumn.Name = "nameTovarDataGridViewTextBoxColumn";
            // 
            // nameKategoriDataGridViewTextBoxColumn
            // 
            this.nameKategoriDataGridViewTextBoxColumn.DataPropertyName = "NameKategori";
            this.nameKategoriDataGridViewTextBoxColumn.HeaderText = "NameKategori";
            this.nameKategoriDataGridViewTextBoxColumn.Name = "nameKategoriDataGridViewTextBoxColumn";
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kolvo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kolvo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // tovariBindingSource1
            // 
            this.tovariBindingSource1.DataMember = "Tovari";
            this.tovariBindingSource1.DataSource = this.mebelBDDataSet;
            // 
            // mebelBDDataSet
            // 
            this.mebelBDDataSet.DataSetName = "MebelBDDataSet";
            this.mebelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategoriBindingSource, "NameKategori", true));
            this.comboBox1.DataSource = this.kategoriBindingSource;
            this.comboBox1.DisplayMember = "NameKategori";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "IdKategori";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.mebelBDDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "НазваниеТовара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Категория";
            // 
            // tovariBindingSource
            // 
            this.tovariBindingSource.DataMember = "Tovari";
            this.tovariBindingSource.DataSource = this.mebelBDDataSet;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // kategoriBindingSource1
            // 
            this.kategoriBindingSource1.DataMember = "Kategori";
            this.kategoriBindingSource1.DataSource = this.mebelBDDataSet;
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tovar";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Tovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MebelBDDataSet mebelBDDataSet;
        private System.Windows.Forms.BindingSource tovariBindingSource;
        private MebelBDDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tovariBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameKategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private MebelBDDataSetTableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private System.Windows.Forms.BindingSource kategoriBindingSource1;
    }
}