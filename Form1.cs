using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaman_SecOPs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            string message = "Shaman SecOPs version 1.0 2023 ";
            string title = "About Shaman";
            MessageBox.Show(message, title);
        }
    }
}
