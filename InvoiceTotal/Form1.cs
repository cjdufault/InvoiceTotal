using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtSubTotal.Text, out double subtotal))
            {
                double discountPercent = 0;

                if(subtotal > 100 && subtotal <= 250)
                {
                    discountPercent = .1;
                }
                else if(subtotal > 100 && subtotal <= 500)
                {
                    discountPercent = .15;
                }
                else if(subtotal > 500)
                {
                    discountPercent = .2;
                }

                double discountAmount = subtotal * discountPercent;
                double total = subtotal - discountAmount;

                txtDiscountPercent.Text = discountPercent.ToString("p1");
                txtDiscountValue.Text = discountAmount.ToString("c");
                txtTotal.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Invalid input.", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
