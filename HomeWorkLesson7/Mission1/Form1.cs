using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission1
{
    public partial class Form1 : Form
    {
        static public Random rnd = new Random();
        static public int i = rnd.Next(1, 100);

        public Form1()
        {
            InitializeComponent();


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (i == Convert.ToInt32(tb.Text))
            {

                MessageBox.Show("Угадал.", "", MessageBoxButtons.OK);

            }
            else MessageBox.Show("Не угадал.", "", MessageBoxButtons.OK);


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            i = rnd.Next(1, 100);
            label1.Text = Convert.ToString(i);
        }
    }
}
