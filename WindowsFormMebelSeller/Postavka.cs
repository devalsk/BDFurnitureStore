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
    public partial class Postavka : Form
    {
        public Postavka()
        {
            InitializeComponent();
        }

        private void Postavka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet1.Postavhiki". При необходимости она может быть перемещена или удалена.
            this.postavhikiTableAdapter.Fill(this.mebelBDDataSet1.Postavhiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet1.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.mebelBDDataSet1.Tovari);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Postavka". При необходимости она может быть перемещена или удалена.
            this.postavkaTableAdapter.Fill(this.mebelBDDataSet.Postavka);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.postavkaTableAdapter.FillBy(this.mebelBDDataSet.Postavka);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.postavkaTableAdapter.FillBy(this.mebelBDDataSet.Postavka);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.postavkaTableAdapter.FillBy(this.mebelBDDataSet.Postavka);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.postavkaTableAdapter.FillBy(this.mebelBDDataSet.Postavka);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string mDateTovar = DateTime.Now.ToString("yyyy-MM-dd") ;
            string mTovar = comboBox1.Text;
            string mPostavhik = comboBox2.Text;
            string mKolvo = textBox2.Text;




            int idCombo = 0;



            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odbCommand = new OdbcCommand("select Tovari.IdTovar,Tovari.NameTovar from Tovari where NameTovar ='" + mTovar.Replace("'", "") + "'", odConnect);
            OdbcDataReader odRead = odbCommand.ExecuteReader();


            if (odRead.Read())
            {


                idCombo = Convert.ToInt32(odRead["IdTovar"].ToString());

            }

            odRead.Dispose();
            odConnect.Close();

            int idCombo2 = 0;
            odConnect.Open();
            OdbcCommand odCom = new OdbcCommand("select Postavhiki.IdPostavhik,Postavhiki.NamePostavhik from  Postavhiki where Postavhiki.NamePostavhik = '" + mPostavhik.Replace("'","")+ "'",odConnect);
            OdbcDataReader odbRead = odCom.ExecuteReader();

            if (odbRead.Read()) {


                idCombo2 = Convert.ToInt32(odbRead["IdPostavhik"].ToString());


            }
            odbRead.Dispose();
            odConnect.Close();

            odConnect.Open();
            OdbcCommand odCommand = new OdbcCommand("INSERT INTO Postavka VALUES('" + mDateTovar + "','" + idCombo + "','" + idCombo2 + "','" + mKolvo + "')", odConnect);
            OdbcDataReader dtRead = odCommand.ExecuteReader();
            dtRead.Dispose();
            odConnect.Close();
            postavkaTableAdapter.Fill(mebelBDDataSet.Postavka);








        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
