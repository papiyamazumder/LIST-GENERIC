using System;
using List_GenericCollection;

public class Book
{
    // Properties of the class
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public string SomeOtherProperty { get; set; }

    // Default constructor
    public Book()
    {
        Console.WriteLine("Default constructor is called!");
    }

    // Parameterized constructor
    public Book(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }

    // Factory method
    public static Book CreateBook(string title, string author, int publicationYear)
    {
        return new Book
        {
            Title = title,
            Author = author,
            PublicationYear = publicationYear
        };
    }

    // Method to display information about the book
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}");
    }
}

class Objects
{
    static void Main()
    {
        #region Object Initialization ways:

        //// 1. Using default constructor and setting properties individually
        //Book book1 = new Book();
        //book1.Title = "The Great Gatsby";
        //book1.Author = "F. Scott Fitzgerald";
        //book1.PublicationYear = 1925;
        //book1.DisplayInfo();

        //// 2. Using parameterized constructor
        //Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
        //book2.DisplayInfo();

        //// 3. Using object initializer syntax
        //Book book3 = new Book
        //{
        //    Title = "1984",
        //    Author = "George Orwell",
        //    PublicationYear = 1949
        //};
        //book3.DisplayInfo();

        //// 4. Combining constructor and property initialization
        //Book book4 = new Book("Pride and Prejudice", "Jane Austen", 1813)
        //{
        //    SomeOtherProperty = "Some Value"
        //};
        //book4.DisplayInfo();

        //// 5. Using a factory method
        //Book book5 = Book.CreateBook("The Lord of the Rings", "J.R.R. Tolkien", 1954);
        //book5.DisplayInfo();

        #endregion

        #region Objects in List, Dictionary, Array

        //// Create List of Objects:
        //List<Book> books = new List<Book>   // Book is an object of another class, so add with new keyword in list for adding objects of a class. )
        //{
        //    new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925),
        //    new Book("To Kill a Mockingbird", "Harper Lee", 1960),
        //    new Book("1984", "George Orwell", 1949),
        //    new Book("Pride and Prejudice", "Jane Austen", 1813),
        //    new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954)
        //};
        ////OR
        //// Create Employee Objects First, tan declare it inside a list:
        //Employee Employee1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
        //Employee Employee2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
        //Employee Employee3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };
        //Employee Employee4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };

        //// Creating a list of type Employee
        //List<Employee> listEmployees = new List<Employee>
        //{
        //    Employee1,
        //    Employee2,
        //    Employee3,
        //    Employee4
        //};

        //// write foreach loop to print

        //// Dictionary of objects (Books)
        //Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>
        //{
        //    { 1, new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublicationYear = 1925 } },
        //    { 2, new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", PublicationYear = 1960 } }
        //    // Add more entries as needed
        //};
        //// Print using if and foreach loop

        //// Array of objects (Books)
        //Book[] booksArray = new Book[3];
        //// Create instances of Book and populate the array
        //booksArray[0] = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        //booksArray[1] = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
        //booksArray[2] = new Book("1984", "George Orwell", 1949);
        ////print using foreach loop

        #endregion

    }
}
