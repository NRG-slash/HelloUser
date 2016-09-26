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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNPress_Click(object sender, EventArgs e)
        {
            LBLHi.Text = "Hello Mr.Handman, I mean Mr.Hardman";
        }
    }
}
