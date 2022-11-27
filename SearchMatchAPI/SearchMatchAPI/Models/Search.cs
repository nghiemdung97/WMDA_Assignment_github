namespace SearchMatchAPI.Models
{
    public record Search
    {
        public Guid PatientID { get; init; }

        public int MatchEngineID { get; init; }
    }
}
