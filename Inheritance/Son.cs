class Son : Mother
{
    public string? Sname { get; set; }
    public int Sage { get; set; }

    public Son(){
        Sname = "Abhi";
        Sage = 22;
    }

    public Son(string Sname, int Sage,string Mname, int Mage):base(Mname,Mage){
        this.Sname = Sname;
        this.Sage = Sage;
    }

    public override string ToString()
    {
        return base.ToString() + $", Son Name : {Sname}, Son Age : {Sage}";
    }
}