namespace  Project6.упражнение_7._3
{
    public class BankAccount3
    {
        private static long nextAccountNumber3 = 100000000;
        private string accountNumber3;
        private decimal balance3;
        private string ownerName3;

        public string AccountNumber => accountNumber3;
        public decimal Balance3
        {
            get { return balance3; }
            set { balance3 = value; }
        }
        public string OwnerName3
        {
            get { return ownerName3; }
            set { ownerName3 = value; }
        }

        public BankAccount3(decimal initialBalance, string ownerName)
        {
            accountNumber3 = GenerateAccountNumber3(); // Уникальный номер генерируется автоматически
            Balance3 = initialBalance;
            OwnerName3 = ownerName;
        }

        private string GenerateAccountNumber3()
        {
            return nextAccountNumber3++.ToString();
        }

        //Метод для вывода информации о счёте
        public void ShowAccountDetails3()
        {
            Console.WriteLine($"Номер счёта: {accountNumber3}");
            Console.WriteLine($"Имя владельца: {ownerName3}");
            Console.WriteLine($"Текущий баланс: {balance3}");
        }

        //Метод для пополнения счёта
        public void Deposit(decimal amount)
        {
            balance3 += amount;
            Console.WriteLine($"{amount} зачислено на счёт");
        }

        // Метод для снятия средств со счёта
        public bool Withdraw(decimal amount)
        {
            if (balance3 >= amount)
            {
                balance3 -= amount;
                Console.WriteLine($"{amount} снято со счёта");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счёте");
                return false;
            }
        }
    }
}