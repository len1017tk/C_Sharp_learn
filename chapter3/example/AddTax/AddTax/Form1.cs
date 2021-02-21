using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBoxManey.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            labelAddTax.Text = money + " 円";
        }
    }
}
