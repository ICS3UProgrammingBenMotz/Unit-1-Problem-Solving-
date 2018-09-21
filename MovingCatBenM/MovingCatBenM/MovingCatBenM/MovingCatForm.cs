/*
 * Created by: Ben Motz
 * Created on: 18-Sep-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program displays a moving cat wehn you select a meni item.
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

namespace MovingCatBenM
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //This closes the program
            this.Close();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //This chanegs the image to Cat1
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //This changes the image to Cat2
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
