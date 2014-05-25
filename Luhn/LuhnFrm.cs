using System;
using System.Drawing;
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
            if (txtVal.TextLength <= 0)
            {
                MessageBox.Show("Can not be empty");
            }
            else
            {
                if (Luhn.LuhnVal(txtVal.Text))
                {
                    lblValRes.BackColor = Color.Lime;
                    lblValRes.Text = "Valid";
                }
                else
                {
                    lblValRes.BackColor = Color.Red;
                    lblValRes.Text = "Invalid";
                }
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (boxBase.TextLength <= 0)
            {
                MessageBox.Show("Cannot be empty");
            }
            else
            {
                boxResult.Text = boxBase.Text + Luhn.LuhnGen(boxBase.Text);
            }
        }
    }
}
