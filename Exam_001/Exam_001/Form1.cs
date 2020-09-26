using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Income;
        int outcome;
        int keeps_money;
        int price;
        int total;

        private void txtIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtIncome.Text != "")
                {
                    Income = int.Parse(txtIncome.Text);
                    txtOutcome.Enabled = true;
                    txtOutcome.Focus();
                }
            }
        }

        private void txtOutcome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtOutcome.Text != "")
                {
                    outcome = int.Parse(txtOutcome.Text);
                    txtPrice.Enabled = true;
                    txtPrice.Focus();
                }
            }
        }

 

        private void button1_Click(object sender, EventArgs e)
        {

            total = Income - outcome;
            keeps_money = price / total;
            txtMoney.Text = Convert.ToString(keeps_money);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIncome.Focus();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPrice.Text != "")
                {
                    price = int.Parse(txtPrice.Text);
                    button1.Enabled = true;
                }
            }
        }

     
    }
}
