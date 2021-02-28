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
// TODO：MonthDayConsistencyCheckの判定に誤りあり

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
                labelHantei.Text = "あり得ない日付";
                return;
            }

            decimal week = this.GetDayOfWeek(seirekiNen, month, day);

            Console.WriteLine(week);

            // 0 ～ 6 日曜 ～ 
            if (week == 0)
            {
                labelHantei.Text = "日曜日です。";
            }
            else if (week == 1)
            {
                labelHantei.Text = "月曜日です。";
            }
            else if (week == 2)
            {
                labelHantei.Text = "火曜日です。";
            }
            else if (week == 3)
            {
                labelHantei.Text = "水曜日です。";
            }
            else if (week == 4)
            {
                labelHantei.Text = "木曜日です。";
            }
            else if (week == 5)
            {
                labelHantei.Text = "金曜日です。";
            }
            else if (week == 6)
            {
                labelHantei.Text = "土曜日です。";
            }

            return;
        }

        // 年月日の妥当性チェックを行うメソッド
        // return true：妥当 false：妥当でない
        private bool MonthDayConsistencyCheck(int year, int month, int day)
        {
            // 末日が31日な月の判定
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return day <= 31;
            }

            // 末日が30日な月の判定
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return day <= 30;
            }

            // ２月の判定
            if (month == 2)
            {
                if (this.IsLeapYear(year))
                {
                    return day <= 29;
                }
                else
                {
                    return day <= 28;
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

        // 西暦年、月、日から曜日を求めるメソッド
        // return 0：日曜 1：月曜 2：火曜 3：水曜 4：木曜 5：金曜 6：土曜
        private decimal GetDayOfWeek(int year, int month, int day)
        {
            // ツェラーの公式を使用して曜日を算出
            // 1月と2月は、それぞれ13月と14月として公式に当てはめる
            if (month == 1 || month == 2)
            {
                year -= 1;
                month = 12 + month;
            }

            return (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
        }
    }
}
