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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelBDDataSet.Kategori". При необходимости она может быть перемещена или удалена.
            this.kategoriTableAdapter.Fill(this.mebelBDDataSet.Kategori);

        }
    }
}
