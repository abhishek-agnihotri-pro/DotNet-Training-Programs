// using System;
// using System.Numerics;

// public class HelloWorld
// {
//     //Overloaded Function
//     public static void calulate_area(int r, double pi){
//         double area = pi*r*r;
//         Console.WriteLine($"area of Circle : {area}");
//     }
//     public static void calulate_area(int l, int b){
//         int area  = l*b;
//         Console.WriteLine($"area of Reactangle : {area}");

//     }
//     public static void calulate_area(float Base, float Height){
//         float area = 0.5f * Base * Height;
//         Console.WriteLine($"area of Triangle : {area : f2}");

//     }

//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter Radius of the Circle : ");
//         int r = Convert.ToInt32(Console.ReadLine());
//         calulate_area(r,Math.PI);

//         // Console.WriteLine("Enter length and breadth of the Reactangle : ");
//         calulate_area(2,4);
//         calulate_area(2.0f,4.0f);
//     }
// }