namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        
        static void Main(string[] args)
        {
            var amountOfEggs = Sum(2, 6);
            var rabbits = Multiply(2, 4, 8);

            //---------exercise 1------------
            Console.WriteLine("Hello, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Wonderful! Lastly, What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}. Here is your profile.");
            Console.WriteLine("--------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");

            //-----------exercise 2----------

        }
    }
}
