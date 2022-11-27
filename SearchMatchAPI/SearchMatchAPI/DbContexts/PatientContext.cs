using Microsoft.EntityFrameworkCore;
using SearchMatchAPI.Models;

namespace SearchMatchAPI.DbContexts
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; } = null!;

    }
}
