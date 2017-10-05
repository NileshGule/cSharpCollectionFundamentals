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

            foreach (object obj in objectArray2)
            {
                Console.WriteLine(obj);
            }
        }   
    }
}