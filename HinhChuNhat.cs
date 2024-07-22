using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuviDientich
{
    public partial class HinhChuNhat : Form
    {
        public HinhChuNhat()
        {
            InitializeComponent();
        }
        double a, b;
        private void Calculator_Click(object sender, EventArgs e)
        {
            Laythongtin();
            CvTxt.Text = Chuvi(a,b).ToString();
            DtTxt.Text = Dientich(a,b).ToString();
        }

        private double Chuvi(double a, double b)
        {
            return (a+b) * 2;
        }

        private double Dientich(double a, double b)
        {
            return a * b;
        }
        private void Laythongtin()
        {
            try
            {
                double a = Convert.ToDouble(CdTxt.Text);
                double b = Convert.ToDouble(CrTxt.Text);
            }
            catch 
            {
                MessageBox.Show("Phải nhập số!!!" + MessageBoxButtons.OK);
                CdTxt.Text = "";
                CrTxt.Text = "";
                CdTxt.Focus();
                return;

            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
