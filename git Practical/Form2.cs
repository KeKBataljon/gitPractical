using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_Practical
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 1)
            {
                updatePanel();
            }
        }

        private void updatePanel()
        {
            StatCalc stats = new StatCalc(Decimal.ToInt32(numericUpDown1.Value));
            textBox1.Visible = true;
            textBox1.Text = stats.toString();
            labelMax.Text = stats.getMax();
            labelMin.Text = stats.getMin();
            labelMean.Text = stats.getAve();
            labelMedian.Text = stats.getMedian();
            labelStanDev.Text = stats.getStanDev();

        }

     
    }
}
