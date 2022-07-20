namespace PatientsWebApi.Common.Models;

public class User
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Surname { get; set; }
    
    public int Age { get; set; }

    public string Address { get; set; }
    
    public string Phone { get; set; }
    public Patient Patients { get; set; }
}