using SearchMatchAPI.Models;

namespace SearchMatchAPI.Repositories
{
    public class InMemPatientRepository : IPatientRepository
    {
        private readonly List<Patient> patients = new()
        {
            new Patient{ Id = Guid.NewGuid(), FirstName = "John",LastName = "Smith", DateOfBirth =  Convert.ToDateTime("12/25/2008"), DiseaseType = "Cancer"},
            new Patient{ Id = Guid.NewGuid(), FirstName = "Kevin",LastName = "Nguyen", DateOfBirth =  Convert.ToDateTime("06/03/1996"), DiseaseType = "Ligma"},
            new Patient{ Id = Guid.NewGuid(), FirstName = "Jorah",LastName = "Mormont", DateOfBirth =  Convert.ToDateTime("01/01/1975"), DiseaseType = "Greyscale"},

        };


        public void CreatePatient(Patient patient)
        {
            patients.Add(patient);
        }

        public Patient GetPatient(Guid id)
        {
            return patients.Where(patient => patient.Id == id).SingleOrDefault();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return patients;
        }
    }
}
