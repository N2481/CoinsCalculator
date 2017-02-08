using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinsCalculator
{
    public partial class Form1 : Form
    {
        List<double> coins = new List<double> { 8.5, 7.5, 7.8, 5.74, 4.1, 3.92, 3.06, 2.3 };
        List<double> values = new List<double> { 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            int interation = 0, totalCoins = 0;
            double weight = 0, w = 0;
            bool valueFound = false;
            Double.TryParse(tbWeight.Text, out weight);
            lbResult.Text = "Calculating...";

            for (int i0 = 0; i0 <= weight / coins[0]; i0++)
            {
                for (int i1 = 0; i1 <= weight / coins[1]; i1++)
                {
                    for (int i2 = 0; i2 <= weight / coins[2]; i2++)
                    {
                        for (int i3 = 0; i3 <= weight / coins[3]; i3++)
                        {
                            for (int i4 = 0; i4 <= weight / coins[4]; i4++)
                            {
                                for (int i5 = 0; i5 <= weight / coins[5]; i5++)
                                {
                                    for (int i6 = 0; i6 <= weight / coins[6]; i6++)
                                    {
                                        for (int i7 = 0; i7 <= weight / coins[7]; i7++)
                                        {
                                            interation++;
                                            w = i0 * coins[0] + i1 * coins[1] + i2 * coins[2] + i3 * coins[3] + i4 * coins[4] + i5 * coins[5] + i6 * coins[6] + i7 * coins[7];
                                            if (w > weight) break;

                                            if (w == weight)
                                            {
                                                valueFound = true;
                                                totalCoins = i0 + i1 + i2 + i3 + i4 + i5 + i6 + i7;
                                                double totalMoney = i0 * values[0] + i1 * values[1] + i2 * values[2] + i3 * values[3] + i4 * values[4] + i5 * values[5] + i6 * values[6] + i7 * values[7];
                                                lbResult.Text += string.Format("{0} x 2€ + {1} x 1€ + {2} x 50c€ + {3} x 20c€ + {4} x 10c€ + {5} x 5c€ + {6} x 2c€ + {7} x 1c€ = {8}€ | interations={9} | coins={10}\n\r", i0, i1, i2, i3, i4, i5, i6, i7, totalMoney, interation, totalCoins);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!valueFound) lbResult.Text = "Value not possible";
            //test
            //test2
            //test3
            //branch:JM

        }
    }
}
