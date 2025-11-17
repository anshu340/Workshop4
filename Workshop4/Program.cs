using System;
using Workshop4;

public class Program
{
    public static void Main(string[] args)
    {
        //Task 1

        // Creating first object
        Student s1 = new Student();
        s1.name = "Anshu";
        s1.age = 21;
        s1.address = "Belbari";

        // Creating second object
        Student s2 = new Student();
        s2.name = "Ab";
        s2.age = 18;
        s2.address = "Belbari - 2";

        // Display object 1 values
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        // Display object 2 values
        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        // Print static field
        Console.WriteLine("\nCollege Name : " + Student.collegeName);
    }
}
