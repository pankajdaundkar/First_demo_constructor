using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_demo
{
    public class student_details
    {
        private int rollno;
        private double percentage;
        private string name;

        public void AcceptData(string na,int rn,double perc)

        {
            name = na;
            rollno = rn;
            percentage = perc;
        }
        public string PrintStudentd()
        {
           return $"student details is \n Name is {name}\nRoll no is {rollno}\nPercentage is {percentage}";

        }
    }
}
