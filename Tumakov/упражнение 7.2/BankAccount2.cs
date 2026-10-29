namespace Project6.упражнение_7._2
{
    class BankAccount2
    {
        private static long nextAccountNumber = 100000000;
        private string accountNumber2;
        private decimal balance2;
        private AccountType2 accountType3;
        public string AccountNumber => accountNumber2;
        public decimal Balance
        {
            get { return balance2; }
            set { balance2 = value; }
        }

        public AccountType2 AccountType
        {
            get { return accountType3; }
            set { accountType3 = value; }
        }
        public BankAccount2(decimal initialBalance, AccountType2 accountType)
        {
            accountNumber2 = GenerateAccountNumber();
            Balance = initialBalance;
            AccountType = accountType;
        }
        private string GenerateAccountNumber() // генерация 
        {
            return (nextAccountNumber++).ToString(); // метод  берёт текущее значение счётчика, превращает его в строку и увеличивает счётчик на единицу
        }
        public void DisplayAccountDetails2()
        {
            Console.WriteLine($"Номер счёта: {accountNumber2}");
            Console.WriteLine($"Баланс: {balance2}");
            Console.WriteLine($"Тип счёта: {accountType3}");
        }
    }
}