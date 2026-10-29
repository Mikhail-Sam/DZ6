namespace SummerCamp.Classes
{
    // Абстрактный класс - нельзя создать объект напрямую
    public abstract class Person
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        protected Person()
        {
            Id = new Random().Next(1000, 9999);
            Name = "Unknown";
            Age = 0;
            Phone = "N/A";
        }

        protected Person(string name, int age, string phone)
        {
            Id = new Random().Next(1000, 9999);
            Name = name;
            Age = age;
            Phone = phone;
        }
        
        public string GetInfo()
        {
            return $"ID: {Id}, Имя: {Name}, Возраст: {Age}";
        }

        public abstract string GetRole();

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
            Console.WriteLine($"Роль: {GetRole()}");
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public void UpdatePhone(string newPhone)
        {
            Phone = newPhone;
        }
    }
}