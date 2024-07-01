using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class TargetTyping
    {
        public void run()
        {
            Person7 person1 = new Person7();

            Person7 person2 = new();

            Person7 person3 = new("User 1");

            Person7 person4 = new()
            {
                FirstName = "User 2"
            };

            var personList = new List<Person7>
                {
                    new ("User 1"),
                    new ("User 2"),
                };


            //private ConcurrentDictionary<string, ObservableList<Cat>> _catsBefore = new ConcurrentDictionary<string, ObservableList<Cat>>();
            //private ConcurrentDictionary<string, ObservableList<Cat>> _cats = new(); // C# 9.0
            //public ObservableCollection<Friend> Friends { get; } = new();




        }
    }

    public class Person7
    {
        public string FirstName { get; set; }

        public Person7() { }
        public Person7(string firstname)
        {
            FirstName = firstname;
        }
    }

    public class PersonWithCtor
    {
        public PersonWithCtor(string firstName)
        {
            this.FirstName = firstName;
        }

        public string FirstName { get; set; }
    }
}
