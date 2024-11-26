using System.Data;

class Department
{
    private object ObjLock = new Object();
    int salary;
    Random r = new Random();
    public Department(int initial)
    {
        salary = initial;
    }
    int Withdraw(int amount){
        if(salary < 0)
            throw new Exception("Negative Balance");
        
        lock(ObjLock){
            if(salary >= amount){
                Console.WriteLine("salary before withdrawal : " + salary);
                Console.WriteLine("amount to withdrawal : " + amount);
                salary -= amount;
                Console.WriteLine("Amount left " + salary);
                return amount;
            }
            else
            return 0;
        }
        
    }
}