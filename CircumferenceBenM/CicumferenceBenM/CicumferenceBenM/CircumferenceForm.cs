/*
 * Created by: Ben Motz
 * Created on: 26-Sep-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 -Top down design and flow chart
 * This program displays the circumference depending on what the user enters in tghe text box.
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

namespace CicumferenceBenM
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        private void frmCircumference_Load(object sender, EventArgs e)
        {
            //Hides Label RadIS
            this.lblRadIs.Hide();
            //Hides Label RadAns
            this.lblRadAns.Hide();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variable
            double radius, circumference;

            //Converts string from text box to a double
            radius = double.Parse(txtEnterRad.Text);

            //Calculates the Circumference
            circumference = (Math.PI * (2 * radius));

            //Circumference in it's Label
            this.lblRadAns.Text = Convert.ToString(circumference) + "cm";

            //Displays Labels
            this.lblRadAns.Show();
            this.lblRadIs.Show();

      
        }
    }
}
