using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
//I have changes！！
namespace ChineseWordSegmentation1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void segmentButton_Click(object sender, EventArgs e)
        {
            completeSegmentation segment = new completeSegmentation();
            segmenTextBox.Text = segment.forwoardSegmentation(enterTextBox.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
