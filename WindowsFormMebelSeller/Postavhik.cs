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
    public partial class Postavhik : Form
    {
        public Postavhik()
        {
            InitializeComponent();
        }

        private void Postavhik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Postavhiki". При необходимости она может быть перемещена или удалена.
            this.postavhikiTableAdapter.Fill(this.mebelBDDataSet.Postavhiki);
            postavhikiTableAdapter.Update(mebelBDDataSet.Postavhiki);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

 

            string mNameCompany = textBox1.Text;
            string mAdres = textBox2.Text;
            int mTelephone = Convert.ToInt32(textBox3.Text);
            string mEmail = textBox4.Text;

            postavhikiTableAdapter.Insert(mNameCompany.ToUpper(),mTelephone,mEmail.ToUpper(),mAdres.ToUpper());


            mebelBDDataSet.Clear();

            postavhikiTableAdapter.Fill(mebelBDDataSet.Postavhiki);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";







        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idCon = 0;
            string idPostavhik =(dataGridView1["IdPostavhik", dataGridView1.CurrentRow.Index].Value.ToString());
            

            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odCom = new OdbcCommand("SELECT   Postavhiki.IdPostavhik, Postavhiki.NamePostavhik, Postavhiki.Telephone, Postavhiki.Email, Postavhiki.Adress FROM Postavhiki where Postavhiki.IdPostavhik = '" + idPostavhik.Replace("'", "") + "'", odConnect);
            OdbcDataReader odRead = odCom.ExecuteReader();


            string mNameCompany = "";
            string mAdress = "";
            string mEmail = "";
            int mTelephone = 0;

            if (odRead.Read())
            {


                idCon = Convert.ToInt32(odRead["IdPostavhik"].ToString());
                mNameCompany = odRead["NamePostavhik"].ToString();
                mAdress = odRead["Adress"].ToString();
                mEmail = odRead["Email"].ToString();
                mTelephone = Convert.ToInt32(odRead["Telephone"].ToString());

            }


            odRead.Dispose();
            odConnect.Close();
            postavhikiTableAdapter.Delete(idCon, mNameCompany, mTelephone, mEmail, mAdress);

            mebelBDDataSet.Clear();
            postavhikiTableAdapter.Fill(mebelBDDataSet.Postavhiki);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            postavhikiTableAdapter.Update(mebelBDDataSet.Postavhiki);
        }
    }
}
