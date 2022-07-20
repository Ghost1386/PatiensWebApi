namespace PatientsWebApi.Common.Models;

public class Patient : User
{
    public int UserId { get; set; }
    
    public string Doctor { get; set; }
    
    public string Allergies { get; set; }
    
    public string ChronicDiseases { get; set; }
    
    public string Profession { get; set; }
}