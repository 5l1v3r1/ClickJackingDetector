using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClickJacking_Detector
{
    public partial class FormDever : Form
    {
        public FormDever()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Launch("http://facebook.com/prince.gersy2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.Launch("http://twitter.com/yasser.gersy");

        }

        public void button3_Click(object sender, EventArgs e)
        {
            Form1.Launch("http://ask.fm/yasser.gersy");

        }
    }
}
