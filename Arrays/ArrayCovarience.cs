using System;

namespace Arrays
{
    class ArrayCovarience
    {      
        static void Main(string[] args)
        {
            object[] objectArray1 = new object[3];

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            object[] objectArray2 = daysOfWeek;

            objectArray1[0] = 3;
            Console.WriteLine($"objectArray[0] = {objectArray1[0]}");

            // Covarience does not work here 
            // daysOfWeek[2] = 4;
        }   
    }
}