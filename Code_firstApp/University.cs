namespace Code_firstApp
{
    internal class University
    {
        public int UniversityID { get; set; }
        public string? UniversityName { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
