namespace SearchMatchAPI.DTOs
{
    public record Engine2DTO
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public string DiseaseType { get; init; }

        public DateTime DateOfBirth { get; init; }
    }
}
