class Mother
{
    public int Mage { get; set; }
    public string? Mname { get; set; }

    public Mother(){
        Mage = 50;
        Mname = "Koshaliya";
    }

    public Mother(string name,int age){
        Mage = age;
        Mname = name;
    }

    public override string ToString()
    {
        return $"Mother Name : {Mname}, Mother Age : {Mage}";
    }

}