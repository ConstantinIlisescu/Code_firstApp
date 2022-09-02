using System.Data.Entity;

namespace Code_firstApp
{
    public class StudentContext : DbContext
    {
        public DbSet<Student>? Students { get; set; }
    }

}
