using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Turnover
    {
        public int Sales { get; set; }
        public double Price { get; set; }
        public string DrinkName { get; set; }
        public double Totturnover
        {
            get
            {
                return Sales * Price;
            }
        }

    }
}
