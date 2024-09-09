using System.Collections;
using System.Collections.Generic;

class Batch:IEnumerable
{
    public int ID { get; set; }
    public Student[] ?Students { get; set; }

    public Batch()
    {
        ID = 101;
        Students = [
            new Student(){ID = 1, Name = "Abhishek"},
            new Student(){ID = 2, Name = "Rakesh"},
            new Student(){ID = 3, Name = "Pankaj"},
            new Student(){ID = 4, Name = "Arun"},
            new Student(){ID = 5, Name = "Manoj"},
        ];
    }

    public IEnumerator GetEnumerator(){
        foreach(Student student in Students){
            yield return student;
        }
    }

    public override string ToString()
    {
        string? students_string = "";

        return $"Batch ID : {ID}, Students : {Students}";
    }

}

