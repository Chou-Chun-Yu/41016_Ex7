using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_EX7
{
    class Checkout
    {
        public Menu F;

        public string GetReceipt()
        {
            string starter = "";
            string main = "";
            string dessert = "";
            string beverge = "";
            string membership = "";
            string result = "";
            double total = 0;

            if (F.chk_Starter.Checked)
            {
                if (F.rb_Salad.Checked)
                {
                    starter = "沙拉" + F.textBox1.Text + "份,";
                    total += 35 * Convert.ToInt32(F.textBox1.Text);
                }
                else if (F.rb_Soup.Checked)
                {
                    starter = "濃湯" + F.textBox1.Text + "份,";
                    total += 30 * Convert.ToInt32(F.textBox1.Text);
                }
                else if (F.rb_Bun.Checked)
                {
                    starter = "餐包" + F.textBox1.Text + "份,";
                    total += 25 * Convert.ToInt32(F.textBox1.Text);
                }
                result += starter;
            }

            if (F.chk_Main.Checked)
            {
                if (F.rb_Steak.Checked)
                {
                    main = "牛排" + F.textBox1.Text + "份,";
                    total += 150 * Convert.ToInt32(F.textBox2.Text);
                }
                else if (F.rb_Noodle.Checked)
                {
                    main = "義大利麵" + F.textBox1.Text + "份,";
                    total += 175 * Convert.ToInt32(F.textBox2.Text);
                }
                else if (F.rb_Chicken.Checked)
                {
                    main = "雞腿排" + F.textBox1.Text + "份,";
                    total += 125 * Convert.ToInt32(F.textBox2.Text);
                }
                result += main;
            }

            if (F.chk_Dessert.Checked)
            {
                if (F.rb_Pudding.Checked)
                {
                    dessert = "布丁" + F.textBox1.Text + "份,";
                    total += 15 * Convert.ToInt32(F.textBox3.Text);
                }
                else if (F.rb_Cheese.Checked)
                {
                    dessert = "奶酪" + F.textBox1.Text + "份,";
                    total += 20 * Convert.ToInt32(F.textBox3.Text);
                }
                else if (F.rb_Ice.Checked)
                {
                    dessert = "冰淇淋" + F.textBox1.Text + "份,";
                    total += 25 * Convert.ToInt32(F.textBox3.Text);
                }
                result += dessert;
            }

            if (F.chk_Beverge.Checked)
            {
                if (F.rb_Coke.Checked)
                {
                    beverge = "可樂" + F.textBox1.Text + "份,";
                    total += 30 * Convert.ToInt32(F.textBox4.Text);
                }
                else if (F.rb_Tea.Checked)
                {
                    beverge = "紅茶" + F.textBox1.Text + "份,";
                    total += 25 * Convert.ToInt32(F.textBox4.Text);
                }
                else if (F.rb_Coffee.Checked)
                {
                    beverge = "咖啡" + F.textBox1.Text + "份,";
                    total += 35 * Convert.ToInt32(F.textBox4.Text);
                }
                result += beverge;
            }
            result += "共" + total + "元\n";

            if (F.Mem_Gold.Checked)
            {
                total = total * 0.8;
                membership = "金卡會員打8折,共需付" + total + "元\n";
            }
            else if (F.Mem_normal.Checked)
            {
                total = total * 0.9;
                membership = "普卡會員打9折,共需付" + total + "元\n";
            }
            else if (F.Mem_non.Checked)
            {
                membership = "非會員不打折,共需付" + total + "元\n";
            }
            result += membership;

            return result;
        }
    }
}
