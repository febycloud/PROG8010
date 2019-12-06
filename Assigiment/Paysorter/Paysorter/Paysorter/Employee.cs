using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paysorter
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Hourlypayrate { get; set; }

        public override string ToString()
        {
            return Id + " | " + Name + " | " + Position + " | " + Hourlypayrate;
        }
    }
}
