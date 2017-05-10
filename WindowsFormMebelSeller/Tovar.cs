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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Kategori". При необходимости она может быть перемещена или удалена.
            this.kategoriTableAdapter.Fill(this.mebelBDDataSet.Kategori);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.mebelBDDataSet.Tovari);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tovariTableAdapter.FillBy(this.mebelBDDataSet.Tovari);
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
                this.tovariTableAdapter.FillBy(this.mebelBDDataSet.Tovari);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tovariTableAdapter.Fill(this.mebelBDDataSet.Tovari);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tovariTableAdapter.Fill(this.mebelBDDataSet.Tovari);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mNameTovar = textBox1.Text;
            string mKolvo = textBox2.Text;
            string mStoimost = textBox3.Text;
            string mOpisannie = textBox4.Text;





            string mCombText = comboBox1.Text;

            int IdCombo = 0;

            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odComand = new OdbcCommand("select Kategori.IdKategori,Kategori.NameKategori from Kategori where Kategori.NameKategori ='" + mCombText.Replace("'", "") + "'", odConnect);
            OdbcDataReader odRead = odComand.ExecuteReader();


            if (odRead.Read())
            {

                IdCombo = Convert.ToInt32(odRead["IdKategori"].ToString());




            }

           // MessageBox.Show(IdCombo.ToString());
           // MessageBox.Show("insert into Tovari values('" + mNameTovar + "'," + "'"+ mStoimost + "',"+ "'" + mKolvo + "'," + "'" + mOpisannie +"'," + "'" + IdCombo+ "')");

            odRead.Dispose();
            odConnect.Close();


            odConnect.Open();

            OdbcCommand odTableCom = new OdbcCommand("insert into Tovari values('" + mNameTovar + "'," + "'" + mStoimost + "'," + "'" + mKolvo + "'," + "'" + mOpisannie + "'," + "'" + IdCombo + "')", odConnect);
            OdbcDataReader od = odTableCom.ExecuteReader();

            od.Dispose();
            odConnect.Close();
            tovariTableAdapter.Fill(mebelBDDataSet.Tovari);



            









        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {







        }

        private void button2_Click(object sender, EventArgs e)
        {

            string st = "Name";
            MessageBox.Show("'st'");
        }
    }
}
