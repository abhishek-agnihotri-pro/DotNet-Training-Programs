class BatchStatic
{
    public static char Gender { get; set; }
    public  int BatchID { get; set; }
    public Student[] Students { get; set; }

    public BatchStatic(){
        Date date = new Date(1,1,1);
        Students = new Student[5];
        Students[0] = new Student (101,"A","A",date);
        Students[1] = new Student (101,"A","A",date);
        Students[2] = new Student (101,"A","A",date);
        Students[3] = new Student (101,"A","A",date);
        Students[4] = new Student (101,"A","A",date);
 
        // Students[0] = new Student { AdmissionDate = date, FirstName = "A", ID = 1, LastName = "A" };
        // Students[1] = new Student { AdmissionDate = date, FirstName = "A", ID = 1, LastName = "A" };
        // Students[2] = new Student { AdmissionDate = date, FirstName = "A", ID = 1, LastName = "A" };
        // Students[3] = new Student { AdmissionDate = date, FirstName = "A", ID = 1, LastName = "A" };
        // Students[4] = new Student { AdmissionDate = date, FirstName = "A", ID = 1, LastName = "A" };
    }

    public BatchStatic(int batchID, params Student[] students){
        BatchID = batchID;
        Students = students;
    }
    public void GetDetails(){
        if(Gender == 'm'){
            Console.WriteLine("No of male studnts in a batch are "+ Students.Length);
        }
        else{
            Console.WriteLine("No of Female students in a batch are " + Students.Length);

        }
        foreach(var student in Students){
            Console.WriteLine($"Student Details : {student}");
        }

    }
}