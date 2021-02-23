using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO：日付妥当性チェック正規化

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

            // 月の取得
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            // 西暦年の取得とエラーチェック
            if (!this.MonthDayConsistencyCheck(seirekiNen, month, day))
            {
                label1.Text = "あり得ない日付";
                return;
            }

            decimal week = this.Zeller(seirekiNen, month, day);

            // 0 ～ 6 日曜 ～ 
            if (week == 0)
            {
                label1.Text = "日曜日です。";
            }
            else if (week == 1)
            {
                label1.Text = "月曜日です。";
            }
            else if (week == 2)
            {
                label1.Text = "火曜日です。";
            }
            else if (week == 3)
            {
                label1.Text = "水曜日です。";
            }
            else if (week == 4)
            {
                label1.Text = "木曜日です。";
            }
            else if (week == 5)
            {
                label1.Text = "金曜日です。";
            }
            else if (week == 6)
            {
                label1.Text = "土曜日です。";
            }

            return;
        }

        // 年月日の妥当性チェックを行うメソッド
        // return true：妥当 false：妥当でない
        private bool MonthDayConsistencyCheck(int year, int month, int day)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day <= 31)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (month == 2)
            {
                if (this.IsLeapYear(year))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        // 閏年かどうか判定するメソッド
        // return true：閏年 false：閏年ではない
        private bool IsLeapYear(int year)
        {
            // 4で割り切れる かつ 100で割り切れない または
            // 400で割り切れる場合は閏年
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private decimal Zeller(int seirekiNen, int month, int day)
        {
            return 5 * seirekiNen / 4 - seirekiNen / 100 + seirekiNen / 400 + (26m + 16) / 10 + day % 7;
        }
    }
}
