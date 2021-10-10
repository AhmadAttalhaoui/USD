using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btChange_Click(object sender, EventArgs e)
        {

            
            if (tbEuro.Text != "")
            {
                double etd = double.Parse(tbEuro.Text) * 1.16;
                tb_USD.Text = etd.ToString();
                
            }
            
          else if (tbFranken.Text != "")
            {
                double ftd = double.Parse(tbFranken.Text) * 1.08;
                tb_USD.Text = ftd.ToString();
                

            }
           
           else if (tbPound.Text != "")
            {
                double ptd = double.Parse(tbPound.Text) * 1.36;
                tb_USD.Text = ptd.ToString();
                
            }
            

          else if (tbRupees.Text != "")
            {
                double rtd = double.Parse(tbRupees.Text) * 0.013;
                tb_USD.Text = rtd.ToString();
                
            }
            

          else if (tbYen.Text != "")
            {
                double ytd = double.Parse(tbYen.Text) * 0.0089;
                tb_USD.Text = ytd.ToString();
                
            }
            


            if (tb_USD.Text != "")
            {

                USD dollar = new USD(double.Parse(tb_USD.Text));
                USD euro = new Euro(double.Parse(tb_USD.Text));
                USD pounds = new Pounds(double.Parse(tb_USD.Text));
                USD yen = new Yen(double.Parse(tb_USD.Text));
                USD franken = new Franken(double.Parse(tb_USD.Text));
                USD rupees = new Rupees(double.Parse(tb_USD.Text));

                tb_USD.Text = dollar.ToString();
                tbEuro.Text = euro.ToString();
                tbFranken.Text = franken.ToString();
                tbPound.Text = pounds.ToString();
                tbYen.Text = yen.ToString();
                tbRupees.Text = rupees.ToString();
                
            }


            
        }
    }
}
