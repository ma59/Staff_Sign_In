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
            int id = 1;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();

                ///assigns an id to a person
                
                int temp = id++;
                string staffid = Convert.ToString(temp);


                var temp1 = new Person(name, staffid);
                Console.WriteLine(name);
                Console.WriteLine(staffid);


                Console.ReadLine();
            }
        }
    }
}
