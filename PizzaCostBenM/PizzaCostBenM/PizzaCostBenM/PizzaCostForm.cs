/*
 * Created by: Ben Motz
 * Created on: 01-Oct-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pseudocode
 * This program displays the subtotal ,HST and total of a pizza depedning on diameter and number of pizzas
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

namespace PizzaCostBenM
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPizzaCost_Load(object sender, EventArgs e)
        {
            //Hides Labels
            this.lblSubtotal.Hide();
            this.lblTotal.Hide();
            this.lblHst.Hide();
            this.lblYourHstIs.Hide();
            this.lblYourSubIs.Hide();
            this.lblYourTotIs.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare Local Variables
            double diameter, numberofza, subtotal, hstprice, total;

            //Declare constant
            const double HST = 0.13;

            //Convert to double
            diameter = (double)(nudDiameter.Value);
            numberofza = (double)(nudNumberOfZa.Value);

            //Calculate
            subtotal = numberofza * (0.99+0.75+(diameter * 0.50));
            hstprice = subtotal * HST;
            total = hstprice + subtotal;

            //Displays the cost
            this.lblSubtotal.Text = String.Format("${0:0.00}", subtotal);
            this.lblHst.Text = String.Format("${0:0.00}", hstprice);
            this.lblTotal.Text = String.Format("${0:0.00}", total);

            this.lblHst.Show();
            this.lblSubtotal.Show();
            this.lblTotal.Show();
            this.lblYourHstIs.Show();
            this.lblYourSubIs.Show();
            this.lblYourTotIs.Show();
        }
    }
}
