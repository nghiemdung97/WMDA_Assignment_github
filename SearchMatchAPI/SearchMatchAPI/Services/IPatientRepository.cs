using SearchMatchAPI.Models;

namespace SearchMatchAPI.Repositories
{
    public interface IPatientRepository
    {
        void CreatePatient(Patient patient);
        Patient GetPatient(Guid id);

        IEnumerable<Patient> GetPatients();
    }
}
