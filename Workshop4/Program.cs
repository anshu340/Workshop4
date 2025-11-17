using Workshop4;

namespace WorkShop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Product (7*1): " + product2);

            
        }
    }
}