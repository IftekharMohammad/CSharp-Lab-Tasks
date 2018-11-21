using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Executive();
            Employee e2 = new Salesman();
            Employee e3 = new PartTimeEmployee();

            e1.Name = "A";
            e1.ID = "A-000001";
            e2.Name = "B";
            e2.ID = "A-000002";
            e3.Name = "C";
            e3.ID = "A-000003";

            e1.GrossSalary(2000, 2000, 2000, 2000, 2000, 2000);
            e1.GrossBonus(1000, 1000, 1000, 1000, 1000, 1000);


            e2.GrossSalary(1000, 1000, 1000, 1000, 1000, 1000);
            e2.GrossBonus(500, 500, 500, 500, 500, 500);
            e2.GrossCommission(500, 355, 257, 0, 348, 3000);

            e3.GrossSalary(500, 500, 500, 500, 500);

            e1.PayableIncomeTax();
            e2.PayableIncomeTax();
            e3.PayableIncomeTax();
        }
    }
}