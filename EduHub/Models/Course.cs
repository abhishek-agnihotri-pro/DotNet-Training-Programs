using System.ComponentModel.DataAnnotations;
class Course
{
    public long CourseID {get; }
    public string Title {get; set; }
    public string Description {get; set; }

    // [DataType(DataType.Date)]
    public DateTime CourseStartDate {get; set; }

    // [DataType(DataType.Date)]
    public DateTime CourseEndDate {get; set; }
    public long UserID {get; set; }
    public string Category {get; set; }
    public string Level {get; set; }

    public Course(long courseID, string title,string description,DateTime courseStartDate,DateTime courseEndDate,long userID,string category,string level){
        CourseID = courseID;
        Title = title;
        Description = description;
        CourseStartDate = courseStartDate;
        CourseEndDate = courseEndDate;
        UserID = userID;
        Category = category;
        Level = level;
    }
    public override string ToString()
    {
        return $"Course : {CourseID}, Title : {Title}, StartDate : {CourseStartDate}, EndDate : {CourseEndDate}";
    }

}