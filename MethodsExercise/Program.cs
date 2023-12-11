using System;
namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Krazy Fact Factory!\nEnter your first name to continue:");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}! What is your favorite color? (ONLY use lower case letters):");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal? (ONLY use lower case letters):");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band? (ONLY use lower case letters):");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"Nice choices {name}! Did you know that {favoriteColor} {favoriteAnimal}s is the mascot of {favoriteBand}?\nThey even bring some on tour with them at their concerts!\nYou man now continue to our 4 part calculator.");

            Console.WriteLine("Enter Number 1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Add(num1, num2));

            Console.WriteLine("Enter Number 3:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 4:");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(num3, num4));

            Console.WriteLine("Enter Number 5:");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 6:");
            int num6 = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(num5, num6));

            Console.WriteLine("Enter Number 7:");
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 8:");
            int num8 = int.Parse(Console.ReadLine());

            Console.WriteLine(Divide(num7, num8));


        }


        public static void GreetPerson(string name)
        {
            Console.WriteLine($"Hey,{name}!");
        }

        public static double Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Multiply(int num3, int num4)
        {
            return num3 * num4;
        }

        public static double Subtract(int num5, int num6)
        {
            return num5 - num6;
        }

        public static double Divide(int num7, int num8)
        {
            return num7 / num8;
        }
    }


}
