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
            Console.WriteLine("The sum of number 1 and number 2 is " + sum);
            Console.WriteLine("The division of number 1 and number 2 is " + division);
            Console.WriteLine($"My name is {firstName} {lastName}");
        }
    }
}
