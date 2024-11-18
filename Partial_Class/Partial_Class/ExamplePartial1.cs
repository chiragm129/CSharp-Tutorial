using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    //all parts of access modifier are same
    //if any parts sealed, abstract or base type then whole class will be same
    //if any part of inherit class then the entire type inherit the class
    //does not support multiple inheritance
    //but support multiple interface
    public partial class StudentPartial
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }

    }
}
