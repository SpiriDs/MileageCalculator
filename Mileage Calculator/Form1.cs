using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        readonly double reimbursedRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage >= endingMileage)
            {
                MessageBox.Show("The Starting mileage must be less then the ending mileage", "Cannot Calculate Mileage");
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimbursedRate;
                label4.Text = "$" + amountOwed;

            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int drivenMiles;
            drivenMiles = (int)numericUpDown2.Value - (int)numericUpDown1.Value;
            MessageBox.Show(drivenMiles + " miles this trip", "Miles Traveled");
        }
    }
}
