using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_GenericCollection
{
    internal class Remove
    {
        public static void remove()
        {
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK",
                "AUSTRALIA",
                "SRILANKA",
                "BANGLADESG",
                "NEPAL",
                "CHINA",
                "NZ",
                "SOUTH AFRICA"
            };
            Console.WriteLine($"Before Removing Element Count : {countries.Count}");

            //Using Remove method to Remove an Element from the List
            Console.WriteLine($"\nRemoving Element SRILANKA : {countries.Remove("SRILANKA")}");
            Console.WriteLine($"After Removing SRILANKA Element Count : {countries.Count}");
            
            //Removing Element using Index Position from the List
            countries.RemoveAt(2);
            Console.WriteLine($"\nAfter Removing Index 2 Element Count : {countries.Count}");
            
            // Using RemoveAll method to Remove Elements from the List
            // Here, we are removing element whose length is less than 3 i.e. UK and NZ
            //countries.RemoveAll(x => x.Length < 3);
            Console.WriteLine($"\nRemoveAll Method Removes: {countries.RemoveAll(x => x.Length < 3)} Element(s)");
            Console.WriteLine($"After RemoveAll Method Element Count : {countries.Count}");
            
            //Removing Element using RemoveRange(int index, int count) Method
            //Here, we are removing the first two elements
            countries.RemoveRange(0, 2);
            Console.WriteLine($"\nAfter RemoveRange Method Element Count : {countries.Count}");
            
            //Removing All Elements using Clear method
            countries.Clear();
            Console.WriteLine($"\nAfter Clear Method Element Count : {countries.Count}");


            Console.ReadKey();
        }
    }
}
