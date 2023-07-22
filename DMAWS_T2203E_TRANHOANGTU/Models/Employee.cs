using System.ComponentModel.DataAnnotations.Schema;

namespace DMAWS_T2203E_TRANHOANGTU.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public DateTime EmployeeDOB { get; set; }
    public string EmployeeDepartment { get; set; }
    public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
    [NotMapped] public IEnumerable<Project> Projects { get; set; }
}