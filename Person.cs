using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_sign_in
{
    public class Person
    {
        public string Name { get; set; }

        public string StaffID { get; set; }
        public Person(string name, string staffid)
        {
            Name = name;
            StaffID = staffid;
        }
    }
}
