namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Krazy Fact Factory!\nEnter your first name to continue:");
                var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}! What is your favorite color? (ONLY use lower case letters):");
                var favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal? (ONLY use lower case letters):");
                var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band? (ONLY use lower case letters):");
                var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Nice choices {name}! Did you know that {favoriteColor} {favoriteAnimal}s is the mascot of {favoriteBand}?\nThey even bring some on tour with them at their concerts!\nThank you, goodbye!"); 
        }
    }
}
