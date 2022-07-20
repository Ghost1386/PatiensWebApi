using Microsoft.EntityFrameworkCore;
using PatientsWebApi.Common.Models;

namespace PatientsWebApi.BusinessLogic;

public sealed class PatientContext : DbContext
{
    public PatientContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<User>? Users { get; set; }
    
    public DbSet<Patient>? Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User {Name="Tom", Surname = "Petr", Age = 26, Address = "pinsk", Phone = "42342355"});
        modelBuilder.Entity<User>().HasData(new User {Name="Vlad", Surname = "Alexis", Age = 14, Address = "minsk", Phone = "3452134"});
        modelBuilder.Entity<User>().HasData(new User {Name="Kirill", Surname = "Martin", Age = 19, Address = "brest", Phone = "6325143"});
        modelBuilder.Entity<User>().HasData(new User {Name="Anna", Surname = "Bronte", Age = 43, Address = "lida", Phone = "345434"});
        modelBuilder.Entity<User>().HasData(new User {Name="Kate", Surname = "Mills", Age = 32, Address = "mogilev", Phone = "5632451"});
        
        modelBuilder.Entity<Patient>().HasData(new Patient {UserId = 1, Doctor = "Ahmed", Allergies = "no", ChronicDiseases = "no", Profession = "Teacher"});
        modelBuilder.Entity<Patient>().HasData(new Patient {UserId = 2, Doctor = "Arthur", Allergies = "no", ChronicDiseases = "yes", Profession = "Actor"});
        modelBuilder.Entity<Patient>().HasData(new Patient {UserId = 3, Doctor = "Caleb", Allergies = "yes", ChronicDiseases = "yes", Profession = "Fireman"});
        modelBuilder.Entity<Patient>().HasData(new Patient {UserId = 4, Doctor = "Arthur", Allergies = "no", ChronicDiseases = "yes", Profession = "Cook"});
        modelBuilder.Entity<Patient>().HasData(new Patient {UserId = 5, Doctor = "Ahmed", Allergies = "yes", ChronicDiseases = "no", Profession = "Writer"});
    }
}