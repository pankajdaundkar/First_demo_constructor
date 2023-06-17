using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_demo
{
    internal class Prgram
    {
        static void Main(string[] args)
        {
            //Date date1 = new Date();
            //date1.AcceptData(16, "june", 2023);
            ////Console.WriteLine(date1.PrintDate());
            //string data = date1.PrintDate();
            //Console.WriteLine(data);
            //int year = date1.PrintYear();
            //Console.WriteLine(year);


            //student_details student_Details1 = new student_details();
            //student_Details1.AcceptData("pankaj", 14, 78.89);
            //Console.WriteLine(student_Details1.PrintStudentd());

            //Employee_details Employee_Details1 = new Employee_details();
            //Employee_Details1.AcceptData("pankaj", 123, 40000);
            //Console.WriteLine(Employee_Details1.PrintEmplyoee_detailsd());

            //Product_details Product_details1 = new Product_details();
            //Product_details1.AcceptData("mobile", 1234, 10000);
            //Console.WriteLine(Product_details1.PrintProduct());

            Employee_details emp1 = new Employee_details();
            Console.WriteLine(emp1.Employee_detailsd());

            Employee_details emp2 = new Employee_details();
            Console.WriteLine(emp2.Employee_detailsd());
        }
        
    }
}
