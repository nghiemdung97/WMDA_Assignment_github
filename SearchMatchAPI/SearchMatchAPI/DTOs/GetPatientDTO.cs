namespace SearchMatchAPI.DTOs
{
    public record GetPatientDTO
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
    }
}
