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
        private int[] array;
        public FormStian()
        {
            InitializeComponent();
            txtMedian.ReadOnly = true;
            txtRandom.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            txtMedian.Clear();
            txtRandom.Clear();
            if (!String.IsNullOrEmpty(txtAmount.Text))
            {
                int n = Convert.ToInt32(txtAmount.Text);
                StianMedian classobject = new StianMedian(n);
                int[] array = classobject.getArray();
                txtMedian.Text = Convert.ToString(classobject.getMedian());
                for (int i = 0; i < n; i++)
                {
                    txtRandom.AppendText(Convert.ToString(array[i]) + ", ");
                }
            }
        }
    }
}
