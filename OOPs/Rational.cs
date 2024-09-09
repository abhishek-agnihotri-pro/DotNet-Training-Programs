class Rational
{
    public int N { get; set; }
    public int D { get; set; }

    public Rational(int N, int D){
        this.N = N;
        this.D = D;
    }

    public static Rational operator + (Rational r1, Rational r2){
        Rational r3 = new Rational(0,0);
        r3.N = r1.N*r2.D + r2.N*r1.D;
        r3.D = r1.D*r2.D;
        if(r3.N % r3.D == 0){
            r3.N /= r3.D;
            r3.D = 1;
        }
        return r3;
    }
    public static Rational operator - (Rational r1, Rational r2){
        Rational r3 = new Rational(0,0);
        r3.N = r1.N*r2.D - r2.N*r1.D;
        r3.D = r1.D*r2.D;
        if(r3.N % r3.D == 0){
            r3.N /= r3.D;
            r3.D = 1;
        }
        return r3;
    }
    public static Rational operator * (Rational r1, Rational r2){
        Rational r3 = new Rational(0,0);
        r3.N = r1.N* r2.N;
        r3.D = r1.D*r2.D;
        if(r3.N % r3.D == 0){
            r3.N /= r3.D;
            r3.D = 1;
        }
        return r3;
    }
    public static Rational operator / (Rational r1, Rational r2){
        Rational r3 = new Rational(0,0);
        r3.N = r1.N* r2.D;
        r3.D = r1.D*r2.N;
        if(r3.N % r3.D == 0){
            r3.N /= r3.D;
            r3.D = 1;
        }
        return r3;
    }

    public static void Simplify(ref int N, ref int D){

    }


    public override string ToString()
    {
        return $"{N}/{D}";
    }
}