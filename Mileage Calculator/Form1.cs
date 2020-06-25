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
        double reimbursedRate = 0.39;
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
                MessageBox.Show("Cannot Calculate Mileage", "The Starting mileage must be less then the ending mileage");
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimbursedRate;
                label4.Text = "$" + amountOwed;
            }


        }




    }
}
