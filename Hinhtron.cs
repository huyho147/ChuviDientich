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
    public partial class Hinhtron : Form
    {
        public Hinhtron()
        {
            InitializeComponent();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(BkTxt.Text);   
            CvTxt.Text = Chuvi(r).ToString();
            DtTxt.Text = Dientich(r).ToString();
        }

        private double Chuvi(double r)
        {
            return 2 * Math.PI * r;
        }

        private double Dientich(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
