using System;

namespace TupleExemple
{
    class Program
    {
        //static (string,int) GetPerson() => ("Bob", 23);
        static (string name, int age) GetPerson() => ("Bob", 23);
        static void Main(string[] args)
        {
            (string, int) bob = ("Bob", 23);

            var person = GetPerson();
            Console.WriteLine(person.name);

            Console.WriteLine(bob.Item1);
            Console.WriteLine(bob.Item2);
            Console.WriteLine(bob.GetType());

            var joe = bob;
            joe.Item1 = "Joe";
            Console.WriteLine(bob);
            Console.WriteLine(joe);


            var tuple = (name:"Bob", age:23);
            Console.WriteLine (tuple.name);
            tuple.age = 85;
        }
    }
}
