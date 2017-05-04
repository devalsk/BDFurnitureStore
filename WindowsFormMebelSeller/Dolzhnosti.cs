using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormMebelSeller;
using System.Data.Odbc;

namespace WindowsFormMebelSeller
{
    public partial class Dolzhnosti : Form
    {
        public Dolzhnosti()
        {
            InitializeComponent();
        }

        private void Dolzhnosti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Dolzhnosti". При необходимости она может быть перемещена или удалена.
            this.dolzhnostiTableAdapter.Fill(this.mebelBDDataSet.Dolzhnosti);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string strDolzh = textBox1.Text;

            dolzhnostiTableAdapter.Insert(strDolzh.ToUpper());

            mebelBDDataSet.Clear();


            dolzhnostiTableAdapter.Fill(mebelBDDataSet.Dolzhnosti);

            textBox1.Text = "";









        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {








        }

        private void button2_Click(object sender, EventArgs e)
        {

            int ftCon = 0;

            string stDolznosti = dataGridView1.CurrentCell.Value.ToString();
            OdbcConnection onConect = new OdbcConnection("DSN=bdr");
            onConect.Open();



            OdbcCommand idDolzh = new OdbcCommand("select Dolzhnosti.IdDolzhnosti,Dolzhnosti.NameDolzhnosti from Dolzhnosti where Dolzhnosti.NameDolzhnosti ='" + stDolznosti.Replace("'","") + "'",onConect);
            OdbcDataReader dataRead = idDolzh.ExecuteReader();


            string dolzhnosti = "";
            if (dataRead.Read())
            {

                ftCon = Convert.ToInt32(dataRead["IdDolzhnosti"].ToString());
                dolzhnosti = dataRead["NameDolzhnosti"].ToString();




            }

            dataRead.Dispose();
            onConect.Close();
            dolzhnostiTableAdapter.Delete(ftCon,dolzhnosti);


            mebelBDDataSet.Clear();
            dolzhnostiTableAdapter.Fill(mebelBDDataSet.Dolzhnosti);


        }
    }
}
