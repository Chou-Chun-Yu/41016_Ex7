using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_EX7
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            Checkbox.C = this;
            RadioButton.R = this;

        }

        private void bt_Check_Click(object sender, EventArgs e)
        {
            Checkout check = new Checkout();
            check.F = this;
            MessageBox.Show(check.GetReceipt(), "結帳清單");
        }

    }
}