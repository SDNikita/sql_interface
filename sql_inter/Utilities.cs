using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_inter
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();
        }

        private void utilitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Utilities_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.utilities". При необходимости она может быть перемещена или удалена.
            this.utilitiesTableAdapter.Fill(this.postgresDataSet.utilities);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.MoveFirst(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.RemoveCurrent();
        }
    }
}
