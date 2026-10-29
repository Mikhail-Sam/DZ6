using SummerCamp.Classes;

namespace SummerCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("     ЛЕТНИЙ ЛАГЕРЬ");

            Task1_Inheritance();
            Task2_Polymorphism();
            Task3_Encapsulation();
            Task4_DataHandling();
            
            Console.ReadKey();
        }
        
        static void Task1_Inheritance()
        {
            Console.WriteLine("     НАСЛЕДОВАНИЕ");
            var counselor = new Counselor("Александр", 25, "+7-999-111-2222", 
                                         "Спорт", 5, 45000, 15);
            
            Console.WriteLine("Вожатый ");
            counselor.ShowInfo();
            Console.WriteLine($"Опыт: {counselor.Experience} лет\n");

            var chef = new Chef("Мария", 35, "+7-999-333-4444", 
                               "Русская кухня", 500, true);
            
            Console.WriteLine("Повар");
            chef.ShowInfo();
            Console.WriteLine($"Ставка: {chef.HourlyRate:C}/час\n");
        }

        static void Task2_Polymorphism()
        {
            Console.WriteLine("     ПОЛИМОРФИЗМ");
            
            List<Person> staffAndCampers = new List<Person>
            {
                new Counselor("Игорь", 28, "+7-999-555-6666", "Туризм", 7, 50000, 20),
                new Chef("Ольга", 40, "+7-999-777-8888", "Итальянская", 600, true),
                new Camper("Максим", 13, "+7-999-999-0000", "C-301", "8 класс", 
                          15000, "Андрей", "+7-999-111-0000", false)
            };

            foreach (var person in staffAndCampers)
            {
                Console.WriteLine($"Имя: {person.Name} | Роль: {person.GetRole()}");
            }
            Console.WriteLine();
        }

        static void Task3_Encapsulation()
        {
            Console.WriteLine("     ИНКАПСУЛЯЦИЯ");

            var camper = new Camper("София", 12, "+7-999-222-3333", 
                                   "D-401", "7 класс", 0, 
                                   "Елена", "+7-999-444-5555", false);

            Console.WriteLine("Текущее имя родителя: " + camper.ParentName);
            
            camper.PayFee(15000);
            camper.RegisterAllergy("Пыльца", "Сезонная");
            
            Console.WriteLine($"Статус готовности: {camper.IsReady()}");
            Console.WriteLine();
        }

        static void Task4_DataHandling()
        {
            Console.WriteLine("     РАБОТА С ДАННЫМИ");

            var campers = new List<Camper>
            {
                new Camper("Иван", 12, "+7-999-123-4567", "A-101", "7 класс", 15000, "Мария", "+7-999-765-4321", false),
                new Camper("Анна", 13, "+7-999-234-5678", "A-102", "8 класс", 15000, "Ольга", "+7-999-876-5432", true),
                new Camper("Дмитрий", 11, "+7-999-345-6789", "B-201", "6 класс", 15000, "Сергей", "+7-999-987-6543", false)
            };

            Console.WriteLine("     Список участников лагеря");
            foreach (var c in campers)
            {
                c.ShowInfo();
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}