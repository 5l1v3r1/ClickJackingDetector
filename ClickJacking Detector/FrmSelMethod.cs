using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClickJacking_Detector
{
    public partial class FrmSelMethod : Form
    {
        public FrmSelMethod()
        {

            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;

        }

        private void FrmSelMethod_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
