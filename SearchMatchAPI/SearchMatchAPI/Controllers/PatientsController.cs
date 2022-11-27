
using Microsoft.AspNetCore.Mvc;
using SearchMatchAPI.DTOs;
using SearchMatchAPI.Models;
using SearchMatchAPI.Repositories;

namespace SearchMatchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository repository;
        public PatientsController(IPatientRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<GetPatientDTO> GetItems()
        {
            var patients = repository.GetPatients().Select(item => item.AsGetPatientDTO());
            return patients;
        }

        [HttpPost]
        public ActionResult CreatePatient(PatientDTO patientDTO)
        {
            if (patientDTO == null)
                return BadRequest("Patient does not exist!");

            Patient patient = new()
            {
                Id = Guid.NewGuid(),
                FirstName = patientDTO.FirstName,
                LastName = patientDTO.LastName,
                DateOfBirth = patientDTO.DateOfBirth,
                DiseaseType = patientDTO.DiseaseType,
            };

            repository.CreatePatient(patient);
            return Ok();
        }

    }
}
