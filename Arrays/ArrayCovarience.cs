using System;

namespace Arrays
{
    static class ArrayCovarience
    {      
        static void Main(string[] args)
        {
            object[] objectArray1 = new object[3];

            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            object[] objectArray2 = daysOfWeek;

            objectArray1[0] = 3;
            Console.WriteLine($"objectArray[0] = {objectArray1[0]}");

            // Covarience does not work here 
            // daysOfWeek[2] = 4;
        }   
    }
}