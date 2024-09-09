using System.Xml;

class ClassStatic
{
    public static int a { get; set; }
    public static int b { get; set; }
    public static int c { get; set; }

    static ClassStatic(){
        a = 10;
        b = 20;
    }

    public static int Add(){
        c = a + b;
        return c;
    }
    public static int Subtract(){
        c = a - b;
        return c;
    }
    public static int Multiplication(){
        c = a * b;
        return c;
    }
    public static int Division(){
        c = a / b;
        return c;
    }
}