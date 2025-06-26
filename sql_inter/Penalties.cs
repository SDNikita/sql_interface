using Npgsql;
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
    public partial class Penalties : Form
    {
        public Penalties()
        {
            InitializeComponent();
        }

        private void penaltiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penaltiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Penalties_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.bills". При необходимости она может быть перемещена или удалена.
            this.billsTableAdapter.Fill(this.postgresDataSet.bills);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.penalties". При необходимости она может быть перемещена или удалена.
            this.penaltiesTableAdapter.Fill(this.postgresDataSet.penalties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            penaltiesBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penaltiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            penaltiesBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            penaltiesBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            penaltiesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            penaltiesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            penaltiesBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
