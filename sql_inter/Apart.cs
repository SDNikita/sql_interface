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
    public partial class Apart : Form
    {
        public Apart()
        {
            InitializeComponent();
        }

        private void apartmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apartmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Apart_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.apartments". При необходимости она может быть перемещена или удалена.
            this.apartmentsTableAdapter.Fill(this.postgresDataSet.apartments);

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void areaLabel_Click(object sender, EventArgs e)
        {

        }

        private void residents_countLabel_Click(object sender, EventArgs e)
        {

        }

        private void residents_countTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apartmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apartmentsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            apartmentsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apartmentsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            apartmentsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            apartmentsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            apartmentsBindingSource.RemoveCurrent();   
        }
    }
}
