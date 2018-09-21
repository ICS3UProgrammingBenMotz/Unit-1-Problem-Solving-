/*
 * Created by: Ben M
 * Created on: 18-Sep-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Area and Perimeter
 * This program displays calculations of area and perimeter depending on what the suer writes into the textbox.
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

namespace AreaPerimeterBenM
{
    public partial class frmAreaPerimeter : Form
    {
        public frmAreaPerimeter()
        {
            InitializeComponent();
        }

        private void frmAreaPerimeter_Load(object sender, EventArgs e)
        {
            
            //This hides all labels
            this.lblArea.Hide();

            this.lblPerimeter.Hide();

            this.lblAreaA.Hide();

            this.lblPerimeterA.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double length, width, area, perimeter;
            // Convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);
            // Calculates area and perimeter
            area = length * width;
            perimeter = (2 * length) + (2 * width);
            // Area and perimeter into their lables
            this.lblAreaA.Text = Convert.ToString(area) + " squared meters";
            this.lblPerimeterA.Text = Convert.ToString(perimeter) + " squared meters";
            //displays perimeter and area labels
            this.lblArea.Show();
            this.lblPerimeter.Show();
            this.lblAreaA.Show();
            this.lblPerimeterA.Show();
           
        }

        private void lblPerimeterA_Click(object sender, EventArgs e)
        {

        }
    }
}
