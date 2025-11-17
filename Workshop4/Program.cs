using Workshop4;

namespace WorkShop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Task 1

            // Create first Student object
            Student student1 = new Student();
            student1.Name = "Anshu";
            student1.Age = 21;
            student1.Address = "Belbari";

            // Create second Student object
            Student student2 = new Student();
            student2.Name = "kamana";
            student2.Age = 24;
            student2.Address = "Belbari";

            // Display values of first student
            Console.WriteLine("Student 1:");
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Address: " + student1.Address);
            Console.WriteLine("College: " + Student.collegeName);
            Console.WriteLine();

            // Display values of second student
            Console.WriteLine("Student 2:");
            Console.WriteLine("Name: " + student2.Name);
            Console.WriteLine("Age: " + student2.Age);
            Console.WriteLine("Address: " + student2.Address);
            Console.WriteLine("College: " + Student.collegeName);

            // Task 2

            // Create Calculator object
            Calculator calc = new Calculator();

            // Call the PrintWelcome method
            calc.PrintWelcome();

            // Call Add method and print result
            int sum = calc.Add(10, 20);
            Console.WriteLine("Sum: " + sum);

            // Call Multiply method with both parameters
            int product1 = calc.Multiply(5, 3);
            Console.WriteLine("Product (5*3): " + product1);

            // Call Multiply method with only one parameter (num2 uses default 1)
            int product2 = calc.Multiply(7);
            Console.WriteLine("Product (7*3): " + product2);

            // Task 3

            // Create an object of ParameterDemo
            ParameterDemo demo = new ParameterDemo();

            // Using ref parameter
            int myNumber = 5;
            Console.WriteLine("Before Increase: " + myNumber);
            demo.Increase(ref myNumber);
            Console.WriteLine("After Increase: " + myNumber);
            Console.WriteLine();

            // Using out parameter
            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine();

            // Using params parameter
            int total = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine("Sum of numbers: " + total);

            // Task 4

            // Create one object using default constructor
            Player player1 = new Player();
            Console.WriteLine();

            // Create another object using parameterized constructor
            Player player2 = new Player("Anshu", 10, 100);

            // Print the values of the fields using both objects
            Console.WriteLine("Player 1 (Default Constructor):");
            Console.WriteLine("Player Name: " + player1.playerName);
            Console.WriteLine("Level: " + player1.level);
            Console.WriteLine("Health: " + player1.health);
            Console.WriteLine();

            Console.WriteLine("Player 2 (Parameterized Constructor):");
            Console.WriteLine("Player Name: " + player2.playerName);
            Console.WriteLine("Level: " + player2.level);
            Console.WriteLine("Health: " + player2.health);
            Console.WriteLine();

        }
    }
}