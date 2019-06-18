using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float num, ans;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        public void deshabilitar()
        {
            lblprint.Text = "";
            textBox1.Enabled = false;
            btnOff.Show();
            textBox1.Text = "";
            btnEqual.Enabled = false;
            btn9.Enabled = false;
            btnDot.Enabled = false;
            btnRestar.Enabled = false;
            btnDividir.Enabled = false;
            btn7.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn8.Enabled = false;
            btnMultiplicar.Enabled = false;
            btnsumar.Enabled = false;
            btnRetro.Enabled = false;
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;

        }

        public void habilitar()
        {
            textBox1.Enabled = false;
            btnOff.Show();
            textBox1.Text = "";
            btnEqual.Enabled = true;
            btn9.Enabled = true;
            btnDot.Enabled = true;
            btnRestar.Enabled = true;
            btnDividir.Enabled = true;
            btn7.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn8.Enabled = true;
            btnMultiplicar.Enabled = true;
            btnsumar.Enabled = true;
            btnRetro.Enabled = true;
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            deshabilitar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            lblprint.Text = num.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            lblprint.Text = num.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            lblprint.Text = num.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            lblprint.Text = num.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operacion();
            lblprint.Text = "";
        }

        private void btnRetro_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string tex = textBox1.Text;
            textBox1.Clear();
            for (int j = 0; j < lenght; j++)
                textBox1.Text = textBox1.Text + tex[j];
           

        }

        public void operacion()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
            }
        }
    }
}
