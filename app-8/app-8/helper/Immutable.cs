using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class Immutable
    {
    }

    public class Person8
    {
        //C# 1
        public string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }


        //c#2
        public string _firstName2;
        public string FirstName2
        {
            get
            {
                return _firstName2;
            }
            private set
            {
                _firstName2 = value;
            }
        }


        //C# 3
        public string FirstName3 { get; set; }

        //C# 6
        // public string Name { get; private set; }
        public string Name { get; }
        public string FirstName4 { get; set; } = "Initial Value";
        //readonly 
        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Now.Year - DateOfBirth.Year;




        //init
        //فقط یکبار مقدار دهی می شود و بعد فقط خواندنی می شود
        public class User
        {
            public string Name { get; init; }

            public User(string name)
            {
                this.Name = name; // Works fine
            }

            public void SetName(string name)
            {
                //this.Name = name; // Compile Time Error
            }
        }

    }






}
