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
    public partial class Form1 : Form
    {


        
        public Form1()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.mebelBDDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.mebelBDDataSet.Tovari);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Prodazha". При необходимости она может быть перемещена или удалена.
            this.prodazhaTableAdapter.Fill(this.mebelBDDataSet.Prodazha);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Clienti". При необходимости она может быть перемещена или удалена.
            this.clientiTableAdapter.Fill(this.mebelBDDataSet.Clienti);

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti cln = new Clienti();
            cln.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dolzhnosti dolzh = new Dolzhnosti();
            dolzh.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sotrudniki SoTrud = new Sotrudniki();
            SoTrud.Show();


        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Postavhik post = new Postavhik();
            post.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Postavka postav = new Postavka();
            postav.Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tovar tovar = new Tovar();
            tovar.Show();
        }

        private void категорияТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Category categ = new Category();
            categ.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {



            string mTextSam = textBox4.Text;
            string mKolvo = textBox2.Text;
            string mAdresDelivery = textBox1.Text;
            string mSumma = textBox3.Text;
            string mTovar = comboBox1.Text;
            string mSotrudnikiFio = comboBox2.Text;
            string mClientiFio = comboBox3.Text;

            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odbCommand = new OdbcCommand("select Tovari.NameTovar,Tovari.IdTovar,Tovari from Tovari where Tovari.NameTovar = '"+ mTovar +"'", odConnect);
            OdbcDataReader odData = odbCommand.ExecuteReader();

            int idTovar = 0;
            string stoimostTovar = "";
            if (odData.Read()) {



                idTovar = Convert.ToInt32(odData["IdTovar"].ToString());
                stoimostTovar = odData["Tovari.Stoimost"].ToString();



            }
            odData.Dispose();
            odConnect.Close();


            odConnect.Open();
            OdbcCommand odCommand = new OdbcCommand("select Sotrudniki.FIO,Sotrudniki.IdSotrudnik from Sotrudniki where Sotrudniki.FIO = '"+ mSotrudnikiFio +"'", odConnect);
            OdbcDataReader odDataRd = odCommand.ExecuteReader();

            int idSotrudnik = 0;
            if (odDataRd.Read()) {


                idSotrudnik = Convert.ToInt32(odDataRd["IdSotrudnik"].ToString());



            }
            odDataRd.Dispose();
            odConnect.Close();

            odConnect.Open();
            OdbcCommand odbCom = new OdbcCommand("select Clienti.FIO,Clienti.IdClienti from Clienti where Clienti.FIO = '"+  mClientiFio + "'", odConnect);
            OdbcDataReader odbDataReader = odbCom.ExecuteReader();

            idSotrudnik = 0;

            if (odbDataReader.Read()) {


                idSotrudnik = Convert.ToInt32(odbDataReader["IdClienti"].ToString());

            }

            odConnect.Close();
            odbDataReader.Dispose();


            odConnect.Open();
            OdbcCommand odbMain = new OdbcCommand("",odConnect);


            








        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
