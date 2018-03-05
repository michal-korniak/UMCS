using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            SingleCount singleCount = new SingleCount(0, 100, Convert.ToInt32(this.textM.Text), 10, 100000, function,
                1000000 / 3, AreaType.Rectangle, Convert.ToDouble(this.textZ.Text));
            List<double> listRect=singleCount.Zad1();
            foreach(var area in listRect)
            {
                this.listBox1.Items.Add($"Metoda prostokatna: {area}");
            }
            singleCount.AreaType = AreaType.Trapezoid;
            List<double> listTrap = singleCount.Zad1();
            foreach (var area in listTrap)
            {
                this.listBox1.Items.Add($"Metoda trapezowa: {area}");
            }
        }

        private double function(double x)
        {
            return x * x;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
