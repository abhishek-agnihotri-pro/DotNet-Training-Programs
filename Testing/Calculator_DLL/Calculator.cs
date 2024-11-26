namespace Calculator_DLL_Project;

public class Calculator
{
    public int Add(int x,int y){ return x+y;}
    public int Sub(int a,int b) { 
        if (a<b)
        {
            throw new ArgumentException($"{a} is less than {b}");
        }
        return a-b;
    }
    public int Multiply(int a,int b){return a*b;}
    public int Divide(int x,int y){
        if ((y==0))
        {
            throw new DivideByZeroException($"{y} is zero.Cannot divide by Zero");
        }
        return x/y;
    }

}
