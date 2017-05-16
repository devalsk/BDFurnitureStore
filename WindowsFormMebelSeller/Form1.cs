using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
