using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_4_currency
{
    public partial class Form1 : Form
    {
        Currency C_Euro;
        Currency C_Dollar;
        public Form1()
        {
            InitializeComponent();
        }

        double money;
        //double price_E;
        //double price_D;
        int days;
        int i;

        bool f = false;
        //const double k = 0.02;
        //Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //price_E = (double)inputPrice_E.Value;
            //days = (int)inputDays.Value;

            //chart1.Series[0].Points.Clear();
            //chart1.Series[0].Points.AddXY(0, price_E);
            //for (int i = 1; i <= days; i++)
            //{
            //    price_E = price_E * (1 + k * (rnd.NextDouble() - 0.5));
            //    chart1.Series[0].Points.AddXY(i, price_E);
            //}
            f = true;
            chek(f);
            i = 0;
            money = 500;
            num(i);
            Euro.Text = "Euro: " + i;
            Dollar.Text = "Dollar: " + i;
            kol_money.Text = "Money: " + money;


            C_Euro = new Currency(inputPrice_E.Value);
            C_Dollar = new Currency(inputPrice_D.Value);
            days = (int)inputDays.Value;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart1.Series[0].Points.AddXY(i, C_Euro.pr);
            chart1.Series[1].Points.AddXY(i, C_Dollar.pr);
        }

        int p = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            chek(f);
            if (f==true)
            {
                if (i < days)
                {
                    C_Euro.count();
                    C_Dollar.count();
                    i++;
                    chart1.Series[0].Points.AddXY(i, C_Euro.pr);
                    chart1.Series[1].Points.AddXY(i, C_Dollar.pr);
                    num(i);
                    if(C_Euro.n>0)
                    {
                        double t = (C_Euro.n * C_Euro.pr*p)/100;
                        money -= t;
                        kol_money.Text = "Money: " + money;
                    }

                    if (C_Dollar.n > 0)
                    {
                        double t = (C_Dollar.n * C_Dollar.pr*p) / 100;
                        money -= t;
                        kol_money.Text = "Money: " + money;
                    }

                }
                else
                {
                    f = false;
                }
            }
        }

        private void chek(bool f)
        {
            if (f != true)
            {
                t.Text = "Please, click Start";
            }
            else
                t.Text = "";
        }

        private void num(int i)
        {
            num_of_day.Text = "Day: " + i;
        }

        private void buy_E_Click(object sender, EventArgs e)
        {
            chek(f);
            if (f == true)
            {
                money = C_Euro.buy(money);
                Euro.Text = "Euro: " + C_Euro.n;
                kol_money.Text = "Money: " + money;
            }
        }

        private void buy_D_Click(object sender, EventArgs e)
        {
            chek(f);
            if (f == true)
            {
                money = C_Dollar.buy(money);
                Dollar.Text = "Dollar: " + C_Dollar.n;
                kol_money.Text = "Money: " + money;
            } 
        }

        private void sell_E_Click(object sender, EventArgs e)
        {
            chek(f);
            if (f == true || i==days)
            {
                money = C_Euro.sell(money);
                Euro.Text = "Euro: " + C_Euro.n;
                kol_money.Text = "Money: " + money;
            }
           
        }

        private void sell_D_Click(object sender, EventArgs e)
        {
            chek(f);
            if (f == true || i == days)
            {
                money = C_Dollar.sell(money);
                Dollar.Text = "Dollar: " + C_Dollar.n;
                kol_money.Text = "Money: " + money;
            }
        }
    }
}
