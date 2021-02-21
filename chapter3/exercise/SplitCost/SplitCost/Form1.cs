using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maney  = int.Parse(textBox1.Text); // 金額
            int number = int.Parse(textBox2.Text); // 人数

            // 税込み金額の計算
            const double Tax = 0.1;
            double addTax = maney * (1 + Tax);
            maney = (int)addTax;

            label6.Text = maney / number + " 円";
            label8.Text = maney % number + " 人";
        }
    }
}
