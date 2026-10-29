using Project6.домашнее_задание_7._1;
using Project6.упражнение_7._1;
using Project6.упражнение_7._2;
using Project6.упражнение_7._3;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Упражнение 7.1");
            BankAccount myAccount = new BankAccount("123456789", 10000m, AccountType.DepositAccount);
            myAccount.PrintAccountDetails();

            Console.WriteLine(string.Empty);
            Console.WriteLine("     Упражнение 7.2");
            BankAccount2 bankAccount2 = new BankAccount2(10000m, AccountType2.DepositAccount);//m - decimal
            bankAccount2.DisplayAccountDetails2();

            Console.WriteLine(string.Empty);
            Console.WriteLine("     Упражнение 7.3");
            BankAccount3 myAccount2 = new BankAccount3(10000m, "Иван Иванов");

            myAccount2.ShowAccountDetails3();

            myAccount2.Deposit(5000m);
            myAccount2.ShowAccountDetails3();

            myAccount2.Withdraw(3000m);
            myAccount2.ShowAccountDetails3();

            myAccount2.Withdraw(15000m);
            myAccount2.ShowAccountDetails3();

            Console.WriteLine(string.Empty);
            Console.WriteLine("     Домашнее задание 7.1");
            Building house = new Building(height: 30.0, floors: 5, apartmentsTotal: 100, entrances: 2);
            house.PrintBuildingDetails();
        }
    }
    //=> иногда используется вместо return/get
}