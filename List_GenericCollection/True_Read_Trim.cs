using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_GenericCollection
{
    internal class True_Read_Trim
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


        public static void TrueReadTrim()
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
            
            //TrueForAll
            Console.WriteLine($"Are all salaries greater than 5000: {listEmployees.TrueForAll(x => x.Salary > 5000)}");

            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Employee> readOnlyEmployees = listEmployees.AsReadOnly();
            Console.WriteLine($"\nTotal Items in ReadOnlyCollection: {readOnlyEmployees.Count}");
            
            // listEmployees list is created with an initial capacity of 8
            // but only 5 items are in the list. The filled percentage is less than 90 percent threshold.
            Console.WriteLine($"\nList Capacity Before invoking TrimExcess: {listEmployees.Capacity}");
            
            
            // Invoke TrimExcess() to set the capacity to the actual number of elements in the List
            listEmployees.TrimExcess();
            Console.WriteLine($"\nList Capacity After invoking TrimExcess: {listEmployees.Capacity} ");
            
            
            Console.ReadKey();
        }
    }
}
