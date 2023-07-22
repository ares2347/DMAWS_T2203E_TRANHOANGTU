using System.ComponentModel.DataAnnotations.Schema;

namespace DMAWS_T2203E_TRANHOANGTU.Models;

public class ProjectEmployee
{
    public int ProjectEmployeeId { get; set; }
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
    public int ProjectId { get; set; }
    public virtual Project Project { get; set; }
    public string Tasks { get; set; }
}