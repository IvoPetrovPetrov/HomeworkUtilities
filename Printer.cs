namespace HomeworkUtilities
{
    internal class Printer
    {
        static void Main(string[] args)
        {
            int myInt1 = 15;
            int myInt2 = 26;
            const int myConstInt = 99;
            string firstName = "Ivo";
            string lastName = "Petrov";
            double myDouble = 1.23;
            char myChar = 'A';
            bool isTestingFun = true;
            int sum = myInt1 + myInt2;
            int division = myInt2 / myInt1;

            Console.WriteLine("Thats my first project!");
            Console.WriteLine("The sum of the hardcoded numbers is " + sum);
            Console.WriteLine("The division of the hardcoded numbers is " + division);
            Console.WriteLine($"My name is {firstName} {lastName}");

            Console.WriteLine("Enter number 1: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            double numberTwo = double.Parse(Console.ReadLine());
            double numbersSum = numberOne + numberTwo;
            Console.WriteLine($"The sum of {numberOne} and {numberTwo} is {numbersSum}");
        }
    }
}
