using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_demo
{
    public class Product_details
    {
        private string name;
        private int code;
        private int price;

        public void AcceptData(string na, int cd, int pr)

        {
            name = na;
            code = cd;
            price = pr;

        }
        public string PrintProduct()
        {
            return$"The product name is {name} \ncode is {code} \nprice is {price}";
        }
    }
}
