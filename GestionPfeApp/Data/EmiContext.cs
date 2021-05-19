using GestionPfeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPfeApp.Data
{
    public class EmiContext : DbContext
    {
        public EmiContext(DbContextOptions<EmiContext> options) : base(options)
        {
            
        }

        
        public DbSet<Pfe> Pfes { get; set; }
        public DbSet<Etudiant> Students { get; set; }
       // public DbSet<Course> Courses { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Professeur> ProfesseurDep { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professeur>().ToTable("Professeur");
            modelBuilder.Entity<Pfe>().ToTable("Pfe");
            modelBuilder.Entity<Etudiant>().ToTable("Student");
            modelBuilder.Entity<Planning>().ToTable("Planning");
            modelBuilder.Entity<Departement>().ToTable("Departement");
        }
        public DbSet<GestionPfeApp.Models.Departement> Departement { get; set; }
        public DbSet<GestionPfeApp.Models.Planning> Planning { get; set; }
    }
}