using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

// using ClassLibrary.bin.Debug.net8.0.ClassLibrary.dll;

static class MyClass
{
    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
    public static void Inform(string parameter){
        Console.WriteLine($"Inform:parameter={parameter}");
    }
}

public class TestClass{
    private int testValue = 42;
    public int TestMethod(int numberToAdd){
        return this.testValue + numberToAdd;
    }
    public int Add(int a,int b){
        return a+b;
    }
}

class Program
{
    public static void Main(string[] args){
        
        // Type t = typeof(TestClass);
        // MethodInfo[] methods = t.GetMethods();
        // foreach(MethodInfo m in methods){ // methods is a name of array MethodInfo
        //     Console.WriteLine(m.Name);
        // }
        // MethodInfo m1 = t.GetMethod("TestMethod");
        // ConstructorInfo ctor = t.GetConstructor(System.Type.EmptyTypes);
        
        // object obj = ctor.Invoke(null);
        // Console.WriteLine("ans of TestMethod = "+m1.Invoke(obj,new object[]{10}));

        // MethodInfo m2 = t.GetMethod("Add");
        // object[] parameters = {10,20};
        // // Console.WriteLine("ans of Add = "+m2.Invoke(obj,new object[]{10,10}));
        // Console.WriteLine("ans of Add = "+m2.Invoke(obj,parameters));

// -------------------------------------

        // string[] parameters = {"Abhi","Test"};
        // Type type = typeof(MyClass);
        // MethodInfo info = type.GetMethod("Inform");

        // foreach(string parameter in parameters){
        //     info.Invoke(null,new object[]{parameter});
        // }

        // Type type = typeof(Double);
        // Console.WriteLine(type.BaseType);
        // Console.WriteLine(type.Name);
        // Console.WriteLine(type.Namespace);

// ------------------------------------------

        // MethodInfo[] methods;
        // Type[] types = new Type[2];

        // try{
        //     Assembly asm = Assembly.LoadFile(@"D:\\ClassLibrary.dll");
        //     types = asm.GetTypes();
        //     foreach(Type t in types){
        //         Console.WriteLine("class Names " + t.FullName);
        //         foreach(MethodInfo m in t.GetMethods()){
        //             Console.WriteLine("Method Names : " + m.Name);
        //         }
        //     }
        // }
        // catch(Exception e){
        //     Console.WriteLine(e);
        // }

// ----------------------------------

        Student s = new Student(1,"Abhishek");
        Type t = s.GetType();
        Console.WriteLine("Name of class from obj s = " + s.GetType());
        Console.WriteLine("Name of class from obj s = " + t);

        try{
            foreach(Attribute a in t.GetCustomAttributes(true)){
                // MyCustomeAttribute c = (MyCustomeAttribute)a;
                if (a is MyCustomeAttribute c)
                {
                    Console.WriteLine("Custom name attribute " + c.Name);
                    Console.WriteLine("Custom version attribute " + c.Version);
                }
            }
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
// ---------------------------------------






    }
    
}