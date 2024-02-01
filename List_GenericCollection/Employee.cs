using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_GenericCollection
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


        //public Employee(int ID, string Name, string Gender, int Salary) {
        //    this.ID = ID;
        //    this.Name = Name;
        //    this.Gender = Gender;
        //    this.Salary = Salary;
        //}

        public static void EmployeeList()
        {
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee emp2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee emp3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };

            // Create a Generic List of type Employee
            List<Employee> listEmployees = new List<Employee>();

            //Adding Employees to the listEmployees collection using Add Method
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            Console.WriteLine("Retrive the First Employee By Index");

            //Retrieving Items from the collection by using Index. 
            //The following line of code will retrieve the employee from the list. 
            //The List index is  0 based.
            Employee FirstEmployee = listEmployees[0]; //Fetch the First Added Employee from the Collection
            Console.WriteLine($"ID = {FirstEmployee.ID}, Name = {FirstEmployee.Name}, Gender = {FirstEmployee.Gender}, Salary = {FirstEmployee.Salary}");
            
            //Retrieving All Employees of Generic List Collection using For loop
            Console.WriteLine("\nRetrieving All Employees using For Loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            
            //Retrieving All Employees of Generic List Collection using For Each loop
            Console.WriteLine("\nRetrieving All Employees using For Each Loop");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            
            //Inserting an Employee into the Index Position 1.
            Employee emp4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            listEmployees.Insert(1, emp4);
            
            //Retrieving the list after inserting the employee in index position 1
            Console.WriteLine("\nRetriving the List After Inserting New Employee in Index 1");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            
            //If you want to get the index postion of a specific employee then use Indexof() method as follows
            Console.WriteLine("\nIndex of emp3 object in the List = " + listEmployees.IndexOf(emp3));





            Console.ReadKey();
        }
    }
}
    

