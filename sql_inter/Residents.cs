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
    public partial class Residents : Form
    {
        public Residents()
        {
            InitializeComponent();
        }

        private void residentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.residentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Residents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.residents". При необходимости она может быть перемещена или удалена.
            this.residentsTableAdapter.Fill(this.postgresDataSet.residents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            residentsBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.residentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            residentsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            residentsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            residentsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            residentsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            residentsBindingSource.RemoveCurrent();
        }
    }
}
