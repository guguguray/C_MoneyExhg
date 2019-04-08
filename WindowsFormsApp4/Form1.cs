/* 找零錢 1000 元總
 * 找零的面額有:
 * 200, 100, 50, 10, 5, 1 
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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private int hung2, hung1, fif, ten, fiv, one, exg_total, exg;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tboxShow.ResetText();
            hung2 = 0;
            hung1 = 0;
            fif = 0;
            ten = 0;
            fiv = 0;
            one = 0;

            exg_total = 1000 - int.Parse(txtExchg.Text);
            exg = exg_total;
            // tboxShow.Text = exg_total.ToString();

            if (exg / 200 != 0)
            {
                hung2 = exg / 200;
                exg = exg % 200;
            }

            if (exg / 100 != 0)
            {
                hung1 = exg / 100;
                exg = exg % 100;
            }

            if (exg / 50 != 0)
            {
                fif = exg / 50;
                exg = exg % 50;
            }

            if (exg_total / 10 != 0)
            {
                ten = exg / 10;
                exg = exg % 10;
            }

            if (exg / 5 != 0)
            {
                fiv = exg / 5;
                exg = exg % 5;
            }

            one = exg;

            String myStr = "應找零錢: 共 " + exg_total + "元\n\n";
            if (hung2 != 0)
                myStr += "200元:\t" + hung2.ToString() + "張\n";
            if (hung1 != 0)
                myStr += "100元:\t" + hung1.ToString() + "張\n";
            if (fif != 0)
                myStr += "50元:\t" + fif.ToString() + "個\n";
            if (ten != 0)
                myStr += "10元:\t" + ten.ToString() + "個\n";
            if (fiv != 0)
                myStr += "5元:\t" + fiv.ToString() + "個\n";
            if (one != 0)
                myStr += "1元:\t" + one.ToString() + "個\n";

            // MessageBox.Show(myStr);
            tboxShow.AppendText(myStr);
        }
    }
}
