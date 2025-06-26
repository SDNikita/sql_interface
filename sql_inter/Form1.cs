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
    public partial class MainForm : Form
    {
        private Apart users;
        private Bils bils;
        private payments payments;
        private Penalties penalties;
        private Utilities utilities;
        private Residents residents;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users = new Apart();
            users.Visible= true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            residents = new Residents();
            residents.Visible= true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bils = new Bils();
            bils.Visible= true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            payments = new payments();
            payments.Visible= true;
        }

        

        

        private void button6_Click_1(object sender, EventArgs e)
        {
            penalties = new Penalties();
            penalties.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            utilities = new Utilities();
            utilities.Visible = true;
        }
    }
}
