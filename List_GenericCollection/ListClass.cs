//using System;
//using System.Collections.Generic;

//public class Company
//{
//    public List<Employee> Employees { get; set; }       // Prop with list

//    public Company()
//    {
//        Employees = new List<Employee>();
//    }
//}

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

//class List_Collections
//{
//    static void Main()
//    {
//        // Creating an object of the Company class
//        Company myCompany = new Company();

//        // Adding employees to the list in the Company object
//        myCompany.Employees.Add(new Employee { Id = 1, Name = "John" });
//        myCompany.Employees.Add(new Employee { Id = 2, Name = "Jane" });

//        // Accessing elements in the list through the Company object
//        foreach (var employee in myCompany.Employees)
//        {
//            Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.Name}");
//        }
//    }
//}
