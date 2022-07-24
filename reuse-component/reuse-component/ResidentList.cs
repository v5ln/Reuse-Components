using System;
using System.Collections.Generic;

namespace reuse_component
{
    public class ResidentList<T> : List <T>
    {
        public new void Add(T item)
        {
            Person person = item as Person;

            if (person.Gender == Person.GenderTypes.male)
            {
                if (person.Age >= 24)
                {
                    Console.WriteLine("Cannot add male above 23");
                    return;
                }
            }
            base.Add(item);
            Console.WriteLine("Added successfully");
        }


        public new bool Remove(T item)
        {
            Person person = item as Person;

            Console.WriteLine("Enter Your Choice\nFinal exit (1) or transfer of sponsorship (2) ?");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 2)
            {
                if (person.Age < 24 && person.Gender == Person.GenderTypes.female)
                {
                    Console.WriteLine("Cannot transfer female bellow 24");
                    return false;
                }
                if (person.Age < 21 && person.Gender == Person.GenderTypes.male)
                {
                    Console.WriteLine("Cannot transfer male bellow 21");
                    return false;
                }

            }
            base.Remove(item);
            Console.WriteLine("Removed successfully");
            return true;
        }
    }
}
