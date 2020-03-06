using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> p1 = new List<Person>();
            // test change
            Person p2 = new Person { id = 101, firstName = "Jordan" };
            Person p3 = new Person { id = 101, firstName = "Paul" };
            Person p4 = new Person { id = 101, firstName = "Zack" };
            Person p5 = new Person { id = 101, firstName = "Roger" };
            Person p6 = new Person { id = 101, firstName = "Kyle" };
            Person p7 = new Person { id = 101, firstName = "Josh" };

            p1.Add(p2);
            p1.Add(p3);
            p1.Add(p4);
            p1.Add(p5);
            p1.Add(p6);
            p1.Add(p7);

            foreach(Person obj in p1)
            {
                Console.WriteLine("Enter a student id: ");
                obj.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the students first name: ");
                obj.firstName = Console.ReadLine();
                Console.WriteLine(obj.id + " " + obj.firstName);
            }

            Console.ReadKey();

        }
    }
}
