using Code_firstApp;

internal class Program
{
    public static void Main(string[] args)
    {
        using (var db = new StudentContext())
        {

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nWhat is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nWhat town are you living in?");
            string townName = Console.ReadLine();

            Console.WriteLine("\nWhat university do you whant to register to?");
            string universityName = Console.ReadLine();

            Console.WriteLine("\n\n");

            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Town = townName,
                UniversityName = universityName
            };

            db.Students.Add(student);
            db.SaveChanges();

            var query = from b in db.Students
                        orderby b.FirstName
                        select b;

            foreach (var item in query)
            {
                Console.WriteLine($"Student {item.FirstName} whants to go to the University \"{item.UniversityName}\".");
            }


            Console.WriteLine("\n\n\nPress any key to exit!");
            Console.ReadLine();
        }
    }
}