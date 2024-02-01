using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_GenericCollection
{
    // https://dotnettutorials.net/lesson/sorting-a-list-of-complex-type-csharp/

    public class SortObjectsClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    internal class Sort_Reverse
    {
        public static void SortReverse()
        {
            List<int> numbersList = new List<int> { 1, 8, 7, 5, 2 };
            Console.WriteLine("Numbers Before Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }
            // The Sort() of List Collection class will sort the data in ascending order 
            numbersList.Sort();
            Console.WriteLine("\n\nNumbers After Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }
            
            
            // If you want to  to retrieve data in descending order then use the Reverse() method
            numbersList.Reverse();
            Console.WriteLine("\n\nNumbers in Descending order");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }
            
            
            //Another Example of Sorting String
            List<string> names = new List<string>() { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };
            Console.WriteLine("\n\nNames Before Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Sort();
            Console.WriteLine("\nNames After Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Reverse();
            Console.WriteLine("\nNames in Descending Order");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

        public static void SortObjects()
        {
            //Creating a list of type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };

            //listEmployees.Sort();       // Error: invalid operation exception – Failed to compare 2 elements in the array“.
            // We are getting the above Runtime Exception because at runtime the .NET Framework does not identify how to sort the complex types.
            // In this, the .NET Runtime is unable to identify whether to sort the data based on ID property, or based on Name property, or based on Gender property, or based on Salary property, or a combination of any properties.
            // So, if we want to sort a complex type then we need to tell the way we want the data to be sorted in the list, and to do this we need to implement the IComparable interface. 

            // Ascending Order
            Console.WriteLine("Ascending Order:");
            listEmployees.Sort((x, y) => x.ID.CompareTo(y.ID));

            // Descending Order
            Console.WriteLine("\nDescending Order:");
            listEmployees.Sort((x, y) => y.ID.CompareTo(x.ID));
            
            // OR

            // Ascending Order using LINQ
            var ascendingOrder = listEmployees.OrderBy(employee => employee.ID).ToList();
            // Descending Order using LINQ
            var descendingOrder = listEmployees.OrderByDescending(employee => employee.ID).ToList();


            // Print above to sort order
            foreach (var employee in listEmployees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }

}
    



