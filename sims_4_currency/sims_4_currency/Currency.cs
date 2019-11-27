using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims_4_currency
{
    class Currency
    {
        public int n = 0;
        public double pr;
        const double k = 0.02;

        public Currency(decimal s)
        {
            pr = (double)s;
        }

        public double buy(double m)
        {
            if (m>pr)
            {
                n++;
                m -= pr;
            }
            return m;
        }

        public double sell(double m)
        {
            if (n>0)
            {
                n--;
                m += pr;
            }
            return m;
        }

        public void count()
        {
            Random rnd = new Random();
            pr = pr * (1 + k * (rnd.NextDouble() - 0.5));
        }
    }
}
