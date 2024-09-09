enum AccountType{ Saving,Current }
class Account
{
    public int AccountNumber { get; set; }
    // public string? Name { get; set; }
    public AccountType AccType { get; set; }
    public decimal Balance { get; set; }
    
    public Date OpeningDate { get; set; }

    public Account(int accountNumber, AccountType accountType, decimal balance, Date openingDate ){
        AccountNumber = accountNumber;
        AccType = accountType;
        Balance = balance;
        OpeningDate = openingDate;
    }

    public override string ToString()
    {
        return $" Account Number : {AccountNumber} \n Account Type : {AccType} \n Account Balance : {Balance}Rs, \n Account Opering Date : {OpeningDate}";
    }

}