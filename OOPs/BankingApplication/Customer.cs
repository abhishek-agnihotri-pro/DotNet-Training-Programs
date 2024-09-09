class Customer
{
    public int CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public string? Contact { get; set; }
    public string? Email { get; set; }
    public Account[] Accounts { get; set; }
    public int accIndex = 0;

    public Customer(int id, string name, string contact, string email){
        Accounts = new Account[20];
        CustomerID = id;
        CustomerName = name;
        Contact = contact;
        Email = email;
    }

    public void addAccount(Account ac){
        Accounts[accIndex] = ac;
        accIndex++;
    }

    public override string ToString()
    {
        string accInfo = "";
        for(int i = 0 ; i < accIndex ; i++){
            // Console.WriteLine(Accounts[i]);
            accInfo += $" {Accounts[i]},\n";
        }
        return $" Customer ID : {CustomerID},\n Customer Name : {CustomerName}\n Email : {Email},\n Contact : {Contact},\n Accounts Information : \n {accInfo}";
    }
}