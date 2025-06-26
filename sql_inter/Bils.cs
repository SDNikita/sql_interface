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
    public partial class Bils : Form
    {
        public Bils()
        {
            InitializeComponent();
        }

        private void billsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Bils_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.bills". При необходимости она может быть перемещена или удалена.
            this.billsTableAdapter.Fill(this.postgresDataSet.bills);

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void is_paidLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            billsBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            billsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            billsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            billsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            billsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            billsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }
    }

}
