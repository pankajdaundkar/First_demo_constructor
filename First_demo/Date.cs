using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_demo
{
    public class Date
    {
        private int date, year;
        private string month;

        public void AcceptData(int dd, string mm, int yr)

        {
            date = dd;
            month = mm;
            year = yr;

        }
        public string PrintDate()
        {
            return $"Date is {date}-{month}-{year}";
            
        }
        public int PrintYear()
        {
            return year;
        }
    }
}

