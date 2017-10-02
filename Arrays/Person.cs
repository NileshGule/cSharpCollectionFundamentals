using System;

namespace Arrays
{
    class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        static void Main(string[] args)
        {
            Person first = new Person("Nilesh", 105);
            Person second = new Person("James", 200);

            Person[] persons = {first, second};

            foreach (Person item in persons)
            {
                // not possible to replace the item
                // item = new Person("abc", 1000);

                // can replace value of the field 
                item.Age = 20;
            }

            foreach (var item in persons)
            {
                Console.WriteLine($"Person name = {item.Name}, Age = {item.Age}");
            }
        }
    }
}