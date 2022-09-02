using System.Data.Entity;

namespace Code_firstApp
{
    internal class UniversityContext : DbContext
    {
        public UniversityContext() : base()
        {

        }

        public DbSet<Student>? Students { get; set; }
        public DbSet<University>? Universities { get; set; }
    }
}
