using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (principalTextBox.Text != string.Empty && rateTextBox.Text != string.Empty && periodTextBox.Text != string.Empty)
            {
                //interest = principal * rate * period / 1200
                var interest = double.Parse(principalTextBox.Text) * double.Parse(rateTextBox.Text) * double.Parse(periodTextBox.Text) / 1200;
                //MessageBox.Show(interest.ToString(),"interest is:");
                var amount = double.Parse(principalTextBox.Text) + interest;
                interestTextBox.Text = interest.ToString();
                amountTextBox.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("Enter the values for principal, rate and period");
            }
            
           
        }
    }
}
