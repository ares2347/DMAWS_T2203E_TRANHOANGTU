namespace DMAWS_T2203E_TRANHOANGTU.Dto;

public class CreateProjectRequest
{
    public string ProjectName { get; set; }
    public DateTime ProjectStartDate { get; set; }
    public DateTime? ProjectEndDate { get; set; }
    public List<int> EmployeeIds { get; set; }
}