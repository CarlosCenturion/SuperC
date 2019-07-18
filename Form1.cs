using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalc
{
    public partial class fMain : Form
    {

        private string _Operand;
        private string _OperandTxt;
        private decimal _NumberA;
        private decimal _NumberB;

        public fMain()
        {
           
            InitializeComponent();
        }

        private void SetOperand(string value)
        {
            _Operand = value;
        }
        private void SetOperandTxt(string value)
        {
            _OperandTxt += value;
            txtResult.Text = _OperandTxt;
            
        }

     

        private void BtnN0_Click(object sender, EventArgs e)
        {
            SetOperandTxt("0");
        }

        private void BtnN1_Click(object sender, EventArgs e)
        {
            SetOperandTxt("1");
        }

        private void BtnN2_Click(object sender, EventArgs e)
        {
            SetOperandTxt("2");
        }

        private void BtnN3_Click(object sender, EventArgs e)
        {
            SetOperandTxt("3");
        }

        private void BtnN4_Click(object sender, EventArgs e)
        {
            SetOperandTxt("4");
        }

        private void BtnN5_Click(object sender, EventArgs e)
        {
            SetOperandTxt("5");
        }

        private void BtnN6_Click(object sender, EventArgs e)
        {
            SetOperandTxt("6");
        }

        private void BtnN7_Click(object sender, EventArgs e)
        {
            SetOperandTxt("7");
        }

        private void BtnN8_Click(object sender, EventArgs e)
        {
            SetOperandTxt("8");
        }

        private void BtnN9_Click(object sender, EventArgs e)
        {
            SetOperandTxt("9");
        }

        private void FMain_KeyPress(object sender, KeyPressEventArgs e)
        {

            SetOperandTxt(e.KeyChar.ToString());
        }

        private void BtnNE_Click(object sender, EventArgs e)
        {
            
                _NumberB = Convert.ToDecimal(txtResult.Text);
                if(_Operand == "+")
                {
                    decimal resultado = _NumberA + _NumberB;
                 txtResult.Text = Convert.ToString(resultado);
                txtProgress.Text = "";
                _OperandTxt = Convert.ToString(resultado);
                }
                else if (_Operand == "-")
                {
                decimal resultado = _NumberA - _NumberB;
                txtResult.Text = Convert.ToString(resultado);
                txtProgress.Text = "";
                _OperandTxt = Convert.ToString(resultado);

            }
            else if (_Operand == "/")
            {
                decimal resultado = _NumberA / _NumberB;
                txtResult.Text = Convert.ToString(resultado);
                txtProgress.Text = "";
                _OperandTxt = Convert.ToString(resultado);
            }
            else if (_Operand == "*")
            {
                decimal resultado = _NumberA * _NumberB;
                txtResult.Text = Convert.ToString(resultado);
                txtProgress.Text = "";
                _OperandTxt = Convert.ToString(resultado);
            }
        }

        private void BtnNP_Click(object sender, EventArgs e)
        {
            _NumberA = Convert.ToDecimal(txtResult.Text);
            SetOperandTxt("+");
            txtResult.Text = "";
            txtProgress.Text = _OperandTxt;
            _OperandTxt = "";
            SetOperand("+");
        }
        private void BtnMul_Click(object sender, EventArgs e)
        {
            _NumberA = Convert.ToDecimal(txtResult.Text);
            SetOperandTxt("*");
            txtResult.Text = "";
            txtProgress.Text = _OperandTxt;
            _OperandTxt = "";
            SetOperand("*");
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            _NumberA = Convert.ToDecimal(txtResult.Text);
            SetOperandTxt("-");
            txtResult.Text = "";
            txtProgress.Text = _OperandTxt;
            _OperandTxt = "";
            SetOperand("-");
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            _NumberA = Convert.ToDecimal(txtResult.Text);
            SetOperandTxt("/");
            txtResult.Text = "";
            txtProgress.Text = _OperandTxt;
            _OperandTxt = "";
            SetOperand("/");
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            _OperandTxt = "";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtProgress.Text = "";
            _Operand = "";
            _OperandTxt = "";
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
