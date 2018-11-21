using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Salesman:FullTimeEmployee
    {
        public override void PayableIncomeTax() {
            Console.WriteLine(" Name: {0}\n ID: {1}\n Salary: {2}\n Bonus: {3}\n Commisson: {4}\n Total Payable Tax: {5}",this.Name,this.ID,this.grossSalary,this.grossBonus,this.grossCommission,((grossSalary*0.6)*0.2)+grossBonus*0.15+grossCommission*0.1);
            Console.WriteLine("---------------------ooo-------------------------");
        }
        
        public override void GrossCommission(params int[] com)
        {
            for (int i = 0; i < com.Length; i++)
            {
                this.grossCommission += com[i];
            }
        }
    }

}
