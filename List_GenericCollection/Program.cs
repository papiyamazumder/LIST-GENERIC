using List_GenericCollection;

internal class Program
{
    private static void Main(string[] args)
    {
        Create_Add.CreateAdd();
        MyClass.AddItemsToList();
        Insert_Check.Insert();
        Insert_Check.Check();
        Remove.remove();
        CopyArrayToList();
        Employee.EmployeeList();
        Find.FindItemsInList();
        True_Read_Trim.TrueReadTrim();
        Sort_Reverse.SortReverse();
        ConditionalOperator();
        MultiDimensionalArray();
        ListHSortNotes();

    }

    public static void ListHSortNotes()
    {
        // List = data structure that represents a list of objects that can be accessed by index.
        //        Similar to array, but can dynamically increase/decrease in size 
        //        using System.Collections.Generic;

        List<String> food = new List<String>();

        food.Add("pizza");
        food.Add("hamburger");
        food.Add("hotdog");
        food.Add("fries");

        //Console.WriteLine(food[0]);       // accessing values with index like array only
        //Console.WriteLine(food[1]);
        //Console.WriteLine(food[2]);
        //Console.WriteLine(food[3]);

        //food.Remove("fries");
        //food.Insert(0, "sushi");
        //Console.WriteLine(food.Count);
        //Console.WriteLine(food.IndexOf("pizza"));
        //Console.WriteLine(food.LastIndexOf("fries"));
        //Console.WriteLine(food.Contains("pizza"));
        //food.Sort();
        //food.Reverse();
        //food.Clear();

        String[] foodArray = food.ToArray();    // Converting list to array and then storing it in an array and then printing the elements of the array

        foreach (String item in food)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    public static void CopyArrayToList()
    {
        // Create new array with 3 elements.
        string[] array = new string[] { "INDIA", "USA", "UK" };
        // Copy the array to a List.
        List<string> copiedList = new List<string>(array);
        Console.WriteLine("Copied Elements in List");
        foreach (var item in copiedList)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

    // In case of List, if its 

    public static void ConditionalOperator()
    {
        // conditional operator = used in conditional assignment if a condition is true/false
        //(condition) ? x : y       // Based on condition question? if true, return x otherwise false, return y // no need if-else

        double temperature = 20;
        String message;

        message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";    

        Console.WriteLine(message);

        Console.ReadKey();
    }

    public static void MultiDimensionalArray()
    {
        String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                 { "Corvette", "Camaro", "Silverado" },
                                 { "Corolla", "Camry", "Rav4" }
                               };

        parkingLot[0, 2] = "Fusion";
        parkingLot[2, 0] = "Tacoma";
        /*
        foreach(String car in parkingLot)
        {
            Console.WriteLine(car);
        }
        */
        for (int i = 0; i < parkingLot.GetLength(0); i++)   // GetLength(0) gives the number of rows
        {
            for (int j = 0; j < parkingLot.GetLength(1); j++)   // GetLength(1) gives the number of colums
            {
                Console.Write(parkingLot[i, j] + " ");  //[i, j], where i is the index in the first dimension, and j is the index in the second dimension. Its a 2D array, so 0 for 1st dimen and 1 for 2nd dimen
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

