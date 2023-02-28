using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CODED BY KATHLEEN FORGIARINI DA SILVA
// 02-28-2023
// SIMULATION MIDTERM SECTION 3, converting area from metric to US or Imperial

namespace testtestsection3
{
    
    public partial class frmAreaConvert : Form
    {
        public frmAreaConvert()
        {
            InitializeComponent();
        }

        private void frmAreaConvert_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox1.Text);
                ConvertArea ca1 = new ConvertArea();
                ca1.MetricArea = value;
                textBox5.Text = ca1.cmToIn().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! An exception occurred - Details: " + ex.Message);
                textBox1.Focus();
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox2.Text);
                ConvertArea ca2 = new ConvertArea();
                ca2.MetricArea = value;
                textBox6.Text = ca2.mToYd().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! An exception occurred - Details: " + ex.Message);
                textBox2.Focus();
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox3.Text);
                ConvertArea ca3 = new ConvertArea();
                ca3.MetricArea = value;
                textBox7.Text = ca3.haToAcres().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! An exception occurred - Details: " + ex.Message);
                textBox3.Focus();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox4.Text);
                ConvertArea ca4 = new ConvertArea();
                ca4.MetricArea = value;
                textBox8.Text = ca4.kmToMile().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! An exception occurred - Details: " + ex.Message);
                textBox4.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to quit?", "Exit", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                MessageBox.Show("You decide to quit");
                this.Close();
            } else
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
            }
        }
    }
}
