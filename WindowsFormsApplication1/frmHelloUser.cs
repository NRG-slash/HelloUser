
/*
 *
 * Name: Garrett Laturski
 * 
 * Teacher: Mr.Hardmen
 * 
 * Assignment #, Program #2
 * 
 * Date Last Modified: 
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

namespace WindowsFormsApplication1
{
    public partial class frmHelloUser : Form
    {
        public frmHelloUser()
        {
            InitializeComponent();
        }

        private void BTNPress_Click(object sender, EventArgs e)
        {
            string userName;

            userName = txtName.Text;

            LBLHi.Text = "Hello " + userName;

            double firstNumber;
            double secondNumber;

            firstNumber = Convert.ToDouble(txtNum.Text);
            secondNumber = Convert.ToDouble(txtNum2.Text);

            double sum = firstNumber + secondNumber;
            double difference = firstNumber - secondNumber;
            double product = firstNumber * secondNumber;
            double Quotient = firstNumber / secondNumber;
            double mod = firstNumber % secondNumber;

            LBLHi.Text += "\nYour sum is:" + sum;
            LBLHi.Text += "\nYour difference is: " + difference;
            LBLHi.Text += "\nYour product is: " + product;
            LBLHi.Text += "\nYour quotient is: " + Quotient;
            LBLHi.Text += "\nYour modulus is: " + mod;
        }

        private void lblWhat_Click(object sender, EventArgs e)
        {

        }

        private void LBLHi_Click(object sender, EventArgs e)
        {

        }

        private void frmHelloUser_Load(object sender, EventArgs e)
        {

        }
    }
}
