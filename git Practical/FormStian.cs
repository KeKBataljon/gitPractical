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
    public partial class FormStian : Form
    {
        public FormStian()
        {
            InitializeComponent();
            txtMedian.ReadOnly = true;
            txtRandom.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtMedian.Clear();
            txtRandom.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAmount.Text))
            {
                Test5_20 test = new Test5_20();
                int n = Convert.ToInt32(txtAmount.Text);
                if (test.test(n))
                {
                    stat classobject = new stat(n);
                    int[] array = classobject.getArray();
                    txtMedian.Text = Convert.ToString(classobject.getMedian());
                    for (int i = 0; i < n; i++)
                    {
                        txtRandom.AppendText(Convert.ToString(array[i]) + ", ");
                    }
                    MessageBox.Show(Convert.ToString(classobject.getMedian()));
                }
                else
                {
                    MessageBox.Show("The integer was not between 5 and 20.");
                }
            }
        }
    }
}
