﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Christian J Munoz
 * Date:5/8/2022
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:I use examples form the website stackoverflow.com to give me ideas on how to create the code
              and solve things I'm stuck on.
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            

            // INPUT
           
            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            // OUTPUT
            // set the output to visible

            // turn the Go button off
        }

        public int Square(int num)
        {
            // we will create this code in class
        }

        public int Cube(int num)
        {
            // we will create this code in class
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
        }

        private void xInputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
