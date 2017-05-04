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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
