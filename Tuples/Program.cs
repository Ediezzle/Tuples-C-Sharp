using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //cannot contain more than 8 elements
            Tuple<int, string, char> tuple = new Tuple<int, string, char>(1, "name", 'c');

            var myTuple = Tuple.Create(2, "surname", 'C', 20.2, 'd', "jaded", 3, false);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(myTuple.Item3);
            Console.WriteLine(myTuple.Rest);
            Console.WriteLine(myTuple);

            var numbersTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbersTuple.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbersTuple.Rest.Item1.Item1); //returns 8

            var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine(numbers.Item3); // returns (3, 4, 5, 6, 7,  8)
            Console.WriteLine(numbers.Item3.Item1); // returns 3
            Console.WriteLine(numbers.Item4); // returns 9

            var person = Tuple.Create(1, "Steve", "Jobs");
            DisplayTuple(person);

            Console.WriteLine(GetPerson());
            Console.WriteLine(GetPerson().Item2);
        }

        //tuple as a method parameter
        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        //tuple as a return type
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }
    }
}
