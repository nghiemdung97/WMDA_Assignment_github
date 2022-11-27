using System.ComponentModel.DataAnnotations;

namespace SearchMatchAPI.DTOs
{
    public record PatientDTO
    {


        [StringLength(int.MaxValue,MinimumLength = 5,
            ErrorMessage = "First name must be minimum of 5 characters")]
        [RegularExpression(@"[a-zA-Z\s]+$", 
            ErrorMessage = "Numbers and symbols not allowed.")]
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public string DiseaseType { get; init; }
        [Required(ErrorMessage = "You should fill out date of birth!")]
        public DateTime DateOfBirth { get; init; }
    }
}
