using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8.helper
{
    internal class DefaultLiterals
    {
        public void run()
        {
            int a = default(int);

            var number = default(int); // 0
            var date = default(DateTime); // DateTime.MinValue
            var obj = default(object); // null


            int a2 = default; // 0
            Guid guid = default; // 00000000-0000-0000-0000-000000000000



            int i = default(int);
            int i2 = default;

            Person Create() => default(Person);
            Person Create2() => default;


            (string Name, int Age) person = ("User 1", default(int));
            (string Name, int Age) person2 = ("User 1", default);


            //Person p = new Person
            //{
            //    Name = default(string),
            //    Age = default(int)
            //};

            //Person p = new Person
            //{
            //    Name = default,
            //    Age = default
            //};


            var people = new[]
            {
                new Person(),
                default(Person),
                new Person()
            };

            var ages = new[] { 18, default(int), 50 };

            var people2 = new[]
            {
              new Person(),
              default,
              new Person()
            };

            var ages2 = new[] { 18, default, 50 };


        }


    }
}
