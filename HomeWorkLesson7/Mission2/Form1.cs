using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission2
{
    public partial class Form1 : Form
    {

        public static Random rnd = new Random();
        public static int goal = 0;
        public static int cmdCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            cmdCounter++;
            lbl.Text = (int.Parse(lbl.Text) + 1).ToString();
            lblCmdCounter.Text = "Всего комманд: " + cmdCounter;
            if (int.Parse(lbl.Text) == goal)
            {
                MessageBox.Show($"Вы набрали необходимое число за {cmdCounter} ходов.", "", MessageBoxButtons.OK);
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

            cmdCounter++;
            lbl.Text = (int.Parse(lbl.Text) * 2).ToString();
            lblCmdCounter.Text = "Всего комманд: " + cmdCounter;
            if (int.Parse(lbl.Text) == goal)
            {
                MessageBox.Show($"Вы набрали необходимое число за {cmdCounter} ходов.", "", MessageBoxButtons.OK);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            cmdCounter++;
            lbl.Text = "0";
            lblCmdCounter.Text = "Всего комманд: " + cmdCounter;

        }     

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lbl.Text = "0";
            goal = rnd.Next(1, 100);
            MessageBox.Show($"Игра началась. Наберите число {goal} за минимальное колличество ходов", "", MessageBoxButtons.OK);
            lblCmdCounter.Text = "0";
            cmdCounter = 0;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
