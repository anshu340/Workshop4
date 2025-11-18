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

            // Task 5

            Console.Write("Enter the day (Example: Sunday): ");
            string day = Console.ReadLine();


            // Check if the day is weekend or weekday
            if (day.ToLower() == "friday" || day.ToLower() == "saturday")
            {
                Console.WriteLine("It is: Weekend");
            }
            else
            {
                Console.WriteLine("It is: Weekday");
            }
            Console.WriteLine();


            // Record Book

            // Create an object for book and assign the values
            Book book1 = new Book("WAR AND PEACE", "Leo Tolstoy", 680);

            // Print the value of first object
            Console.WriteLine("Book 1:");
            Console.WriteLine("Title: " + book1.title);
            Console.WriteLine("Author: " + book1.author);
            Console.WriteLine("Price: $" + book1.price);
            Console.WriteLine();

            // Create another object and by using with expression, change the title and price
            Book book2 = book1 with { title = "Harry Potter", price = 2199 };

            Console.WriteLine("Book 2 ");
            Console.WriteLine("Title: " + book2.title);
            Console.WriteLine("Author: " + book2.author);
            Console.WriteLine("Price: $" + book2.price);
            Console.WriteLine();

            // Deconstruct the second object into three variables and print them
            var (title, author, price) = book2;
            Console.WriteLine("Deconstructed Book 2:");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price);

            // Task 6

            // Ask user for input
            Console.Write("Enter marks: ");
            string marksInput = Console.ReadLine();

            Console.Write("Enter total: ");
            string totalInput = Console.ReadLine();

            // Parse inputs using TryParse
            int marks, totals;
            if (!int.TryParse(marksInput, out marks))
                marks = 0;
            if (!int.TryParse(totalInput, out total))
                total = 0;

            // Calculate percentage (BUGGY VERSION - for debugging practice)
            double percentage = (double)marks / total * 100;
            
            Console.WriteLine($"Percentage: {percentage}");

            // Task 7

            Car myCar = new Car
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2023,
                NumberOfDoors = 4
            };

            myCar.DisplayInfo();
            myCar.Start();
            myCar.OpenTrunk();
        }
    }
}