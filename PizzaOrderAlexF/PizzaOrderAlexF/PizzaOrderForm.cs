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
                double pizzaCost, toppingsCost, friesCost, sodaCost, subtotal, hst, total;
                const double HST = 0.13;

                //Pizza Cost
                if (nudSize.Value == 1)
                {
                    pizzaCost = 7.99;
                }
                else
                {
                    if (nudSize.Value == 2)
                    {
                        pizzaCost = 9.99;
                    }
                    else
                    {
                        pizzaCost = 12.99;
                    }
                }

                //Toppings Cost
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
                                toppingsCost = 3.35;
                            }
                        }
                    }
                }
            }
        }
    }
}