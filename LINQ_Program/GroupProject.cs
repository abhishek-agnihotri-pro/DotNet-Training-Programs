public class GroupProject
{
    public int ProjectId { get; set; }
    public string? ProjectName { get; set; }
    public List<string>? GroupofStudents { get; set; }
    public static List<GroupProject> GetProjects()
    {
        return new List<GroupProject>()
        {
            new GroupProject(){ProjectId = 1, ProjectName = "Caterpillar Inventory", GroupofStudents = new List<string>() { "Abhishek", "Shukla", "Dwivedi"} },
            new GroupProject(){ProjectId = 2, ProjectName = "John Deere", GroupofStudents = new List<string>() { "Pratik", "Shamra", "Sutar" }},
            new GroupProject(){ProjectId = 3, ProjectName = "Bunzle", GroupofStudents = new List<string>() { "Kumar", "Gautam", "Singh"} },
            new GroupProject(){ProjectId = 4, ProjectName = "Life Care Pharma", GroupofStudents = new List<string>() { "Mishra", "Agnihotri", "Agrawal" } }
        };
    }
}