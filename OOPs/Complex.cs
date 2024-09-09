using System.Runtime.InteropServices;

class Complex
{
    public int Real { get; set; }
    public int Imag { get; set; }

    public Complex(int real, int imag){
        Real = real;
        Imag = imag;
    }

    public static Complex operator + (Complex c1, Complex c2){
        Complex c3 = new Complex(0,0);
        c3.Real = c1.Real + c2.Real;
        c3.Imag = c1.Imag + c2.Imag;
        return c3;
    }
}