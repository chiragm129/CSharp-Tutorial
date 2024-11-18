using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class StudentPartial
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
