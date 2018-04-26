using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            {

                double ba, uc, tax, ta;
                uc = Convert.ToDouble(txt__units.Text);
                                
              
                if (cb_types.SelectedIndex==0)
                {
                    if (uc > 100)
                    {
                        ba = uc * 30;
                        tax = ba * .05;
                    }

                    else if (uc > 50)
                    {
                        ba = uc * 20;
                        tax = ba * .03;
                    }

                    else
                    {
                        ba = uc * 10;
                        tax = ba * .02;
                    }

                    ta = ba + tax;

                    lbl_ba.Text = ba.ToString();
                    lbl_tax.Text = tax.ToString();
                    lbl_ta.Text = ta.ToString();
                }

                else if (cb_types.SelectedIndex == 1)
                {
                    if (uc > 100)
                    { 
                        ba = uc * 100;
                        tax = ba * .1;
                    }

                    else if (uc > 50)
                    {
                        ba = uc * 50;
                        tax = ba * .08;
                    }

                    else
                    {
                        ba = uc * 20;
                        tax = ba * .05;
                    }

                    ta = ba + tax;

                    lbl_ba.Text = "Bill Amount :" + ba.ToString();
                    lbl_tax.Text = "Tax Amount :" + tax.ToString();
                    lbl_ta.Text = "Total Bill Amount :" + ta.ToString();
                }






            }


}

        private void btn_ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
