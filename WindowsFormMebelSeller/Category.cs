using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormMebelSeller
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Kategori". При необходимости она может быть перемещена или удалена.
            this.kategoriTableAdapter.Fill(this.mebelBDDataSet.Kategori);

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string mTextDolzh = textBox1.Text;

            kategoriTableAdapter.Insert(mTextDolzh.ToUpper());

            mebelBDDataSet.Clear();

            kategoriTableAdapter.Fill(mebelBDDataSet.Kategori);

            textBox1.Text = "";








        }

        private void button2_Click(object sender, EventArgs e)
        {


            int ftCon = 0;








        }
    }
}
