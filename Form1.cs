using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalProgram
{
    public partial class frmFindTotal : Form
    {
        public frmFindTotal()
        {
            InitializeComponent();
        }

        private void frmFindTotal_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString(Convert.ToDouble(txtNo1.Text) + Convert.ToDouble(txtNo2.Text) + Convert.ToDouble(txtNo3.Text));
            txtAverage.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) / 3);
            if (Convert.ToDouble(txtAverage.Text) >= 75)
            {
                txtResult.Text = "Very Good";
            }
            else
            {
                if (Convert.ToDouble(txtAverage.Text) >= 65)
                {
                    txtResult.Text = "Good";
                }
                else
                {
                    if (Convert.ToDouble(txtAverage.Text) >= 55)
                    {
                        txtResult.Text = "Pass";
                    }
                    else
                    {
                        txtResult.Text = "Fail";
                    }
                }
            }
            double No1 = Convert.ToDouble(txtNo1.Text);
            double No2 = Convert.ToDouble(txtNo2.Text);
            double No3 = Convert.ToDouble(txtNo3.Text);
            if (No1 > No2)
            {
                if (No1 > No3)
                {
                    //txtLargestValue.Text = Convert.ToString(No1);
                    txtLargeValue.Text = txtNo1.Text;
                }
                else
                {
                    txtLargeValue.Text = txtNo3.Text;
                }
            }
            else
            {
                if (No2 > No3)
                {
                    txtLargeValue.Text = txtNo2.Text;
                }
                else
                {
                    txtLargeValue.Text = txtNo3.Text;
                }

            }
         

            {

            }

        }
    }
}