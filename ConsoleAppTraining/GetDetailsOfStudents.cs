
// public class GetDetailsOfStudents
// {
//     public static void Main(string[] args)
//     {
//         GetStudentDetails('f',"Ab","Bc","Cd","De");
//     }
//     public static void GetStudentDetails(char gender, params string[] students){
//         if(gender == 'f' || gender == 'F') Console.WriteLine($"There are {students.Length} Girls in the class");
//         else if( gender == 'm' || gender == 'M') Console.WriteLine($"There are {students.Length} boys in the class");
        
//         Console.WriteLine("The names are as follows");
//         int i = 0;
//         foreach(string student in students){
//             if(i == students.Length - 1) Console.WriteLine(student);
//             else Console.WriteLine(student + ",");
//             i++;
//         }
//     }
// }