using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientsWebApi.BusinessLogic;
using PatientsWebApi.Common.Models;

namespace PatiensWebApi.Controllers;

public class MainController : ControllerBase
{
    private readonly PatientContext _patientContext;
    
    public MainController(PatientContext patientContext)
    {
        _patientContext = patientContext;
    }
    
    [HttpDelete]
    public void CascadeDelete()
    {
        if (_patientContext.Users != null)
        {
            User user = _patientContext.Users.OrderBy(e => e.Name).
                Include(e => e.Patients).First();

            _patientContext.Remove(user);
        }

        _patientContext.SaveChanges();
    }

    [HttpGet]
    public List<User> GetUserWithProcedure(int id)
    {
        Microsoft.Data.SqlClient.SqlParameter param = new Microsoft.Data.SqlClient.SqlParameter("@id", id);

        if (_patientContext.Users == null) return null;
        List<User> users = _patientContext.Users.FromSqlRaw("exec GetUser @id", id).ToList();

        return users;
    }
    
    //InformationAboutUser
    [HttpGet]
    public List<User> GetUserWithView()
    {
        List<User> users = _patientContext.InformationAboutUser.ToList();
        return users;
    }
}