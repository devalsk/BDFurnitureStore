﻿using System;
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
            int mKolvo = Convert.ToInt32(textBox2.Text);
            string mAdresDelivery = textBox1.Text;
            int mSumma = 0;
            string mTovar = comboBox1.Text;
            string mSotrudnikiFio = comboBox2.Text;
            string mClientiFio = comboBox3.Text;

            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();


            OdbcCommand odbCommand = new OdbcCommand("select Tovari.NameTovar,Tovari.IdTovar,Tovari.Stoimost from Tovari where Tovari.NameTovar = '" + mTovar +"'", odConnect);
            OdbcDataReader odData = odbCommand.ExecuteReader();

            int idTovar = 0;
            int stoimostTovar = 0;
            if (odData.Read()) {



                idTovar = Convert.ToInt32(odData["IdTovar"].ToString());
                stoimostTovar = Convert.ToInt32(odData["Stoimost"]);



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

            int idClienti = 0;

            if (odbDataReader.Read()) {


                idClienti = Convert.ToInt32(odbDataReader["IdClienti"].ToString());

            }

            odConnect.Close();
            odbDataReader.Dispose();


            label8.Text = stoimostTovar + " Руб";
            mSumma = mKolvo * stoimostTovar;

            odConnect.Open();
            OdbcCommand odbMain = new OdbcCommand("INSERT INTO Prodazha VALUES('"+ idTovar +"','" + idSotrudnik +"','"+idClienti+"','"+mTextSam+"','"+mKolvo+"','"+mAdresDelivery+"','"+mSumma+"')",odConnect);
            OdbcDataReader odDtRead = odbMain.ExecuteReader();
            odConnect.Close();

            prodazhaTableAdapter.Fill(mebelBDDataSet.Prodazha);

            








        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            string idProdazha = dataGridView1["IdProdazha", dataGridView1.CurrentRow.Index].Value.ToString();

            OdbcConnection odConnect = new OdbcConnection("DSN=bdr");
            odConnect.Open();

   
        
            OdbcCommand odbcCom = new OdbcCommand("delete from Prodazha where Prodazha.IdProdazha = '"+idProdazha+ "'", odConnect);
            odbcCom.ExecuteReader();
            odbcCom.Dispose();
            odConnect.Close();


            prodazhaTableAdapter.Fill(mebelBDDataSet.Prodazha);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
         
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
