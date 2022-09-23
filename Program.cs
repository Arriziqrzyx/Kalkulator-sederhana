namespace KalkulatorSederhana{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter The Action To Be Performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Enter 1st Input");
            Console.WriteLine("");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Input");
            Console.WriteLine("");
            float number2 = float.Parse(Console.ReadLine());
            Console.Write("The Result is ");
            switch (count)
            {
                case 1:
                    Console.WriteLine(number1 + number2);
                    break;
                case 2:
                    Console.WriteLine(number1 - number2);
                    break;
                case 3:
                    Console.WriteLine(number1 * number2);
                    break;
                case 4:
                    Console.WriteLine(number1 / number2);
                    break;
            }   
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to quit . . .");
            Console.ReadKey();
        }
    }
}