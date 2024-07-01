using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class TupleNameInference
    {
        public void run()
        {
            string name = "User 1";
            int age = 20;


            var personTuple = (name, age);
            Console.WriteLine(personTuple.Item1); // User 1
            Console.WriteLine(personTuple.Item2); // 20



            var personTuple2 = (name: name, age: age);
            Console.WriteLine(personTuple2.name); // User 1
            Console.WriteLine(personTuple2.age); // 20



            var personTuple3 = (name, age);
            Console.WriteLine(personTuple3.name); // User 1
            Console.WriteLine(personTuple3.age); // 20



            var p = new Person
            {
                FirstName = "User 1",
                Age = 20
            };
            var personTuple4 = (p.FirstName, p.Age);
            Console.WriteLine(personTuple4.FirstName);
            Console.WriteLine(personTuple4.Age);



            Person p2 = null;
            var personTuple5 = (p?.FirstName, p?.Age);
            Console.WriteLine(personTuple5.FirstName); // null
            Console.WriteLine(personTuple5.Age); // null










            var people = new List<Person>
                {
                   new Person {FirstName = "User 1", Age = 42},
                   new Person {FirstName = "User 2", Age = 18},
                   new Person {FirstName = "User 3", Age = 21}
                };

            var tuples = people
               .Select(person =>
                       (
                          person.FirstName,
                          person.Age,
                          NameAndAge: $"{person.FirstName} is {person.Age}"
                       )
            );
            var name5 = tuples.First().FirstName;
            var age5 = tuples.First().Age;
            var nameAndAge = tuples.First().NameAndAge;




        }
    }
}
