class Student
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Date AdmissionDate { get; set; }

    public Student( int id , string firstName , string lastName,Date admissionDate )
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        this.AdmissionDate = admissionDate;
    }

    public override string ToString()
    {
        return $"Student ID : {ID}, FirstName : {FirstName}, LastName : {LastName}, Admission Date: {AdmissionDate}";
    }
}