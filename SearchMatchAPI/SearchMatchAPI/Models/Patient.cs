namespace SearchMatchAPI.Models
{
    public record Patient
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public string DiseaseType { get; init; }

        public DateTime DateOfBirth { get; init; }
    }
}
