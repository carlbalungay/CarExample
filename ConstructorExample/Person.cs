using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"a new person has been created and their name is {Name}");
        }
        public void Speak()
        {
            Console.WriteLine($"my Name is {Name}");
        }

        public void Dance()
        {
            Console.WriteLine($"{Name} is Dancing");
        }
    }
}
