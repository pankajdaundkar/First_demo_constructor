using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_demo
{
    public class Employee_details

    {
        private string name;
        private int  empid;
        private int salary;


        public Employee_details()
        {
            name = "pankaj";
            empid = 123;
            salary = 20000;
                
        }
        public Employee_details(string na,int id,int sal)
        {
            name = na;
            empid = id;
            salary = sal;
        }
        public string Employee_detailsd()
        {
            return $"employee name is {name} \n employee id is {empid} \n sallary is {salary}";
        }

    }
}
    
    
   


