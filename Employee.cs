using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class  Employee
    {
        protected string name,id;
        protected int grossSalary=0,grossBonus=0,grossCommission=0;
        
        public string Name{
            set{
                this.name = value;
            }
            get{
                return this.name;
            }
        }

        public string ID{
            set{
                this.id = value;
            }
            get{
                return this.id;
            }
        }

        public virtual void PayableIncomeTax() { }
        public virtual void GrossBonus(params int[] bon) { }
        public virtual void GrossCommission(params int[] com) { }
        public void GrossSalary(params int[] sal){
            for(int i= 0;i<sal.Length;i++){
                this.grossSalary+=sal[i];
            }
        }
    }
}
