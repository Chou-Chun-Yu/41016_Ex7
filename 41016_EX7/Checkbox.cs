using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_EX7
{
    class Checkbox
    {
        static public Menu C;

        static internal void chk_Starter_CheckedChanged(object sender, EventArgs e)
        {
            if (C.chk_Starter.Checked)
            {
                C.groupBox1.Enabled = true;
            }
            if (!C.chk_Starter.Checked)
            {
                C.groupBox1.Enabled = false;
            }
        }
        static internal void chk_Main_CheckedChanged(object sender, EventArgs e)
        {
            if (C.chk_Main.Checked)
            {
                C.groupBox2.Enabled = true;
            }
            if (!C.chk_Main.Checked)
            {
                C.groupBox2.Enabled = false;
            }
        }
        static internal void chk_Dessert_CheckedChanged(object sender, EventArgs e)
        {
            if (C.chk_Dessert.Checked)
            {
                C.groupBox3.Enabled = true;
            }
            if (!C.chk_Dessert.Checked)
            {
                C.groupBox3.Enabled = false;
            }
        }
        static internal void chk_Beverge_CheckedChanged(object sender, EventArgs e)
        {
            if (C.chk_Beverge.Checked)
            {
                C.groupBox4.Enabled = true;
            }
            if (!C.chk_Beverge.Checked)
            {
                C.groupBox4.Enabled = false;
            }
        }
    }
}
