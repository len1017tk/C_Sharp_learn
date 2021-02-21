using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYoubiSanshutsu_Click(object sender, EventArgs e)
        {
            // 西暦年の取得とエラーチェック
            if (int.TryParse(textBoxSeirekiNen.Text, out int seirekiNen) == false ||
                seirekiNen < 0)
            {
                labelHantei.Text = "西暦年エラー";
                return;
            }
            





        }
    }
}
