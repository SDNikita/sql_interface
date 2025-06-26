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
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void payments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.payments". При необходимости она может быть перемещена или удалена.
            this.paymentsTableAdapter.Fill(this.postgresDataSet.payments);

        }

        private void apartment_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void payment_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apartment_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MoveFirst();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }
    }
}
