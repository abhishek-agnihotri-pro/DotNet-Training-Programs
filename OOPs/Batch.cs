class Batch
{
    public int BatchID { get; set; }
    public Student []Students { get; set; }
    public string Trainer { get; set; }
    public string TrainingDuration { get; set; }
    public Date TrainingStartDate { get; set; }
    public Date TrainingEndDate { get; set; }

    public Batch(){
        BatchID = 101;

        Students = new Student[5];
        Students[0] = new Student(101,"Abhishek","Agnihotri",new Date(1,1,2008));
        Students[1] = new Student(102,"Abhishek","Agnihotri",new Date(1,1,2008));
        Students[2] = new Student(103,"Abhishek","Agnihotri",new Date(1,1,2008));
        Students[3] = new Student(104,"Abhishek","Agnihotri",new Date(1,1,2008));            
        Students[4] = new Student(105,"Abhishek","Agnihotri",new Date(1,1,2008));

        Trainer = "Mrs. Sarita Lad";
        TrainingDuration = "3 months";
        TrainingStartDate = new Date(1,6,2024);
        TrainingEndDate = new Date(1,9,2024);
    }
    public Batch(int id, Student[] arr, string trainer)
    {
        BatchID = id;
        Students = arr;
        Trainer = trainer;
        Trainer = "Mrs. Sarita Lad";
        TrainingDuration = "3 months";
        TrainingStartDate = new Date(1,6,2024);
        TrainingEndDate = new Date(1,9,2024);

    }

    public override string ToString()
    {
        return $"Batch ID : {BatchID},\n All Students :\n {Students[0]} \n {Students[1]}\n {Students[2]}\n {Students[3]}\n {Students[4]} \n Trainer : {Trainer} \n Training Duration : {TrainingDuration} \n Training Start Date : {TrainingStartDate} \n Training End Date : {TrainingEndDate}";
    }
}