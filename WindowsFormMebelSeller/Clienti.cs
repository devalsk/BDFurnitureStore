using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormMebelSeller;

namespace WindowsFormMebelSeller
{
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Clienti". При необходимости она может быть перемещена или удалена.
            this.clientiTableAdapter.Fill(this.mebelBDDataSet.Clienti);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //тест
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string nameFIO = textBox1.Text;
                string nameTel = textBox2.Text;
                string nameEmail = textBox3.Text;


                clientiTableAdapter.Insert(nameFIO.ToUpper(), nameTel.ToUpper(), nameEmail.ToUpper());


                mebelBDDataSet.Clear();

                clientiTableAdapter.Fill(mebelBDDataSet.Clienti);

                textBox1.Text = "";

            }
            catch
            {



            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                int ftCon = 0;
                string stClienti = dataGridView1.CurrentCell.Value.ToString();
          
                OdbcConnection idCon = new OdbcConnection("DSN=bdr");
                idCon.Open();

                OdbcCommand idConf = new OdbcCommand("select Clienti.IdClienti,Clienti.FIO,Clienti.Telephone,Clienti.Email from Clienti where Clienti.FIO ='"  + stClienti.Replace("'", "") + "'",idCon);
                OdbcDataReader dataRead = idConf.ExecuteReader();

                string strFio = "";
                string strTelephone = "";
                string strEmail = "";
                if (dataRead.Read()) {


                    ftCon = Convert.ToInt32(dataRead["IdClienti"].ToString());
                    strFio = dataRead["FIO"].ToString();
                    strTelephone = dataRead["Telephone"].ToString();
                    strEmail = dataRead["Email"].ToString();
                }
                
                dataRead.Dispose();
                idCon.Close();
                ///clientiTableAdapter.Delete(4,"ИВАНЕНКО","ДМИТРИЙ","ВИКТОРОВИЧ");
                clientiTableAdapter.Delete(ftCon,strFio,strTelephone,strEmail);
                mebelBDDataSet.Clear();

                clientiTableAdapter.Fill(mebelBDDataSet.Clienti);

            }

            catch(Exception exp)
            {
                
              
                MessageBox.Show(exp.StackTrace);
              

            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
