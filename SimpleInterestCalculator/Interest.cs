using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    class Interest
    {
        public float Principal { get; set; }
        public float Rate { get; set; }
        public float Time { get; set; }

        public float Calculate()
        {
            return Principal * Rate * Time;
        }

        public float Amount
        {
            get
            {
                return Calculate() + Principal;
            }
        }
    }
}
