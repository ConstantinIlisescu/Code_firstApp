internal class Program
{
    private static void Main(string[] args)
    {
        using (var db = new UniversityContext())
        {

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nWhat is your second name?");
            string secondName = Console.ReadLine();

            Console.WriteLine("\nWhat university do you whant to register to?");
            string universityName = Console.ReadLine();



            Console.WriteLine("\n\n\nPress any key to exit!");
            Console.ReadLine();
        }
    }
}