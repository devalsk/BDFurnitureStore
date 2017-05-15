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
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Dolzhnosti". При необходимости она может быть перемещена или удалена.
            this.dolzhnostiTableAdapter.Fill(this.mebelBDDataSet.Dolzhnosti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.mebelBDDataSet.Sotrudniki);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sotrudnikiTableAdapter.Fill(this.mebelBDDataSet.Sotrudniki);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mFIO = textBox1.Text;
            string mAdres = textBox2.Text;
            string mTelephine = textBox3.Text;
            string mEmail = textBox4.Text;
            string mDolzhost = comboBox1.Text;

            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();

            OdbcCommand odCommand = new OdbcCommand("select Dolzhnosti.IdDolzhnosti,Dolzhnosti.NameDolzhnosti from Dolzhnosti where Dolzhnosti.NameDolzhnosti = '"+ mDolzhost + "'", odConnect);
            OdbcDataReader dataRead = odCommand.ExecuteReader();
            

            int idDolznosti = 0;
            if (dataRead.Read()) {

                idDolznosti = Convert.ToInt32(dataRead["IdDolzhnosti"].ToString());


            }
            dataRead.Dispose();
            odConnect.Close();


            //MessageBox.Show(idDolznosti.ToString());
            odConnect.Open();
            OdbcCommand odCom = new OdbcCommand("INSERT INTO Sotrudniki VALUES('"+ mFIO +"','"+ idDolznosti +"','" + mAdres +"','"+mTelephine+"','"+mEmail+"')",odConnect);
            OdbcDataReader dtRead = odCom.ExecuteReader();
            dtRead.Dispose();

            odConnect.Close();
            sotrudnikiTableAdapter.Fill(mebelBDDataSet.Sotrudniki);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string mText = dataGridView1.CurrentCell.Value.ToString();


            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odCommand = new OdbcCommand("select Sotrudniki.FIO,Sotrudniki.IdSotrudnik from Sotrudniki where Sotrudniki.FIO ='"+ mText +"'", odConnect);
            OdbcDataReader dataRead = odCommand.ExecuteReader();

            int idSotrudniki = 0;
            if (dataRead.Read())
            {

                idSotrudniki = Convert.ToInt32(dataRead["IdSotrudnik"].ToString());


            }

            dataRead.Dispose();
            odConnect.Close();


           // MessageBox.Show(idSotrudniki.ToString());
            odConnect.Open();
            OdbcCommand odCom = new OdbcCommand("delete from Sotrudniki where Sotrudniki.IdSotrudnik = '"+  idSotrudniki + "'", odConnect);
            OdbcDataReader dtRead = odCom.ExecuteReader();
            odConnect.Close();
            dtRead.Dispose();

            sotrudnikiTableAdapter.Fill(mebelBDDataSet.Sotrudniki);

        }
    }
}
