using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    [Serializable]
    class Employee
    {
        public int Id;
        public string Name;

        public Employee(int Id, String Name)
        {
             this.Id = Id;
            this.Name = Name;
        }
    }
}
