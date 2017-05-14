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


            string stCategory = dataGridView1.CurrentCell.Value.ToString();



            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odCom = new OdbcCommand("SELECT Kategori.IdKategori, Kategori.NameKategori FROM  Kategori where Kategori.NameKategori ='" + stCategory.Replace("'", "") + "'", odConnect);
            OdbcDataReader odRead = odCom.ExecuteReader();


            string nameCategori = "";

            if (odRead.Read())
            {

                ftCon = Convert.ToInt32(odRead["IdKategori"].ToString());

                nameCategori = odRead["NameKategori"].ToString();


            }
            odRead.Dispose();
            odConnect.Close();
            kategoriTableAdapter.Delete(ftCon, nameCategori);

            mebelBDDataSet.Clear();
            kategoriTableAdapter.Fill(mebelBDDataSet.Kategori);






        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
