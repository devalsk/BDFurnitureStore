namespace WindowsFormMebelSeller
{
    partial class Dolzhnosti
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
            this.dolzhnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelBDDataSet = new WindowsFormMebelSeller.MebelBDDataSet();
            this.dolzhnostiTableAdapter = new WindowsFormMebelSeller.MebelBDDataSetTableAdapters.DolzhnostiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IdDolzhnosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDolzhnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDolzhnosti,
            this.nameDolzhnostiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dolzhnostiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dolzhnostiBindingSource
            // 
            this.dolzhnostiBindingSource.DataMember = "Dolzhnosti";
            this.dolzhnostiBindingSource.DataSource = this.mebelBDDataSetBindingSource;
            // 
            // mebelBDDataSetBindingSource
            // 
            this.mebelBDDataSetBindingSource.DataSource = this.mebelBDDataSet;
            this.mebelBDDataSetBindingSource.Position = 0;
            // 
            // mebelBDDataSet
            // 
            this.mebelBDDataSet.DataSetName = "MebelBDDataSet";
            this.mebelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolzhnostiTableAdapter
            // 
            this.dolzhnostiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Должность";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IdDolzhnosti
            // 
            this.IdDolzhnosti.DataPropertyName = "IdDolzhnosti";
            this.IdDolzhnosti.HeaderText = "IdDolzhnosti";
            this.IdDolzhnosti.Name = "IdDolzhnosti";
            this.IdDolzhnosti.ReadOnly = true;
            this.IdDolzhnosti.Visible = false;
            // 
            // nameDolzhnostiDataGridViewTextBoxColumn
            // 
            this.nameDolzhnostiDataGridViewTextBoxColumn.DataPropertyName = "NameDolzhnosti";
            this.nameDolzhnostiDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.nameDolzhnostiDataGridViewTextBoxColumn.Name = "nameDolzhnostiDataGridViewTextBoxColumn";
            this.nameDolzhnostiDataGridViewTextBoxColumn.Width = 500;
            // 
            // Dolzhnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 313);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dolzhnosti";
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.Dolzhnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mebelBDDataSetBindingSource;
        private MebelBDDataSet mebelBDDataSet;
        private System.Windows.Forms.BindingSource dolzhnostiBindingSource;
        private MebelBDDataSetTableAdapters.DolzhnostiTableAdapter dolzhnostiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDolzhnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDolzhnostiDataGridViewTextBoxColumn;
    }
}