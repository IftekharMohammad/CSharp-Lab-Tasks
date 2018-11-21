using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class FullTimeEmployee:Employee
    {
        public override void GrossBonus(params int[] bon)
        {
            for (int i = 0; i < bon.Length; i++)
            {
                this.grossBonus += bon[i];
            }
        }
    }
}
