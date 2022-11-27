using SearchMatchAPI.DTOs;
using SearchMatchAPI.Models;

namespace SearchMatchAPI
{
    public static class Extension
    {
        public static Engine1DTO AsEngine1DTO(this Patient patient)
        {
            return new Engine1DTO
            {
                Forename = patient.FirstName,
                Surname = patient.LastName,
                DateOfBirth = patient.DateOfBirth,
                DiseaseType = patient.DiseaseType,
            };
        }

        public static Engine2DTO AsEngine2DTO(this Patient patient)
        {
            return new Engine2DTO
            {
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                DateOfBirth = patient.DateOfBirth,
                DiseaseType = patient.DiseaseType,
            };
        }

        public static PatientDTO AsPatientDTO(this Patient patient)
        {
            return new PatientDTO
            {
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                DateOfBirth = patient.DateOfBirth,
                DiseaseType = patient.DiseaseType,
            };
        }

        public static GetPatientDTO AsGetPatientDTO(this Patient patient)
        {
            return new GetPatientDTO
            {
                Id= patient.Id,
                FirstName = patient.FirstName,
            };
        }
    }
}
