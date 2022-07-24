using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
namespace reuse_component
{

    class Program
    {

        static void Main(string[] args)
        {
            Sponsor sponsor1 = new Sponsor { ID = 21213, Age = 45, Gender = Person.GenderTypes.male, Name = "Ahmad" };
            Person person1 = new Person { Age = 26, Name = "Omar", Gender = Person.GenderTypes.male };
            Person person2 = new Person { Age = 20, Name = "Ezz", Gender = Person.GenderTypes.male };
            Person person3 = new Person { Age = 21, Name = "Farah", Gender = Person.GenderTypes.female };
            Person person4 = new Person { Age = 30, Name = "Sarah", Gender = Person.GenderTypes.female };

            Console.WriteLine("\n\n\nAdding male above 23");

            sponsor1.Accompany.Add(person1);


            Console.WriteLine("\n\n\nAdding male bellow 23");

            sponsor1.Accompany.Add(person2);


            Console.WriteLine("\n\n\nAdding female");

            sponsor1.Accompany.Add(person3);


            Console.WriteLine("\n\n\nAdding female");

            sponsor1.Accompany.Add(person4);


            Console.WriteLine("\n\n\nTransferring male bellow 21");

            sponsor1.Accompany.Remove(person2);

            Console.WriteLine("\n\n\nTransferring female bellow 24");

            sponsor1.Accompany.Remove(person3);

            Console.WriteLine("\n\n\nTransferring female above 24");

            sponsor1.Accompany.Remove(person4);

            Console.WriteLine("\n\n\nRemoving female");

            sponsor1.Accompany.Remove(person3);

        }
    }
}
