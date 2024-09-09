// using System;

// public class VarDynamic
// {
//     public static void Main(string[] args)
//     {
//         // var x = 10; // statically typed , known at compile time
//         // Console.WriteLine(x);

//         // dynamic y = MyAction(x); // type known at runtime, dynamically typed
//         // Console.WriteLine(y);
//         int []arr = new int[10];
//         for(int i = 0 ; i < 10 ; i++) arr[i] = i+10;

//         dynamic ans = DynamicMethod(arr,10);
//         Console.WriteLine(ans);

//     }

//     public static dynamic DynamicMethod(int []arr, int n){
//         dynamic sum = arr[0];
//         for(int i = 1 ; i < n ; i++){
//             sum += arr[i];
//         }
//         return sum/n;
//     }

//     // public static dynamic MyAction(int x){
//     //     return x*x;
//     // }
// }