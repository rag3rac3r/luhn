using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Luhn
{
    public partial class LuhnFrm : Form
    {
        public LuhnFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblValRes.BackColor = Color.Transparent;
            if (Luhn.LuhnVal(txtVal.Text))
            {
                lblValRes.BackColor = Color.Lime;
                lblValRes.Text = "Valid";
                //MessageBox.Show("Value is correct");
            }
            else
            {
                lblValRes.BackColor = Color.Red;
                lblValRes.Text = "Invalid";
                //MessageBox.Show("Value is incorrect");
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            boxResult.Text = Luhn.LuhnGen(boxBase.Text);
        }
    }
}
