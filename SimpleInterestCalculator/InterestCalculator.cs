using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculator
{
    public partial class IterestCalculatorForm : Form
    {
        public IterestCalculatorForm()
        {
            InitializeComponent();
        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text != "" && txtRate.Text != "" && txtTime.Text != "")
            {
                try
                {
                    var interest = new Interest
                    {
                        Principal = Convert.ToSingle(txtPrincipal.Text),
                        Rate = Convert.ToSingle(txtRate.Text),
                        Time = Convert.ToSingle(txtTime.Text)
                    };
                MessageBox.Show($"Interest = {interest.Calculate()} Amount = {interest.Amount}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid user input.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the value.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
