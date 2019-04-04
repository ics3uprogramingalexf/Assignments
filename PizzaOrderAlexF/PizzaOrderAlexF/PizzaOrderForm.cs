/*
 * Created by: Alex Forgeron
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Assignment #5
 * This program calculates pizza cost
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderAlexF
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            {
                //Local Variables
                double pizzaCost, toppingsCost, subtotal, hst, total;

                //How much the Pizza Cost
                if (nudSize.Value == 1)
                {
                    pizzaCost = 6.99;
                }
                else
                {
                    if (nudSize.Value == 2)
                    {
                        pizzaCost = 10.99;
                    }
                    else
                    {
                        pizzaCost = 12.99;
                    }
                }

                //How much the Toppings Cost
                if (nudToppings.Value == 1)
                {
                    toppingsCost = 0.75;
                }
                else
                {
                    if (nudToppings.Value == 2)
                    {
                        toppingsCost = 1.35;
                    }
                    else
                    {
                        if (nudToppings.Value == 3)
                        {
                            toppingsCost = 2.15;
                        }
                        else
                        {
                            if (nudToppings.Value == 4)
                            {
                                toppingsCost = 2.75;
                            }
                            else
                            {
                                toppingsCost = 3.25;
                            }
                        }
                    }
                }
                // Calculations for cost
                subtotal = pizzaCost + toppingsCost;
                hst = subtotal * 0.13;
                total = subtotal + hst;

                //displaying costs on labels 
                lblSubtotal.Text = String.Format("Subtotal = ${0:0.00}", subtotal);
                lblHST.Text = string.Format("hst = ${0:0.00}", hst);
                lblTotal.Text = String.Format("total = ${0:0.00}", total);

            }
        }
    }
}