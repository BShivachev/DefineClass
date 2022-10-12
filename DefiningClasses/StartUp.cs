using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Family family = new Family();

            //int numberOfPeople = int.Parse(Console.ReadLine());
            //for (int i = 0; i < numberOfPeople; i++)
            //{
            //    string[] arrPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    Person currentPerson = new Person(arrPeople[0], int.Parse(arrPeople[1]));                              
            //    family.AddMember(currentPerson);

            //}
            //Person oldestPerson = family.GetOldestMember();

            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");-3

            Person currentPerson = new Person();
            List<Person> list = new List<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] arrPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                currentPerson = new Person(arrPeople[0], int.Parse(arrPeople[1]));
                list.Add(currentPerson);

            }
           
            foreach (var item in list.Where(x=>x.Age>30).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
            



        }
    }
}
