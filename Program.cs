using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_sign_in
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            ///assigns an id to a person
            int id = 1;
            int temp = id++;
            string staffid = Convert.ToString(temp);


            var temp1 = new Person(name, staffid);
            Console.WriteLine(name);
            Console.WriteLine(staffid);
            

            Console.ReadLine();
        }
    }
}
