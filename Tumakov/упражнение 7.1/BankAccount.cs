namespace Project6.упражнение_7._1
{
    class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public BankAccount(string accNum, decimal bal, AccountType type)
        {
            AccountNumber = accNum;
            Balance = bal;
            AccountType = type;
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accountType}");
        }
    }
}