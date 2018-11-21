using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunityGUI
{
    class Executive : Member
    {
        private string position;

        public string Position
        {
            set
            {
                this.position = value;
            }
            get
            {
                return this.position;
            }
        }
        public Executive(string name, string address, string position) : base(name, address)
        {
            this.Position = position;
        }
        public override string show()
        {
            return this.Position;
        }
    }
}
