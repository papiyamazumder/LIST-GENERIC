using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_GenericCollection
{
    public class MyClass
    {
        public int MyProperty { get; set; }
        public string MyString { get; set; }

        public static void AddItemsToList()
        {
            // Create a list that can hold different types
            List<object> mixedList = new List<object>();

            // Add elements to the list
            mixedList.Add("Hello, World!");
            mixedList.Add(42);
            mixedList.Add(new MyClass { MyProperty = 10, MyString = "Example" });       // Creating objects of this class directly under list, not adding from another class.
            //OR
            //Refer "Objects class" for adding objects to a list.

            // Access elements in the list
            foreach (var item in mixedList)
            {
                // Check the type of each element and perform appropriate actions
                if (item is string)
                {
                    Console.WriteLine("String: " + item);
                }
                else if (item is int)
                {
                    Console.WriteLine("Integer: " + item);
                }
                else if (item is MyClass)
                {
                    MyClass myObject = (MyClass)item;
                    Console.WriteLine($"MyClass: MyProperty={myObject.MyProperty}, MyString={myObject.MyString}");
                }
            }
        }
        
    }
    public class Create_Add
    {
        public static void CreateAdd()
        {
            //Creating a Generic List of string type to store string elements
            List<string> countries = new List<string>();

            //Adding String Elements to the Generic List using the Add Method
            countries.Add("INDIA");
            countries.Add("USA");

            //The following Two Statements will give compile time error as element is not string type
            //countries.Add(100);
            //countries.Add(true);
            //Creating Another Generic List Collection of String Type
            List<string> newCountries = new List<string>();

            //Adding Elements using Add Method
            newCountries.Add("JAPAN");
            newCountries.Add("UK");

            //Adding the newCountries collection into countries collection using AddRange Method
            countries.AddRange(newCountries);

            //Accessing Generic List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Accessing Generic List Elements using For Loop
            Console.WriteLine("\nAccessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                var element = countries[i];
                Console.WriteLine(element);
            }
            //Accessing List Elements by using the Integral Index Position
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {countries[0]}");
            Console.WriteLine($"Second Element: {countries[1]}");
            Console.WriteLine($"Third Element: {countries[2]}");
            Console.WriteLine($"Fourth Element: {countries[3]}");
            Console.ReadKey();



            //Crea:ting a Generic List of string type and adding elements using collection initializer
            List<string> Countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK"
            };
            //Accessing List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List Elemenst using For Each Loop");
            foreach (var item in Countries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
