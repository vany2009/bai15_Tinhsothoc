using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai15_Tinhsothoc
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {


            int soO = int.Parse(txtô.Text);
            if (soO > 64)
            {
                MessageBox.Show("Số ô cờ phải nhỏ hơn 64", "Số thóc phải nhỏ hơn 64", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double tongsothoc = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < soO; i++)
            {
                tongsothoc += Math.Pow(2, i);
                listBox1.Items.Add("Ô thứ " + (i + 1) + " có " + Math.Pow(2, i) + " thóc");
            }



        }
    }
}
