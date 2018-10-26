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
            C.groupBox1.Enabled = C.chk_Starter.Checked ? true : false;
        }
        static internal void chk_Main_CheckedChanged(object sender, EventArgs e)
        {
            C.groupBox2.Enabled = C.chk_Main.Checked ? true : false;
        }
        static internal void chk_Dessert_CheckedChanged(object sender, EventArgs e)
        {
                C.groupBox3.Enabled = C.chk_Dessert.Checked ? true : false;
        }
        static internal void chk_Beverge_CheckedChanged(object sender, EventArgs e)
        {
                C.groupBox4.Enabled = C.chk_Beverge.Checked ? true : false;
        }
    }
}
