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
            var marlon = new Person("Marlon Adams");

            var alex = new Person("Alex Williams");
            Console.WriteLine(marlon.Name);

            Console.WriteLine(alex.Name);
            Console.ReadLine();
        }
    }
}
