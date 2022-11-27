namespace SearchMatchAPI.DTOs
{
    public record SearchDTO
    {
        public Guid PatientID { get; init; }

        public int MatchEngineID { get; init; }

    }
}
