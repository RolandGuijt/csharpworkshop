namespace EntityFramework.Database
{
    internal class Pet
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; }
    }
}
