using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_with_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ints = new int[3];
            
            ints[0] = (int)numericUpDown1.Value;
            ints[1] = (int)numericUpDown2.Value;
            ints[2] = (int)numericUpDown3.Value;

            MessageBox.Show("Summan är " + Summa(ints));

        }

        private int Summa(int[] intarray)
        {
            int sum = 0;    
            for (int i = 0; i < intarray.Length; i++) 
            {
                sum = sum + intarray[i];     
            }

            return sum;
        }

    }
}
