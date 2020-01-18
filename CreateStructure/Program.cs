using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStructure
{
    public enum Genders { Male, Female };
    struct Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Genders gender;

        public Person(string _firstName, string _lastName, int _age, Genders _gender)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            gender = _gender;     
        }
        public override string ToString()
        {
            return firstName + " " +  lastName + " "+ gender+" " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tony", "Allen", 32, Genders.Female);
            Console.WriteLine(p);
            var k = Console.ReadKey();

            switch (k.KeyChar)
            {
                case 'a':
                case 'b':
                    break;
                case 'c':
                    Console.WriteLine("It's a C.");
                    break;
                default:
                    break;



            }
            Console.ReadKey();

        }
    }
}
