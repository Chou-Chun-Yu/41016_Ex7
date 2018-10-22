using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41016_EX7
{
    class RadioButton
    {
        static public Menu R;

        static internal void rb_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Salad.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Salad;
            }
        }
        static internal void rb_Soup_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Soup.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Soup;
            }
        }
        static internal void rb_Bun_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Bun.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Bun;
            }
        }
        static internal void rb_Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Steak.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Steak;
            }
        }
        static internal void rb_Noodle_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Noodle.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Noodle;
            }
        }
        static internal void rb_Chicken_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Chicken.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Chicken;
            }
        }
        static internal void rb_Pudding_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Pudding.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Pudding;
            }
        }
        static internal void rb_Cheese_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Cheese.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Cheese;
            }
        }
        static internal void rb_Ice_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Ice.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Ice;
            }
        }
        static internal void rb_Coke_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Coke.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Coke;
            }
        }
        static internal void rb_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Tea.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Tea;
            }
        }
        static internal void rb_Coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (R.rb_Coffee.Checked)
            {
                R.pictureBox1.Image = Properties.Resources.Coffee;
            }
        }
    }
}
