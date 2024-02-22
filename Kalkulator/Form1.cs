using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double HasilTemp;
        char LambangOperator;
        bool OperatorDitekan;

        private void fokuskan()
        {
            txtUtama.Focus();
            txtUtama.Select(txtUtama.Text.Length, 1);
        }

        private void clearkan()
        {
           txtUtama.Text = "0";
           txtTemp.Text = "";
           HasilTemp = 0;
           LambangOperator = ' ';
           OperatorDitekan = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            clearkan();
            fokuskan();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn1.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn2.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn3.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn4.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn5.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn6.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn7.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn8.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn9.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text == "0")
            {
                txtUtama.Clear();
            }
            txtUtama.Text = txtUtama.Text + btn0.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            if (txtUtama.Text.Contains(',') == false)
            {
                txtUtama.Text = txtUtama.Text + ",";
            }
            fokuskan();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            txtUtama.Text = (Convert.ToDouble(txtUtama.Text) * -1).ToString();
            fokuskan();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearkan();
            fokuskan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            txtUtama.Text = txtUtama.Text.Remove(txtUtama.Text.Length -1);
            if ((txtUtama.Text == "") || (txtUtama.Text == "-"))
            {
                txtUtama.Text = "0";
            }
            fokuskan();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btnOp = (Button)sender;

            if(OperatorDitekan == false)
            {
                if (txtTemp.Text == "")
                {
                    HasilTemp = Convert.ToDouble(txtUtama.Text);
                }
                else
                {
                    if (LambangOperator == '+')
                    {
                        HasilTemp = HasilTemp + Convert.ToDouble(txtUtama.Text);
                    }
                    else if (LambangOperator == '-')
                    {
                        HasilTemp = HasilTemp - Convert.ToDouble(txtUtama.Text);
                    }
                    else if (LambangOperator == ':')
                    {
                        HasilTemp = HasilTemp / Convert.ToDouble(txtUtama.Text);
                    }
                    else if (LambangOperator == 'X')
                    {
                        HasilTemp = HasilTemp * Convert.ToDouble(txtUtama.Text);
                    }
                }
            }

            if (btnOp.Text == "=")
            {
                txtTemp.Text = "";
                txtUtama.Text = HasilTemp.ToString();
            }
            else
            {
                txtTemp.Text = HasilTemp.ToString() + btnOp.Text;
                txtUtama.Text = "0";
            }
           
            LambangOperator = Convert.ToChar(btnOp.Text);
            OperatorDitekan = true;
            fokuskan();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtUtama.Text = "0";
            fokuskan();
        }
    }
}
