namespace SearchMatchAPI.DTOs
{
    public record Engine1DTO
    {
        public string Forename { get; init; }
        public string Surname { get; init; }

        public string DiseaseType { get; init; }

        public DateTime DateOfBirth { get; init; }
    }
}
