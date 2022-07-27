using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IGB.Models
{
    public class AppDbContext : IdentityDbContext<Patient>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient_Services>()
               .HasKey(am => new
               {
                   am.PatientId,
                   am.ServiceId
               });

            modelBuilder.Entity<Patient_Services>()
                .HasOne(m => m.Patient)
                .WithMany(am => am.Patient_Services)
                .HasForeignKey(m => m.PatientId);

            modelBuilder.Entity<Patient_Services>()
                .HasOne(m => m.Service)
                .WithMany(am => am.Patient_Services)
                .HasForeignKey(m => m.ServiceId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Patient_Services> Patient_Services { get; set; }

    }
}
