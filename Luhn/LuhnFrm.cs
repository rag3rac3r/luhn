using System;
using System.Drawing;
using System.Windows.Forms;

namespace Luhn
{
    public partial class LuhnFrm : Form
    {
        private bool hasValidated = false;

        public LuhnFrm()
        {
            InitializeComponent();
        }

        #region Validate tab

        private void txtVal_KeyDown(object sender, KeyEventArgs e)
        {
            // Just react on enter, the rest can do what it likes.
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger Validate button
                btnVal_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape && hasValidated)
            {
                // Trigger Clear button
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblValRes.BackColor = Color.Transparent;
            lblValRes.Text = "";
            txtVal.Text = "";
            hasValidated = false;
        }
        
        private void btnVal_Click(object sender, EventArgs e)
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
                hasValidated = true;
            }
        }

        #endregion

        #region Generate tab

        private void boxBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGen_Click(sender, e);
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

        #endregion
    }
}
